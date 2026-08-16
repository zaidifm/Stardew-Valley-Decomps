// @category Stardew
import ghidra.app.script.GhidraScript;
import ghidra.app.decompiler.*;
import ghidra.program.model.address.Address;
import ghidra.program.model.listing.Function;
import ghidra.program.model.symbol.SourceType;
import java.nio.file.*;
import java.util.*;

public class DecompileBatch extends GhidraScript {
  static class Spec { String addr,name,token,type,method; }
  List<Spec> readSpecs(String p) throws Exception {
    List<Spec> out=new ArrayList<>();
    for(String line:Files.readAllLines(Paths.get(p))) {
      if(line.isBlank()) continue;
      String[] a=line.split("\\t",5); if(a.length<5) continue;
      Spec s=new Spec(); s.addr=a[0];s.name=a[1];s.token=a[2];s.type=a[3];s.method=a[4];out.add(s);
    }
    return out;
  }
  Function ensure(Spec s) throws Exception {
    Address ad=toAddr(Long.parseUnsignedLong(s.addr.replace("0x",""),16));
    Function f=getFunctionAt(ad);
    if(f==null) { disassemble(ad); f=getFunctionAt(ad); }
    if(f==null) f=createFunction(ad,s.name);
    if(f!=null) { try { f.setName(s.name,SourceType.USER_DEFINED); } catch(Exception e){} }
    return f;
  }
  public void run() throws Exception {
    String[] a=getScriptArgs(); String preFile=a[0], decFile=a[1], outDir=a[2];
    Files.createDirectories(Paths.get(outDir));
    List<Spec> pre=readSpecs(preFile), dec=readSpecs(decFile);
    int made=0;
    for(Spec s:pre){ if(monitor.isCancelled()) break; if(ensure(s)!=null) made++; }
    println("PREDECLARED "+made+" / "+pre.size());
    DecompInterface di=new DecompInterface(); di.toggleCCode(true);di.toggleSyntaxTree(true);di.setSimplificationStyle("decompile");
    if(!di.openProgram(currentProgram)) throw new RuntimeException("decompiler open failed");
    int ok=0,fail=0;
    for(Spec s:dec){
      if(monitor.isCancelled()) break;
      Function f=ensure(s); if(f==null){ println("NOFUNC "+s.type+"."+s.method);fail++;continue; }
      DecompileResults r=di.decompileFunction(f,90,monitor);
      String text=(r.decompileCompleted()&&r.getDecompiledFunction()!=null)?r.getDecompiledFunction().getC():"FAILED: "+r.getErrorMessage();
      String file=s.token.substring(2)+"__"+s.name+".c";
      Files.writeString(Paths.get(outDir,file),"/* "+s.token+" "+s.type+"."+s.method+" @ "+s.addr+" */\n"+text);
      if(r.decompileCompleted()){ok++;println("OK "+s.token+" "+s.type+"."+s.method+" len="+text.length());}else{fail++;println("FAIL "+s.token+" "+s.type+"."+s.method+" "+r.getErrorMessage());}
    }
    di.dispose(); println("BATCH_DONE ok="+ok+" fail="+fail);
  }
}
