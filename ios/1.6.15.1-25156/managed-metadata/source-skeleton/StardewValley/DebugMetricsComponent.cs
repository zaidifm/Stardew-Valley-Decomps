using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Network;

namespace StardewValley;

public class DebugMetricsComponent : DrawableGameComponent
{
	private readonly Game _game;

	private SpriteFont _font;

	private SpriteBatch _spriteBatch;

	private int _drawX;

	private int _drawY;

	private double _fps;

	private double _mspf;

	private int _lastCollection;

	private float _lastBaseMB;

	private bool _runningSlowly;

	private StringBuilder _stringBuilder;

	private Texture2D _opaqueWhite;

	public int XOffset;

	public int YOffset;

	private IBandwidthMonitor bandwidthMonitor;

	private BarGraph bandwidthUpGraph;

	private BarGraph bandwidthDownGraph;

	public SpriteFont Font
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DebugMetricsComponent(Game game)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LoadContent()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Update(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Draw(GameTime gameTime)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DrawLine(Color color, StringBuilder sb, int x)
	{
	}
}
