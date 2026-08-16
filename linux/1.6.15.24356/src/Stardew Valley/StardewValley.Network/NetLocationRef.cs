using System;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley.Network;

public class NetLocationRef : INetObject<NetFields>
{
	public readonly NetString locationName = new NetString();

	public readonly NetBool isStructure = new NetBool();

	protected GameLocation _gameLocation;

	protected bool _dirty = true;

	protected bool _usedLocalLocation;

	[XmlIgnore]
	public Action OnLocationChanged;

	public string LocationName => locationName.Value;

	public bool IsStructure => isStructure.Value;

	[XmlIgnore]
	public GameLocation Value
	{
		get
		{
			return Get();
		}
		set
		{
			Set(value);
		}
	}

	[XmlIgnore]
	public NetFields NetFields { get; } = new NetFields("NetLocationRef");

	public NetLocationRef()
	{
		NetFields.SetOwner(this).AddField(locationName, "locationName").AddField(isStructure, "isStructure");
		locationName.fieldChangeVisibleEvent += delegate
		{
			_dirty = true;
		};
		isStructure.fieldChangeVisibleEvent += delegate
		{
			_dirty = true;
		};
	}

	public NetLocationRef(GameLocation value)
		: this()
	{
		Set(value);
	}

	public bool IsChanging()
	{
		if (!locationName.IsChanging())
		{
			return isStructure.IsChanging();
		}
		return true;
	}

	public void Update(bool forceUpdate = false)
	{
		if (forceUpdate)
		{
			_dirty = true;
		}
		ApplyChangesIfDirty();
	}

	public void ApplyChangesIfDirty()
	{
		if (_usedLocalLocation && _gameLocation != Game1.currentLocation)
		{
			_dirty = true;
			_usedLocalLocation = false;
		}
		if (_dirty)
		{
			_gameLocation = Game1.getLocationFromName(locationName.Value, isStructure.Value);
			_dirty = false;
			OnLocationChanged?.Invoke();
		}
		if (!_usedLocalLocation && _gameLocation != Game1.currentLocation && IsCurrentlyViewedLocation())
		{
			_usedLocalLocation = true;
			_gameLocation = Game1.currentLocation;
		}
	}

	public GameLocation Get()
	{
		ApplyChangesIfDirty();
		return _gameLocation;
	}

	public void Set(GameLocation location)
	{
		if (location == null)
		{
			isStructure.Value = false;
			locationName.Value = "";
		}
		else
		{
			isStructure.Value = location.isStructure.Value;
			locationName.Value = location.NameOrUniqueName;
		}
		if (IsCurrentlyViewedLocation())
		{
			_usedLocalLocation = true;
			_gameLocation = Game1.currentLocation;
		}
		else
		{
			_gameLocation = location;
		}
		if (_gameLocation?.IsTemporary ?? false)
		{
			_gameLocation = null;
		}
		_dirty = false;
	}

	public bool IsCurrentlyViewedLocation()
	{
		if (Game1.currentLocation != null && locationName.Value == Game1.currentLocation.NameOrUniqueName)
		{
			return true;
		}
		return false;
	}
}
