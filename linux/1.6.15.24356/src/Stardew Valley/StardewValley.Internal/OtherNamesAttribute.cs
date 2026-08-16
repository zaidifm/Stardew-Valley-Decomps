using System;

namespace StardewValley.Internal;

[AttributeUsage(AttributeTargets.Method)]
public class OtherNamesAttribute : Attribute
{
	public string[] Aliases { get; }

	public OtherNamesAttribute(params string[] aliases)
	{
		Aliases = aliases;
	}
}
