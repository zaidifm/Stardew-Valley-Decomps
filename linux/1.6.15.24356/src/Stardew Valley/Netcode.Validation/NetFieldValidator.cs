using System;
using System.Collections.Generic;
using System.Reflection;

namespace Netcode.Validation;

public static class NetFieldValidator
{
	public static void ValidateNetFields(INetObject<NetFields> owner, Action<string> onError)
	{
		string name = owner.NetFields.Name;
		HashSet<INetSerializable> trackedFields = new HashSet<INetSerializable>(owner.NetFields.GetFields(), ReferenceEqualityComparer.Instance);
		List<NetFieldValidatorEntry> list = new List<NetFieldValidatorEntry>();
		FieldInfo[] fields = owner.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		foreach (FieldInfo field in fields)
		{
			if (!NetFieldValidatorEntry.TryGetNetField(owner, field, out var netField))
			{
				continue;
			}
			if (netField.IsMarkedNotNetField())
			{
				if (!IsInCollection(trackedFields, netField))
				{
					continue;
				}
				onError(GetFieldError(name, netField, "is marked [NotNetFieldAttribute] but still added to the collection"));
			}
			list.Add(netField);
		}
		foreach (NetFieldValidatorEntry item in list)
		{
			if (item.Value == null)
			{
				onError(GetFieldError(name, item, "is null"));
			}
			else if (string.IsNullOrWhiteSpace(item.Name))
			{
				onError(GetFieldError(name, item, "has no name (and likely isn't in the collection)"));
			}
			else if (!IsInCollection(trackedFields, item.Value))
			{
				onError(GetFieldError(name, item, "isn't in the collection"));
			}
		}
	}

	private static string GetFieldError(string collectionName, NetFieldValidatorEntry entry, string phrase)
	{
		return $"The owner of {"NetFields"} collection '{collectionName}' has field '{entry.FromField.Name}' which {phrase}.";
	}

	private static bool IsInCollection(HashSet<INetSerializable> trackedFields, object netField)
	{
		if (!(netField is INetSerializable item))
		{
			if (netField is INetObject<NetFields> netObject)
			{
				return trackedFields.Contains(netObject.NetFields);
			}
			return false;
		}
		return trackedFields.Contains(item);
	}
}
