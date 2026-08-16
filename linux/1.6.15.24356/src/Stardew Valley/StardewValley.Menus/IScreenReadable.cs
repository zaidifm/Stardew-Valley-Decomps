namespace StardewValley.Menus;

public interface IScreenReadable
{
	string ScreenReaderText { get; }

	string ScreenReaderDescription { get; }

	bool ScreenReaderIgnore { get; }
}
