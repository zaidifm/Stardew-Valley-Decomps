using System.Runtime.CompilerServices;

namespace TinyTween;

public interface ITween
{
	TweenState State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Pause();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Resume();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Stop(StopBehavior stopBehavior);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Update(float elapsedTime);
}
