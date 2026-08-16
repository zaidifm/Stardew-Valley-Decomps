using System.Runtime.CompilerServices;

namespace rail;

public interface IRailBrowserRender : IRailComponent
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	void UpdateCustomDrawWindowPos(int content_offset_x, int content_offset_y, uint content_window_width, uint content_window_height);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void SetBrowserActive(bool active);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void GoBack();

	[MethodImpl(MethodImplOptions.NoInlining)]
	void GoForward();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ExecuteJavascript(string event_name, string event_value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void DispatchWindowsMessage(uint window_msg, uint w_param, uint l_param);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void DispatchMouseMessage(EnumRailMouseActionType button_action, uint user_define_mouse_key, uint x_pos, uint y_pos);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void MouseWheel(int delta, uint user_define_mouse_key, uint x_pos, uint y_pos);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void SetFocus(bool has_focus);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void KeyDown(uint key_code);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void KeyUp(uint key_code);

	[MethodImpl(MethodImplOptions.NoInlining)]
	void KeyChar(uint key_code, bool is_uinchar);
}
