using System.Runtime.CompilerServices;

namespace rail;

public interface IRailIMEHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult EnableIMEHelperTextInputWindow(bool enable, RailTextInputImeWindowOption option);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult UpdateIMEHelperTextInputWindowPosition(RailWindowPosition position);
}
