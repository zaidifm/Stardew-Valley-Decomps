using System.IO;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Audio;

namespace StardewValley.Network;

public class NetAudio : INetObject<NetFields>
{
	private readonly NetEventBinary audioEvent = new NetEventBinary();

	private readonly NetStringDictionary<bool, NetBool> activeCues = new NetStringDictionary<bool, NetBool>();

	private GameLocation location;

	public NetFields NetFields { get; } = new NetFields("NetAudio");

	public NetDictionary<string, bool, NetBool, SerializableDictionary<string, bool>, NetStringDictionary<bool, NetBool>>.KeysCollection ActiveCues => activeCues.Keys;

	public NetAudio(GameLocation location)
	{
		this.location = location;
		NetFields.SetOwner(this).AddField(audioEvent, "audioEvent").AddField(activeCues, "activeCues");
		audioEvent.AddReaderHandler(handleAudioEvent);
	}

	private void handleAudioEvent(BinaryReader reader)
	{
		Read(reader, out var audioName, out var position, out var pitch, out var context);
		Game1.sounds.PlayLocal(audioName, location, position, pitch, context, out var _);
	}

	public void Update()
	{
		audioEvent.Poll();
	}

	public void Fire(string audioName, Vector2? position, int? pitch, SoundContext context)
	{
		audioEvent.Fire(delegate(BinaryWriter writer)
		{
			writer.Write(audioName);
			writer.WriteVector2(position ?? new Vector2(-2.1474836E+09f));
			writer.Write(pitch ?? int.MinValue);
			writer.Write((int)context);
		});
		audioEvent.Poll();
	}

	public void Read(BinaryReader reader, out string audioName, out Vector2? position, out int? pitch, out SoundContext context)
	{
		audioName = reader.ReadString();
		position = reader.ReadVector2();
		pitch = reader.ReadInt32();
		context = (SoundContext)reader.ReadInt32();
		if ((int)position.Value.X == int.MinValue && (int)position.Value.Y == int.MinValue)
		{
			position = null;
		}
		if (pitch == int.MinValue)
		{
			pitch = null;
		}
	}

	public void StartPlaying(string cueName)
	{
		activeCues[cueName] = false;
	}

	public void StopPlaying(string cueName)
	{
		activeCues.Remove(cueName);
	}
}
