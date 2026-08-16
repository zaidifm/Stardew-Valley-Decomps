using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class IRailDlcHelperImpl : RailObject, IRailDlcHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailDlcHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailDlcHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncQueryIsOwnedDlcsOnServer(List<RailDlcID> dlc_ids, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncCheckAllDlcsStateReady(string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsDlcInstalled(RailDlcID dlc_id, out string installed_path)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsDlcInstalled(RailDlcID dlc_id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsOwnedDlc(RailDlcID dlc_id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual uint GetDlcCount()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool GetDlcInfo(uint index, RailDlcInfo dlc_info)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool AsyncInstallDlc(RailDlcID dlc_id, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool AsyncRemoveDlc(RailDlcID dlc_id, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
