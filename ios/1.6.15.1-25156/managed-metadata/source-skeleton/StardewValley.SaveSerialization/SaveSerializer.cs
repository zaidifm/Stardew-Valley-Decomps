using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Xml.Serialization.GeneratedAssembly;

namespace StardewValley.SaveSerialization;

public static class SaveSerializer
{
	private static XmlSerializerContract _contract;

	private static readonly Dictionary<Type, XmlSerializer> _serializerLookup;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static XmlSerializer GetSerializer(Type type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SerializeFast(this XmlSerializer serializer, Stream stream, object obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize<T>(XmlWriter xmlWriter, T obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SerializeFast(this XmlSerializer serializer, XmlWriter xmlWriter, object obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T Deserialize<T>(Stream stream)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T Deserialize<T>(XmlReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object DeserializeFast(this XmlSerializer serializer, Stream stream)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object DeserializeFast(this XmlSerializer serializer, XmlReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
