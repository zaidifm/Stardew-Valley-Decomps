using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StardewValley.Mobile;

internal class MobileDisplay
{
	private struct MobileMetrics
	{
		public readonly MobileDeviceType Type;

		public readonly string Model;

		public readonly int PixelWidth;

		public readonly int PixelHeight;

		public readonly int Ppi;

		public readonly int PixelInset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MobileMetrics(MobileDeviceType type, string model, int pixelWidth, int pixelHeight, int ppi, int pixelInset = 0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEqual(int pixelWidth, int pixelHeight)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsModel(string model)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private static readonly MobileDevice DisplayEmulation;

	private static readonly Dictionary<MobileDevice, MobileMetrics> Metrics;

	private const float MIN_TILE_HEIGHT_IN_INCHES = 0.225f;

	private const float OPTIMAL_TILE_HEIGHT_IN_INCHES = 0.3f;

	private const float MIN_VISIBLE_ROWS = 10f;

	private const float MIN_ZOOM_SCALE = 0.5f;

	private const float MAX_ZOOM_SCALE = 5f;

	private const float OPTIMAL_BUTTON_HEIGHT_IN_INCHES = 0.225f;

	public static string currentModel;

	public static float ZoomScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public static float MenuButtonScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public static int ScreenWidthPixels
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public static int ScreenHeightPixels
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool IsiPhoneX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public static float DesktopScale
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		private set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static MobileDisplay()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetupDisplaySettings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SetDisplaySettings(MobileDevice device)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void PrintInfo(MobileDevice? device, int pixelWidth, int pixelHeight, int ppi)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CalculateZoomAndMenuScale(int width, int height, int dpi)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void EnsureLandscapeMode(ref int width, ref int height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Android_SetDisplaySettings(int width, int height, int ppi, int inset)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static int iOS_LookupPpi(string model)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsDevice(string model, params MobileDevice[] devices)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void iOS_SetDisplaySettings(string model, int pixelWidth, int pixelHeight, int? ppi)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MobileDisplay()
	{
	}
}
