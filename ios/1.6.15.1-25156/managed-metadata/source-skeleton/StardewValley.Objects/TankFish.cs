using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Objects;

public class TankFish
{
	public enum FishType
	{
		Normal,
		Eel,
		Cephalopod,
		Float,
		Ground,
		Crawl,
		Hop,
		Static
	}

	public const int field_spriteIndex = 0;

	public const int field_type = 1;

	public const int field_idleAnimations = 2;

	public const int field_dartStartFrames = 3;

	public const int field_dartHoldFrames = 4;

	public const int field_dartEndFrames = 5;

	public const int field_texture = 6;

	public const int field_hatOffset = 7;

	protected FishTankFurniture _tank;

	public Vector2 position;

	public float zPosition;

	public bool facingLeft;

	public Vector2 velocity;

	protected Texture2D _texture;

	public float nextSwim;

	public string fishItemId;

	public int fishIndex;

	public int currentFrame;

	public Point? hatPosition;

	public int frogVariant;

	public int numberOfDarts;

	public FishType fishType;

	public float minimumVelocity;

	public float fishScale;

	public List<int> currentAnimation;

	public List<int> idleAnimation;

	public List<int> dartStartAnimation;

	public List<int> dartHoldAnimation;

	public List<int> dartEndAnimation;

	public int currentAnimationFrame;

	public float currentFrameTime;

	public float nextBubble;

	public bool isErrorFish;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TankFish(FishTankFurniture tank, Item item)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAnimation(List<int> frames)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch b, float alpha, float draw_layer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[MemberNotNullWhen(true, "hatPosition")]
	public bool CanWearHat()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetWorldPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConstrainToTank()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float GetScale()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rectangle GetBounds()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(GameTime time)
	{
	}
}
