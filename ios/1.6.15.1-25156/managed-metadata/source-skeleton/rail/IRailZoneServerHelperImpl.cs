using System.Runtime.CompilerServices;

namespace rail;

public class IRailZoneServerHelperImpl : RailObject, IRailZoneServerHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailZoneServerHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailZoneServerHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailZoneID GetPlayerSelectedZoneID()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailZoneID GetRootZoneID()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailZoneServer OpenZoneServer(RailZoneID zone_id, out RailResult result)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult AsyncSwitchPlayerSelectedZone(RailZoneID zone_id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
