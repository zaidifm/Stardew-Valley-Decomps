using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.HomeRenovations;

public class HomeRenovation
{
	public string TextStrings;

	public string AnimationType;

	public bool CheckForObstructions;

	[ContentSerializer(Optional = true)]
	public int Price;

	[ContentSerializer(Optional = true)]
	public string RoomId;

	public List<RenovationValue> Requirements;

	public List<RenovationValue> RenovateActions;

	[ContentSerializer(Optional = true)]
	public List<RectGroup> RectGroups;

	[ContentSerializer(Optional = true)]
	public string SpecialRect;

	[ContentSerializer(Optional = true)]
	public Dictionary<string, string> CustomFields;
}
