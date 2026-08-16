using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace StardewValley.Tests;

public class SyntaxAbstractor
{
	public const string TextMarker = "text";

	public readonly Dictionary<string, ExtractSyntaxDelegate> SyntaxHandlers;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ExtractSyntaxDelegate GetSyntaxHandler(string baseAssetName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ExtractSyntaxFor(string baseAssetName, string key, string value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ExtractPlainTextSyntax(string value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ExtractDialogueSyntax(string value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ExtractDialogueSyntax(string baseAssetName, string key, string value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ExtractEventSyntax(string value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ExtractFestivalSyntax(string baseAssetName, string key, string value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ExtractCreditsSyntax(string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ExtractMailSyntax(string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ExtractDelimitedDataSyntax(string text, char delimiter, params int[] textFields)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ExtractDelimitedDataSyntax(string text, char delimiter, int[] textFields, int[] dialogueFields)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string Extract16StringsSyntax(string key, string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ExtractLexiconSyntax(string key, string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string DialogueSyntaxHandler(SyntaxAbstractor syntaxAbstractor, string baseAssetName, string key, string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string PlainTextSyntaxHandler(SyntaxAbstractor syntaxAbstractor, string baseAssetName, string key, string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string EventSyntaxHandler(SyntaxAbstractor syntaxAbstractor, string baseAssetName, string key, string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string FestivalSyntaxHandler(SyntaxAbstractor syntaxAbstractor, string baseAssetName, string key, string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExtractEventSyntaxImpl(string text, ref int index, StringBuilder syntax, int maxIndex = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AppendEventCommandArg(StringBuilder syntax, string[] args, int index, bool prependSpace = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AppendEventCommandDialogueArg(StringBuilder syntax, string[] args, int index, bool prependSpace = true, bool quote = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string ExtractNpcGenderedDialogueSyntax(string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExtractDialogueSyntaxImpl(string text, char commandDelimiter, ref int index, StringBuilder syntax, int maxIndex = -1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExtractDialogueCommandSyntax(string text, ref int index, StringBuilder syntax, char commandDelimiter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExtractDialogueItemSpawnSyntax(string text, ref int index, StringBuilder syntax)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExtractMailCommandSyntax(string text, ref int index, StringBuilder syntax)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExtractTagSyntax(string text, ref int index, StringBuilder syntax)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ExtractRevealTasteCommandSyntax(string text, ref int index, StringBuilder syntax)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndTextContext(ref bool hasText, StringBuilder syntax)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SyntaxAbstractor()
	{
	}
}
