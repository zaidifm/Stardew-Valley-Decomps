using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

internal static class NetRefTypes
{
	private static Dictionary<string, Type> types;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type ReadType(this BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Type ReadGenericType(this BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteType(this BinaryWriter writer, Type type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void WriteGenericType(this BinaryWriter writer, Type type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void WriteTypeOf<T>(this BinaryWriter writer, T value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Type GetType(string typeName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
