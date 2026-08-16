using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Shops;

public class ShopOwnerData
{
	private string IdImpl;

	private string NameImpl;

	[ContentSerializer(Optional = true)]
	public string Condition;

	[ContentSerializer(Optional = true)]
	public string Portrait;

	[ContentSerializer(Optional = true)]
	public List<ShopDialogueData> Dialogues;

	[ContentSerializer(Optional = true)]
	public bool RandomizeDialogueOnOpen = true;

	[ContentSerializer(Optional = true)]
	public string ClosedMessage;

	[ContentSerializer(Optional = true)]
	public string Id
	{
		get
		{
			return IdImpl ?? Name;
		}
		set
		{
			IdImpl = value;
		}
	}

	public string Name
	{
		get
		{
			return NameImpl;
		}
		set
		{
			if (Enum.TryParse<ShopOwnerType>(value, ignoreCase: true, out var result) && Enum.IsDefined(typeof(ShopOwnerType), result))
			{
				NameImpl = result.ToString();
				Type = result;
			}
			else
			{
				NameImpl = value;
				Type = ShopOwnerType.NamedNpc;
			}
		}
	}

	[ContentSerializerIgnore]
	public ShopOwnerType Type { get; private set; }

	public bool IsValid(string npcName)
	{
		return Type switch
		{
			ShopOwnerType.AnyOrNone => true, 
			ShopOwnerType.Any => !string.IsNullOrWhiteSpace(npcName), 
			ShopOwnerType.None => string.IsNullOrWhiteSpace(npcName), 
			_ => Name == npcName, 
		};
	}
}
