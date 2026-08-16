using System.Runtime.CompilerServices;

namespace rail;

public class RailDlcInstallProgress
{
	public uint progress;

	public ulong finished_bytes;

	public ulong total_bytes;

	public uint speed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailDlcInstallProgress()
	{
	}
}
