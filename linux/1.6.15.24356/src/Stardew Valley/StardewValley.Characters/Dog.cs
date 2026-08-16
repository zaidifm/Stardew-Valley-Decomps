using System;

namespace StardewValley.Characters;

[Obsolete("All dogs now use the Pet class.")]
public class Dog : Pet
{
	public Dog()
	{
		Sprite = new AnimatedSprite(getPetTextureName(), 0, 32, 32);
		base.HideShadow = true;
		base.Breather = false;
		base.willDestroyObjectsUnderfoot = false;
	}
}
