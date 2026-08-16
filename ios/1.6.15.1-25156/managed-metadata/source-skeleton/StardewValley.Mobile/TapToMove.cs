using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using StardewValley.Buildings;
using StardewValley.Characters;
using StardewValley.Monsters;
using StardewValley.Objects;
using StardewValley.TerrainFeatures;
using StardewValley.Tools;

namespace StardewValley.Mobile;

public class TapToMove
{
	private struct SelectedToolState
	{
		public int Index;

		public bool Stowed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SelectedToolState(int index, bool stowed)
		{
		}
	}

	private const int MAX_TRIES = 2;

	private const float MIN_DISTANCE = 8f;

	private const int MAX_STUCK_COUNT = 4;

	private const int MAX_REALLY_STUCK_COUNT = 2;

	private const float MIN_MONSTER_RANGE = 96f;

	private const int TICKS_BEFORE_TAP_HOLD_KICKS_IN = 3500000;

	private const int TICKS_BEFORE_REENABLING_MONSTER_CHECK = 5000000;

	private const bool loggingEnabled = true;

	private List<int> _actionableObjectIDs;

	public MobileKeyStates mobileKeyStates;

	public int mouseCursor;

	public Vector2 nodeCenter;

	public Vector2 noPathHere;

	public bool preventMountingHorse;

	private bool _endNodeToBeActioned;

	private bool _endTileIsActionable;

	private bool _justUsedWeapon;

	private bool _performActionFromNeighbourTile;

	private bool _warping;

	private bool _enableCheckToAttackMonsters;

	private bool _pendingFurnitureAction;

	private Horse _tappedOnHorse;

	private bool _waterSourceAndFishingRodSelected;

	private bool _tappedOnCrop;

	private bool _tapHoldActive;

	private bool _tapPressed;

	private bool _justClosedActiveMenu;

	private bool _waitingToFinishWatering;

	private bool _tappedCinemaTicketBooth;

	private bool _tappedCinemaDoor;

	private bool _wasJustTouchingVirtualJoystick;

	private bool _tappedHaleyBracelet;

	private AStarGraph _aStarGraph;

	private AStarPath _aStarPath;

	private AStarNode _startNode;

	private AStarNode _nodeClicked;

	private AStarNode _endNodeOccupied;

	private AStarNode _farmerNode;

	private AStarNode _finalNode;

	private AStarNode _gateNode;

	private Fence _gateClickedOn;

	private Vector2 _clickPoint;

	private Vector2 _tileClicked;

	private float _lastDistance;

	private int _stuckCount;

	private int _reallyStuckCount;

	private Monster _monsterTarget;

	private TapToMovePhase _phase;

	private int _mouseX;

	private int _mouseY;

	private int _viewportX;

	private int _viewportY;

	private int _tryCount;

	private NPC _targetNPC;

	private FarmAnimal _targetFarmAnimal;

	private ResourceClump _forestLog;

	private GameLocation gameLocation;

	private DistanceToTarget _distanceToTarget;

	public static long startTime;

	private long _monsterCheckStartTime;

	private WalkDirection _walkDirectionFarmerToFinger;

	private Furniture _furniture;

	private Furniture _rotatingFurniture;

	private CrabPot _crabPot;

	private Object _forageItem;

	private Building _actionableBuilding;

	private bool _preSlingshotJoypadMode;

	private List<TapQueueItem> _tapQueueItemList;

	private bool _buttonAPressed;

	private int _nextDirection;

	private WalkDirection _nextWalkDirection;

	private List<SelectedToolState> _lastToolIndexList;

	private string _toolToSelect;

	public static MeleeWeapon mostRecentlyChosenMeleeWeapon;

	private Object recentlyOpenedGate;

	public Vector2 grabTile;

	public Furniture furniture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public AStarGraph aStarGraph
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector2 tapLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector2 viewportLocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool Moving
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool TapHoldActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector2 ClickPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Vector2 TileClicked
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public NPC targetNPC
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public FarmAnimal targetFarmAnimal
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool Warping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isTapToMoveWeaponControl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TapToMove(GameLocation gameLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(GameLocation gameLocation)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LogIt(string s)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void test()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset(bool resetMobileKeyStates = true)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetRotatingFurniture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void JoystickOverride()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCloseActiveMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTapHeld(int mouseX, int mouseY, int viewportX, int viewportY)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTapRelease(int mouseX = 0, int mouseY = 0, int viewportX = 0, int viewportY = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoLeftClick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoRightClick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveJoystickHeld(float angle)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopMoving()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnButtonAHeld(float angle)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnButtonARelease()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AddToTapQueueItemList(int mouseX, int mouseY, int viewportX, int viewportY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnTap(int mouseX, int mouseY, int viewportX, int viewportY, int tryCount = 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TileOnMap(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckToEatFood(int clickPointX, int clickPointY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckToDoDefenseAction(int clickPointX, int clickPointY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TappedOnFarmer(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool holdingWallpaperAndTileClickedIsWallOrFloor()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SelectDifferentEndNode(int x, int y)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TappedOnAnotherQueableCrop(int clickPointX, int clickPointY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool TappedOnHoeDirtAndHoldingSeed(int clickPointX, int clickPointY)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMouseCursor(AStarNode endNode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool EndNodeBlocked(AStarNode endNode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AutoSelectTool(string toolName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AutoSelectPendingTool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SwitchBackToLastTool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MeleeWeapon chooseActiveWeapon()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearAutoSelectTool()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void TryTofindAlternatePath(AStarNode startNode)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool FindAlternatePath(AStarNode start, int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void attackInNewDirectionUpdate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckToRetargetNPC()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckToRetargetFarmAnimal()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckToAttackMonsters()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool IsObjectBlockingMonster(Monster monster)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FollowAStarPathToNextNode()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckToOpenClosedGate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveOnFinalTile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnReachEndOfPath()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StopMovingAfterReachingEndOfPath()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTapToMoveComplete()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckForQueuedReadyToHarvestTaps()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckToWaterNextTile()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void faceTileClicked(bool faceClickPoint = false, int tileClickedX = -1000, int tileClickedY = -1000)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void faceClickPoint()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool WateringCanActionAtEndNode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool PerformCrabPotAction()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool PerformAction()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
