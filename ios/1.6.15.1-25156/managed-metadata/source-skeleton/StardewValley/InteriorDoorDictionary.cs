using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Network;

namespace StardewValley;

public class InteriorDoorDictionary : NetPointDictionary<bool, InteriorDoor>
{
	public struct DoorCollection : IEnumerable<InteriorDoor>, IEnumerable
	{
		public struct Enumerator : IEnumerator<InteriorDoor>, IEnumerator, IDisposable
		{
			private readonly InteriorDoorDictionary _dict;

			private Dictionary<Point, InteriorDoor>.Enumerator _enumerator;

			private InteriorDoor _current;

			private bool _done;

			public InteriorDoor Current
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
			public Enumerator(InteriorDoorDictionary dict)
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

		private InteriorDoorDictionary _dict;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DoorCollection(InteriorDoorDictionary dict)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Enumerator GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator<InteriorDoor> IEnumerable<InteriorDoor>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[CompilerGenerated]
	private sealed class <GetDoorTilesFromMapProperty>d__7 : IEnumerable<Point>, IEnumerable, IEnumerator<Point>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private Point <>2__current;

		private int <>l__initialThreadId;

		private GameLocation location;

		public GameLocation <>3__location;

		private string[] <fields>5__2;

		private int <i>5__3;

		Point IEnumerator<Point>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public <GetDoorTilesFromMapProperty>d__7(int <>1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<Point> IEnumerable<Point>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private GameLocation location;

	public DoorCollection Doors
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InteriorDoorDictionary(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void setFieldValue(InteriorDoor door, Point position, bool open)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<GetDoorTilesFromMapProperty>d__7))]
	public static IEnumerable<Point> GetDoorTilesFromMapProperty(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MakeMapModifications()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CleanUpLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(SpriteBatch b)
	{
	}
}
