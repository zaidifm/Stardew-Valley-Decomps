using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Buildings;

namespace StardewValley.Menus;

public class BuildingPaintMenu : IClickableMenu
{
	public class RegionData
	{
		public string Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public string DisplayName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public int MinBrightness
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public int MaxBrightness
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RegionData(string id, string displayName, int minBrightness, int maxBrightness)
		{
		}
	}

	public class ColorSliderPanel
	{
		public BuildingPaintMenu buildingPaintMenu;

		public int regionIndex;

		public string regionId;

		public Rectangle rectangle;

		public Vector2 colorDrawPosition;

		public List<KeyValuePair<string, List<int>>> colors;

		public int selectedColor;

		public BuildingColorSlider hueSlider;

		public BuildingColorSlider saturationSlider;

		public BuildingColorSlider lightnessSlider;

		public int minimumBrightness;

		public int maximumBrightness;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ColorSliderPanel(BuildingPaintMenu menu, int region_index, string regionId, int min_brightness = -100, int max_brightness = 100)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual int GetHeight()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Rectangle Reposition(Rectangle start_rect)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ApplyColors()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetColorForValues(float hue_slider, float saturation_slider)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetColorForValues(float hue_slider, float saturation_slider, float lightness_slider)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool ApplyMovementKey(int direction)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PerformHoverAction(int x, int y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool ReceiveLeftClick(int x, int y, bool play_sound = true)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public class BuildingColorSlider
	{
		public ClickableTextureComponent handle;

		public BuildingPaintMenu buildingPaintMenu;

		public Rectangle bounds;

		protected float _sliderPosition;

		public int min;

		public int max;

		public Action<int> onValueSet;

		public Func<float, Color> getDrawColor;

		protected int _displayedValue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BuildingColorSlider(BuildingPaintMenu bpm, int handle_id, Rectangle bounds, int min, int max, Action<int> on_value_set = null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ApplyMovementKey(int direction)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ReceiveLeftClick(int x, int y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetValueFromPosition(int x, int y)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetValue(int value, bool skip_value_set = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetValue()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Draw(SpriteBatch b)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Update(int x, int y)
		{
		}
	}

	public const int region_colorButtons = 1000;

	public const int region_okButton = 101;

	public const int region_nextRegion = 102;

	public const int region_prevRegion = 103;

	public const int region_copyColor = 104;

	public const int region_defaultColor = 105;

	public const int region_hueSlider = 106;

	public const int region_saturationSlider = 107;

	public const int region_lightnessSlider = 108;

	public const int region_appearanceButton = 109;

	public static int WINDOW_WIDTH;

	public static int WINDOW_HEIGHT;

	public Rectangle previewPane;

	public Rectangle colorPane;

	public BuildingColorSlider activeSlider;

	public ClickableTextureComponent appearanceButton;

	public ClickableTextureComponent okButton;

	public static List<Vector3> savedColors;

	public List<Color> buttonColors;

	public ColorSliderPanel colorSliderPanel;

	private string hoverText;

	public Building building;

	public string buildingType;

	public BuildingPaintColor colorTarget;

	protected Dictionary<string, string> _paintData;

	public int currentPaintRegion;

	public List<RegionData> regions;

	public ClickableTextureComponent nextRegionButton;

	public ClickableTextureComponent previousRegionButton;

	public ClickableTextureComponent copyColorButton;

	public ClickableTextureComponent defaultColorButton;

	public List<ClickableTextureComponent> savedColorButtons;

	public List<ClickableComponent> sliderHandles;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuildingPaintMenu(Building target_building)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitializeSavedColors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void applyMovementKey(int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons button)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
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
	public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool SaveColor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetRegion(int new_region)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadRegionData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}
}
