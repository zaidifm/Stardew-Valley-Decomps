using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;
using StardewValley.GameData.Movies;

namespace StardewValley.Events;

public class MovieTheaterScreeningEvent
{
	public int currentResponse;

	public List<List<Character>> playerAndGuestAudienceGroups;

	public Dictionary<int, Character> _responseOrder;

	protected Dictionary<Character, Character> _whiteListDependencyLookup;

	protected Dictionary<Character, string> _characterResponses;

	public MovieData movieData;

	protected List<Farmer> _farmers;

	protected Dictionary<Character, MovieConcession> _concessionsData;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Event getMovieEvent(string movieId, List<List<Character>> player_and_guest_audience_groups, List<List<Character>> npcOnlyAudienceGroups, Dictionary<Character, MovieConcession> concessions_data = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _ParseScene(StringBuilder sb, MovieScene scene)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _ParseResponse(StringBuilder sb, MovieScene scene = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _ParseCharacterResponse(StringBuilder sb, Character responding_character, bool ignoreScript = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<Character, string> GetCharacterResponses()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string getEventName(Character c)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Point getBackRowSeatTileFromIndex(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Point getMidRowSeatTileFromIndex(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Point getFrontRowSeatTileFromIndex(int index)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MovieTheaterScreeningEvent()
	{
	}
}
