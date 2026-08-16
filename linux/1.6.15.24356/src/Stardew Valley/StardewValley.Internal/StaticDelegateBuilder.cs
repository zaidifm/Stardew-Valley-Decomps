using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace StardewValley.Internal;

public static class StaticDelegateBuilder
{
	private struct CachedDelegate(object createdDelegate, string error)
	{
		public readonly object CreatedDelegate = createdDelegate;

		public readonly string Error = error;
	}

	private static readonly Dictionary<Type, Dictionary<string, CachedDelegate>> CachedDelegates = new Dictionary<Type, Dictionary<string, CachedDelegate>>();

	public static bool TryCreateDelegate<TDelegate>(string fullMethodName, out TDelegate createdDelegate, out string error) where TDelegate : Delegate
	{
		if (string.IsNullOrWhiteSpace(fullMethodName))
		{
			error = "the method name can't be empty";
			createdDelegate = null;
			return false;
		}
		if (!CachedDelegates.TryGetValue(typeof(TDelegate), out var value))
		{
			value = (CachedDelegates[typeof(TDelegate)] = new Dictionary<string, CachedDelegate>());
		}
		if (!value.TryGetValue(fullMethodName, out var value2))
		{
			string[] array = LegacyShims.SplitAndTrim(fullMethodName, ':');
			if (array.Length != 2)
			{
				error = "invalid method name format, expected a type full name and method separated with a colon (:)";
				createdDelegate = null;
				return false;
			}
			string text = array[0];
			string text2 = array[1];
			if (Game1.GameAssemblyName != "Stardew Valley" && text.Contains("Stardew Valley"))
			{
				string[] array2 = LegacyShims.SplitAndTrim(text, ',');
				if (ArgUtility.Get(array2, 1) == "Stardew Valley")
				{
					array2[1] = Game1.GameAssemblyName;
					text = string.Join(", ", array2);
				}
			}
			Type type = Type.GetType(text);
			if (type == null)
			{
				error = "could not find type '" + text + "'";
				createdDelegate = null;
				return false;
			}
			MethodInfo method = type.GetMethod(text2, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			if (method == null)
			{
				error = $"could not find method '{text2}' on type '{text}'";
				createdDelegate = null;
				return false;
			}
			if (!method.IsStatic)
			{
				error = $"found method '{text2}' on type '{text}', but the method isn't static";
				createdDelegate = null;
				return false;
			}
			try
			{
				createdDelegate = (TDelegate)Delegate.CreateDelegate(typeof(TDelegate), null, method);
				error = null;
			}
			catch (ArgumentException)
			{
				MethodInfo method2 = typeof(TDelegate).GetMethod("Invoke");
				createdDelegate = null;
				error = $"failed to bind method '{fullMethodName}': it didn't match the expected signature {method2.ReturnType} method({string.Join(", ", from p in method2.GetParameters()
					select $"{p.ParameterType} {p.Name}")})";
			}
			value2 = (value[fullMethodName] = new CachedDelegate(createdDelegate, error));
		}
		createdDelegate = (TDelegate)value2.CreatedDelegate;
		error = value2.Error;
		return createdDelegate != null;
	}
}
