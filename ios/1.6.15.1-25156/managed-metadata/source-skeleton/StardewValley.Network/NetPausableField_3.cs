using System.Runtime.CompilerServices;
using Netcode;

namespace StardewValley.Network;

public abstract class NetPausableField<T, TField, TBaseField> : INetObject<NetFields> where TField : TBaseField, new() where TBaseField : NetFieldBase<T, TBaseField>, new()
{
	private bool paused;

	public readonly TField Field;

	private readonly NetEvent1Field<bool, NetBool> pauseEvent;

	public T Value
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

	public bool Paused
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

	public abstract NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetPausableField(TField field)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetPausableField()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual T Get()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(T value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPausePending()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInterpolating()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
