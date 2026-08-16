using System.Runtime.CompilerServices;

namespace rail;

public class VoiceDataCapturedEvent : EventBase
{
	public bool is_last_package;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VoiceDataCapturedEvent()
	{
	}
}
