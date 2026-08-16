using System;
using System.Reflection;

namespace Netcode.Validation;

public class NetFieldValidatorEntry
{
	public string Name { get; }

	public object Value { get; }

	public FieldInfo FromField { get; }

	public NetFieldValidatorEntry(string name, object value, FieldInfo fromField)
	{
		Name = name;
		Value = value;
		FromField = fromField;
	}

	public static bool TryGetNetField(INetObject<NetFields> owner, FieldInfo field, out NetFieldValidatorEntry netField)
	{
		if (field.Name != "NetFields" && field.Name[0] != '<')
		{
			Type fieldType = field.FieldType;
			if (typeof(INetSerializable).IsAssignableFrom(fieldType) && !IsMarkedNotImplicitNetField(fieldType))
			{
				INetSerializable netSerializable = (INetSerializable)field.GetValue(owner);
				netField = new NetFieldValidatorEntry(netSerializable?.Name, netSerializable, field);
				return true;
			}
			if (typeof(INetObject<NetFields>).IsAssignableFrom(fieldType) && !IsMarkedNotImplicitNetField(fieldType))
			{
				INetObject<NetFields> netObject = (INetObject<NetFields>)field.GetValue(owner);
				netField = new NetFieldValidatorEntry(netObject?.NetFields.Name, netObject, field);
				return true;
			}
		}
		netField = null;
		return false;
	}

	public bool IsMarkedNotNetField()
	{
		return FromField.GetCustomAttribute<NotNetFieldAttribute>() != null;
	}

	public static bool IsMarkedNotImplicitNetField(Type type)
	{
		return type.GetCustomAttribute<NotImplicitNetFieldAttribute>(inherit: true) != null;
	}
}
