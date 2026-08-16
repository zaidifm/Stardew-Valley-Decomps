using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Graphics;
using Netcode;

namespace StardewValley.Buffs;

public class BuffAttributeDisplay
{
	public readonly Func<Texture2D> Texture;

	public readonly int SpriteIndex;

	public readonly Func<Buff, float> Value;

	public readonly Func<float, string> Description;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuffAttributeDisplay(Func<Texture2D> texture, int spriteIndex, Func<Buff, float> value, Func<float, string> description)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BuffAttributeDisplay(int spriteIndex, Func<BuffEffects, NetFloat> value, string descriptionKey)
	{
	}
}
