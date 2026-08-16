using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Objects;

public class DefaultPhoneHandler : IPhoneHandler
{
	public static class OutgoingCallIds
	{
		public const string AdventureGuild = "AdventureGuild";

		public const string AnimalShop = "AnimalShop";

		public const string Blacksmith = "Blacksmith";

		public const string Carpenter = "Carpenter";

		public const string Saloon = "Saloon";

		public const string SeedShop = "SeedShop";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string CheckForIncomingCall(Random random)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryHandleIncomingCall(string callId, out Action showDialogue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<KeyValuePair<string, string>> GetOutgoingNumbers()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryHandleOutgoingCall(string callId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallAdventureGuild()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallAnimalShop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallBlacksmith()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallCarpenter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallSaloon()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallSeedShop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DefaultPhoneHandler()
	{
	}
}
