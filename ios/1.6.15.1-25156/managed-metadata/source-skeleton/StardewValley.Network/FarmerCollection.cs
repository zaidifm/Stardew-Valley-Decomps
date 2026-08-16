using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Network;

public class FarmerCollection : IEnumerable<Farmer>, IEnumerable
{
	public struct Enumerator : IEnumerator<Farmer>, IEnumerator, IDisposable
	{
		private GameLocation _locationFilter;

		private Dictionary<long, Netcode.NetRoot<Farmer>>.Enumerator _enumerator;

		private Farmer _player;

		private Farmer _current;

		private int _done;

		public Farmer Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Enumerator(GameLocation locationFilter)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		void IEnumerator.Reset()
		{
		}
	}

	private GameLocation _locationFilter;

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarmerCollection(GameLocation locationFilter = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Any()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsID(long uniqueMultiplayerID)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Enumerator GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator<Farmer> IEnumerable<Farmer>.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
