using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StardewValley;

public class StartupPreferences
{
	public const int windowed_borderless = 0;

	public const int windowed = 1;

	public const int fullscreen = 2;

	private static readonly string _filename;

	public static XmlSerializer serializer;

	public bool startMuted;

	public bool levelTenFishing;

	public bool levelTenMining;

	public bool levelTenForaging;

	public bool levelTenCombat;

	public bool skipWindowPreparation;

	public bool sawAdvancedCharacterCreationIndicator;

	public int timesPlayed;

	public int windowMode;

	public int displayIndex;

	public Options.GamepadModes gamepadMode;

	public int playerLimit;

	public int fullscreenResolutionX;

	public int fullscreenResolutionY;

	public string lastEnteredIP;

	public float safeRegionSize;

	public string languageCode;

	public Options clientOptions;

	[XmlIgnore]
	public bool isLoaded;

	private bool _isBusy;

	private bool _pendingApplyLanguage;

	private Task _task;

	private bool _resetViewportAfterLoadSettings;

	[XmlIgnore]
	public bool IsBusy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLanguageChange(LocalizedContentManager.LanguageCode code)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ensureFolderStructureExists()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void savePreferences(bool async, bool update_language_from_ingame_language = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _savePreferences()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private long writeSettings(Stream stream)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void loadPreferences(bool async, bool applyLanguage = true, bool resetViewportAfterLoad = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _SetLanguageFromCode(string language_code_string)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _loadPreferences()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void readSettings(Stream stream)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void readSettings(StartupPreferences p)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetViewport()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StartupPreferences()
	{
	}
}
