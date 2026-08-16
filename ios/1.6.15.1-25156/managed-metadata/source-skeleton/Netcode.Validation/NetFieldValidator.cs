using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Netcode.Validation;

public static class NetFieldValidator
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ValidateNetFields(INetObject<NetFields> owner, Action<string> onError)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string GetFieldError(string collectionName, NetFieldValidatorEntry entry, string phrase)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool IsInCollection(HashSet<INetSerializable> trackedFields, object netField)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
