using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Netcode;

public abstract class SerializationCollectionFacade<SerialT> : IEnumerable<SerialT>, IEnumerable
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract List<SerialT> Serialize();

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected abstract void DeserializeAdd(SerialT serialElem);

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<SerialT> GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(SerialT value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected SerializationCollectionFacade()
	{
	}
}
