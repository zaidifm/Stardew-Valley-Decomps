using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class PassiveFestivalData
{
	public string DisplayName;

	public string Condition;

	[ContentSerializer(Optional = true)]
	public bool ShowOnCalendar = true;

	public Season Season;

	public int StartDay;

	public int EndDay;

	public int StartTime;

	public string StartMessage;

	[ContentSerializer(Optional = true)]
	public bool OnlyShowMessageOnFirstDay;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> MapReplacements;

	[ContentSerializer(Optional = true)]
	public string DailySetupMethod;

	[ContentSerializer(Optional = true)]
	public string CleanupMethod;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
