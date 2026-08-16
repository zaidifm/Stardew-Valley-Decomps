using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Buildings;
using StardewValley.GameData.Buildings;

namespace StardewValley.Menus;

public class BuildingSkinMenu : IClickableMenu
{
	public class SkinEntry
	{
		public int Index;

		public readonly string Id;

		public readonly string DisplayName;

		public readonly string Description;

		public readonly BuildingSkin Data;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SkinEntry(int index, BuildingSkin skin)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SkinEntry(int index, BuildingSkin skin, string displayName, string description)
		{
		}
	}

	public const int region_okButton = 101;

	public const int region_nextSkin = 102;

	public const int region_prevSkin = 103;

	public static int WindowWidth;

	public static int WindowHeight;

	public Rectangle PreviewPane;

	public ClickableTextureComponent OkButton;

	public Building Building;

	public ClickableTextureComponent NextSkinButton;

	public ClickableTextureComponent PreviousSkinButton;

	public string BuildingDisplayName;

	public string BuildingDescription;

	public List<SkinEntry> Skins;

	public SkinEntry Skin;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuildingSkinMenu(Building targetBuilding, bool ignoreSeparateConstructionEntries = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons button)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSkin(int index)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSkin(SkinEntry skin)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RepositionElements()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool SaveColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetRegion(int newRegion)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
