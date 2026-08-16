using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailDlcHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQueryIsOwnedDlcsOnServer(List<RailDlcID> dlc_ids, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncCheckAllDlcsStateReady(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsDlcInstalled(RailDlcID dlc_id, out string installed_path);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsDlcInstalled(RailDlcID dlc_id);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsOwnedDlc(RailDlcID dlc_id);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetDlcCount();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GetDlcInfo(uint index, RailDlcInfo dlc_info);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool AsyncInstallDlc(RailDlcID dlc_id, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool AsyncRemoveDlc(RailDlcID dlc_id, string user_data);
}
