using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Audio;

namespace StardewValley.Network;

public class NetAudio : INetObject<NetFields>
{
	private readonly NetEventBinary audioEvent;

	private readonly NetStringDictionary<bool, NetBool> activeCues;

	private GameLocation location;

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public NetDictionary<string, bool, NetBool, SerializableDictionary<string, bool>, NetStringDictionary<bool, NetBool>>.KeysCollection ActiveCues
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetAudio(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void handleAudioEvent(BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fire(string audioName, Vector2? position, int? pitch, SoundContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Read(BinaryReader reader, out string audioName, out Vector2? position, out int? pitch, out SoundContext context)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartPlaying(string cueName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopPlaying(string cueName)
	{
	}
}
