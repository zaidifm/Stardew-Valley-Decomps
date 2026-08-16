using System;
using System.IO;
using System.Runtime.InteropServices;
using StardewValley.Network;
using Steamworks;

namespace StardewValley.SDKs.Steam.Internal;

internal static class SteamSocketUtils
{
	internal static SteamNetworkingConfigValue_t[] GetNetworkingOptions()
	{
		return new SteamNetworkingConfigValue_t[1]
		{
			new SteamNetworkingConfigValue_t
			{
				m_eValue = ESteamNetworkingConfigValue.k_ESteamNetworkingConfig_SendBufferSize,
				m_eDataType = ESteamNetworkingConfigDataType.k_ESteamNetworkingConfig_Int32,
				m_val = 
				{
					m_int32 = 1048576
				}
			}
		};
	}

	internal static void ProcessSteamMessage(IntPtr messagePtr, IncomingMessage message, out HSteamNetConnection messageConnection, BandwidthLogger bandwidthLogger)
	{
		SteamNetworkingMessage_t steamNetworkingMessage_t = (SteamNetworkingMessage_t)Marshal.PtrToStructure(messagePtr, typeof(SteamNetworkingMessage_t));
		messageConnection = steamNetworkingMessage_t.m_conn;
		byte[] array = new byte[steamNetworkingMessage_t.m_cbSize];
		Marshal.Copy(steamNetworkingMessage_t.m_pData, array, 0, array.Length);
		using (MemoryStream memoryStream = new MemoryStream(Program.netCompression.DecompressBytes(array)))
		{
			memoryStream.Position = 0L;
			using BinaryReader reader = new BinaryReader(memoryStream);
			message.Read(reader);
		}
		SteamNetworkingMessage_t.Release(messagePtr);
		bandwidthLogger?.RecordBytesDown(array.Length);
	}

	internal unsafe static void SendMessage(HSteamNetConnection messageConnection, OutgoingMessage message, BandwidthLogger bandwidthLogger, Action<HSteamNetConnection> onDisconnected = null)
	{
		byte[] data = null;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using BinaryWriter writer = new BinaryWriter(memoryStream);
			message.Write(writer);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			data = memoryStream.ToArray();
		}
		byte[] array = Program.netCompression.CompressAbove(data, 1024);
		EResult eResult;
		fixed (byte* ptr = array)
		{
			eResult = SteamNetworkingSockets.SendMessageToConnection(messageConnection, (IntPtr)ptr, Convert.ToUInt32(array.Length), 8, out var _);
		}
		if (eResult != EResult.k_EResultOK)
		{
			Game1.log.Warn("Failed to send message (" + eResult.ToString() + "). Closing connection.");
			CloseConnection(messageConnection, onDisconnected);
		}
		else
		{
			bandwidthLogger?.RecordBytesUp(array.Length);
		}
	}

	internal static void CloseConnection(HSteamNetConnection connection, Action<HSteamNetConnection> onDisconnected = null)
	{
		if (!(connection == HSteamNetConnection.Invalid))
		{
			SteamNetworkingSockets.SetConnectionPollGroup(connection, HSteamNetPollGroup.Invalid);
			onDisconnected?.Invoke(connection);
			SteamNetworkingSockets.CloseConnection(connection, 1000, null, bEnableLinger: true);
		}
	}
}
