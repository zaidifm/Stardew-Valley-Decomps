using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace StardewValley.Menus;

public class ReadyCheckDialog : ConfirmationDialog
{
	public string checkName;

	private bool allowCancel;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReadyCheckDialog(string checkName, bool allowCancel, behavior onConfirm = null, behavior onCancel = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isCancelable()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool readyToClose()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void closeDialog(Farmer who)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void receiveKeyPress(Keys key)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updateMessage()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void update(GameTime time)
	{
	}
}
