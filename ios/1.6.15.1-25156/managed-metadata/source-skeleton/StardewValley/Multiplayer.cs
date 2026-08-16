using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Netcode;
using StardewValley.Network;

namespace StardewValley;

public class Multiplayer
{
	public enum PartyWideMessageQueue
	{
		MailForTomorrow,
		SeenMail
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	private struct FarmerRoots : IEnumerable<NetFarmerRoot>, IEnumerable
	{
		public struct Enumerator : IEnumerator<NetFarmerRoot>, IEnumerator, IDisposable
		{
			private Dictionary<long, NetRoot<Farmer>>.Enumerator _enumerator;

			private NetFarmerRoot _current;

			private int _step;

			private bool _done;

			public NetFarmerRoot Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Enumerator(bool dummy)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool MoveNext()
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			void IEnumerator.Reset()
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Enumerator GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator<NetFarmerRoot> IEnumerable<NetFarmerRoot>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct ActiveLocations : IEnumerable<GameLocation>, IEnumerable
	{
		public struct Enumerator : IEnumerator<GameLocation>, IEnumerator, IDisposable
		{
			private List<StardewValley.Buildings.Building>.Enumerator _enumerator;

			private GameLocation _current;

			private int _step;

			private bool _done;

			public GameLocation Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
				}
			}

			object IEnumerator.Current
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool MoveNext()
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Dispose()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			void IEnumerator.Reset()
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Enumerator GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator<GameLocation> IEnumerable<GameLocation>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public enum DisconnectType
	{
		None,
		ClosedGame,
		ExitedToMainMenu,
		ExitedToMainMenu_FromFarmhandSelect,
		HostLeft,
		ServerOfflineMode,
		ServerFull,
		Kicked,
		AcceptedOtherInvite,
		ClientTimeout,
		LidgrenTimeout,
		GalaxyTimeout,
		Timeout_FarmhandSelection,
		LidgrenDisconnect_Unknown
	}

	[CompilerGenerated]
	private sealed class <_GetActiveLocationsHere>d__136 : IEnumerable<GameLocation>, IEnumerable, IEnumerator<GameLocation>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private GameLocation <>2__current;

		private int <>l__initialThreadId;

		private GameLocation location;

		public GameLocation <>3__location;

		public Multiplayer <>4__this;

		private List<StardewValley.Buildings.Building>.Enumerator <>7__wrap1;

		private IEnumerator<GameLocation> <>7__wrap2;

		GameLocation IEnumerator<GameLocation>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public <_GetActiveLocationsHere>d__136(int <>1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void <>m__Finally1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void <>m__Finally2()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<GameLocation> IEnumerable<GameLocation>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[CompilerGenerated]
	private sealed class <activeLocations>d__135 : IEnumerable<GameLocation>, IEnumerable, IEnumerator<GameLocation>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private GameLocation <>2__current;

		private int <>l__initialThreadId;

		public Multiplayer <>4__this;

		private List<GameLocation>.Enumerator <>7__wrap1;

		private IEnumerator<GameLocation> <>7__wrap2;

		GameLocation IEnumerator<GameLocation>.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			get
			{
				/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		public <activeLocations>d__135(int <>1__state)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void <>m__Finally1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void <>m__Finally2()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<GameLocation> IEnumerable<GameLocation>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static readonly long AllPlayers;

	public const byte farmerDelta = 0;

	public const byte serverIntroduction = 1;

	public const byte playerIntroduction = 2;

	public const byte locationIntroduction = 3;

	public const byte forceEvent = 4;

	public const byte warpFarmer = 5;

	public const byte locationDelta = 6;

	public const byte locationSprites = 7;

	public const byte characterWarp = 8;

	public const byte availableFarmhands = 9;

	public const byte chatMessage = 10;

	public const byte connectionMessage = 11;

	public const byte worldDelta = 12;

	public const byte teamDelta = 13;

	public const byte newDaySync = 14;

	public const byte chatInfoMessage = 15;

	public const byte userNameUpdate = 16;

	public const byte farmerGainExperience = 17;

	public const byte serverToClientsMessage = 18;

	public const byte disconnecting = 19;

	public const byte sharedAchievement = 20;

	public const byte globalMessage = 21;

	public const byte partyWideMail = 22;

	public const byte forceKick = 23;

	public const byte removeLocationFromLookup = 24;

	public const byte farmerKilledMonster = 25;

	public const byte requestGrandpaReevaluation = 26;

	public const byte digBuriedNut = 27;

	public const byte requestPassout = 28;

	public const byte passout = 29;

	public const byte startNewDaySync = 30;

	public const byte readySync = 31;

	public const byte chestHitSync = 32;

	public const byte dedicatedServerSync = 33;

	public const byte compressed = 127;

	public const byte WARP_FLAG_STRUCTURE = 1;

	public const byte WARP_FLAG_FORCED = 2;

	public const byte WARP_FLAG_NEEDS_INFO = 4;

	public const byte WARP_FLAG_FACE_UP = 8;

	public const byte WARP_FLAG_FACE_RIGHT = 16;

	public const byte WARP_FLAG_FACE_DOWN = 32;

	public const byte WARP_FLAG_FACE_LEFT = 64;

	public const string chat_token_aOrAn = "aOrAn:";

	public int defaultInterpolationTicks;

	public int farmerDeltaBroadcastPeriod;

	public int locationDeltaBroadcastPeriod;

	public int worldStateDeltaBroadcastPeriod;

	public int playerLimit;

	public static string kicked;

	internal static string protocolVersionOverride;

	public readonly NetLogger logging;

	protected List<long> disconnectingFarmers;

	public ulong latestID;

	public Dictionary<string, CachedMultiplayerMap> cachedMultiplayerMaps;

	protected HashSet<GameLocation> _updatedRoots;

	public const string MSG_START_FESTIVAL_EVENT = "festivalEvent";

	public const string MSG_END_FESTIVAL = "endFest";

	public const string MSG_TRAIN_APPROACH = "trainApproach";

	public static string protocolVersion
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public virtual int MaxPlayers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Multiplayer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual long getNewID()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isDisconnecting(Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isDisconnecting(long uid)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isClientBroadcastType(byte messageType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool allowSyncDelay()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int interpolationTicks()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private FarmerRoots farmerRoots()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual NetFarmerRoot farmerRoot(long id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastFarmerDeltas()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void broadcastTeamDelta(byte[] delta)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void broadcastFarmerDelta(Farmer farmer, byte[] delta)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateRoot<T>(T root) where T : INetRoot
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void updateRoots()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastLocationDeltas()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastLocationDelta(GameLocation loc)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void broadcastLocationBytes(GameLocation loc, byte messageType, byte[] bytes)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void broadcastLocationMessage(GameLocation loc, OutgoingMessage message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastSprites(GameLocation location, TemporaryAnimatedSpriteList sprites)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastSprites(GameLocation location, params TemporaryAnimatedSprite[] sprites)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastWorldStateDeltas()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receiveWorldState(BinaryReader msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void requestCharacterWarp(NPC character, GameLocation targetLocation, Vector2 position)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual NetRoot<GameLocation> locationRoot(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void sendPassoutRequest()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receivePassoutRequest(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _receivePassoutRequest(Farmer farmer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receivePassout(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual object[] generateForceEventMessage(string eventId, GameLocation location, int tileX, int tileY, bool use_local_farmer, bool notify_when_done)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastEvent(Event evt, GameLocation location, Vector2 positionBeforeEvent, bool use_local_farmer = true, bool notify_when_done = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveRequestGrandpaReevaluation(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveFarmerKilledMonster(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastRemoveLocationFromLookup(GameLocation location)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastNutDig(GameLocation location, Point point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveNutDig(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _performNutDig(GameLocation location, Point point)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastPartyWideMail(string mail_key, PartyWideMessageQueue message_queue = PartyWideMessageQueue.MailForTomorrow, bool no_letter = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastGrandpaReevaluation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastGlobalMessage(string translationKey, bool onlyShowIfEmpty = false, GameLocation location = null, params string[] substitutions)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual NetRoot<T> readObjectFull<T>(BinaryReader reader) where T : class, INetObject<INetSerializable>
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual BinaryWriter createWriter(Stream stream)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void writeObjectFull<T>(BinaryWriter writer, NetRoot<T> root, long? peer) where T : class, INetObject<INetSerializable>
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual byte[] writeObjectFullBytes<T>(NetRoot<T> root, long? peer) where T : class, INetObject<INetSerializable>
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void readObjectDelta<T>(BinaryReader reader, NetRoot<T> root) where T : class, INetObject<INetSerializable>
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void writeObjectDelta<T>(BinaryWriter writer, NetRoot<T> root) where T : class, INetObject<INetSerializable>
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual byte[] writeObjectDeltaBytes<T>(NetRoot<T> root) where T : class, INetObject<INetSerializable>
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual NetFarmerRoot readFarmer(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void addPlayer(NetFarmerRoot f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receivePlayerIntroduction(BinaryReader reader)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastPlayerIntroduction(NetFarmerRoot farmerRoot)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void broadcastUserName(long farmerId, string userName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getUserName(long id)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playerDisconnected(long id)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void removeDisconnectedFarmers()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void sendFarmhand()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void saveFarmhand(NetFarmerRoot farmhand)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void saveFarmhands()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void clientRemotelyDisconnected(DisconnectType disconnectType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void returnToMainMenu()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ShouldLogDisconnect(DisconnectType disconnectType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsTimeout(DisconnectType disconnectType)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LogDisconnect(DisconnectType disconnectType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void sendSharedAchievementMessage(int achievement)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void sendServerToClientsMessage(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void sendChatMessage(LocalizedContentManager.LanguageCode language, string message, long recipientID)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void receiveChatMessage(Farmer sourceFarmer, long recipientID, LocalizedContentManager.LanguageCode language, string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void globalChatInfoMessage(string messageKey, params string[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void globalChatInfoMessageEvenInSinglePlayer(string messageKey, params string[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void sendChatInfoMessage(string messageKey, params string[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveChatInfoMessage(Farmer sourceFarmer, string messageKey, string[] args)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void parseServerToClientsMessage(string message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<activeLocations>d__135))]
	public virtual IEnumerable<GameLocation> activeLocations()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<_GetActiveLocationsHere>d__136))]
	protected virtual IEnumerable<GameLocation> _GetActiveLocationsHere(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isAlwaysActiveLocation(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void readActiveLocation(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isActiveLocation(GameLocation location)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual GameLocation readLocation(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual LocationRequest readLocationRequest(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual NPC readNPC(BinaryReader reader)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void readSprites(BinaryReader reader, GameLocation location, Action<TemporaryAnimatedSprite> assignSprite)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveTeamDelta(BinaryReader msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveNewDaySync(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveFarmerGainExperience(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveSharedAchievement(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveRemoveLocationFromLookup(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receivePartyWideMail(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void _performPartyWideMail(string mail_key, PartyWideMessageQueue message_queue, bool no_letter)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void receiveForceKick()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void receiveGlobalMessage(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void receiveStartNewDaySync()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void receiveReadySync(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void receiveChestHitSync(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void receiveDedicatedServerSync(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void processIncomingMessage(IncomingMessage msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartLocalMultiplayerServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartServer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Disconnect(DisconnectType disconnectType)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void updatePendingConnections()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateLoading()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateEarly()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateLate(bool forceSync = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void inviteAccepted()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Client InitClient(Client client)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Server InitServer(Server server)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
