using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public class NetFields : AbstractNetSerializable
{
	public static bool ShouldValidateNetFields;

	private readonly List<INetSerializable> fields;

	public new string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public INetObject<NetFields> Owner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetFields(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetFields SetOwner(INetObject<NetFields> owner)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetNameForInstance<TBaseType>(TBaseType instance)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<INetSerializable> GetFields()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelInterpolation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetFields AddField(INetSerializable field, [CallerArgumentExpression("field")] string name = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void SetParent(INetSerializable parent)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void ValidateNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ReadFull(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteFull(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CopyFrom(NetFields source)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ForEachChild(Action<INetSerializable> childAction)
	{
	}
}
