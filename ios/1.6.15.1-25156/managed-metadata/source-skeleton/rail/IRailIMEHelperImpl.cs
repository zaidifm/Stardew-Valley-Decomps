using System.Runtime.CompilerServices;

namespace rail;

public class IRailIMEHelperImpl : RailObject, IRailIMEHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailIMEHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailIMEHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult EnableIMEHelperTextInputWindow(bool enable, RailTextInputImeWindowOption option)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult UpdateIMEHelperTextInputWindowPosition(RailWindowPosition position)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
