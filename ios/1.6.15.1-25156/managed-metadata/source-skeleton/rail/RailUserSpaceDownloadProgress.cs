using System.Runtime.CompilerServices;

namespace rail;

public class RailUserSpaceDownloadProgress
{
	public uint progress;

	public ulong total;

	public uint speed;

	public SpaceWorkID id;

	public ulong finidshed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailUserSpaceDownloadProgress()
	{
	}
}
