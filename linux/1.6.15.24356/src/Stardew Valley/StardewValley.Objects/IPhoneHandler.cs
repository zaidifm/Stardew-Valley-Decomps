using System;
using System.Collections.Generic;

namespace StardewValley.Objects;

public interface IPhoneHandler
{
	string CheckForIncomingCall(Random random);

	bool TryHandleIncomingCall(string callId, out Action showDialogue);

	IEnumerable<KeyValuePair<string, string>> GetOutgoingNumbers();

	bool TryHandleOutgoingCall(string callId);
}
