#!/usr/bin/env python3
import csv,struct
from pathlib import Path
from collections import Counter
from importlib.machinery import SourceFileLoader
m=SourceFileLoader('aotmap','/mnt/data/ios_probe/v155/mono_aot_map.py').load_module()
MACHO=Path('/mnt/data/ios_probe/v155/StardewValley')
ADIR=Path('/mnt/data/ios_probe/v155/all-managed'); MDIR=Path('/mnt/data/ios_probe/v155/all-methods'); ODIR=Path('/mnt/data/ios_probe/v155/all-maps'); ODIR.mkdir(exist_ok=True)
b=MACHO.read_bytes(); segs=m.segments(b); version=185
# Discover every plausible MonoAotFileInfo in one pass.
infos=[]; needle=struct.pack('<I',version); pos=0
sizes={p.stat().st_size for p in ADIR.glob('*.aotdata.arm64')}
seen=set()
while True:
    pos=b.find(needle,pos)
    if pos<0: break
    off=pos; pos += 1
    if off%4 or off+600>len(b): continue
    ds=struct.unpack_from('<I',b,off+400)[0]
    if ds not in sizes: continue
    try: info=m.parse_info(b,off,segs)
    except Exception: continue
    name=info['assembly_name']
    if name and off not in seen:
        infos.append(info); seen.add(off)
byname={x['assembly_name']:x for x in infos}
print('fileinfos',len(infos))
for x in sorted(infos,key=lambda z:z['assembly_name']): print('INFO',x['assembly_name'],hex(x['file_offset']),x['scalar']['datafile_size'],x['scalar']['nmethods'],x['scalar']['nextra_methods'])
combined=[]; summary=[]
for meth in sorted(MDIR.glob('*.methods.tsv')):
    asm=meth.name[:-len('.methods.tsv')]
    aot=ADIR/(asm+'.aotdata.arm64')
    info=byname.get(asm)
    if not aot.exists() or info is None:
        summary.append((asm,'NO_INFO',0,0,0)); continue
    rows=list(csv.DictReader(open(meth,encoding='utf-8-sig'),delimiter='\t'))
    mt=info['ptr']['method_addresses']; es=info['scalar']['call_table_entry_size']
    mapped=absent=bad=0; out=[]
    for r in rows:
        idx=int(r['index']); entry=mt+idx*es; ins,tgt=m.decode_call(b,segs,entry)
        if tgt is None: status='bad_call_entry'; native=''; chain=''; bad+=1
        elif tgt==mt: status='absent'; native=''; chain=f'{tgt:#x}'; absent+=1
        else:
            na,ch=m.resolve_island(b,segs,tgt); status='mapped'; native=f'{na:#x}'; chain=','.join(f'{x:#x}' for x in ch); mapped+=1
        nr={'assembly':asm,**r,'call_entry':f'{entry:#x}','call_insn':f'{ins:#010x}' if ins is not None else '', 'initial_target':f'{tgt:#x}' if tgt is not None else '', 'native_address':native,'status':status,'resolve_chain':chain}
        out.append(nr); combined.append(nr)
    op=ODIR/(asm+'.map.tsv')
    if out:
        with op.open('w',newline='') as f: w=csv.DictWriter(f,fieldnames=out[0].keys(),delimiter='\t'); w.writeheader(); w.writerows(out)
    summary.append((asm,'OK',len(rows),mapped,absent))
print('SUMMARY')
for x in summary: print('\t'.join(map(str,x)))
print('combined rows',len(combined),'mapped',sum(x['status']=='mapped' for x in combined),'absent',sum(x['status']=='absent' for x in combined))
if combined:
    with (ODIR/'ALL-managed-native-map.tsv').open('w',newline='') as f: w=csv.DictWriter(f,fieldnames=combined[0].keys(),delimiter='\t'); w.writeheader(); w.writerows(combined)
