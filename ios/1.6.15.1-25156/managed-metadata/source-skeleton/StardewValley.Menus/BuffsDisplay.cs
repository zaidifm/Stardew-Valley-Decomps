using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Buffs;

namespace StardewValley.Menus;

public class BuffsDisplay : IClickableMenu
{
	[CompilerGenerated]
	private sealed class <getClickableComponents>d__31 : IEnumerable<ClickableTextureComponent>, IEnumerable, IEnumerator<ClickableTextureComponent>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private ClickableTextureComponent <>2__current;

		private int <>l__initialThreadId;

		private Buff buff;

		public Buff <>3__buff;

		public BuffsDisplay <>4__this;

		private List<BuffAttributeDisplay>.Enumerator <>7__wrap1;

		ClickableTextureComponent IEnumerator<ClickableTextureComponent>.Current
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
		public <getClickableComponents>d__31(int <>1__state)
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
		private void <>m__Finally1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<ClickableTextureComponent> IEnumerable<ClickableTextureComponent>.GetEnumerator()
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

	public static readonly List<BuffAttributeDisplay> displayAttributes;

	public const int fullnessLength = 180000;

	public const int quenchedLength = 60000;

	private readonly Dictionary<ClickableTextureComponent, Buff> buffs;

	public readonly HashSet<string> updatedIDs;

	public Buff food;

	public Buff drink;

	public List<Buff> otherBuffs;

	public int fullnessLeft;

	public int quenchedLeft;

	public bool dirty;

	public string hoverText;

	private bool _hovering;

	private Buff _selectedBuff;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuffsDisplay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updatePosition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getNumBuffs()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string[] getBuffDescriptionTextReplacement(string buffName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void mobileArrangeComponents()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void arrangeTheseComponentsInThisRectangle(int rectangleX, int rectangleY, int rectangleWidthInComponentWidthUnits, int componentWidth, int componentHeight, int buffer, bool rightToLeft)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void resetIcons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public new void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<Buff> GetSortedBuffs()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string getDescription(Buff buff)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string getDescription(Buff buff, BuffAttributeDisplay attribute, bool withSource)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string getSourceLine(Buff buff)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<getClickableComponents>d__31))]
	public virtual IEnumerable<ClickableTextureComponent> getClickableComponents(Buff buff)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
