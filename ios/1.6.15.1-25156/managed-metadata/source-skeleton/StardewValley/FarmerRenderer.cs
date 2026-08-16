using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley;

[InstanceStatics]
public class FarmerRenderer : INetObject<NetFields>
{
	public enum FarmerSpriteLayers
	{
		SlingshotUp,
		ToolUp,
		Base,
		Pants,
		FaceSkin,
		Eyes,
		Shirt,
		AccessoryUnderHair,
		ArmsUp,
		HatMaskUp,
		Hair,
		Accessory,
		Hat,
		Tool,
		Arms,
		ToolDown,
		Slingshot,
		PantsPassedOut,
		SwimWaterRing,
		MAX,
		TOOL_IN_USE_SIDE
	}

	public const int accessoriesTextureWidth = 128;

	public const int accessoriesTextureHeight = 96;

	public const int farmerTextureWidth = 384;

	public const int farmerTextureHeight = 672;

	public const int hairStylesTextureWidth = 128;

	public const int hairStylesTextureHeight = 384;

	public const int hatsTextureWidth = 240;

	public const int hatsTextureHeight = 320;

	public const int sleeveDarkestColorIndex = 256;

	public const int skinDarkestColorIndex = 260;

	public const int shoeDarkestColorIndex = 268;

	public const int eyeLightestColorIndex = 276;

	public const int accessoryDrawBelowHairThreshold = 8;

	public const int accessoryFacialHairThreshold = 6;

	protected bool _sickFrame;

	public static bool isDrawingForUI;

	public const int TransparentSkin = -12345;

	public const int pantsOffset = 288;

	public const int armOffset = 96;

	public const int shirtXOffset = 16;

	public const int shirtYOffset = 56;

	public static int[] featureYOffsetPerFrame;

	public static int[] featureXOffsetPerFrame;

	public static int[] hairstyleHatOffset;

	public static Texture2D hairStylesTexture;

	public static Texture2D shirtsTexture;

	public static Texture2D hatsTexture;

	public static Texture2D accessoriesTexture;

	public static Texture2D pantsTexture;

	internal static Dictionary<string, Dictionary<int, List<int>>> recolorOffsets;

	[XmlElement("textureName")]
	public readonly NetString textureName;

	[XmlIgnore]
	private LocalizedContentManager farmerTextureManager;

	[XmlIgnore]
	internal Texture2D baseTexture;

	[XmlElement("heightOffset")]
	public readonly NetInt heightOffset;

	[XmlIgnore]
	public readonly NetColor eyes;

	[XmlIgnore]
	public readonly NetInt skin;

	[XmlIgnore]
	public readonly NetString shoes;

	[XmlIgnore]
	public readonly NetString shirt;

	[XmlIgnore]
	public readonly NetString pants;

	protected bool _spriteDirty;

	protected bool _baseTextureDirty;

	protected bool _eyesDirty;

	protected bool _skinDirty;

	protected bool _shoesDirty;

	protected bool _shirtDirty;

	protected bool _pantsDirty;

	public Rectangle shirtSourceRect;

	public Rectangle hairstyleSourceRect;

	public Rectangle hatSourceRect;

	public Rectangle accessorySourceRect;

	public Vector2 rotationAdjustment;

	public Vector2 positionOffset;

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
	public FarmerRenderer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarmerRenderer(string textureName, Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isAccessoryFacialHair(int which)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool drawAccessoryBelowHair(int which)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void executeRecolorActions(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _GeneratePixelIndices(int source_color_index, string texture_name, Color[] pixels)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void unload()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void textureChanged()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void recolorEyes(Color lightestColor)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyEyeColor(string texture_name, Color[] pixels)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _SwapColor(string texture_name, Color[] pixels, int color_index, Color color)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void recolorShoes(string which)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplyShoeColor(string texture_name, Color[] pixels)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int recolorSkin(int which, bool force = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ApplySkinColor(string texture_name, Color[] pixels)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changeShirt(string whichShirt)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void changePants(string whichPants)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkSpriteDirty()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplySleeveColor(string texture_name, Color[] pixels, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Color changeBrightness(Color c, int brightness)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b, Farmer who, int whichFrame, Vector2 position, float layerDepth = 1f, bool flip = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b, FarmerSprite farmerSprite, Rectangle sourceRect, Vector2 position, Vector2 origin, float layerDepth, Color overrideColor, float rotation, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawMiniPortrat(SpriteBatch b, Vector2 position, float layerDepth, float scale, int facingDirection, Farmer who, float alpha = 1f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b, FarmerSprite.AnimationFrame animationFrame, int currentFrame, Rectangle sourceRect, Vector2 position, Vector2 origin, float layerDepth, Color overrideColor, float rotation, float scale, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void drawHairAndAccesories(SpriteBatch b, int facingDirection, Farmer who, Vector2 position, Vector2 origin, float scale, int currentFrame, float rotation, Color overrideColor, float layerDepth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetLayerDepth(float baseLayerDepth, FarmerSpriteLayers layer, bool dyeLayer = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch b, FarmerSprite.AnimationFrame animationFrame, int currentFrame, Rectangle sourceRect, Vector2 position, Vector2 origin, float layerDepth, int facingDirection, Color overrideColor, float rotation, float scale, Farmer who)
	{
	}
}
