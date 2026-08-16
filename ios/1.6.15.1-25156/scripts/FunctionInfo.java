// @category Stardew
import ghidra.app.script.GhidraScript; import ghidra.program.model.address.*; import ghidra.program.model.listing.*;
public class FunctionInfo extends GhidraScript { public void run() throws Exception { for(String s:getScriptArgs()){Address a=toAddr(Long.parseUnsignedLong(s.replace("0x",""),16));Function f=getFunctionAt(a);println(a+" name="+(f==null?"NULL":f.getName()+" body="+f.getBody()+" entries="+f.getBody().getNumAddressRanges()+" bytes="+f.getBody().getNumAddresses()));}}}
