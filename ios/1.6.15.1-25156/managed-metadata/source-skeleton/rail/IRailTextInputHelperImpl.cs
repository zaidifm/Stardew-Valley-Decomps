using System.Runtime.CompilerServices;

namespace rail;

public class IRailTextInputHelperImpl : RailObject, IRailTextInputHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailTextInputHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailTextInputHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult ShowTextInputWindow(RailTextInputWindowOption options)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetTextInputContent(out string content)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult HideTextInputWindow()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
