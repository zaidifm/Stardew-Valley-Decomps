using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace Netcode;

public static class BinaryReaderWriterExtensions
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReadSkippable(this BinaryReader reader, Action readAction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] ReadSkippableBytes(this BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Skip(this BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteSkippable(this BinaryWriter writer, Action writeAction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BitArray ReadBitArray(this BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteBitArray(this BinaryWriter writer, BitArray bits)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Write7BitEncoded(this BinaryWriter writer, uint value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static uint Read7BitEncoded(this BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Guid ReadGuid(this BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteGuid(this BinaryWriter writer, Guid guid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2 ReadVector2(this BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteVector2(this BinaryWriter writer, Vector2 vec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Point ReadPoint(this BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WritePoint(this BinaryWriter writer, Point p)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Rectangle ReadRectangle(this BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteRectangle(this BinaryWriter writer, Rectangle rect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color ReadColor(this BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteColor(this BinaryWriter writer, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T ReadEnum<T>(this BinaryReader reader) where T : struct, IConvertible
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteEnum<T>(this BinaryWriter writer, T enumValue) where T : struct, IConvertible
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteEnum(this BinaryWriter writer, object enumValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Push(this BinaryWriter writer, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Pop(this BinaryWriter writer)
	{
	}
}
