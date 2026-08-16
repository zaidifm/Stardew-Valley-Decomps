using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using StardewValley.SaveSerialization;

namespace StardewValley;

[XmlRoot("dictionary")]
public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
{
	public struct ChangeArgs(ChangeType type, TKey k, TValue v)
	{
		public readonly ChangeType Type = type;

		public readonly TKey Key = k;

		public readonly TValue Value = v;
	}

	public delegate void ChangeCallback(object sender, ChangeArgs args);

	private static XmlSerializer _keySerializer;

	private static XmlSerializer _valueSerializer;

	public event ChangeCallback CollectionChanged;

	static SerializableDictionary()
	{
		_keySerializer = SaveSerializer.GetSerializer(typeof(TKey));
		_valueSerializer = SaveSerializer.GetSerializer(typeof(TValue));
	}

	public SerializableDictionary()
	{
	}

	public SerializableDictionary(IDictionary<TKey, TValue> data)
		: base(data)
	{
	}

	public static SerializableDictionary<TKey, TValue> BuildFrom<TSourceValue>(IDictionary<TKey, TSourceValue> data, Func<TSourceValue, TValue> getValue)
	{
		SerializableDictionary<TKey, TValue> serializableDictionary = new SerializableDictionary<TKey, TValue>();
		foreach (KeyValuePair<TKey, TSourceValue> datum in data)
		{
			serializableDictionary[datum.Key] = getValue(datum.Value);
		}
		return serializableDictionary;
	}

	public static SerializableDictionary<TKey, TValue> BuildFrom<TSourceKey, TSourceValue>(IDictionary<TSourceKey, TSourceValue> data, Func<TSourceKey, TKey> getKey, Func<TSourceValue, TValue> getValue)
	{
		SerializableDictionary<TKey, TValue> serializableDictionary = new SerializableDictionary<TKey, TValue>();
		foreach (KeyValuePair<TSourceKey, TSourceValue> datum in data)
		{
			serializableDictionary[getKey(datum.Key)] = getValue(datum.Value);
		}
		return serializableDictionary;
	}

	protected SerializableDictionary(IEqualityComparer<TKey> comparer = null)
		: base(comparer)
	{
	}

	protected SerializableDictionary(IDictionary<TKey, TValue> data, IEqualityComparer<TKey> comparer = null)
		: base(data, comparer)
	{
	}

	public new void Add(TKey key, TValue value)
	{
		base.Add(key, value);
		OnCollectionChanged(this, new ChangeArgs(ChangeType.Add, key, value));
	}

	public new bool Remove(TKey key)
	{
		if (TryGetValue(key, out var value))
		{
			base.Remove(key);
			OnCollectionChanged(this, new ChangeArgs(ChangeType.Remove, key, value));
			return true;
		}
		return false;
	}

	public new void Clear()
	{
		base.Clear();
		OnCollectionChanged(this, new ChangeArgs(ChangeType.Clear, default(TKey), default(TValue)));
	}

	private void OnCollectionChanged(object sender, ChangeArgs args)
	{
		CollectionChanged?.Invoke(sender ?? this, args);
	}

	public XmlSchema GetSchema()
	{
		return null;
	}

	public void ReadXml(XmlReader reader)
	{
		bool isEmptyElement = reader.IsEmptyElement;
		reader.Read();
		if (isEmptyElement)
		{
			return;
		}
		while (reader.NodeType != XmlNodeType.EndElement)
		{
			reader.ReadStartElement("item");
			reader.ReadStartElement("key");
			bool flag = false;
			TKey key = default(TKey);
			if (typeof(TKey) == typeof(string))
			{
				string name = reader.Name;
				if (!(name == "int"))
				{
					if (name == "LocationContext")
					{
						reader.ReadStartElement();
						key = (TKey)Convert.ChangeType(reader.ReadContentAsString(), typeof(TKey));
						reader.ReadEndElement();
						flag = true;
					}
				}
				else
				{
					key = (TKey)Convert.ChangeType(SaveSerializer.Deserialize<int>(reader), typeof(TKey));
					flag = true;
				}
			}
			if (!flag)
			{
				key = (TKey)_keySerializer.DeserializeFast(reader);
			}
			reader.ReadEndElement();
			reader.ReadStartElement("value");
			TValue value = default(TValue);
			flag = false;
			if (typeof(TValue) == typeof(string) && reader.Name == "int")
			{
				value = (TValue)Convert.ChangeType(SaveSerializer.Deserialize<int>(reader), typeof(TValue));
				flag = true;
			}
			if (!flag)
			{
				value = (TValue)_valueSerializer.DeserializeFast(reader);
			}
			reader.ReadEndElement();
			AddDuringDeserialization(key, value);
			reader.ReadEndElement();
			reader.MoveToContent();
		}
		reader.ReadEndElement();
	}

	public void WriteXml(XmlWriter writer)
	{
		foreach (TKey key in base.Keys)
		{
			writer.WriteStartElement("item");
			writer.WriteStartElement("key");
			_keySerializer.SerializeFast(writer, key);
			writer.WriteEndElement();
			writer.WriteStartElement("value");
			TValue val = base[key];
			_valueSerializer.SerializeFast(writer, val);
			writer.WriteEndElement();
			writer.WriteEndElement();
		}
	}

	protected virtual void AddDuringDeserialization(TKey key, TValue value)
	{
		base.Add(key, value);
	}
}
