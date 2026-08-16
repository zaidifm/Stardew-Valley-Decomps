// @category Stardew
import ghidra.app.script.GhidraScript;
import ghidra.app.decompiler.*;
import ghidra.program.model.address.Address;
import ghidra.program.model.listing.Function;
import ghidra.program.model.symbol.SourceType;
import java.nio.file.*;
public class DecompileOne extends GhidraScript {
  public void run() throws Exception {
    String[] a=getScriptArgs(); long v=Long.parseUnsignedLong(a[0].replace("0x",""),16); Address ad=toAddr(v); String name=a[1], out=a[2];
    disassemble(ad); Function f=getFunctionAt(ad); if(f==null) f=createFunction(ad,name); if(f==null) throw new RuntimeException("no function at "+ad); f.setName(name,SourceType.USER_DEFINED);
    DecompInterface di=new DecompInterface(); di.toggleCCode(true); di.toggleSyntaxTree(true); di.setSimplificationStyle("decompile"); if(!di.openProgram(currentProgram))throw new RuntimeException("open fail");
    DecompileResults r=di.decompileFunction(f,120,monitor); String text=(r.decompileCompleted()&&r.getDecompiledFunction()!=null)?r.getDecompiledFunction().getC():("FAILED: "+r.getErrorMessage()); Files.writeString(Paths.get(out),text); println("DECOMPILE_ONE "+name+" "+ad+" completed="+r.decompileCompleted()+" length="+text.length()); di.dispose();
  }
}
