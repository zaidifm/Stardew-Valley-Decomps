using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using Netcode.Validation;

namespace StardewValley;

[NotImplicitNetField]
public class LightSource : INetObject<NetFields>
{
	public enum LightContext
	{
		None,
		MapLight,
		WindowLight
	}

	public const int lantern = 1;

	public const int windowLight = 2;

	public const int sconceLight = 4;

	public const int cauldronLight = 5;

	public const int indoorWindowLight = 6;

	public const int projectorLight = 7;

	public const int fishTankLight = 8;

	public const int townWinterTreeLight = 9;

	public const int pinpointLight = 10;

	public readonly NetInt textureIndex;

	public Texture2D lightTexture;

	public readonly NetVector2 position;

	public readonly NetColor color;

	public readonly NetFloat radius;

	public readonly NetString netId;

	public readonly NetEnum<LightContext> lightContext;

	public readonly NetLong playerID;

	public readonly NetInt fadeOut;

	public readonly NetString onlyLocation;

	public string Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public long PlayerID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

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
	public LightSource()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightSource(string id, int textureIndex, Vector2 position, float radius, Color color, LightContext lightContext = LightContext.None, long playerID = 0L, string onlyLocation = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightSource(string id, int textureIndex, Vector2 position, float radius, LightContext lightContext = LightContext.None, long playerID = 0L, string onlyLocation = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void loadTextureFromConstantValue(int value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOnScreen()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch spriteBatch, GameLocation location, float lightMultiplier)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightSource Clone()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
