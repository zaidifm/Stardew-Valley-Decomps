using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BmFont;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class SpriteText
{
	public enum ScrollTextAlignment
	{
		Left,
		Center,
		Right
	}

	public const int scrollStyle_scroll = 0;

	public const int scrollStyle_scrollleftjustified = 0;

	public const int scrollStyle_speechBubble = 1;

	public const int scrollStyle_darkMetal = 2;

	public const int scrollStyle_blueMetal = 3;

	public const int maxCharacter = 999999;

	public const int maxHeight = 999999;

	public const int characterWidth = 8;

	public const int characterHeight = 16;

	public const int horizontalSpaceBetweenCharacters = 0;

	public const int verticalSpaceBetweenCharacters = 2;

	public const char newLine = '^';

	public static float fontPixelZoom;

	public static float shadowAlpha;

	public static Dictionary<char, FontChar> characterMap;

	public static FontFile FontFile;

	public static List<Texture2D> fontPages;

	public static Texture2D spriteTexture;

	public static Texture2D coloredTexture;

	private static bool fontShrunk;

	public const int color_index_Default = -1;

	public const int color_index_Black = 0;

	public const int color_index_Blue = 1;

	public const int color_index_Red = 2;

	public const int color_index_Purple = 3;

	public const int color_index_White = 4;

	public const int color_index_Orange = 5;

	public const int color_index_Green = 6;

	public const int color_index_Cyan = 7;

	public const int color_index_Gray = 8;

	public const int color_index_JojaBlue = 9;

	public static bool forceEnglishFont;

	public static float FontPixelZoom
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Color color_Default
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Color color_Black
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Color color_Blue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Color color_Red
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Color color_Purple
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Color color_White
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Color color_Orange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Color color_Green
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Color color_Cyan
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Color color_Gray
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Color color_JojaBlue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void shrinkFont(bool shrink)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SetFontPixelZoom()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawScroll(SpriteBatch b, int X, int Y, int Width)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawScrollText(SpriteBatch b, string text, SpriteFont font, int X, int Y, int Width)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawStringHorizontallyCenteredAt(SpriteBatch b, string s, int x, int y, int characterPosition = 999999, int width = -1, int height = 999999, float alpha = 1f, float layerDepth = 0.88f, bool junimoText = false, Color? color = null, int maxWidth = 99999)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getWidthOfString(string s, int widthConstraint = 999999)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsMissingCharacters(string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getHeightOfString(string s, int widthConstraint = 999999)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color getColorFromIndex(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getSubstringBeyondHeight(string s, int width, int height)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getIndexOfSubstringBeyondHeight(string s, int width, int height)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<string> getStringBrokenIntoSectionsOfHeight(string s, int width, int height)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getStringPreviousToThisHeightCutoff(string s, int width, int height)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int getLastSpace(string s, int startIndex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getWidthOffsetForChar(char c)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawStringWithScrollCenteredAt(SpriteBatch b, string s, int x, int y, int width, float alpha = 1f, Color? color = null, int scrollType = 0, float layerDepth = 0.88f, bool junimoText = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawSmallTextBubble(SpriteBatch b, string s, Vector2 positionOfBottomCenter, int maxWidth = -1, float layerDepth = -1f, bool drawPointerOnTop = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawStringWithScrollCenteredAt(SpriteBatch b, string s, int x, int y, string placeHolderWidthText = "", float alpha = 1f, Color? color = null, int scrollType = 0, float layerDepth = 0.88f, bool junimoText = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawStringWithScrollBackground(SpriteBatch b, string s, int x, int y, string placeHolderWidthText = "", float alpha = 1f, Color? color = null, ScrollTextAlignment scroll_text_alignment = ScrollTextAlignment.Left)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static FontFile loadFont(string assetName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void setUpCharacterMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void drawString(SpriteBatch b, string s, int x, int y, int characterPosition = 999999, int width = -1, int height = 999999, float alpha = 1f, float layerDepth = 0.88f, bool junimoText = false, int drawBGScroll = -1, string placeHolderScrollWidthText = "", Color? color = null, ScrollTextAlignment scroll_text_alignment = ScrollTextAlignment.Left)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsSpecialCharacter(char c)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OnLanguageChange(LocalizedContentManager.LanguageCode code)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadFontData(LocalizedContentManager.LanguageCode code)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int positionOfNextSpace(string s, int index, int currentXPosition, int accumulatedHorizontalSpaceBetweenCharacters)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool isUsingNonSpriteSheetFont()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Rectangle getSourceRectForChar(char c, bool junimoText)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpriteText()
	{
	}
}
