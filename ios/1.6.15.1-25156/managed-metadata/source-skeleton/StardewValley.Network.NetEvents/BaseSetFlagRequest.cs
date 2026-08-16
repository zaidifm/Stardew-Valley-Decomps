using System.IO;
using System.Runtime.CompilerServices;

namespace StardewValley.Network.NetEvents;

public abstract class BaseSetFlagRequest : BasePlayerActionRequest
{
	public string FlagId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool FlagState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected BaseSetFlagRequest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected BaseSetFlagRequest(PlayerActionTarget target, string flagId, bool flagState, long? onlyPlayerId)
	{
	}
}
