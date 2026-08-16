using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Netcode;
using StardewValley.Delegates;
using StardewValley.GameData;
using StardewValley.ItemTypeDefinitions;

namespace StardewValley.Internal;

public static class ItemQueryResolver
{
	public static class Helpers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string[] SplitArguments(string arguments)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ItemQueryResult[] ErrorResult(string key, string arguments, Action<string, string> logError, string message)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ExcludeFromRandomSale(ParsedItemData data)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static class DefaultResolvers
	{
		[CompilerGenerated]
		private sealed class <ALL_ITEMS>d__0 : IEnumerable<ItemQueryResult>, IEnumerable, IEnumerator<ItemQueryResult>, IEnumerator, IDisposable
		{
			private int <>1__state;

			private ItemQueryResult <>2__current;

			private int <>l__initialThreadId;

			private string arguments;

			public string <>3__arguments;

			private string key;

			public string <>3__key;

			private Action<string, string> logError;

			public Action<string, string> <>3__logError;

			private string <onlyTypeId>5__2;

			private bool <isRandomSale>5__3;

			private bool <requirePrice>5__4;

			private List<IItemDataDefinition>.Enumerator <>7__wrap4;

			private List<StardewValley.Objects.Furniture>.Enumerator <>7__wrap5;

			private IEnumerator<ParsedItemData> <>7__wrap6;

			ItemQueryResult IEnumerator<ItemQueryResult>.Current
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
			public <ALL_ITEMS>d__0(int <>1__state)
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
			private void <>m__Finally3()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator<ItemQueryResult> IEnumerable<ItemQueryResult>.GetEnumerator()
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
		private sealed class <ITEMS_SOLD_BY_PLAYER>d__4 : IEnumerable<ItemQueryResult>, IEnumerable, IEnumerator<ItemQueryResult>, IEnumerator, IDisposable
		{
			private int <>1__state;

			private ItemQueryResult <>2__current;

			private int <>l__initialThreadId;

			private string arguments;

			public string <>3__arguments;

			private string key;

			public string <>3__key;

			private Action<string, string> logError;

			public Action<string, string> <>3__logError;

			private NetList<Item, NetRef<Item>>.Enumerator <>7__wrap1;

			ItemQueryResult IEnumerator<ItemQueryResult>.Current
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
			public <ITEMS_SOLD_BY_PLAYER>d__4(int <>1__state)
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
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator<ItemQueryResult> IEnumerable<ItemQueryResult>.GetEnumerator()
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
		private sealed class <MONSTER_SLAYER_REWARDS>d__8 : IEnumerable<ItemQueryResult>, IEnumerable, IEnumerator<ItemQueryResult>, IEnumerator, IDisposable
		{
			private int <>1__state;

			private ItemQueryResult <>2__current;

			private int <>l__initialThreadId;

			private ItemQueryContext context;

			public ItemQueryContext <>3__context;

			private KeyValuePair<string, MonsterSlayerQuestData>[] <monsterSlayerQuestData>5__2;

			private HashSet<string> <questIds>5__3;

			private KeyValuePair<string, MonsterSlayerQuestData>[] <>7__wrap3;

			private int <>7__wrap4;

			private string <id>5__6;

			ItemQueryResult IEnumerator<ItemQueryResult>.Current
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
			public <MONSTER_SLAYER_REWARDS>d__8(int <>1__state)
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
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator<ItemQueryResult> IEnumerable<ItemQueryResult>.GetEnumerator()
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
		private sealed class <MOVIE_CONCESSIONS_FOR_GUEST>d__9 : IEnumerable<ItemQueryResult>, IEnumerable, IEnumerator<ItemQueryResult>, IEnumerator, IDisposable
		{
			private int <>1__state;

			private ItemQueryResult <>2__current;

			private int <>l__initialThreadId;

			private string arguments;

			public string <>3__arguments;

			private List<MovieConcession>.Enumerator <>7__wrap1;

			ItemQueryResult IEnumerator<ItemQueryResult>.Current
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
			public <MOVIE_CONCESSIONS_FOR_GUEST>d__9(int <>1__state)
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
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator<ItemQueryResult> IEnumerable<ItemQueryResult>.GetEnumerator()
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
		private sealed class <RANDOM_ITEMS>d__12 : IEnumerable<ItemQueryResult>, IEnumerable, IEnumerator<ItemQueryResult>, IEnumerator, IDisposable
		{
			private int <>1__state;

			private ItemQueryResult <>2__current;

			private int <>l__initialThreadId;

			private string arguments;

			public string <>3__arguments;

			private string key;

			public string <>3__key;

			private Action<string, string> logError;

			public Action<string, string> <>3__logError;

			private ItemQueryContext context;

			public ItemQueryContext <>3__context;

			private int <minId>5__2;

			private int <maxId>5__3;

			private bool <isRandomSale>5__4;

			private bool <requirePrice>5__5;

			private bool <hasRange>5__6;

			private IEnumerator<ParsedItemData> <>7__wrap6;

			ItemQueryResult IEnumerator<ItemQueryResult>.Current
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
			public <RANDOM_ITEMS>d__12(int <>1__state)
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
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[DebuggerHidden]
			IEnumerator<ItemQueryResult> IEnumerable<ItemQueryResult>.GetEnumerator()
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(<ALL_ITEMS>d__0))]
		public static IEnumerable<ItemQueryResult> ALL_ITEMS(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<ItemQueryResult> DISH_OF_THE_DAY(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<ItemQueryResult> FLAVORED_ITEM(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<ItemQueryResult> ITEMS_LOST_ON_DEATH(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(<ITEMS_SOLD_BY_PLAYER>d__4))]
		public static IEnumerable<ItemQueryResult> ITEMS_SOLD_BY_PLAYER(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<ItemQueryResult> LOCATION_FISH(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<ItemQueryResult> LOST_BOOK_OR_ITEM(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<ItemQueryResult> LOST_UNIQUE_ITEMS(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(<MONSTER_SLAYER_REWARDS>d__8))]
		public static IEnumerable<ItemQueryResult> MONSTER_SLAYER_REWARDS(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(<MOVIE_CONCESSIONS_FOR_GUEST>d__9))]
		public static IEnumerable<ItemQueryResult> MOVIE_CONCESSIONS_FOR_GUEST(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<ItemQueryResult> RANDOM_ARTIFACT_FOR_DIG_SPOT(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<ItemQueryResult> RANDOM_BASE_SEASON_ITEM(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IteratorStateMachine(typeof(<RANDOM_ITEMS>d__12))]
		public static IEnumerable<ItemQueryResult> RANDOM_ITEMS(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<ItemQueryResult> SECRET_NOTE_OR_ITEM(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<ItemQueryResult> SHOP_TOWN_KEY(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<ItemQueryResult> TOOL_UPGRADES(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static IEnumerable<ItemQueryResult> PET_ADOPTION(string key, string arguments, ItemQueryContext context, bool avoidRepeat, HashSet<string> avoidItemIds, Action<string, string> logError)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public static Dictionary<string, ResolveItemQueryDelegate> ItemResolvers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemQueryResolver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Register(string queryKey, ResolveItemQueryDelegate queryDelegate)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ItemQueryResult[] TryResolve(string query, ItemQueryContext context, ItemQuerySearchMode filter = ItemQuerySearchMode.All, string perItemCondition = null, int? maxItems = null, bool avoidRepeat = false, HashSet<string> avoidItemIds = null, Action<string, string> logError = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IList<ItemQueryResult> TryResolve(ISpawnItemData data, ItemQueryContext context, ItemQuerySearchMode filter = ItemQuerySearchMode.All, bool avoidRepeat = false, HashSet<string> avoidItemIds = null, Func<string, string> formatItemId = null, Action<string, string> logError = null, Item inputItem = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item TryResolveRandomItem(string query, ItemQueryContext context, bool avoidRepeat = false, HashSet<string> avoidItemIds = null, Action<string, string> logError = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item TryResolveRandomItem(ISpawnItemData data, ItemQueryContext context, bool avoidRepeat = false, HashSet<string> avoidItemIds = null, Func<string, string> formatItemId = null, Item inputItem = null, Action<string, string> logError = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ISalable ApplyItemFields(ISalable item, ISpawnItemData data, ItemQueryContext context, Item inputItem = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ISalable ApplyItemFields(ISalable item, int minStackSize, int maxStackSize, int toolUpgradeLevel, string objectInternalName, string objectDisplayName, string objectColor, int quality, bool isRecipe, List<QuantityModifier> stackSizeModifiers, QuantityModifier.QuantityModifierMode stackSizeModifierMode, List<QuantityModifier> qualityModifiers, QuantityModifier.QuantityModifierMode qualityModifierMode, Dictionary<string, string> modData, ItemQueryContext context, Item inputItem = null)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string FormatLogMessage(string template, ISpawnItemData data, ItemQueryContext context)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void LogNothing(string query, string error)
	{
	}
}
