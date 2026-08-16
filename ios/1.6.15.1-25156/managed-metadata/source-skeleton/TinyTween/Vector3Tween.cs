using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace TinyTween;

public class Vector3Tween : Tween<Vector3>
{
	private static readonly LerpFunc<Vector3> LerpFunc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3Tween()
	{
	}
}
