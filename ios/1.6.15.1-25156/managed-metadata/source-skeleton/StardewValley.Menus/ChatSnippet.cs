using System.Runtime.CompilerServices;

namespace StardewValley.Menus;

public class ChatSnippet
{
	public string message;

	public int emojiIndex;

	public float myLength;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChatSnippet(string message, LocalizedContentManager.LanguageCode language)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChatSnippet(int emojiIndex)
	{
	}
}
