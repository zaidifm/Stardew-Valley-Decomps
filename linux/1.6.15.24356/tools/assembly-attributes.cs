using ICSharpCode.Decompiler; using ICSharpCode.Decompiler.CSharp; using ICSharpCode.Decompiler.Metadata;
var asm=Path.GetFullPath(args[0]); var search=Path.GetFullPath(args[1]);
var resolver=new UniversalAssemblyResolver(asm,false,null,null,System.Reflection.PortableExecutable.PEStreamOptions.Default,System.Reflection.Metadata.MetadataReaderOptions.Default); resolver.AddSearchDirectory(search);
var d=new CSharpDecompiler(asm,resolver,new DecompilerSettings(LanguageVersion.Latest){ThrowOnAssemblyResolveErrors=false}); Console.Write(d.DecompileModuleAndAssemblyAttributesToString());
