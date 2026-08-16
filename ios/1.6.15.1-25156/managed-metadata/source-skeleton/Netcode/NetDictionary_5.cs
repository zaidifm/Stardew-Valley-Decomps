using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace Netcode;

public abstract class NetDictionary<TKey, TValue, TField, TSerialDict, TSelf> : AbstractNetSerializable, IEquatable<TSelf>, IEnumerable<TSerialDict>, IEnumerable where TField : class, INetObject<INetSerializable>, new() where TSerialDict : IDictionary<TKey, TValue>, new() where TSelf : NetDictionary<TKey, TValue, TField, TSerialDict, TSelf>
{
	public class IncomingChange
	{
		public uint Tick;

		public bool Removal;

		public TKey Key;

		public TField Field;

		public NetVersion Reassigned;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IncomingChange(uint tick, bool removal, TKey key, TField field, NetVersion reassigned)
		{
		}
	}

	public class OutgoingChange
	{
		public bool Removal;

		public TKey Key;

		public TField Field;

		public NetVersion Reassigned;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutgoingChange(bool removal, TKey key, TField field, NetVersion reassigned)
		{
		}
	}

	public delegate void ContentsChangeEvent(TKey key, TValue value);

	public delegate void ConflictResolveEvent(TKey key, TField rejected, TField accepted);

	public delegate void ContentsUpdateEvent(TKey key, TValue old_target_value, TValue new_target_value);

	private delegate void ReadFunc(BinaryReader reader, NetVersion version);

	private delegate void WriteFunc<T>(BinaryWriter writer, T value);

	public struct PairsCollection : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		public struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
		{
			private readonly NetDictionary<TKey, TValue, TField, TSerialDict, TSelf> _net;

			private Dictionary<TKey, TField>.Enumerator _enumerator;

			private KeyValuePair<TKey, TValue> _current;

			private bool _done;

			public KeyValuePair<TKey, TValue> Current
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
			public Enumerator(NetDictionary<TKey, TValue, TField, TSerialDict, TSelf> net)
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

		private NetDictionary<TKey, TValue, TField, TSerialDict, TSelf> _net;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PairsCollection(NetDictionary<TKey, TValue, TField, TSerialDict, TSelf> net)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int Count()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyValuePair<TKey, TValue> ElementAt(int index)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Enumerator GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public struct ValuesCollection : IEnumerable<TValue>, IEnumerable
	{
		public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
		{
			private readonly NetDictionary<TKey, TValue, TField, TSerialDict, TSelf> _net;

			private Dictionary<TKey, TField>.Enumerator _enumerator;

			private TValue _current;

			private bool _done;

			public TValue Current
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
			public Enumerator(NetDictionary<TKey, TValue, TField, TSerialDict, TSelf> net)
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

		private NetDictionary<TKey, TValue, TField, TSerialDict, TSelf> _net;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ValuesCollection(NetDictionary<TKey, TValue, TField, TSerialDict, TSelf> net)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Enumerator GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public struct KeysCollection : IEnumerable<TKey>, IEnumerable
	{
		public struct Enumerator : IEnumerator<TKey>, IEnumerator, IDisposable
		{
			private readonly Dictionary<TKey, TField> _dict;

			private Dictionary<TKey, TField>.Enumerator _enumerator;

			private TKey _current;

			private bool _done;

			public TKey Current
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
			public Enumerator(Dictionary<TKey, TField> dict)
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

		private Dictionary<TKey, TField> _dict;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeysCollection(Dictionary<TKey, TField> dict)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Any()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TKey First()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Contains(TKey key)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Enumerator GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerator IEnumerable.GetEnumerator()
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[CompilerGenerated]
	private sealed class <updates>d__92 : IEnumerable<OutgoingChange>, IEnumerable, IEnumerator<OutgoingChange>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private OutgoingChange <>2__current;

		private int <>l__initialThreadId;

		public NetDictionary<TKey, TValue, TField, TSerialDict, TSelf> <>4__this;

		private Dictionary<TKey, TField>.Enumerator <>7__wrap1;

		private IEnumerator<OutgoingChange> <>7__wrap2;

		OutgoingChange IEnumerator<OutgoingChange>.Current
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
		public <updates>d__92(int <>1__state)
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
		IEnumerator<OutgoingChange> IEnumerable<OutgoingChange>.GetEnumerator()
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

	public bool InterpolationWait;

	private Dictionary<TKey, TField> dict;

	private Dictionary<TKey, NetVersion> dictReassigns;

	private List<OutgoingChange> outgoingChanges;

	private List<IncomingChange> incomingChanges;

	[CompilerGenerated]
	private ContentsChangeEvent m_OnValueAdded;

	[CompilerGenerated]
	private ContentsChangeEvent m_OnValueRemoved;

	[CompilerGenerated]
	private ContentsUpdateEvent m_OnValueTargetUpdated;

	[CompilerGenerated]
	private ConflictResolveEvent m_OnConflictResolve;

	public int Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsReadOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public TValue this[TKey key]
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

	public KeysCollection Keys
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public ValuesCollection Values
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public PairsCollection Pairs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public Dictionary<TKey, TField> FieldDict
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public event ContentsChangeEvent OnValueAdded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ContentsChangeEvent OnValueRemoved
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ContentsUpdateEvent OnValueTargetUpdated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ConflictResolveEvent OnConflictResolve
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		add
		{
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Any()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetDictionary()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetDictionary(IEnumerable<KeyValuePair<TKey, TValue>> dict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override bool tickImpl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract void setFieldValue(TField field, TKey key, TValue value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract TValue getFieldValue(TField field);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract TValue getFieldTargetValue(TField field);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected TField createField(TKey key, TValue value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyFrom(IEnumerable<KeyValuePair<TKey, TValue>> dict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Set(IEnumerable<KeyValuePair<TKey, TValue>> dict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveFrom(TSelf dict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEqualityComparer(IEqualityComparer<TKey> comparer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void setFieldParent(TField arg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void added(TKey key, TField field, NetVersion reassign)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void addedEvent(TKey key, TField field)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void updatedEvent(TKey key, TValue old_target_value, TValue new_target_value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void clearFieldParent(TField arg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void removed(TKey key, TField field, NetVersion reassign)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void removedEvent(TKey key, TField field)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(TKey key, TValue value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(TKey key, TField field)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryAdd(TKey key, TValue value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsKey(TKey key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Count()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(TKey key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int RemoveWhere(Func<KeyValuePair<TKey, TValue>, bool> match)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete("Use RemoveWhere instead.")]
	public void Filter(Func<KeyValuePair<TKey, TValue>, bool> f)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetValue(TKey key, out TValue value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TValue GetValueOrDefault(TKey key, TValue defaultValue = default(TValue))
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Equals(TSelf other)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void CleanImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract TKey ReadKey(BinaryReader reader);

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract void WriteKey(BinaryWriter writer, TKey key);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void readMultiple(ReadFunc readFunc, BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void writeMultiple<T>(WriteFunc<T> writeFunc, BinaryWriter writer, IEnumerable<T> values)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual TField ReadFieldFull(BinaryReader reader, NetVersion version)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void WriteFieldFull(BinaryWriter writer, TField field)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void readAddition(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool resolveConflict(TKey key, TField currentField, NetVersion currentReassign, TField incomingField, NetVersion incomingReassign)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private KeyValuePair<NetVersion, TField>? findConflict(TKey key)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void queueIncomingChange(bool removal, TKey key, TField field, NetVersion fieldReassign)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performIncomingAdd(IncomingChange add)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void readRemoval(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void readDictChange(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void performIncomingRemove(IncomingChange remove)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void readUpdate(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Read(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ReadFull(BinaryReader reader, NetVersion version)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void writeAddition(BinaryWriter writer, OutgoingChange update)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void writeRemoval(BinaryWriter writer, OutgoingChange update)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void writeDictChange(BinaryWriter writer, OutgoingChange ch)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void writeUpdate(BinaryWriter writer, OutgoingChange update)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(NetDictionary<, , , , >.<updates>d__92))]
	private IEnumerable<OutgoingChange> updates()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void WriteFull(BinaryWriter writer)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<TSerialDict> GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ForEachChild(Action<INetSerializable> childAction)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(TSerialDict dict)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ValidateChildren()
	{
	}
}
