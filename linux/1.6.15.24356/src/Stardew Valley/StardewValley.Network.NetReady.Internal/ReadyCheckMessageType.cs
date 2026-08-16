namespace StardewValley.Network.NetReady.Internal;

internal enum ReadyCheckMessageType : byte
{
	Ready,
	Cancel,
	Lock,
	Release,
	AcceptLock,
	RejectLock,
	UpdateAmounts,
	RequireFarmers,
	Finish
}
