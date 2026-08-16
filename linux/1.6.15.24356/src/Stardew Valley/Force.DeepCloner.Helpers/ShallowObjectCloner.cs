using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Force.DeepCloner.Helpers;

public abstract class ShallowObjectCloner
{
	private class ShallowSafeObjectCloner : ShallowObjectCloner
	{
		private static readonly Func<object, object> _cloneFunc;

		static ShallowSafeObjectCloner()
		{
			MethodInfo privateMethod = typeof(object).GetPrivateMethod("MemberwiseClone");
			ParameterExpression parameterExpression = Expression.Parameter(typeof(object));
			_cloneFunc = Expression.Lambda<Func<object, object>>(Expression.Call(parameterExpression, privateMethod), new ParameterExpression[1] { parameterExpression }).Compile();
		}

		protected override object DoCloneObject(object obj)
		{
			return _cloneFunc(obj);
		}
	}

	private static readonly ShallowObjectCloner _unsafeInstance;

	private static ShallowObjectCloner _instance;

	protected abstract object DoCloneObject(object obj);

	public static object CloneObject(object obj)
	{
		return _instance.DoCloneObject(obj);
	}

	internal static bool IsSafeVariant()
	{
		return _instance is ShallowSafeObjectCloner;
	}

	static ShallowObjectCloner()
	{
		_instance = new ShallowSafeObjectCloner();
		_unsafeInstance = _instance;
	}

	internal static void SwitchTo(bool isSafe)
	{
		DeepClonerCache.ClearCache();
		if (isSafe)
		{
			_instance = new ShallowSafeObjectCloner();
		}
		else
		{
			_instance = _unsafeInstance;
		}
	}
}
