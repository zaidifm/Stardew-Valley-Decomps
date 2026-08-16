using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Netcode;
using StardewValley.Monsters;
using StardewValley.SaveSerialization;

namespace StardewValley.Quests;

[XmlInclude(typeof(Item))]
[XmlInclude(typeof(Character))]
public class DescriptionElement : INetObject<NetFields>
{
	public static XmlSerializer serializer = SaveSerializer.GetSerializer(typeof(DescriptionElement));

	[XmlElement("xmlKey")]
	public string translationKey;

	[XmlElement("param")]
	public List<object> substitutions;

	[XmlIgnore]
	public NetFields NetFields { get; } = new NetFields("DescriptionElement");

	public DescriptionElement()
		: this(string.Empty)
	{
	}

	public DescriptionElement(string key, params object[] substitutions)
	{
		NetFields.SetOwner(this);
		translationKey = key;
		this.substitutions = new List<object>();
		this.substitutions.AddRange(substitutions);
	}

	public string loadDescriptionElement()
	{
		if (string.IsNullOrWhiteSpace(translationKey))
		{
			return string.Empty;
		}
		object[] array = substitutions.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			object obj = array[i];
			if (!(obj is DescriptionElement descriptionElement))
			{
				if (!(obj is Object obj2))
				{
					if (!(obj is Monster monster))
					{
						if (obj is NPC nPC)
						{
							array[i] = NPC.GetDisplayName(nPC.name.Value);
						}
						continue;
					}
					DescriptionElement descriptionElement2;
					if (monster.name.Value == "Frost Jelly")
					{
						descriptionElement2 = new DescriptionElement("Strings\\StringsFromCSFiles:SlayMonsterQuest.cs.13772");
						array[i] = descriptionElement2.loadDescriptionElement();
					}
					else
					{
						descriptionElement2 = new DescriptionElement("Data\\Monsters:" + monster.name.Value);
						array[i] = ((LocalizedContentManager.CurrentLanguageCode == LocalizedContentManager.LanguageCode.en) ? (descriptionElement2.loadDescriptionElement().Split('/').Last() + "s") : descriptionElement2.loadDescriptionElement().Split('/').Last());
					}
					array[i] = descriptionElement2.loadDescriptionElement().Split('/').Last();
				}
				else
				{
					array[i] = ItemRegistry.GetDataOrErrorItem(obj2.QualifiedItemId).DisplayName;
				}
			}
			else
			{
				array[i] = descriptionElement.loadDescriptionElement();
			}
		}
		switch (array.Length)
		{
		case 0:
			if (!translationKey.Contains("Dialogue.cs.7") && !translationKey.Contains("Dialogue.cs.8"))
			{
				return Game1.content.LoadString(translationKey);
			}
			return Game1.content.LoadString(translationKey).Replace("/", " ").TrimStart(' ');
		case 1:
			return Game1.content.LoadString(translationKey, array[0]);
		case 2:
			return Game1.content.LoadString(translationKey, array[0], array[1]);
		case 3:
			return Game1.content.LoadString(translationKey, array[0], array[1], array[2]);
		default:
			return Game1.content.LoadString(translationKey, array);
		}
	}
}
