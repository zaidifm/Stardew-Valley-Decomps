using System.Runtime.CompilerServices;

namespace Netcode;

public interface InterpolationCancellable
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	void CancelInterpolation();
}
