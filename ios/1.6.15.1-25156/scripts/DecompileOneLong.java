// @category Stardew
import ghidra.app.script.GhidraScript;
import ghidra.app.decompiler.*;
import ghidra.program.model.address.Address;
import ghidra.program.model.listing.Function;
import ghidra.program.model.symbol.SourceType;
import java.nio.file.*;
public class DecompileOneLong extends GhidraScript {
  public void run() throws Exception {
    String[] a=getScriptArgs(); Address ad=toAddr(Long.parseUnsignedLong(a[0].replace("0x",""),16)); String name=a[1], out=a[2]; int secs=Integer.parseInt(a[3]);
    disassemble(ad); Function f=getFunctionAt(ad); if(f==null) f=createFunction(ad,name); if(f==null) throw new RuntimeException("no function at "+ad); try{f.setName(name,SourceType.USER_DEFINED);}catch(Exception e){}
    DecompInterface di=new DecompInterface(); di.toggleCCode(true);di.toggleSyntaxTree(true);di.setSimplificationStyle("decompile"); if(!di.openProgram(currentProgram))throw new RuntimeException("open fail");
    DecompileResults r=di.decompileFunction(f,secs,monitor); String text=(r.decompileCompleted()&&r.getDecompiledFunction()!=null)?r.getDecompiledFunction().getC():"FAILED: "+r.getErrorMessage(); Files.writeString(Paths.get(out),text); println("LONG_DONE "+name+" completed="+r.decompileCompleted()+" len="+text.length()+" msg="+r.getErrorMessage());di.dispose();
  }
}
