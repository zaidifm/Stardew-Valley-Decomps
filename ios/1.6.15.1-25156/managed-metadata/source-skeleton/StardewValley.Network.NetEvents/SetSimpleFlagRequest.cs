using System.IO;
using System.Runtime.CompilerServices;

namespace StardewValley.Network.NetEvents;

public sealed class SetSimpleFlagRequest : BaseSetFlagRequest
{
	public SimpleFlagType FlagType
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
	public SetSimpleFlagRequest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SetSimpleFlagRequest(SimpleFlagType flagType, PlayerActionTarget target, string flagId, bool flagState, long? onlyPlayerId)
	{
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
	public override void PerformAction(Farmer farmer)
	{
	}
}
