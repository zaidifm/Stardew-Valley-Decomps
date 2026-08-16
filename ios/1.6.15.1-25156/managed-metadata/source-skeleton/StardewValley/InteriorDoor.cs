using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using xTile.Tiles;

namespace StardewValley;

public class InteriorDoor : NetField<bool, InteriorDoor>
{
	public GameLocation Location;

	public Point Position;

	public TemporaryAnimatedSprite Sprite;

	public Tile Tile;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InteriorDoor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InteriorDoor(GameLocation location, Point position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Set(bool newValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReadDelta(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void WriteDelta(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyMapModifications()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CleanUpLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void closeDoorSprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void openDoorSprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void openDoorTiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void closeDoorTiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(SpriteBatch b)
	{
	}
}
