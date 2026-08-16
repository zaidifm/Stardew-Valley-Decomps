using System.Runtime.CompilerServices;

namespace StardewValley.Menus;

public interface IScreenReadable
{
	string ScreenReaderText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	string ScreenReaderDescription
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}

	bool ScreenReaderIgnore
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
	}
}
