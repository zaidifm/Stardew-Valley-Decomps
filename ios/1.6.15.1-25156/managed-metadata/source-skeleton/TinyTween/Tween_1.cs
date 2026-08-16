using System.Runtime.CompilerServices;

namespace TinyTween;

public class Tween<T> : ITween<T>, ITween where T : struct
{
	private readonly LerpFunc<T> lerpFunc;

	private float currentTime;

	private float duration;

	private ScaleFunc scaleFunc;

	private TweenState state;

	private T start;

	private T end;

	private T value;

	public float CurrentTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public float Duration
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public TweenState State
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public T StartValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public T EndValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public T CurrentValue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Tween(LerpFunc<T> lerpFunc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start(T start, T end, float duration, ScaleFunc scaleFunc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Pause()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Resume()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop(StopBehavior stopBehavior)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(float elapsedTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateValue()
	{
	}
}
