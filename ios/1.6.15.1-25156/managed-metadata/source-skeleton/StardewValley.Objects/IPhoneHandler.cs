using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Objects;

public interface IPhoneHandler
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	string CheckForIncomingCall(Random random);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool TryHandleIncomingCall(string callId, out Action showDialogue);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerable<KeyValuePair<string, string>> GetOutgoingNumbers();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool TryHandleOutgoingCall(string callId);
}
