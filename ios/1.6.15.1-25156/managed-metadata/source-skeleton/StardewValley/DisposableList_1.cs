using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley;

[Obsolete("This is only kept for backwards compatibility. It should no longer be used, and no longer does anything besides wrap the provided list.")]
public struct DisposableList<T>
{
	public struct Enumerator : IDisposable
	{
		private readonly DisposableList<T> _parent;

		private int _index;

		public T Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Enumerator(DisposableList<T> parent)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
		}
	}

	private readonly List<T> _list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DisposableList(List<T> list)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Enumerator GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
