using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Projectiles;

namespace StardewValley.Tools;

public class Slingshot : Tool
{
	public const int basicDamage = 5;

	public const string basicSlingshotId = "32";

	public const string masterSlingshotId = "33";

	public const string galaxySlingshotId = "34";

	public const int drawBackSoundThreshold = 8;

	[XmlIgnore]
	public int lastClickX;

	[XmlIgnore]
	public int lastClickY;

	[XmlIgnore]
	public int mouseDragAmount;

	[XmlIgnore]
	public double pullStartTime;

	[XmlIgnore]
	public float nextAutoFire;

	[XmlIgnore]
	public bool canPlaySound;

	[XmlIgnore]
	private readonly NetEvent0 finishEvent;

	[XmlIgnore]
	public readonly NetPoint aimPos;

	public override string TypeDefinitionId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Slingshot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void MigrateLegacyItemId()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Item GetOneNew()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string loadDisplayName()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override string loadDescription()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool doesShowTileLocationMarker()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Slingshot(string itemId = "32")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBackArmDistance(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PerformFire(GameLocation location, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetAmmoDamage(Object ammunition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetAmmoCollisionSound(Object ammunition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual BasicProjectile.onCollisionBehavior GetAmmoCollisionBehavior(Object ammunition)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetShootOrigin(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 AdjustForHeight(Vector2 position, bool for_cursor = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void finish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void doFinish()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool canThisBeAttached(Object o, int slot)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string getHoverBoxText(Item hoveredItem)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool onRelease(GameLocation location, int x, int y, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool beginUsing(GameLocation location, int x, int y, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual float GetAutoFireRate()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanAutoFire()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void updateAimPos()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void tickUpdate(GameTime time, Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void GetAttachmentSlotSprite(int slot, out Texture2D texture, out Rectangle sourceRect)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetSlingshotChargeTime()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetRequiredChargeTime()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
	{
	}
}
