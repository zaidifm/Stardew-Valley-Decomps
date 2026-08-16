using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace StardewValley;

[XmlRoot("dictionary")]
public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IXmlSerializable
{
	public struct ChangeArgs
	{
		public readonly ChangeType Type;

		public readonly TKey Key;

		public readonly TValue Value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChangeArgs(ChangeType type, TKey k, TValue v)
		{
		}
	}

	public delegate void ChangeCallback(object sender, ChangeArgs args);

	private static XmlSerializer _keySerializer;

	private static XmlSerializer _valueSerializer;

	[CompilerGenerated]
	private ChangeCallback m_CollectionChanged;

	public event ChangeCallback CollectionChanged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializableDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SerializableDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SerializableDictionary(IDictionary<TKey, TValue> data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SerializableDictionary<TKey, TValue> BuildFrom<TSourceValue>(IDictionary<TKey, TSourceValue> data, Func<TSourceValue, TValue> getValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static SerializableDictionary<TKey, TValue> BuildFrom<TSourceKey, TSourceValue>(IDictionary<TSourceKey, TSourceValue> data, Func<TSourceKey, TKey> getKey, Func<TSourceValue, TValue> getValue)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected SerializableDictionary(IEqualityComparer<TKey> comparer = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected SerializableDictionary(IDictionary<TKey, TValue> data, IEqualityComparer<TKey> comparer = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new void Add(TKey key, TValue value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new bool Remove(TKey key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCollectionChanged(object sender, ChangeArgs args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public XmlSchema GetSchema()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReadXml(XmlReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteXml(XmlWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void AddDuringDeserialization(TKey key, TValue value)
	{
	}
}
