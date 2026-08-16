using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class ParrotPlatform
{
	public enum TakeoffState
	{
		Idle,
		Boarding,
		BeginFlying,
		Liftoff,
		Flying,
		Finished
	}

	public class Parrot
	{
		public Vector2 position;

		public Vector2 anchorPosition;

		public Texture2D texture;

		protected ParrotPlatform _platform;

		protected bool facingRight;

		protected bool facingUp;

		public const int START_HEIGHT = 21;

		public const int END_HEIGHT = 64;

		public float height;

		public bool flapping;

		public float nextFlap;

		public float slack;

		public Vector2[] points;

		public float swayOffset;

		public float liftSpeed;

		public float squawkTime;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Parrot(ParrotPlatform platform, int x, int y, bool facing_right, bool facing_up)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateLine(Vector2 start, Vector2 end)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Update(GameTime time)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Draw(SpriteBatch b)
		{
		}
	}

	[InstancedStatic]
	[XmlIgnore]
	public static ParrotPlatform activePlatform;

	[XmlIgnore]
	public Vector2 position;

	[XmlIgnore]
	public Texture2D texture;

	[XmlIgnore]
	public List<Parrot> parrots;

	[XmlIgnore]
	public float height;

	[XmlIgnore]
	protected Event _takeoffEvent;

	[XmlIgnore]
	public TakeoffState takeoffState;

	[XmlIgnore]
	public float stateTimer;

	[XmlIgnore]
	public float liftSpeed;

	[XmlIgnore]
	protected bool _onActivationTile;

	public Vector2 shake;

	public string currentLocationKey;

	public KeyValuePair<string, KeyValuePair<string, Point>> currentDestination;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<KeyValuePair<string, KeyValuePair<string, Point>>> GetDestinations(bool only_show_accessible = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<ParrotPlatform> CreateParrotPlatformsForArea(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParrotPlatform()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParrotPlatform(int tile_x, int tile_y, string key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartDeparture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Activate()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool AnswerQuestion(Response answer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Cleanup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CheckCollisions(Rectangle rectangle)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OccupiesTile(Vector2 tile_pos)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector2 GetDrawPosition()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch b)
	{
	}
}
