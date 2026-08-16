using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Shops;

public class ShopThemeData
{
	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public string WindowBorderTexture;

	[ContentSerializer(Optional = true)]
	public Rectangle? WindowBorderSourceRect;

	[ContentSerializer(Optional = true)]
	public string PortraitBackgroundTexture;

	[ContentSerializer(Optional = true)]
	public Rectangle? PortraitBackgroundSourceRect;

	[ContentSerializer(Optional = true)]
	public string DialogueBackgroundTexture;

	[ContentSerializer(Optional = true)]
	public Rectangle? DialogueBackgroundSourceRect;

	[ContentSerializer(Optional = true)]
	public string DialogueColor;

	[ContentSerializer(Optional = true)]
	public string DialogueShadowColor;

	[ContentSerializer(Optional = true)]
	public string ItemRowBackgroundTexture;

	[ContentSerializer(Optional = true)]
	public Rectangle? ItemRowBackgroundSourceRect;

	[ContentSerializer(Optional = true)]
	public string ItemRowBackgroundHoverColor;

	[ContentSerializer(Optional = true)]
	public string ItemRowTextColor;

	[ContentSerializer(Optional = true)]
	public string ItemIconBackgroundTexture;

	[ContentSerializer(Optional = true)]
	public Rectangle? ItemIconBackgroundSourceRect;

	[ContentSerializer(Optional = true)]
	public string ScrollUpTexture;

	[ContentSerializer(Optional = true)]
	public Rectangle? ScrollUpSourceRect;

	[ContentSerializer(Optional = true)]
	public string ScrollDownTexture;

	[ContentSerializer(Optional = true)]
	public Rectangle? ScrollDownSourceRect;

	[ContentSerializer(Optional = true)]
	public string ScrollBarFrontTexture;

	[ContentSerializer(Optional = true)]
	public Rectangle? ScrollBarFrontSourceRect;

	[ContentSerializer(Optional = true)]
	public string ScrollBarBackTexture;

	[ContentSerializer(Optional = true)]
	public Rectangle? ScrollBarBackSourceRect;
}
