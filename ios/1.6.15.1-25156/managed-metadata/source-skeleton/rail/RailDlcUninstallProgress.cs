using System.Runtime.CompilerServices;

namespace rail;

public class RailDlcUninstallProgress
{
	public ulong finished_files;

	public uint progress;

	public ulong total_files;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailDlcUninstallProgress()
	{
	}
}
