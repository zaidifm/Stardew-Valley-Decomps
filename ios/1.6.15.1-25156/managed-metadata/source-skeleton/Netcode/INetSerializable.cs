using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public interface INetSerializable
{
	uint DirtyTick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	bool Dirty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	bool NeedsTick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	bool ChildNeedsTick
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	INetSerializable Parent
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	INetRoot Root
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void MarkDirty();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void MarkClean();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool Tick();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Read(BinaryReader reader, NetVersion version);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Write(BinaryWriter writer);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void ReadFull(BinaryReader reader, NetVersion version);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void WriteFull(BinaryWriter writer);
}
