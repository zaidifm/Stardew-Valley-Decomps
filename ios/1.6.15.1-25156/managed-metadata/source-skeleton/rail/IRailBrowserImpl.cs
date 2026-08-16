using System.Runtime.CompilerServices;

namespace rail;

public class IRailBrowserImpl : RailObject, IRailBrowser, IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailBrowserImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailBrowserImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool GetCurrentUrl(out string url)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ReloadWithUrl(string new_url)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ReloadWithUrl()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StopLoad()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool AddJavascriptEventListener(string event_name)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool RemoveAllJavascriptEventListener()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AllowNavigateNewPage(bool allow)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Close()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual ulong GetComponentVersion()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Release()
	{
	}
}
