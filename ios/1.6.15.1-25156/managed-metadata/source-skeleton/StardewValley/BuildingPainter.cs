using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley;

[XmlInclude(typeof(BuildingPaintColor))]
public class BuildingPainter
{
	[XmlIgnore]
	public static Dictionary<string, List<List<int>>> paintMaskLookup;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture2D Apply(Texture2D base_texture, string mask_path, BuildingPaintColor color)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static void _ApplyPaint(int h_shift, int s_shift, int l_shift, Color[] pixels, List<int> indices)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuildingPainter()
	{
	}
}
