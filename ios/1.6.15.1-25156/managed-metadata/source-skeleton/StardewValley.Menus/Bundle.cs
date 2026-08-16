using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Menus;

public class Bundle : ClickableComponent
{
	public const int NameIndex = 0;

	public const int RewardIndex = 1;

	public const int IngredientsIndex = 2;

	public const int ColorIndex = 3;

	public const int NumberOfSlotsIndex = 4;

	public const int SpriteIndex = 5;

	public const int DisplayNameIndex = 6;

	public const int FieldCount = 7;

	public const float shakeRate = (float)Math.PI / 200f;

	public const float shakeDecayRate = 0.0030679617f;

	public const int Color_Green = 0;

	public const int Color_Purple = 1;

	public const int Color_Orange = 2;

	public const int Color_Yellow = 3;

	public const int Color_Red = 4;

	public const int Color_Blue = 5;

	public const int Color_Teal = 6;

	public const float DefaultShakeForce = (float)Math.PI * 3f / 128f;

	public string rewardDescription;

	public List<BundleIngredientDescription> ingredients;

	public int bundleColor;

	public int numberOfIngredientSlots;

	public int bundleIndex;

	public int completionTimer;

	public bool complete;

	public bool depositsAllowed;

	public Texture2D bundleTextureOverride;

	public int bundleTextureIndexOverride;

	public TemporaryAnimatedSprite sprite;

	private float maxShake;

	private bool shakeLeft;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bundle(string name, string displayName, List<BundleIngredientDescription> ingredients, bool[] completedIngredientsList, string rewardListString = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bundle(int bundleIndex, string rawBundleInfo, bool[] completedIngredientsList, Point position, string textureName, JunimoNoteMenu menu)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item getReward()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void shake(float force = (float)Math.PI * 3f / 128f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void shake(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void shakeAndAllowClicking(int extraInfo)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void tryHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsValidItemForThisIngredientDescription(Item item, BundleIngredientDescription ingredient)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBundleIngredientDescriptionIndexForItem(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canAcceptThisItem(Item item, ClickableTextureComponent slot)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canAcceptThisItem(Item item, ClickableTextureComponent slot, bool ignore_stack_count = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item tryToDepositThisItem(Item item, ClickableTextureComponent slot, string noteTextureName, JunimoNoteMenu parentMenu)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool couldThisItemBeDeposited(Item item)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ingredientDepositAnimation(ClickableTextureComponent slot, string noteTextureName, bool skipAnimation = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool canBeClicked()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void completionAnimation(JunimoNoteMenu menu, bool playSound = true, int delay = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void completionAnimation(bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color getColorFromColorIndex(int color)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
