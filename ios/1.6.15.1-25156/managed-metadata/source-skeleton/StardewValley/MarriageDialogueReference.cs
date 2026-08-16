using System;
using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley;

public class MarriageDialogueReference : INetObject<NetFields>, IEquatable<MarriageDialogueReference>
{
	public const string ENDEARMENT_TOKEN = "%endearment";

	public const string ENDEARMENT_TOKEN_LOWER = "%endearmentlower";

	private readonly NetString _dialogueFile;

	private readonly NetString _dialogueKey;

	private readonly NetBool _isGendered;

	private readonly NetStringList _substitutions;

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string DialogueFile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string DialogueKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsGendered
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public string[] Substitutions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MarriageDialogueReference()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MarriageDialogueReference(string dialogue_file, string dialogue_key, bool gendered = false, params string[] substitutions)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetText()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsItemGrabDialogue(NPC n)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _ReplaceTokens(Dialogue dialogue, NPC npc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected string _ReplaceTokens(string text, NPC npc)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dialogue GetDialogue(NPC n)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(MarriageDialogueReference other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Equals(object obj)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashCode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
