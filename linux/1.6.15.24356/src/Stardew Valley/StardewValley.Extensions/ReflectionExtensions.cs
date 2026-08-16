using System;
using System.Reflection;
using Sickhead.Engine.Util;

namespace StardewValley.Extensions;

public static class ReflectionExtensions
{
	public static bool TrySetValueFromString(this MemberInfo info, object obj, string rawValue, object[] index, out string error)
	{
		Type type;
		bool flag;
		if (!(info is FieldInfo fieldInfo))
		{
			if (!(info is PropertyInfo propertyInfo))
			{
				error = "the member is not a field or property";
				return false;
			}
			type = propertyInfo.PropertyType;
			flag = propertyInfo.CanWrite;
		}
		else
		{
			type = fieldInfo.FieldType;
			flag = !fieldInfo.IsLiteral && !fieldInfo.IsLiteral;
		}
		if (!flag)
		{
			error = "the " + ((info is FieldInfo) ? "field" : "property") + " property is read-only";
			return false;
		}
		object value;
		try
		{
			value = Convert.ChangeType(rawValue, type);
		}
		catch (FormatException)
		{
			error = $"can't convert value '{rawValue}' to the '{type.FullName}' type";
			return false;
		}
		try
		{
			info.SetValue(obj, value, index);
			error = null;
			return true;
		}
		catch (Exception ex2)
		{
			error = ex2.Message;
			return false;
		}
	}
}
