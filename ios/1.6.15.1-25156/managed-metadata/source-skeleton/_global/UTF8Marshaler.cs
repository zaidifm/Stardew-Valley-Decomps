using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class UTF8Marshaler : ICustomMarshaler
{
	private static UTF8Marshaler instance_;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public nint MarshalManagedToNative(object obj)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public object MarshalNativeToManaged(nint data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CleanUpNativeData(nint data)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CleanUpManagedData(object obj)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetNativeDataSize()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ICustomMarshaler GetInstance(string cookie)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string MarshalNativeToString(nint data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UTF8Marshaler()
	{
	}
}
