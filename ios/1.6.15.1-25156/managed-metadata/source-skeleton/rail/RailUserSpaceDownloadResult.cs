using System.Runtime.CompilerServices;

namespace rail;

public class RailUserSpaceDownloadResult
{
	public string err_msg;

	public ulong finished_bytes;

	public uint finished_files;

	public ulong total_bytes;

	public uint total_files;

	public SpaceWorkID id;

	public uint err_code;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailUserSpaceDownloadResult()
	{
	}
}
