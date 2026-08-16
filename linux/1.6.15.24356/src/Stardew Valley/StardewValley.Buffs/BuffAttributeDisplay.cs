using System;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Buffs;

public class BuffAttributeDisplay
{
	public readonly Func<Texture2D> Texture;

	public readonly int SpriteIndex;

	public readonly Func<Buff, float> Value;

	public readonly Func<float, string> Description;

	public BuffAttributeDisplay(Func<Texture2D> texture, int spriteIndex, Func<Buff, float> value, Func<float, string> description)
	{
		Texture = texture;
		SpriteIndex = spriteIndex;
		Value = value;
		Description = description;
	}

	public BuffAttributeDisplay(int spriteIndex, Func<BuffEffects, NetFloat> value, string descriptionKey)
	{
		Texture = () => Game1.buffsIcons;
		SpriteIndex = spriteIndex;
		Value = (Buff buff) => value(buff.effects).Value;
		Description = delegate(float buffValue)
		{
			string text = ((buffValue > 0f) ? ("+" + buffValue) : (buffValue.ToString() ?? ""));
			string text2 = Game1.content.LoadString(descriptionKey);
			LocalizedContentManager.LanguageCode currentLanguageCode = LocalizedContentManager.CurrentLanguageCode;
			return (currentLanguageCode == LocalizedContentManager.LanguageCode.ja || currentLanguageCode == LocalizedContentManager.LanguageCode.es || currentLanguageCode == LocalizedContentManager.LanguageCode.ko) ? (text2 + text) : (text + text2);
		};
	}
}
