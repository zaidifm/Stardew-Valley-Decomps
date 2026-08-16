using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace StardewValley.Util;

public static class CloneExtensions
{
	private class ReferenceComparer : EqualityComparer<object>
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object x, object y)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode(object obj)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReferenceComparer()
		{
		}
	}

	private class ArrayTraverse
	{
		public int[] Position;

		private int[] maxLengths;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ArrayTraverse(Array array)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Step()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private static readonly MethodInfo CloneMethod;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsPrimitive(this Type type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object DeepClone(this object obj)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T DeepCloneT<T>(this T obj)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object DeepCloneObject(object originalObject)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static object InternalCopy(object originalObject, Dictionary<object, object> visited)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void RecursiveCopyBaseTypePrivateFields(object originalObject, Dictionary<object, object> visited, object cloneObject, Type typeToReflect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CopyFields(object originalObject, Dictionary<object, object> visited, object cloneObject, Type typeToReflect, BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy, Func<FieldInfo, bool> filter = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T Copy<T>(this T original)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ForEach(Array array, Action<Array, int[]> action)
	{
	}
}
