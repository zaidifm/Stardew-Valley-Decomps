using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.Metadata;

static string Clean(string s) {
    foreach (char c in Path.GetInvalidFileNameChars()) s = s.Replace(c, '_');
    return s.Replace('`','_').Replace('<','_').Replace('>','_');
}
if (args.Length < 5) { Console.Error.WriteLine("usage: <assembly> <searchdir> <outdir> <start> <count>"); return 2; }
var asm=Path.GetFullPath(args[0]); var search=Path.GetFullPath(args[1]); var outdir=Path.GetFullPath(args[2]);
int start=int.Parse(args[3]); int count=int.Parse(args[4]); Directory.CreateDirectory(outdir);
var settings=new DecompilerSettings(LanguageVersion.Latest) { ThrowOnAssemblyResolveErrors=false };
var resolver=new UniversalAssemblyResolver(asm,false,null,null,System.Reflection.PortableExecutable.PEStreamOptions.Default,MetadataReaderOptions.Default);
resolver.AddSearchDirectory(search);
var dec=new CSharpDecompiler(asm,resolver,settings);
var md=dec.TypeSystem.MainModule.MetadataFile.Metadata;
var items=new List<(TypeDefinitionHandle h,string ns,string name)>();
foreach(var h in md.TypeDefinitions){ var td=md.GetTypeDefinition(h); if(!td.GetDeclaringType().IsNil) continue; var name=md.GetString(td.Name); if(name=="<Module>") continue; items.Add((h,md.GetString(td.Namespace),name)); }
items=items.OrderBy(x=>x.ns,StringComparer.Ordinal).ThenBy(x=>x.name,StringComparer.Ordinal).ToList();
var end=Math.Min(items.Count,start+count); int ok=0, fail=0; var sw=System.Diagnostics.Stopwatch.StartNew();
var manifest=Path.Combine(outdir,"_manifest.tsv"); if(start==0) File.WriteAllText(manifest,"index\tnamespace\ttype\tfile\tstatus\terror\n");
for(int i=start;i<end;i++){
 var x=items[i]; var dir=Path.Combine(outdir,string.IsNullOrEmpty(x.ns)?"_global":Clean(x.ns)); Directory.CreateDirectory(dir);
 var fn=Clean(x.name)+".cs"; var path=Path.Combine(dir,fn); string status="ok",err="";
 try { File.WriteAllText(path, dec.DecompileTypesAsString(new[]{x.h})); ok++; }
 catch(Exception ex){ status="error"; err=ex.GetType().Name+": "+ex.Message.Replace('\t',' ').Replace('\n',' '); File.WriteAllText(path,"// DECOMPILATION ERROR\n// "+err+"\n"); fail++; }
 File.AppendAllText(manifest,$"{i}\t{x.ns}\t{x.name}\t{Path.GetRelativePath(outdir,path)}\t{status}\t{err}\n");
}
sw.Stop(); Console.WriteLine($"total={items.Count} start={start} end={end} ok={ok} fail={fail} seconds={sw.Elapsed.TotalSeconds:F2}"); return fail==0?0:3;
