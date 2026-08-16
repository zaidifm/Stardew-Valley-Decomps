using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley;

public class AnimatedSprite : INetObject<NetFields>
{
	public delegate void endOfAnimationBehavior(Farmer who);

	public Texture2D spriteTexture;

	public string loadedTexture;

	public string overrideTextureName;

	public readonly NetString textureName;

	public float timer;

	public float interval;

	public int framesPerAnimation;

	public int currentFrame;

	public readonly NetInt spriteWidth;

	public readonly NetInt spriteHeight;

	public int tempSpriteHeight;

	public Rectangle sourceRect;

	public bool loop;

	public bool ignoreStopAnimation;

	public bool textureUsesFlippedRightForLeft;

	public endOfAnimationBehavior endOfAnimationFunction;

	public readonly List<FarmerSprite.AnimationFrame> currentAnimation;

	public int oldFrame;

	public int currentAnimationIndex;

	protected ContentManager contentManager;

	public bool ignoreSourceRectUpdates;

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Texture2D Texture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	protected int textureWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	protected int textureHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int SpriteWidth
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public int SpriteHeight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public virtual int CurrentFrame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public List<FarmerSprite.AnimationFrame> CurrentAnimation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public Rectangle SourceRect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public virtual Character Owner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnimatedSprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnimatedSprite(ContentManager contentManager, string textureName, int currentFrame, int spriteWidth, int spriteHeight)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnimatedSprite(ContentManager contentManager, string textureName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnimatedSprite(string textureName, int currentFrame, int spriteWidth, int spriteHeight)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AnimatedSprite(string textureName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetOwner(Character owner)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTexture(string textureName, bool syncTextureName = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void loadTexture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getHeight()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getWidth()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StopAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void standAndFaceDirection(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void faceDirectionStandard(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void faceDirection(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AnimateRight(GameTime gameTime, int intervalOffset = 0, string soundForFootstep = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AnimateUp(GameTime gameTime, int intervalOffset = 0, string soundForFootstep = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AnimateDown(GameTime gameTime, int intervalOffset = 0, string soundForFootstep = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AnimateLeft(GameTime gameTime, int intervalOffset = 0, string soundForFootstep = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool Animate(GameTime gameTime, int startFrame, int numberOfFrames, float interval)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ClearAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddFrame(FarmerSprite.AnimationFrame frame)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setCurrentAnimation(List<FarmerSprite.AnimationFrame> animation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool animateOnce(GameTime time)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateSourceRect()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b, Vector2 screenPosition, float layerDepth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void draw(SpriteBatch b, Vector2 screenPosition, float layerDepth, int xOffset, int yOffset, Color c, bool flip = false, float scale = 1f, float rotation = 0f, bool characterSourceRectOffset = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawShadow(SpriteBatch b, Vector2 screenPosition, float scale = 4f, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void drawShadow(SpriteBatch b, Vector2 screenPosition, float scale = 4f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual AnimatedSprite Clone()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Rectangle GetSourceRect(int textureWidth, int spriteWidth, int spriteHeight, int frame)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
