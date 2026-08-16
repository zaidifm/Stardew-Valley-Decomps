using System.Runtime.CompilerServices;

namespace rail;

public class RailBranchInfo
{
	public string branch_name;

	public string build_number;

	public string branch_type;

	public string version_id;

	public string branch_id;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailBranchInfo()
	{
	}
}
