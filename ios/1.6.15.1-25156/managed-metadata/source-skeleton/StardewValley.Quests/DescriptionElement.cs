using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Quests;

[XmlInclude(typeof(Character))]
[XmlInclude(typeof(Item))]
public class DescriptionElement : INetObject<NetFields>
{
	public static XmlSerializer serializer;

	[XmlElement("xmlKey")]
	public string translationKey;

	[XmlElement("param")]
	public List<object> substitutions;

	[XmlIgnore]
	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DescriptionElement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DescriptionElement(string key, params object[] substitutions)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string loadDescriptionElement()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
