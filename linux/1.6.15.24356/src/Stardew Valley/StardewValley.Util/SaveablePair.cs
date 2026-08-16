using System.Xml.Serialization;

namespace StardewValley.Util;

public struct SaveablePair<TKey, TValue>
{
	public TKey[] key;

	public TValue[] value;

	[XmlIgnore]
	public TKey Key => key[0];

	[XmlIgnore]
	public TValue Value => value[0];

	public SaveablePair(TKey key, TValue value)
	{
		this.key = new TKey[1] { key };
		this.value = new TValue[1] { value };
	}
}
