using System.Runtime.CompilerServices;

namespace rail;

public interface IRailTextInputHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult ShowTextInputWindow(RailTextInputWindowOption options);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void GetTextInputContent(out string content);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult HideTextInputWindow();
}
