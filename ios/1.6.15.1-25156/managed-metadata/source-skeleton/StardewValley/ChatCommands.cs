using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StardewValley.Delegates;
using StardewValley.Menus;

namespace StardewValley;

public static class ChatCommands
{
	public class ChatCommand
	{
		public readonly string Name;

		public readonly ChatCommandHandlerDelegate Handler;

		public readonly Func<string, string> HelpDescription;

		public readonly bool IsMainPlayerOnly;

		public readonly bool IsMultiplayerOnly;

		public readonly bool IsCheatsOnly;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatCommand(string name, Func<string, string> helpDescription, ChatCommandHandlerDelegate handler, bool isMainPlayerOnly, bool isMultiplayerOnly, bool isCheatsOnly)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsVisible()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static class DefaultHandlers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Ban(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Cheat(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Clear(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Color(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ConcernedApe(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ColorList(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Debug(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Emote(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Help(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Kick(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void List(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MapScreenshot(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Message(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Money(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void MoveBuildingPermission(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Pause(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Ping(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void PrintDiag(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Qi(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void RecountNuts(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Reply(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Resume(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SleepAnnounceMode(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Unban(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UnbanAll(string[] command, ChatBox chat)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UnlinkPlayer(string[] command, ChatBox chat)
		{
		}
	}

	private static readonly Dictionary<string, ChatCommand> Handlers;

	private static readonly Dictionary<string, string> Aliases;

	public static bool AllowCheats
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ChatCommands()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Exists(string commandName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Register(string commandName, ChatCommandHandlerDelegate handler, Func<string, string> helpDescription, string[] aliases = null, bool mainOnly = false, bool multiplayerOnly = false, bool cheatsOnly = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterAlias(string alias, string commandName)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryHandle(string[] command, ChatBox chat)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ChatCommandHandlerDelegate GetDebugPassThrough(string debugCommandName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
