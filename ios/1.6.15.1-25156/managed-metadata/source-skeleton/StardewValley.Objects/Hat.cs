using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Enchantments;

namespace StardewValley.Objects;

public class Hat : Item
{
	public enum HairDrawType
	{
		DrawFullHair,
		DrawObscuredHair,
		HideHair
	}

	public const int widthOfTileSheetSquare = 20;

	public const int heightOfTileSheetSquare = 20;

	public const int data_index_internalName = 0;

	public const int data_index_description = 1;

	public const int data_index_showFullHair = 2;

	public const int data_index_ignoreHairOffset = 3;

	public const int data_index_tags = 4;

	public const int data_index_displayName = 5;

	public const int data_index_texture = 7;

	[XmlElement("which")]
	public int? obsolete_which;

	[XmlElement("skipHairDraw")]
	public bool skipHairDraw;

	[XmlElement("ignoreHairstyleOffset")]
	public readonly NetBool ignoreHairstyleOffset;

	[XmlElement("hairDrawType")]
	public readonly NetInt hairDrawType;

	[XmlElement("isPrismatic")]
	public readonly NetBool isPrismatic;

	[XmlIgnore]
	protected int _isMask;

	[XmlElement("enchantments")]
	public List<BaseEnchantment> enchantments;

	[XmlElement("previousEnchantments")]
	public List<string> previousEnchantments;

	[XmlIgnore]
	public string displayName;

	[XmlIgnore]
	public string description;

	public override string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public bool isMask
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[XmlIgnore]
	public override string DisplayName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void MigrateLegacyItemId()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Hat()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Hat(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void load(string id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void draw(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, int direction, bool useAnimalTexture = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int maximumStackSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool isPlaceable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool loadDisplayFields()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
