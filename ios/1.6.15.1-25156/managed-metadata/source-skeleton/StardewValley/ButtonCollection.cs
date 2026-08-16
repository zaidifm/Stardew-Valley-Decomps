using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Input;

namespace StardewValley;

public struct ButtonCollection
{
	public struct ButtonEnumerator
	{
		private readonly Buttons _pressed;

		private int _current;

		public Buttons Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ButtonEnumerator(Buttons pressed)
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
	}

	private readonly Buttons _pressed;

	private readonly int _count;

	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ButtonCollection(ref GamePadState padState, ref GamePadState oldPadState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ButtonCollection(ref GamePadState padState, ref GamePadState oldPadState, bool released)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ButtonCollection(ref GamePadState padState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ButtonEnumerator GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
