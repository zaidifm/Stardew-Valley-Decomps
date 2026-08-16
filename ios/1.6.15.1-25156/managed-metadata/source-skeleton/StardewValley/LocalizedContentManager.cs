using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework.Content;
using StardewValley.GameData;

namespace StardewValley;

public class LocalizedContentManager : ContentManager
{
	public delegate void LanguageChangedHandler(LanguageCode code);

	public enum LanguageCode
	{
		en,
		ja,
		ru,
		zh,
		pt,
		es,
		de,
		th,
		fr,
		ko,
		it,
		tr,
		hu,
		mod
	}

	private const bool OnlyCheckManifest = true;

	private static readonly object ManifestLocker;

	private static HashSet<string> _manifest;

	[CompilerGenerated]
	private static LanguageChangedHandler m_OnLanguageChange;

	public static readonly Dictionary<string, string> localizedAssetNames;

	protected string _CachedContentRoot;

	private static LanguageCode _currentLangCode;

	private static string _currentLangString;

	private static ModLanguage _currentModLanguage;

	public CultureInfo CurrentCulture;

	protected static StringBuilder _timeFormatStringBuilder;

	[ThreadStatic]
	private static StringBuilder StringBuilder;

	private static readonly char AssetPathSeparator;

	public static string CurrentLanguageString
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static LanguageCode CurrentLanguageCode
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

	public static bool CurrentLanguageLatin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static ModLanguage CurrentModLanguage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static event LanguageChangedHandler OnLanguageChange
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlatformEnsureManifestInitialized()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnsureManifestInitialized()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static LanguageCode GetDefaultLanguageCode()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocalizedContentManager(IServiceProvider serviceProvider, string rootDirectory, CultureInfo currentCulture)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocalizedContentManager(IServiceProvider serviceProvider, string rootDirectory)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static bool _IsStringAt(string source, string string_to_find, int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static StringBuilder FormatTimeString(int time, string format)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetModLanguage(ModLanguage new_mod_language)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetContentRoot()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool DoesAssetExistInternal(string assetName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool DoesAssetExist<T>(string assetName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual T LoadImpl<T>(string baseAssetName, string localizedAssetName, LanguageCode languageCode)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override T Load<T>(string assetName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual T Load<T>(string assetName, LanguageCode language)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string LanguageCodeString(LanguageCode code)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LanguageCode GetCurrentLanguage()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetString(Dictionary<string, string> strings, string key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsValidTranslationKey(string path)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LoadStringReturnNullIfNotFound(string path, bool localeFallback = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LoadStringReturnNullIfNotFound(string path, string sub1, bool localeFallback = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LoadStringReturnNullIfNotFound(string path, string sub1, string sub2, bool localeFallback = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LoadStringReturnNullIfNotFound(string path, object[] substitutions, bool localeFallback = true)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LoadString(string path)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string PreprocessString(string text)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ShouldUseGenderedCharacterTranslations()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LoadString(string path, object sub1)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LoadString(string path, object sub1, object sub2)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LoadString(string path, object sub1, object sub2, object sub3)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LoadString(string path, params object[] substitutions)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LoadBaseStringOrNull(string path)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string LoadBaseString(string path)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void parseStringPath(string path, out string assetName, out string key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual LocalizedContentManager CreateTemporary()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
