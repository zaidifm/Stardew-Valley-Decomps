using System;

namespace StardewValley.Characters;

[Obsolete("All cats now use the Pet class.")]
public class Cat : Pet
{
	public Cat()
	{
		Sprite = new AnimatedSprite(getPetTextureName(), 0, 32, 32);
		base.HideShadow = true;
		base.Breather = false;
		base.willDestroyObjectsUnderfoot = false;
	}
}
