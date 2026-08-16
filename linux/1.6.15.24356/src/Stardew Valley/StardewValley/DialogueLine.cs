using System;

namespace StardewValley;

public class DialogueLine
{
	public string Text;

	public Action SideEffects;

	public bool HasText
	{
		get
		{
			if (!string.IsNullOrEmpty(Text))
			{
				return Text != "{";
			}
			return false;
		}
	}

	public DialogueLine(string text, Action sideEffects = null)
	{
		Text = text ?? "";
		SideEffects = sideEffects;
	}
}
