using System.Runtime.CompilerServices;

namespace rail;

public interface IRailAssetsHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailAssets OpenAssets();

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailAssets OpenGameServerAssets();
}
