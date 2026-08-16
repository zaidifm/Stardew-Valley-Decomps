using System.Runtime.CompilerServices;

namespace Netcode;

public interface ILoggingWriter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	void Push(string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Pop();
}
