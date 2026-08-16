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

	public readonly NetInt textureIndex = new NetInt().Interpolated(interpolate: false, wait: false);

	public Texture2D lightTexture;

	public readonly NetVector2 position = new NetVector2().Interpolated(interpolate: true, wait: true);

	public readonly NetColor color = new NetColor();

	public readonly NetFloat radius = new NetFloat();

	public readonly NetString netId = new NetString();

	public readonly NetEnum<LightContext> lightContext = new NetEnum<LightContext>();

	public readonly NetLong playerID = new NetLong(0L).Interpolated(interpolate: false, wait: false);

	public readonly NetInt fadeOut = new NetInt(-1);

	public readonly NetString onlyLocation = new NetString();

	public string Id
	{
		get
		{
			return netId.Value;
		}
		set
		{
			netId.Value = value;
		}
	}

	public long PlayerID
	{
		get
		{
			return playerID.Value;
		}
		set
		{
			playerID.Value = value;
		}
	}

	public NetFields NetFields { get; } = new NetFields("LightSource");

	public LightSource()
	{
		NetFields.SetOwner(this).AddField(textureIndex, "textureIndex").AddField(position, "position")
			.AddField(color, "color")
			.AddField(radius, "radius")
			.AddField(netId, "netId")
			.AddField(lightContext, "lightContext")
			.AddField(playerID, "playerID")
			.AddField(fadeOut, "fadeOut")
			.AddField(onlyLocation, "onlyLocation");
		textureIndex.fieldChangeEvent += delegate(NetInt field, int oldValue, int newValue)
		{
			loadTextureFromConstantValue(newValue);
		};
	}

	public LightSource(string id, int textureIndex, Vector2 position, float radius, Color color, LightContext lightContext = LightContext.None, long playerID = 0L, string onlyLocation = null)
		: this()
	{
		netId.Value = id;
		this.textureIndex.Value = textureIndex;
		this.position.Value = position;
		this.radius.Value = radius;
		this.color.Value = color;
		this.lightContext.Value = lightContext;
		this.playerID.Value = playerID;
		this.onlyLocation.Value = onlyLocation;
	}

	public LightSource(string id, int textureIndex, Vector2 position, float radius, LightContext lightContext = LightContext.None, long playerID = 0L, string onlyLocation = null)
		: this(id, textureIndex, position, radius, Color.Black, lightContext, playerID, onlyLocation)
	{
	}

	private void loadTextureFromConstantValue(int value)
	{
		switch (value)
		{
		case 1:
			lightTexture = Game1.lantern;
			break;
		case 2:
			lightTexture = Game1.windowLight;
			break;
		case 4:
			lightTexture = Game1.sconceLight;
			break;
		case 5:
			lightTexture = Game1.cauldronLight;
			break;
		case 6:
			lightTexture = Game1.indoorWindowLight;
			break;
		case 7:
			lightTexture = Game1.temporaryContent.Load<Texture2D>("LooseSprites\\Lighting\\projectorLight");
			break;
		case 8:
			lightTexture = Game1.content.Load<Texture2D>("LooseSprites\\Lighting\\fishTankLight");
			break;
		case 9:
			lightTexture = Game1.content.Load<Texture2D>("LooseSprites\\Lighting\\treeLights");
			break;
		case 10:
			lightTexture = Game1.content.Load<Texture2D>("LooseSprites\\Lighting\\pinpointLight");
			break;
		case 3:
			break;
		}
	}

	public bool IsOnScreen()
	{
		if (onlyLocation.Value != null && onlyLocation.Value != Game1.currentLocation?.NameOrUniqueName)
		{
			return false;
		}
		if (!Utility.isOnScreen(position.Value, (int)(radius.Value * 64f * 4f)))
		{
			return false;
		}
		if (PlayerID != 0L && PlayerID != Game1.player.UniqueMultiplayerID)
		{
			Farmer player = Game1.GetPlayer(PlayerID);
			if (player == null || player.hidden.Value || (player.currentLocation != null && player.currentLocation.Name != Game1.currentLocation?.Name))
			{
				return false;
			}
		}
		return true;
	}

	public virtual void Draw(SpriteBatch spriteBatch, GameLocation location, float lightMultiplier)
	{
		if (fadeOut.Value > 0)
		{
			if (color.Value.A <= 0)
			{
				return;
			}
			color.Value = new Color(color.R, color.G, color.B, color.A - fadeOut.Value);
		}
		if (lightContext.Value == LightContext.WindowLight && (Game1.IsRainingHere() || Game1.isTimeToTurnOffLighting(location)))
		{
			fadeOut.Value = 4;
		}
		if (IsOnScreen())
		{
			Texture2D texture2D = lightTexture;
			int lightingQuality = Game1.options.lightingQuality;
			spriteBatch.Draw(texture2D, Game1.GlobalToLocal(Game1.viewport, position.Value) / (lightingQuality / 2), texture2D.Bounds, color.Value * lightMultiplier, 0f, new Vector2(texture2D.Bounds.Width / 2, texture2D.Bounds.Height / 2), radius.Value / (float)(lightingQuality / 2), SpriteEffects.None, 0.9f);
		}
	}

	public LightSource Clone()
	{
		LightSource lightSource = new LightSource(Id, textureIndex.Value, position.Value, radius.Value, color.Value, lightContext.Value, playerID.Value);
		lightSource.onlyLocation.Value = onlyLocation.Value;
		return lightSource;
	}
}
