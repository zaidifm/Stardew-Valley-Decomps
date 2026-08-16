using System.Runtime.CompilerServices;

namespace rail;

public class IRailBrowserRenderImpl : RailObject, IRailBrowserRender, IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal IRailBrowserRenderImpl(nint cPtr)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	~IRailBrowserRenderImpl()
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
	public virtual void UpdateCustomDrawWindowPos(int content_offset_x, int content_offset_y, uint content_window_width, uint content_window_height)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetBrowserActive(bool active)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GoBack()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GoForward()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool ExecuteJavascript(string event_name, string event_value)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DispatchWindowsMessage(uint window_msg, uint w_param, uint l_param)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DispatchMouseMessage(EnumRailMouseActionType button_action, uint user_define_mouse_key, uint x_pos, uint y_pos)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MouseWheel(int delta, uint user_define_mouse_key, uint x_pos, uint y_pos)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetFocus(bool has_focus)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void KeyDown(uint key_code)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void KeyUp(uint key_code)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void KeyChar(uint key_code, bool is_uinchar)
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
