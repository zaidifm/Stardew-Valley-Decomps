using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace TinyTween;

public class QuaternionTween : Tween<Quaternion>
{
	private static readonly LerpFunc<Quaternion> LerpFunc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuaternionTween()
	{
	}
}
