using System.Runtime.CompilerServices;

namespace rail;

public class IRailBrowserHelperImpl : RailObject, IRailBrowserHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailBrowserHelperImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailBrowserHelperImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data, CreateBrowserOptions options, out RailResult result)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data, CreateBrowserOptions options)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data, CreateCustomerDrawBrowserOptions options, out RailResult result)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data, CreateCustomerDrawBrowserOptions options)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual RailResult NavigateWebPage(string url, bool display_in_new_tab)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}
}
