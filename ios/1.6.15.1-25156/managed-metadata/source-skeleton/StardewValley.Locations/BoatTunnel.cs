using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class BoatTunnel : GameLocation
{
	public enum TunnelAnimationState
	{
		Idle,
		MoveWillyToGate,
		OpenGate,
		MoveWillyToCockpit,
		MoveFarmer,
		MovePlank,
		CloseGate,
		MoveBoat
	}

	private Texture2D boatTexture;

	private Vector2 boatPosition;

	public Microsoft.Xna.Framework.Rectangle gateRect;

	protected int _gateFrame;

	protected int _gateDirection;

	protected float _gateFrameTimer;

	public const float GATE_SECONDS_PER_FRAME = 0.1f;

	public const int GATE_FRAMES = 5;

	protected int _boatOffset;

	protected int _boatDirection;

	public const int PLANK_MAX_OFFSET = 16;

	public float _plankPosition;

	public float _plankDirection;

	protected Farmer _farmerActor;

	protected Event _boatEvent;

	protected bool _playerPathing;

	protected int nonBlockingPause;

	protected float _nextBubble;

	protected float _nextSlosh;

	protected float _nextSmoke;

	protected float _plankShake;

	protected int forceWarpTimer;

	protected bool _boatAnimating;

	public TunnelAnimationState animationState;

	public int TicketPrice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BoatTunnel()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BoatTunnel(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool GateFinishedAnimating()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool PlankFinishedAnimating()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetCurrentState(TunnelAnimationState animation_state)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateGateTileProperty()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isActionableTile(int xTile, int yTile, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool answerDialogue(Response answer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void checkForBoatComplete()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool shouldShadowBeDrawnAboveBuildingsLayer(Vector2 p)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartDeparture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBoatEventEnd()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool RunLocationSpecificEventCommand(Event current_event, string command_string, bool first_run, params string[] args)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnReachedBoatDeck(Character character, GameLocation location)
	{
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
}
