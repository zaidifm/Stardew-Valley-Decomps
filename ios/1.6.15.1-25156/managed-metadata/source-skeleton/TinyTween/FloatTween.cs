using System.Runtime.CompilerServices;

namespace TinyTween;

public class FloatTween : Tween<float>
{
	private static readonly LerpFunc<float> LerpFunc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static float LerpFloat(float start, float end, float progress)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FloatTween()
	{
	}
}
