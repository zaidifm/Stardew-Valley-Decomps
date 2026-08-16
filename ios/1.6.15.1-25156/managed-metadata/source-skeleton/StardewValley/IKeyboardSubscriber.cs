using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Input;

namespace StardewValley;

public interface IKeyboardSubscriber
{
	bool Selected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	void RecieveTextInput(char inputChar);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void RecieveTextInput(string text);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void RecieveCommandInput(char command);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void RecieveSpecialInput(Keys key);
}
