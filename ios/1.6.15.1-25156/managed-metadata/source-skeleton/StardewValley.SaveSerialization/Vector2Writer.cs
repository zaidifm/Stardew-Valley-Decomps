using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;

namespace StardewValley.SaveSerialization;

public class Vector2Writer : XmlSerializationWriter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteVector2(Vector2 vec)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void InitCallbacks()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2Writer()
	{
	}
}
