using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
static string Esc(string s)=>s.Replace("\t"," ").Replace("\r"," ").Replace("\n"," ");
var asm=args[0]; var outdir=args[1]; Directory.CreateDirectory(outdir);
using var fs=File.OpenRead(asm); using var pe=new PEReader(fs); var md=pe.GetMetadataReader();
string Full(TypeDefinitionHandle h){ var td=md.GetTypeDefinition(h); var n=md.GetString(td.Name); if(!td.GetDeclaringType().IsNil) return Full(td.GetDeclaringType())+"+"+n; var ns=md.GetString(td.Namespace); return string.IsNullOrEmpty(ns)?n:ns+"."+n; }
using(var w=new StreamWriter(Path.Combine(outdir,"types.tsv"))){w.WriteLine("token\ttype\tattributes\tmethods\tfields\tproperties\tnested"); foreach(var h in md.TypeDefinitions){var td=md.GetTypeDefinition(h); w.WriteLine($"0x{MetadataTokens.GetToken(h):X8}\t{Esc(Full(h))}\t{td.Attributes}\t{td.GetMethods().Count}\t{td.GetFields().Count}\t{td.GetProperties().Count}\t{td.GetNestedTypes().Count()}");}}
using(var w=new StreamWriter(Path.Combine(outdir,"methods.tsv"))){w.WriteLine("token\tdeclaring_type\tmethod\trva\til_bytes\tattributes\timpl_attributes"); foreach(var th in md.TypeDefinitions){var td=md.GetTypeDefinition(th); foreach(var h in td.GetMethods()){var m=md.GetMethodDefinition(h); int size=0; if(m.RelativeVirtualAddress!=0){try{size=pe.GetMethodBody(m.RelativeVirtualAddress).GetILBytes().Length;}catch{}} w.WriteLine($"0x{MetadataTokens.GetToken(h):X8}\t{Esc(Full(th))}\t{Esc(md.GetString(m.Name))}\t0x{m.RelativeVirtualAddress:X}\t{size}\t{m.Attributes}\t{m.ImplAttributes}");}}}
using(var w=new StreamWriter(Path.Combine(outdir,"fields.tsv"))){w.WriteLine("token\tdeclaring_type\tfield\tattributes"); foreach(var th in md.TypeDefinitions){var td=md.GetTypeDefinition(th); foreach(var h in td.GetFields()){var f=md.GetFieldDefinition(h); w.WriteLine($"0x{MetadataTokens.GetToken(h):X8}\t{Esc(Full(th))}\t{Esc(md.GetString(f.Name))}\t{f.Attributes}");}}}
Console.WriteLine($"types={md.TypeDefinitions.Count} methods={md.MethodDefinitions.Count} fields={md.FieldDefinitions.Count} properties={md.PropertyDefinitions.Count}");
