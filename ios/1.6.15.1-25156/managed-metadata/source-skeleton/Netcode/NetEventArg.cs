using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public interface NetEventArg
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	void Read(BinaryReader reader);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Write(BinaryWriter writer);
}
