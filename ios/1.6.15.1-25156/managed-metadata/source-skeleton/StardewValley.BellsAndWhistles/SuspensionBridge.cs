using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class SuspensionBridge
{
	public Rectangle bridgeBounds;

	public List<Rectangle> bridgeEntrances;

	public List<Rectangle> bridgeSortRegions;

	public const float BRIDGE_SORT_OFFSET = 0.0256f;

	protected Texture2D _texture;

	public float shakeTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SuspensionBridge()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SuspensionBridge(int tile_x, int tile_y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool InEntranceArea(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool InEntranceArea(Rectangle rectangle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CheckPlacementPrevention(Vector2 tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnFootstep(Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch b)
	{
	}
}
