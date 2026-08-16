using System.Runtime.CompilerServices;

namespace rail;

public interface IRailBrowserHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data, CreateBrowserOptions options, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data, CreateBrowserOptions options);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailBrowser AsyncCreateBrowser(string url, uint window_width, uint window_height, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data, CreateCustomerDrawBrowserOptions options, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data, CreateCustomerDrawBrowserOptions options);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailBrowserRender CreateCustomerDrawBrowser(string url, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult NavigateWebPage(string url, bool display_in_new_tab);
}
