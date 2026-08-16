using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace TinyTween;

public class Vector4Tween : Tween<Vector4>
{
	private static readonly LerpFunc<Vector4> LerpFunc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector4Tween()
	{
	}
}
