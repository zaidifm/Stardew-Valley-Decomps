using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;

namespace StardewValley.BellsAndWhistles;

public class PlayerStatusList : INetObject<NetFields>
{
	public enum SortMode
	{
		None,
		NumberSort,
		NumberSortDescending,
		AlphaSort,
		AlphaSortDescending
	}

	public enum DisplayMode
	{
		Text,
		LocalizedText,
		Icons
	}

	public enum VerticalAlignment
	{
		Top,
		Bottom
	}

	public enum HorizontalAlignment
	{
		Left,
		Right
	}

	protected readonly NetLongDictionary<string, NetString> _statusList;

	protected readonly Dictionary<long, string> _formattedStatusList;

	protected readonly Dictionary<string, Texture2D> _iconSprites;

	protected readonly List<Farmer> _sortedFarmers;

	public int iconAnimationFrames;

	public int largestSpriteWidth;

	public int largestSpriteHeight;

	public SortMode sortMode;

	public DisplayMode displayMode;

	protected Dictionary<string, KeyValuePair<string, Rectangle>> _iconDefinitions;

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PlayerStatusList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSpriteDefinition(string key, string file, int x, int y, int width, int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateState(string newState)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WithdrawState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _OnValueChanged()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _ResortList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetStatusText(long id, out string statusText)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetStatusText(long id, string fallback = "")
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetStatusInt(long id, int fallback = 0)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(SpriteBatch b, Vector2 draw_position, float draw_scale = 4f, float draw_layer = 0.45f, HorizontalAlignment horizontal_origin = HorizontalAlignment.Left, VerticalAlignment vertical_origin = VerticalAlignment.Top)
	{
	}
}
