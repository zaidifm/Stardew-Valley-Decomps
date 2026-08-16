using System.Runtime.CompilerServices;

namespace StardewValley.Menus;

public class InviteCodeDialog : ConfirmationDialog
{
	private string code;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InviteCodeDialog(string code, behavior onClose)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void copyCode(Farmer who)
	{
	}
}
