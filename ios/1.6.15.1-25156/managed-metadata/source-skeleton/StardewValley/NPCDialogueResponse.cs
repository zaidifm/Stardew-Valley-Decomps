using System.Runtime.CompilerServices;

namespace StardewValley;

public class NPCDialogueResponse : Response
{
	public int friendshipChange;

	public string id;

	public string extraArgument;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPCDialogueResponse(string id, int friendshipChange, string keyToNPCresponse, string responseText, string extraArgument = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPCDialogueResponse(NPCDialogueResponse other)
	{
	}
}
