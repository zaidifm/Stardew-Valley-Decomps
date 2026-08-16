using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace TinyTween;

public class ColorTween : Tween<Color>
{
	private static readonly LerpFunc<Color> LerpFunc;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ColorTween()
	{
	}
}
