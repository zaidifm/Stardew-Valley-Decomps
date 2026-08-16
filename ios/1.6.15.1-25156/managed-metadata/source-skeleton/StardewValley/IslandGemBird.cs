using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley;

public class IslandGemBird : INetObject<NetFields>
{
	public enum GemBirdType
	{
		Emerald,
		Aquamarine,
		Ruby,
		Amethyst,
		Topaz,
		MAX
	}

	[XmlIgnore]
	public Texture2D texture;

	[XmlElement("position")]
	public NetVector2 position;

	[XmlIgnore]
	protected float _destroyTimer;

	[XmlElement("height")]
	public NetFloat height;

	[XmlIgnore]
	public int[] idleAnimation;

	[XmlIgnore]
	public int[] lookBackAnimation;

	[XmlIgnore]
	public int[] scratchAnimation;

	[XmlIgnore]
	public int[] flyAnimation;

	[XmlIgnore]
	public int[] currentAnimation;

	[XmlIgnore]
	public float frameTimer;

	[XmlIgnore]
	public int currentFrameIndex;

	[XmlIgnore]
	public float idleAnimationTime;

	[XmlElement("alpha")]
	public NetFloat alpha;

	[XmlElement("flying")]
	public NetBool flying;

	[XmlElement("color")]
	public NetColor color;

	[XmlElement("itemIndex")]
	public NetString itemIndex;

	[XmlIgnore]
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
	public IslandGemBird()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IslandGemBird(Vector2 tile_position, GemBirdType bird_type)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color GetColor(GemBirdType bird_type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetItemIndex(GemBirdType bird_type)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GemBirdType GetBirdTypeForLocation(string location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Update(GameTime time, GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
