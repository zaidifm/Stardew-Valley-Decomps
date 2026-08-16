using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace StardewValley.Tests;

public class TranslationValidator
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0<TValue> where TValue : notnull
	{
		public Func<string, string, string> getSyntax;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public <>c__DisplayClass2_0()
		{
		}
	}

	[CompilerGenerated]
	private sealed class <Compare>d__2<TValue> : IEnumerable<TranslationValidatorResult>, IEnumerable, IEnumerator<TranslationValidatorResult>, IEnumerator, IDisposable where TValue : notnull
	{
		private int <>1__state;

		private TranslationValidatorResult <>2__current;

		private int <>l__initialThreadId;

		private Func<string, string, string> getSyntax;

		public Func<string, string, string> <>3__getSyntax;

		private Dictionary<string, TValue> baseData;

		public Dictionary<string, TValue> <>3__baseData;

		private <>c__DisplayClass2_0<TValue> <>8__1;

		private Func<TValue, string> getText;

		public Func<TValue, string> <>3__getText;

		private Dictionary<string, TValue> translatedData;

		public Dictionary<string, TValue> <>3__translatedData;

		public TranslationValidator <>4__this;

		private Dictionary<string, TValue>.Enumerator <>7__wrap1;

		TranslationValidatorResult IEnumerator<TranslationValidatorResult>.Current
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
		public <Compare>d__2(int <>1__state)
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
		IEnumerator<TranslationValidatorResult> IEnumerable<TranslationValidatorResult>.GetEnumerator()
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

	private readonly SyntaxAbstractor Abstractor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<TranslationValidatorResult> Compare<TValue>(Dictionary<string, TValue> baseData, Dictionary<string, TValue> translatedData, Func<TValue, string> getText, string baseAssetName)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(<Compare>d__2<>))]
	public IEnumerable<TranslationValidatorResult> Compare<TValue>(Dictionary<string, TValue> baseData, Dictionary<string, TValue> translatedData, Func<TValue, string> getText, Func<string, string, string> getSyntax)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TranslationValidatorResult CompareEntry(string key, string baseText, string translationText, Func<string, string> getSyntax)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ValidateGenderSwitchBlocks(string text, out string error, out string errorBlock)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDiffIndex(string baseText, string translatedText)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TranslationValidator()
	{
	}
}
