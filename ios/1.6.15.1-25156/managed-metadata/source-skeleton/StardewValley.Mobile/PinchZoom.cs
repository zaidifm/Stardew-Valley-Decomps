using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

namespace StardewValley.Mobile;

public sealed class PinchZoom
{
	private const float MAX_ZOOM = 4f;

	private float _startDistanceBetweenTouchPoints;

	private float _startRealDistance;

	private float _pinchZoomLevel;

	private bool _isPinching;

	private float _farmerStartX;

	private float _farmerStartY;

	private float _screenCenterX;

	private float _screenCenterY;

	private float _pinchCenterX;

	private float _pinchCenterY;

	private float _startPinchPercentX;

	private float _startPinchPercentY;

	private Vector2 _pinchPointA;

	private Vector2 _pinchPointB;

	private Vector2 _startPinchMidPoint;

	private Vector2 _pinchMidPoint;

	private float _dragDistanceX;

	private float _dragDistanceY;

	private float _newViewportWidth;

	private float _newViewportHeight;

	private float _lastPinchZoomLevel;

	private static PinchZoom _instance;

	private static readonly object _padlock;

	public bool justPinchZoomed;

	private float _dragDistanceXSinceLastUpdate;

	private float _dragDistanceYSinceLastUpdate;

	private Vector2 _oldViewportTarget;

	public static PinchZoom Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public float MinZoom
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public float ZoomLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
		}
	}

	public bool Pinching
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	private bool ZoomingAllowed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetZoomLevel(float zoom)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckForPinchZoom()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Center()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CenterOnPinch()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CenterOnScreen()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CenterOnFarmer()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PinchZoom()
	{
	}
}
