// @category Stardew
import ghidra.app.script.GhidraScript;
import ghidra.program.model.address.Address;
import ghidra.program.model.listing.Function;
import java.nio.file.*;
import java.util.*;
public class FunctionSizes extends GhidraScript {
 public void run() throws Exception {
  String[] a=getScriptArgs(); String in=a[0], out=a[1];
  StringBuilder sb=new StringBuilder("addr\tname\ttoken\ttype\tmethod\tbody_bytes\tranges\n");
  int ok=0;
  for(String line:Files.readAllLines(Paths.get(in))){
   if(line.isBlank())continue; String[] p=line.split("\\t",5); if(p.length<5)continue;
   Address ad=toAddr(Long.parseUnsignedLong(p[0].replace("0x",""),16));
   Function f=getFunctionAt(ad); if(f==null) f=getFunctionContaining(ad);
   long bytes=0; int ranges=0;
   if(f!=null){ bytes=f.getBody().getNumAddresses(); ranges=f.getBody().getNumAddressRanges(); ok++; }
   sb.append(p[0]).append('\t').append(p[1]).append('\t').append(p[2]).append('\t').append(p[3]).append('\t').append(p[4]).append('\t').append(bytes).append('\t').append(ranges).append('\n');
  }
  Files.writeString(Paths.get(out),sb.toString()); println("SIZES "+ok);
 }
}
