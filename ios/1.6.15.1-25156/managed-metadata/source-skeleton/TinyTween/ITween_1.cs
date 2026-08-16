using System.Runtime.CompilerServices;

namespace TinyTween;

public interface ITween<T> : ITween where T : struct
{
	T CurrentValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Start(T start, T end, float duration, ScaleFunc scaleFunc);
}
