using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley;

public class FarmerSprite : AnimatedSprite
{
	public struct AnimationFrame
	{
		public int frame;

		public int milliseconds;

		public int positionOffset;

		public int xOffset;

		public int armOffset;

		public bool flip;

		public endOfAnimationBehavior frameStartBehavior;

		public endOfAnimationBehavior frameEndBehavior;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimationFrame(int frame, int milliseconds, int position_offset, bool secondary_arm, bool flip, endOfAnimationBehavior frame_start_behavior, endOfAnimationBehavior frame_end_behavior, int x_offset, bool hideArms = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimationFrame(int frame, int milliseconds, int position_offset, int armOffset, bool flip, endOfAnimationBehavior frame_start_behavior, endOfAnimationBehavior frame_end_behavior, int x_offset)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimationFrame(int frame, int milliseconds, int positionOffset, bool secondaryArm, bool flip, endOfAnimationBehavior frameBehavior = null, bool behaviorAtEndOfFrame = false, int xOffset = 0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimationFrame(int frame, int milliseconds, bool secondaryArm, bool flip, endOfAnimationBehavior frameBehavior = null, bool behaviorAtEndOfFrame = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimationFrame(int frame, int milliseconds, bool secondaryArm, bool flip, bool hideArm)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimationFrame(int frame, int milliseconds)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimationFrame(int frame, int milliseconds, int armOffset, bool flip = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimationFrame AddFrameAction(endOfAnimationBehavior callback)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AnimationFrame AddFrameEndAction(endOfAnimationBehavior callback)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public const int walkDown = 0;

	public const int walkRight = 8;

	public const int walkUp = 16;

	public const int walkLeft = 24;

	public const int runDown = 32;

	public const int runRight = 40;

	public const int runUp = 48;

	public const int runLeft = 56;

	public const int grabDown = 64;

	public const int grabRight = 72;

	public const int grabUp = 80;

	public const int grabLeft = 88;

	public const int carryWalkDown = 96;

	public const int carryWalkRight = 104;

	public const int carryWalkUp = 112;

	public const int carryWalkLeft = 120;

	public const int carryRunDown = 128;

	public const int carryRunRight = 136;

	public const int carryRunUp = 144;

	public const int carryRunLeft = 152;

	public const int toolDown = 160;

	public const int toolRight = 168;

	public const int toolUp = 176;

	public const int toolLeft = 184;

	public const int toolChooseDown = 192;

	public const int toolChooseRight = 194;

	public const int toolChooseUp = 196;

	public const int toolChooseLeft = 198;

	public const int seedThrowDown = 200;

	public const int seedThrowRight = 204;

	public const int seedThrowUp = 208;

	public const int seedThrowLeft = 212;

	public const int eat = 216;

	public const int sick = 224;

	public const int swordswipeDown = 232;

	public const int swordswipeRight = 240;

	public const int swordswipeUp = 248;

	public const int swordswipeLeft = 256;

	public const int punchDown = 272;

	public const int punchRight = 274;

	public const int punchUp = 276;

	public const int punchLeft = 278;

	public const int harvestItemUp = 279;

	public const int harvestItemRight = 280;

	public const int harvestItemDown = 281;

	public const int harvestItemLeft = 282;

	public const int shearUp = 283;

	public const int shearRight = 284;

	public const int shearDown = 285;

	public const int shearLeft = 286;

	public const int milkUp = 287;

	public const int milkRight = 288;

	public const int milkDown = 289;

	public const int milkLeft = 290;

	public const int tired = 291;

	public const int tired2 = 292;

	public const int passOutTired = 293;

	public const int drink = 294;

	public const int fishingUp = 295;

	public const int fishingRight = 296;

	public const int fishingDown = 297;

	public const int fishingLeft = 298;

	public const int fishingDoneUp = 299;

	public const int fishingDoneRight = 300;

	public const int fishingDoneDown = 301;

	public const int fishingDoneLeft = 302;

	public const int pan = 303;

	public const int showHoldingEdible = 304;

	private int currentToolIndex;

	private float oldInterval;

	public bool pauseForSingleAnimation;

	public bool animateBackwards;

	public bool loopThisAnimation;

	public bool freezeUntilDialogueIsOver;

	public int currentSingleAnimation;

	public int currentAnimationFrames;

	public float currentSingleAnimationInterval;

	public float intervalModifier;

	public string currentStep;

	private Farmer owner;

	public bool animatingBackwards;

	public const int cheer = 97;

	public override Character Owner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public AnimationFrame CurrentAnimationFrame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int CurrentSingleAnimation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public override int CurrentFrame
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

	public bool PauseForSingleAnimation
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

	public int CurrentToolIndex
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetOwner(Character owner)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setCurrentAnimation(AnimationFrame[] animation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void faceDirection(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsPlayingBasicAnimation(int direction, bool carrying)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setCurrentSingleFrame(int which, short interval = 32000, bool secondaryArm = false, bool flip = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setCurrentFrame(int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setCurrentFrame(int which, int offset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setCurrentFrameBackwards(int which, int offset, int interval, int numFrames, bool secondaryArm, bool flip)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setCurrentFrame(int which, int offset, int interval, int numFrames, bool flip, bool secondaryArm)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarmerSprite()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarmerSprite(string texture)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void animate(int whichAnimation, GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void animate(int whichAnimation, int milliseconds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void checkForSingleAnimation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void animateOnce(int whichAnimation, float animationInterval, int numberOfFrames)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void animateOnce(int whichAnimation, float animationInterval, int numberOfFrames, endOfAnimationBehavior endOfBehaviorFunction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void animateOnce(int whichAnimation, float animationInterval, int numberOfFrames, endOfAnimationBehavior endOfBehaviorFunction, bool flip, bool secondaryArm)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void animateOnce(AnimationFrame[] animation, endOfAnimationBehavior endOfBehaviorFunction = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void showFrameUntilDialogueOver(int whichFrame)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void animateOnce(int whichAnimation, float animationInterval, int numberOfFrames, endOfAnimationBehavior endOfBehaviorFunction, bool flip, bool secondaryArm, bool backwards)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void animateBackwardsOnce(int whichAnimation, float animationInterval)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isUsingWeapon()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int getWeaponTypeFromAnimation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isOnToolAnimation()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isPassingOut()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doneWithAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void currentAnimationTick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateSourceRect()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private new void animateOnce(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkForFootstep()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void animateBackwardsOnce(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setCurrentSingleAnimation(int which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void animate(int Milliseconds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void StopAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void getAnimationFromIndex(int index, FarmerSprite requester, int interval, int numberOfFrames, bool flip, bool secondaryArm)
	{
	}
}
