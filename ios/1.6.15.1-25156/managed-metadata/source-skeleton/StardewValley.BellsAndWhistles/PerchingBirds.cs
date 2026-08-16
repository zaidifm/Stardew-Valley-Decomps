using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValley.BellsAndWhistles;

public class PerchingBirds
{
	public const int BIRD_STARTLE_DISTANCE = 200;

	[XmlIgnore]
	public List<Bird> _birds;

	[XmlIgnore]
	protected Point[] _birdLocations;

	protected Point[] _birdRoostLocations;

	[XmlIgnore]
	public Dictionary<Point, Bird> _birdPointOccupancy;

	public bool roosting;

	protected Texture2D _birdSheet;

	protected int _birdWidth;

	protected int _birdHeight;

	protected int _flapFrames;

	protected Vector2 _birdOrigin;

	public int peckDuration;

	public float birdSpeed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PerchingBirds(Texture2D bird_texture, int flap_frames, int width, int height, Vector2 origin, Point[] perch_locations, Point[] roost_locations)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBirdWidth()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBirdHeight()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetBirdOrigin()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Texture2D GetTexture()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point GetFreeBirdPoint(Bird bird = null, int clearance = 200)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReserveBirdPoint(Bird bird, Point point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShouldBirdsRoost()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Point[] GetCurrentBirdLocationList()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddBird(int bird_type)
	{
	}
}
