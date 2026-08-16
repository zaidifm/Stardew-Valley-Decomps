using System.Runtime.CompilerServices;

namespace rail;

public class RailIMEHelperTextInputCompositionState : EventBase
{
	public string composition_text;

	public RailIMETextInputCompositionState composition_state;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailIMEHelperTextInputCompositionState()
	{
	}
}
