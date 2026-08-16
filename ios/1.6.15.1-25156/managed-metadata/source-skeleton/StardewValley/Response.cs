using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Input;

namespace StardewValley;

public class Response
{
	public string responseKey;

	public string responseText;

	public Keys hotkey;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Response(string responseKey, string responseText)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Response SetHotKey(Keys key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
