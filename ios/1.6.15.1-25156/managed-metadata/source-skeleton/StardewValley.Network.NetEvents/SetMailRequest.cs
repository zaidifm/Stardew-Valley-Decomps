using System.IO;
using System.Runtime.CompilerServices;

namespace StardewValley.Network.NetEvents;

public sealed class SetMailRequest : BaseSetFlagRequest
{
	public MailType MailType
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
	public SetMailRequest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SetMailRequest(PlayerActionTarget target, string mailId, MailType mailType, bool state, long? onlyPlayerId = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void PerformAction(Farmer farmer)
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
	private void ToggleMailbox(Farmer farmer, string mailId, bool add)
	{
	}
}
