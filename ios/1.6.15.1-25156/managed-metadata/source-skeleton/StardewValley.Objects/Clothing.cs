using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Objects;

public class Clothing : Item
{
	public enum ClothesType
	{
		SHIRT,
		PANTS
	}

	public const int SHIRT_SHEET_WIDTH = 128;

	public const string DefaultShirtSheetName = "Characters\\Farmer\\shirts";

	public const string DefaultPantsSheetName = "Characters\\Farmer\\pants";

	public const int MinShirtId = 1000;

	[XmlElement("price")]
	public readonly NetInt price;

	[XmlElement("indexInTileSheet")]
	public readonly NetInt indexInTileSheet;

	[XmlElement("indexInTileSheetFemale")]
	public int? obsolete_indexInTileSheetFemale;

	[XmlIgnore]
	public string description;

	[XmlIgnore]
	public string displayName;

	[XmlElement("clothesType")]
	public readonly NetEnum<ClothesType> clothesType;

	[XmlElement("dyeable")]
	public readonly NetBool dyeable;

	[XmlElement("clothesColor")]
	public readonly NetColor clothesColor;

	[XmlElement("isPrismatic")]
	public readonly NetBool isPrismatic;

	[XmlIgnore]
	protected bool _loadedData;

	public override string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int Price
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
	public Clothing()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Clothing(string itemId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadData(bool applyColor = false, bool forceReload = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getCategoryName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int salePrice(bool ignoreProfitMargins = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dye(Color color, float strength = 0.5f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int maximumStackSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getDescription()
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
	protected override void GetOneCopyFrom(Item source)
	{
	}
}
