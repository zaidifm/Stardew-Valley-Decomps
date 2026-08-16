using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.Objects;

public class TV : Furniture
{
	public const int customChannel = 1;

	public const int weatherChannel = 2;

	public const int fortuneTellerChannel = 3;

	public const int tipsChannel = 4;

	public const int cookingChannel = 5;

	public const int fishingChannel = 6;

	private int currentChannel;

	private TemporaryAnimatedSprite screen;

	private TemporaryAnimatedSprite screenOverlay;

	internal static Dictionary<int, string> weekToRecipeMap;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TV()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TV(string itemId, Vector2 tile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void selectChannel(Farmer who, string answer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string getFortuneTellerOpening()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string getWeatherChannelOpening()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float getScreenSizeModifier()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 getScreenPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void proceedToNextScene()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void turnOffTV()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void setWeatherOverlay(bool island = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void setWeatherOverlay(string weatherId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] getFishingInfo()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string getSanitizedFishingLocation(string rawLocationName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string getTodaysTip()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected int getRerunWeek()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string[] getWeeklyRecipe()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string[] getWeeklyRecipe(Dictionary<string, string> channelData, string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string getIslandWeatherForecast()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string getWeatherForecast()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual string getWeatherForecast(string weatherId)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void setFortuneOverlay(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getFortuneForecast(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
	{
	}
}
