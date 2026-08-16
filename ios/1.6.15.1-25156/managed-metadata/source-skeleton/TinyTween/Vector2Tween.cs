using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace TinyTween;

public class Vector2Tween : Tween<Vector2>
{
	private static readonly LerpFunc<Vector2> LerpFunc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2Tween()
	{
	}
}
