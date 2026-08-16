using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public abstract class AbstractNetSerializable : INetSerializable, INetObject<INetSerializable>
{
	private uint dirtyTick;

	private uint minNextDirtyTime;

	protected NetVersion ChangeVersion;

	public ushort DeltaAggregateTicks;

	private bool needsTick;

	private bool childNeedsTick;

	private INetSerializable parent;

	public uint DirtyTick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public virtual bool Dirty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool NeedsTick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public bool ChildNeedsTick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	public INetRoot Root
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
		}
	}

	public INetSerializable Parent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public INetSerializable NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetNewestReceivedChangeVersion()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SetDirtySooner(uint tick)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void SetDirtyLater(uint tick)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void CleanImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkDirty()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkClean()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool tickImpl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Tick()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void Read(BinaryReader reader, NetVersion version);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void Write(BinaryWriter writer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void ReadFull(BinaryReader reader, NetVersion version);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public abstract void WriteFull(BinaryWriter writer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected uint GetLocalTick()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected NetVersion GetLocalVersion()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void SetParent(INetSerializable parent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void SetChildParents()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ClearChildParents()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ValidateChild(INetSerializable child)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ValidateChildren()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void ForEachChild(Action<INetSerializable> childAction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected AbstractNetSerializable()
	{
	}
}
