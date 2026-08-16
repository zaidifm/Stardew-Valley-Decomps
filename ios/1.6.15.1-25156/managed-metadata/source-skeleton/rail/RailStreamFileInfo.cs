using System.Runtime.CompilerServices;

namespace rail;

public class RailStreamFileInfo
{
	public ulong file_size;

	public string filename;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailStreamFileInfo()
	{
	}
}
