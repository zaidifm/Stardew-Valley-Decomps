using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData;

public class QuantityModifier
{
	public enum ModificationType
	{
		Add,
		Subtract,
		Multiply,
		Divide,
		Set
	}

	public enum QuantityModifierMode
	{
		Stack,
		Minimum,
		Maximum
	}

	public string Id;

	[ContentSerializer(Optional = true)]
	public string Condition;

	public ModificationType Modification;

	[ContentSerializer(Optional = true)]
	public float Amount;

	[ContentSerializer(Optional = true)]
	public List<float> RandomAmount;

	public static float Apply(float value, ModificationType modification, float amount)
	{
		return modification switch
		{
			ModificationType.Add => value + amount, 
			ModificationType.Subtract => value - amount, 
			ModificationType.Multiply => value * amount, 
			ModificationType.Divide => value / amount, 
			ModificationType.Set => amount, 
			_ => value, 
		};
	}
}
