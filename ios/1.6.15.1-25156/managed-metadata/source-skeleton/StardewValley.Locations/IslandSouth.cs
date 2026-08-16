using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class IslandSouth : IslandLocation
{
	public class IslandActivityAssigments
	{
		public int activityTime;

		public List<NPC> visitors;

		public Dictionary<Character, string> currentAssignments;

		public Dictionary<Character, string> currentAnimationAssignments;

		public Random random;

		public Dictionary<string, string> animationDescriptions;

		public List<Point> shoreLoungePoints;

		public List<Point> chairPoints;

		public List<Point> umbrellaPoints;

		public List<Point> towelLoungePoints;

		public List<Point> drinkPoints;

		public List<Point> wanderPoints;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IslandActivityAssigments(int time, List<NPC> visitors, Random seeded_random, Dictionary<Character, string> last_activity_assignments)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void FindActivityForCharacters(Dictionary<Character, string> last_activity_assignments)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryAssignment(Character character, List<Point> points, string dialogue_key, string animation_name = null, bool animation_required = false, double chance = 1.0, Dictionary<Character, string> last_activity_assignments = null)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetRandomDialogueKey(string dialogue_key, Random random)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetScheduleStringForCharacter(NPC character)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	protected int _boatDirection;

	[XmlIgnore]
	public Texture2D boatTexture;

	[XmlIgnore]
	public Vector2 boatPosition;

	[XmlIgnore]
	protected int _boatOffset;

	[XmlIgnore]
	protected float _nextBubble;

	[XmlIgnore]
	protected float _nextSlosh;

	[XmlIgnore]
	protected float _nextSmoke;

	[XmlIgnore]
	public LightSource boatLight;

	[XmlIgnore]
	public LightSource boatStringLight;

	[XmlElement("shouldToggleResort")]
	public readonly NetBool shouldToggleResort;

	[XmlElement("resortOpenToday")]
	public readonly NetBool resortOpenToday;

	[XmlElement("resortRestored")]
	public readonly NetBool resortRestored;

	[XmlElement("westernTurtleMoved")]
	public readonly NetBool westernTurtleMoved;

	[XmlIgnore]
	protected bool _parrotBoyHiding;

	[XmlIgnore]
	protected bool _isFirstVisit;

	[XmlIgnore]
	protected bool _exitsBlocked;

	[XmlIgnore]
	protected bool _sawFlameSprite;

	[XmlIgnore]
	public NetEvent0 moveTurtleEvent;

	private Microsoft.Xna.Framework.Rectangle turtle1Spot;

	private Microsoft.Xna.Framework.Rectangle turtle2Spot;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandSouth()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandSouth(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void TransferDataFromSavedLocation(GameLocation l)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyResortRestore()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyWesternTurtleMove()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void parrotBoyLands(int extra)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isCollidingPosition(Microsoft.Xna.Framework.Rectangle position, xTile.Dimensions.Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isTilePlaceable(Vector2 tileLocation, bool itemIsPassable = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void MakeMapModifications(bool force = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanVisitIslandToday(NPC npc)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTouchAction(string[] action, Vector2 playerStandingPosition)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Depart()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Point GetDressingRoomPoint(NPC character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool HasLocationOverrideDialogue(NPC character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetLocationOverrideDialogue(NPC character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasIslandAttire(NPC character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetupIslandSchedules()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetBoat()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetBoatPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool RunLocationSpecificEventCommand(Event current_event, string command_string, bool first_run, params string[] args)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
