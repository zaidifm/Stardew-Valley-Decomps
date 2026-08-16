using System;
using Galaxy.Api;

namespace StardewValley.SDKs.GogGalaxy.Listeners;

internal sealed class GalaxyOperationalStateChangeListener : IOperationalStateChangeListener
{
	private readonly Action<uint> Callback;

	public GalaxyOperationalStateChangeListener(Action<uint> callback)
	{
		Callback = callback;
		GalaxyInstance.ListenerRegistrar().Register(GalaxyTypeAwareListenerOperationalStateChange.GetListenerType(), this);
	}

	public override void OnOperationalStateChanged(uint operationalState)
	{
		Callback?.Invoke(operationalState);
	}

	public override void Dispose()
	{
		GalaxyInstance.ListenerRegistrar().Unregister(GalaxyTypeAwareListenerOperationalStateChange.GetListenerType(), this);
		base.Dispose();
	}
}
