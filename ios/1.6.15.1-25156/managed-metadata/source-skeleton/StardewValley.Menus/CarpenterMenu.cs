using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using StardewValley.Buildings;
using StardewValley.GameData.Buildings;

namespace StardewValley.Menus;

public class CarpenterMenu : IClickableMenu
{
	private enum BottomButton
	{
		None,
		Move,
		BuildOrUpgrade,
		Demolish,
		Paint
	}

	public class BlueprintEntry
	{
		public int Index
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public string Id
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public BuildingData Data
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public BuildingSkin Skin
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
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
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Description
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			private set
			{
			}
		}

		public int TilesWide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public int TilesHigh
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[CompilerGenerated]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public bool IsUpgrade
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public int BuildDays
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public int BuildCost
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public List<BuildingMaterial> BuildMaterials
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public string UpgradeFrom
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		public bool MagicalConstruction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BlueprintEntry(int index, string id, BuildingData data, string skinId)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSkin(string id)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetDisplayNameForBuildingToUpgrade()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public const int region_backButton = 101;

	public const int region_forwardButton = 102;

	public const int region_upgradeIcon = 103;

	public const int region_demolishButton = 104;

	public const int region_moveBuitton = 105;

	public const int region_okButton = 106;

	public const int region_cancelButton = 107;

	public const int region_paintButton = 108;

	public const int region_appearanceButton = 109;

	public int maxWidthOfBuildingViewer;

	public int maxHeightOfBuildingViewer;

	public int maxWidthOfDescription;

	public readonly string Builder;

	public GameLocation TargetLocation;

	private List<BlueprintEntry> blueprints;

	private int currentBlueprintIndex;

	public ClickableComponent moveButton;

	public ClickableComponent buildButton;

	public ClickableComponent demolishButton;

	public ClickableComponent paintButton;

	public ClickableTextureComponent okButton;

	public ClickableTextureComponent cancelButton;

	public ClickableTextureComponent backButton;

	public ClickableTextureComponent forwardButton;

	public ClickableTextureComponent upgradeIcon;

	public ClickableTextureComponent appearanceButton;

	private bool okButtonHeld;

	private bool cancelButtonHeld;

	private bool hoveringFarmHouse;

	private Building currentBuilding;

	private Building buildingToMove;

	private string buildingDescription;

	private string buildingName;

	private List<Item> ingredients;

	private int price;

	private bool onFarm;

	private bool drawBG;

	private bool freeze;

	private bool upgrading;

	private bool demolishing;

	private bool moving;

	private bool magicalConstruction;

	private bool painting;

	protected BlueprintEntry _demolishCheckBlueprint;

	private bool canPlace;

	private RasterizerState _rasterizerState;

	private Rectangle scissorRectangleForBuildingImage;

	private float widthMod;

	private float heightMod;

	private int buildingBoxX;

	private int buildingBoxY;

	private int buildingBoxWidth;

	private int buildingBoxHeight;

	private int scrollBoxX;

	private int scrollBoxY;

	private int scrollBoxWidth;

	private int messageBoxX;

	private int messageBoxY;

	private int messageBoxWidth;

	private int messageBoxHeight;

	private int messageXText;

	private int messageYText;

	private int ingredientsYText;

	private int buttonX;

	private int buttonY;

	private int buttonWidth;

	private int buttonHeight;

	private int button2X;

	private int button3X;

	private int button4X;

	private string moveButtonText;

	private string buildButtonText;

	private string demolishButtonText;

	private string upgradeButtonText;

	private string paintButtonText;

	private bool demolishButtonHeld;

	private bool buildButtonHeld;

	private bool moveButtonHeld;

	private bool paintButtonHeld;

	private int _drawAtX;

	private int _drawAtY;

	private int _lastTapX;

	private int _lastTapY;

	private Building _selectedBuilding;

	private bool _onBottomButtons;

	private BottomButton _selectedBottomButton;

	private string hoverText;

	public bool readOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public BlueprintEntry CurrentBlueprint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CarpenterMenu(string builder, GameLocation targetLocation = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldClampGamePadCursor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void snapToDefaultClickableComponent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void resetBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateAppearanceButtonVisibility()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setNewActiveBlueprint()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performHoverAction(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasPermissionsToDemolish(Building b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanPaintHouse()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasPermissionsToPaint(Building b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool hasPermissionsToMove(Building b)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveGamePadButton(Buttons b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveLeftClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnClickOK()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool tryToBuild()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void returnToCarpentryMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void returnToCarpentryMenuAfterSuccessfulBuild()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void robinConstructionMessage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool overrideSnappyMenuCursorMovementBan()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void setUpForBuildingPlacement()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsValidBuildingForLocation(string typeId, BuildingData data, GameLocation targetLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanDemolishThis()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanDemolishThis(Building building)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCancelButtonBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetOKButtonBounds()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTapButtonLeftArrow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTapButtonRightArrow()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void releaseLeftClick(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawPlacementSquares(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnReleasePaintButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnReleaseDemolishButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnReleaseMoveButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnReleaseBuildButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnReleaseCancelButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnReleaseOKButton()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetButtonHeldStates()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TestToPan(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void leftClickHeld(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void cleanupBeforeExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveRightClick(int x, int y, bool playSound = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConsumeResources()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DoesFarmerHaveEnoughResourcesToBuild()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
