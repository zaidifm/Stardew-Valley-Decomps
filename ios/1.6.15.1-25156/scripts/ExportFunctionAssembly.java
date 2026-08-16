// @category Stardew
import ghidra.app.script.GhidraScript;
import ghidra.program.model.address.*;
import ghidra.program.model.listing.*;
import ghidra.program.model.symbol.*;
import java.nio.file.*;
import java.util.*;
public class ExportFunctionAssembly extends GhidraScript {
 public void run() throws Exception {
  String[] a=getScriptArgs(); String spec=a[0], outDir=a[1]; Files.createDirectories(Paths.get(outDir));
  Listing listing=currentProgram.getListing(); FunctionManager fm=currentProgram.getFunctionManager();
  for(String line:Files.readAllLines(Paths.get(spec))){if(line.isBlank())continue;String[] p=line.split("\\t",5);Address ad=toAddr(Long.parseUnsignedLong(p[0].replace("0x",""),16));Function f=fm.getFunctionAt(ad);if(f==null)f=fm.getFunctionContaining(ad);if(f==null){disassemble(ad);f=fm.getFunctionAt(ad);}if(f==null){println("NOFUNC "+p[2]);continue;}
   StringBuilder sb=new StringBuilder();sb.append("# ").append(p[2]).append(' ').append(p[3]).append('.').append(p[4]).append(" @ ").append(p[0]).append('\n');sb.append("# body_bytes=").append(f.getBody().getNumAddresses()).append(" ranges=").append(f.getBody().getNumAddressRanges()).append('\n');
   AddressRangeIterator ri=f.getBody().getAddressRanges();while(ri.hasNext()){AddressRange r=ri.next();sb.append("# RANGE ").append(r.getMinAddress()).append(" .. ").append(r.getMaxAddress()).append('\n');}
   InstructionIterator it=listing.getInstructions(f.getBody(),true);int n=0,calls=0;
   while(it.hasNext()){Instruction ins=it.next();n++;sb.append(ins.getAddress()).append("  ").append(ins).append('\n');
    for(Reference ref:ins.getReferencesFrom()){if(ref.getReferenceType().isCall()){calls++;Address to=ref.getToAddress();Function tf=fm.getFunctionAt(to);sb.append("    # CALL -> ").append(to);if(tf!=null)sb.append(" ").append(tf.getName(true));sb.append('\n');}}
   }
   sb.append("# instructions=").append(n).append(" call_refs=").append(calls).append('\n');String fn=p[2].substring(2)+"__"+p[1]+".asm.txt";Files.writeString(Paths.get(outDir,fn),sb.toString());println("ASM_OK "+p[2]+" insns="+n+" calls="+calls);
  }
 }
}
