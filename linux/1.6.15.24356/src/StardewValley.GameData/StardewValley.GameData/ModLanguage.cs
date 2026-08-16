using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class ModLanguage
{
	public string Id;

	public string LanguageCode;

	public string ButtonTexture;

	public bool UseLatinFont;

	[ContentSerializer(Optional = true)]
	public string FontFile;

	[ContentSerializer(Optional = true)]
	public float FontPixelZoom;

	[ContentSerializer(Optional = true)]
	public bool FontApplyYOffset;

	[ContentSerializer(Optional = true)]
	public int SmallFontLineSpacing = 26;

	[ContentSerializer(Optional = true)]
	public bool UseGenderedCharacterTranslations;

	[ContentSerializer(Optional = true)]
	public string NumberComma = ",";

	public string TimeFormat;

	public string ClockTimeFormat;

	public string ClockDateFormat;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
