using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.BellsAndWhistles;
using StardewValley.GameData.Movies;
using StardewValley.Network;
using xTile.Dimensions;

namespace StardewValley.Locations;

public class MovieTheater : GameLocation
{
	public enum MovieStates
	{
		Preshow,
		Show,
		PostShow
	}

	protected bool _startedMovie;

	internal static bool _isJojaTheater;

	internal static List<MovieData> _movieData;

	internal static Dictionary<string, MovieData> _movieDataById;

	internal static List<MovieCharacterReaction> _genericReactions;

	internal static List<ConcessionTaste> _concessionTastes;

	protected readonly NetStringDictionary<int, NetInt> _spawnedMoviePatrons;

	protected readonly NetStringDictionary<string, NetString> _purchasedConcessions;

	protected readonly NetStringDictionary<int, NetInt> _playerInvitedPatrons;

	protected readonly NetStringDictionary<bool, NetBool> _characterGroupLookup;

	protected Dictionary<int, List<Point>> _hangoutPoints;

	protected Dictionary<int, List<Point>> _availableHangoutPoints;

	protected int _maxHangoutGroups;

	protected int _movieStartTime;

	[XmlElement("dayFirstEntered")]
	public readonly NetInt dayFirstEntered;

	internal static Dictionary<string, MovieConcession> _concessions;

	public const int LOVE_MOVIE_FRIENDSHIP = 200;

	public const int LIKE_MOVIE_FRIENDSHIP = 100;

	public const int DISLIKE_MOVIE_FRIENDSHIP = 0;

	public const int LOVE_CONCESSION_FRIENDSHIP = 50;

	public const int LIKE_CONCESSION_FRIENDSHIP = 25;

	public const int DISLIKE_CONCESSION_FRIENDSHIP = 0;

	public const int OPEN_TIME = 900;

	public const int CLOSE_TIME = 2100;

	public const string MainTileSheetId = "movieTheater_tileSheet";

	[XmlIgnore]
	protected Dictionary<string, KeyValuePair<Point, int>> _destinationPositions;

	[XmlIgnore]
	public PerchingBirds birds;

	[XmlIgnore]
	public static string forceMovieId;

	protected int _exitX;

	protected int _exitY;

	private NetEvent1<MovieViewerLockEvent> movieViewerLockEvent;

	private NetEvent1<StartMovieEvent> startMovieEvent;

	private NetEvent1Field<long, NetLong> requestStartMovieEvent;

	private NetEvent1Field<long, NetLong> endMovieEvent;

	protected List<Farmer> _viewingFarmers;

	protected List<List<Character>> _viewingGroups;

	protected List<List<Character>> _playerGroups;

	protected List<List<Character>> _npcGroups;

	internal static bool _hasRequestedMovieStart;

	internal static int _playerHangoutGroup;

	protected int _farmerCount;

	protected readonly NetInt currentState;

	protected readonly NetInt showingId;

	public static string[][][][] possibleNPCGroups;

	protected int CurrentState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	protected int ShowingId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MovieTheater()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddMoviePoster(GameLocation location, float x, float y, bool isUpcoming = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MovieTheater(string map, string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<MovieCharacterReaction> GetMovieReactions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetConcessionTasteForCharacter(Character character, MovieConcession concession)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<string> GetPatronNames()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _InitializeMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void initNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStartMovieEvent(StartMovieEvent e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRequestStartMovieEvent(long uid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnMovieViewerLockEvent(MovieViewerLockEvent e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void _ShowMovieStartReady()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<MovieData> GetMovieData()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, MovieData> GetMovieDataById()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetMovieData(string id, out MovieData data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetMovieIdFromLegacyIndex(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Microsoft.Xna.Framework.Rectangle GetSourceRectForScreen(int movieIndex, int frame)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Microsoft.Xna.Framework.Rectangle GetSourceRectForPoster(int movieIndex)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NPC GetMoviePatron(string name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected NPC AddMoviePatronNPC(string name, int x, int y, int facingDirection)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllPatrons()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetSharedState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void resetLocalState()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addRandomNPCs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addSpecificRandomNPC(int whichRandomNPC)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MovieData GetMovieToday()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<MovieData> GetMoviesForSeason(WorldDate date)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MovieData GetMovieForDate(WorldDate date)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MovieData GetUpcomingMovie()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MovieData GetUpcomingMovieForDate(WorldDate afterDate)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool MovieYearMatches(MovieData movie, int year)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool MovieSeasonMatches(MovieData movie, Season season)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DayUpdate(int dayOfMonth)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void UpdateWhenCurrentLocation(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Invite(Farmer farmer, NPC invited_npc)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetTheater()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MovieCharacterReaction GetReactionsForCharacter(NPC character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void checkForMusic(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetResponseForMovie(NPC character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dialogue GetDialogueForCharacter(NPC character)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string FormatString(string text, params string[] args)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool checkAction(Location tileLocation, xTile.Dimensions.Rectangle viewport, Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _PopulateNPCOnlyGroups(List<List<Character>> player_groups, List<List<Character>> groups)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<Character, MovieConcession> GetConcessionsDictionary()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _ResetHangoutPoints()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void cleanupBeforePlayerExit()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestEndMovie(long uid)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PathCharacterToLocation(NPC character, Point point, int direction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, MovieConcession> GetConcessions()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static MovieConcession GetConcessionItem(string id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OnPurchaseConcession(ISalable salable, Farmer who, int countTaken, ItemStockInformation stock)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasInvitedSomeone(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasPurchasedConcession(Farmer who)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Farmer GetFirstInvitedPlayer(NPC npc)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void performTouchAction(string[] action, Vector2 playerStandingPosition)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<MovieConcession> GetConcessionsForGuest()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<MovieConcession> GetConcessionsForGuest(string npc_name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _Leave()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool performAction(string[] action, Farmer who, Location tileLocation)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void tryToStartCraneGame(Farmer who, string whichAnswer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearCachedLocalizedData()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ClearCachedConcessionTastes()
	{
	}
}
