using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Movies;

public class MovieReaction
{
	public string Tag;

	[ContentSerializer(Optional = true)]
	public string Response = "like";

	[ContentSerializer(Optional = true)]
	public List<string> Whitelist = new List<string>();

	[ContentSerializer(Optional = true)]
	public SpecialResponses SpecialResponses;

	public string Id = "";

	public bool ShouldApplyToMovie(MovieData movieData, IEnumerable<string> moviePatrons, params string[] otherValidTags)
	{
		if (Whitelist != null)
		{
			if (moviePatrons == null)
			{
				return false;
			}
			foreach (string item in Whitelist)
			{
				if (!moviePatrons.Contains(item))
				{
					return false;
				}
			}
		}
		if (Tag == movieData.Id)
		{
			return true;
		}
		if (movieData.Tags.Contains(Tag))
		{
			return true;
		}
		if (Tag == "*")
		{
			return true;
		}
		if (otherValidTags.Contains(Tag))
		{
			return true;
		}
		return false;
	}
}
