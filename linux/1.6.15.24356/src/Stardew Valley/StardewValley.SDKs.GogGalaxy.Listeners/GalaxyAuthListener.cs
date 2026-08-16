using System;
using Galaxy.Api;

namespace StardewValley.SDKs.GogGalaxy.Listeners;

internal sealed class GalaxyAuthListener : IAuthListener
{
	private readonly Action OnSuccess;

	private readonly Action<FailureReason> OnFailure;

	private readonly Action OnLost;

	public GalaxyAuthListener(Action success, Action<FailureReason> failure, Action lost)
	{
		OnSuccess = success;
		OnFailure = failure;
		OnLost = lost;
		GalaxyInstance.ListenerRegistrar().Register(GalaxyTypeAwareListenerAuth.GetListenerType(), this);
	}

	public override void OnAuthSuccess()
	{
		OnSuccess?.Invoke();
	}

	public override void OnAuthFailure(FailureReason reason)
	{
		OnFailure?.Invoke(reason);
	}

	public override void OnAuthLost()
	{
		OnLost?.Invoke();
	}

	public override void Dispose()
	{
		GalaxyInstance.ListenerRegistrar().Unregister(GalaxyTypeAwareListenerAuth.GetListenerType(), this);
		base.Dispose();
	}
}
