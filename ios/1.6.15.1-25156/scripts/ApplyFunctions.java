// @category Stardew
import ghidra.app.script.GhidraScript;
import ghidra.program.model.address.Address;
import ghidra.program.model.listing.Function;
import ghidra.program.model.symbol.SourceType;
import java.nio.file.*;
public class ApplyFunctions extends GhidraScript {
 public void run() throws Exception {
  String p=getScriptArgs()[0]; int ok=0;
  for(String line:Files.readAllLines(Paths.get(p))){if(line.isBlank())continue;String[] a=line.split("\\t",5);Address ad=toAddr(Long.parseUnsignedLong(a[0].replace("0x",""),16));Function f=getFunctionAt(ad);if(f==null){disassemble(ad);f=getFunctionAt(ad);}if(f==null)f=createFunction(ad,a[1]);if(f!=null){try{f.setName(a[1],SourceType.USER_DEFINED);}catch(Exception e){}ok++;}}
  println("APPLIED_FUNCTIONS "+ok);
 }
}
