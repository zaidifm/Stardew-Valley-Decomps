using System.Runtime.CompilerServices;

namespace rail;

public interface IRailBrowser : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GetCurrentUrl(out string url);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ReloadWithUrl(string new_url);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ReloadWithUrl();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void StopLoad();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool AddJavascriptEventListener(string event_name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool RemoveAllJavascriptEventListener();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void AllowNavigateNewPage(bool allow);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void Close();
}
