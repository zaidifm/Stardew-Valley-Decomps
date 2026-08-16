using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class ChatMessage
{
	public List<ChatSnippet> message;

	public int timeLeftToDisplay;

	public int verticalSize;

	public float alpha;

	public Color color;

	public LocalizedContentManager.LanguageCode language;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void parseMessageForEmoji(string messagePlaintext)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color getColorFromName(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void breakNewLines(StringBuilder sb)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string makeMessagePlaintext(List<ChatSnippet> message, bool include_color_information)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b, int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ChatMessage()
	{
	}
}
