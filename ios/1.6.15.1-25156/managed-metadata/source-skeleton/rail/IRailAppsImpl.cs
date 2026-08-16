using System.Runtime.CompilerServices;

namespace rail;

public class IRailAppsImpl : RailObject, IRailApps
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailAppsImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailAppsImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsGameInstalled(RailGameID game_id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncQuerySubscribeWishPlayState(RailGameID game_id, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
