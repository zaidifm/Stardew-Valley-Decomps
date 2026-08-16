using System.Runtime.CompilerServices;
using Netcode;
using StardewValley.Network;

namespace StardewValley;

public class Proposal : INetObject<NetFields>
{
	public readonly NetFarmerRef sender;

	public readonly NetFarmerRef receiver;

	public readonly NetEnum<ProposalType> proposalType;

	public readonly NetEnum<ProposalResponse> response;

	public readonly NetString responseMessageKey;

	public readonly NetRef<Item> gift;

	public readonly NetBool canceled;

	public readonly NetBool cancelConfirmed;

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Proposal()
	{
	}
}
