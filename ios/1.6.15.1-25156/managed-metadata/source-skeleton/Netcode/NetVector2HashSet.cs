using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace Netcode;

public class NetVector2HashSet : NetHashSet<Vector2>
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Vector2 ReadValue(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteValue(BinaryWriter writer, Vector2 value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetVector2HashSet()
	{
	}
}
