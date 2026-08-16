using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Audio;
using StardewValley.Extensions;
using StardewValley.GameData;

namespace StardewValley.Audio;

public class AudioCueModificationManager
{
	public Dictionary<string, AudioCueData> cueModificationData;

	public void OnStartup()
	{
		cueModificationData = DataLoader.AudioChanges(Game1.content);
		ApplyAllCueModifications();
	}

	public virtual void ApplyAllCueModifications()
	{
		foreach (string key in cueModificationData.Keys)
		{
			ApplyCueModification(key);
		}
	}

	public virtual string GetFilePath(string filePath)
	{
		return Path.Combine(Game1.content.RootDirectory, filePath);
	}

	public virtual void ApplyCueModification(string key)
	{
		try
		{
			if (!cueModificationData.TryGetValue(key, out var value))
			{
				return;
			}
			bool flag = false;
			int categoryIndex = Game1.audioEngine.GetCategoryIndex("Default");
			CueDefinition cueDefinition;
			if (Game1.soundBank.Exists(value.Id))
			{
				cueDefinition = Game1.soundBank.GetCueDefinition(value.Id);
				flag = true;
			}
			else
			{
				cueDefinition = new CueDefinition();
				cueDefinition.name = value.Id;
			}
			if (value.Category != null)
			{
				categoryIndex = Game1.audioEngine.GetCategoryIndex(value.Category);
			}
			if (value.FilePaths != null)
			{
				SoundEffect[] array = new SoundEffect[value.FilePaths.Count];
				for (int i = 0; i < value.FilePaths.Count; i++)
				{
					string filePath = GetFilePath(value.FilePaths[i]);
					bool flag2 = Path.GetExtension(filePath).EqualsIgnoreCase(".ogg");
					int num = 0;
					try
					{
						SoundEffect soundEffect;
						if (flag2 && value.StreamedVorbis)
						{
							soundEffect = new OggStreamSoundEffect(filePath);
						}
						else
						{
							using FileStream stream = new FileStream(filePath, FileMode.Open);
							soundEffect = SoundEffect.FromStream(stream, flag2);
						}
						array[i - num] = soundEffect;
					}
					catch (Exception exception)
					{
						Game1.log.Error("Error loading sound: " + filePath, exception);
						num++;
					}
					if (num > 0)
					{
						Array.Resize(ref array, array.Length - num);
					}
				}
				cueDefinition.SetSound(array, categoryIndex, value.Looped, value.UseReverb);
				if (flag)
				{
					cueDefinition.OnModified?.Invoke();
				}
			}
			Game1.soundBank.AddCue(cueDefinition);
		}
		catch (NoAudioHardwareException)
		{
			Game1.log.Warn("Can't apply modifications for audio cue '" + key + "' because there's no audio hardware available.");
		}
	}
}
