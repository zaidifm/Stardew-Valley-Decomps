using System;
using System.Xml.Serialization;
using Netcode;

namespace StardewValley;

public class WorldDate : INetObject<NetFields>
{
	public const int MonthsPerYear = 4;

	public const int DaysPerMonth = 28;

	public const int DaysPerYear = 112;

	private readonly NetInt year = new NetInt(1);

	private readonly NetEnum<Season> season = new NetEnum<Season>(Season.Spring);

	private readonly NetInt dayOfMonth = new NetInt(1);

	public int Year
	{
		get
		{
			return year.Value;
		}
		set
		{
			year.Value = value;
		}
	}

	[XmlIgnore]
	public int SeasonIndex => (int)season.Value;

	public int DayOfMonth
	{
		get
		{
			return dayOfMonth.Value;
		}
		set
		{
			dayOfMonth.Value = value;
		}
	}

	public DayOfWeek DayOfWeek => GetDayOfWeekFor(DayOfMonth);

	[XmlIgnore]
	public Season Season
	{
		get
		{
			return season.Value;
		}
		set
		{
			season.Value = value;
		}
	}

	[XmlElement("Season")]
	public string SeasonKey
	{
		get
		{
			return Utility.getSeasonKey(season.Value);
		}
		set
		{
			if (!Utility.TryParseEnum<Season>(value, out var parsed))
			{
				throw new ArgumentException("Can't parse '" + value + "' as a season key.", "value");
			}
			season.Value = parsed;
		}
	}

	[XmlIgnore]
	public int TotalDays
	{
		get
		{
			return GetDaysPlayed(Year, Season, DayOfMonth);
		}
		set
		{
			int num = value / 28;
			DayOfMonth = value % 28 + 1;
			Season = (Season)(num % 4);
			Year = num / 4 + 1;
		}
	}

	public int TotalWeeks => TotalDays / 7;

	public int TotalSundayWeeks => (TotalDays + 1) / 7;

	public NetFields NetFields { get; } = new NetFields("WorldDate");

	public WorldDate()
	{
		NetFields.SetOwner(this).AddField(year, "year").AddField(season, "season")
			.AddField(dayOfMonth, "dayOfMonth");
	}

	public WorldDate(WorldDate other)
		: this()
	{
		Year = other.Year;
		Season = other.Season;
		DayOfMonth = other.DayOfMonth;
	}

	public WorldDate(int year, Season season, int dayOfMonth)
		: this()
	{
		Year = year;
		Season = season;
		DayOfMonth = dayOfMonth;
	}

	public WorldDate(int year, string seasonKey, int dayOfMonth)
		: this()
	{
		Year = year;
		SeasonKey = seasonKey;
		DayOfMonth = dayOfMonth;
	}

	public string Localize()
	{
		return Utility.getDateStringFor(DayOfMonth, SeasonIndex, Year);
	}

	public override string ToString()
	{
		return $"Year {Year}, {SeasonKey} {DayOfMonth}, {DayOfWeek}";
	}

	public override bool Equals(object obj)
	{
		if (obj is WorldDate worldDate)
		{
			return TotalDays == worldDate.TotalDays;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return TotalDays;
	}

	public static bool operator ==(WorldDate a, WorldDate b)
	{
		return a?.TotalDays == b?.TotalDays;
	}

	public static bool operator !=(WorldDate a, WorldDate b)
	{
		return a?.TotalDays != b?.TotalDays;
	}

	public static bool operator <(WorldDate a, WorldDate b)
	{
		return a?.TotalDays < b?.TotalDays;
	}

	public static bool operator >(WorldDate a, WorldDate b)
	{
		return a?.TotalDays > b?.TotalDays;
	}

	public static bool operator <=(WorldDate a, WorldDate b)
	{
		return a?.TotalDays <= b?.TotalDays;
	}

	public static bool operator >=(WorldDate a, WorldDate b)
	{
		return a?.TotalDays >= b?.TotalDays;
	}

	public static DayOfWeek GetDayOfWeekFor(int dayOfMonth)
	{
		return (DayOfWeek)(dayOfMonth % 7);
	}

	public static WorldDate Now()
	{
		return new WorldDate(Game1.year, Game1.season, Game1.dayOfMonth);
	}

	public static WorldDate ForDaysPlayed(int daysPlayed)
	{
		return new WorldDate
		{
			TotalDays = daysPlayed
		};
	}

	public static int GetDaysPlayed(int year, Season season, int dayOfMonth)
	{
		return (int)((year - 1) * 4 + season) * 28 + (dayOfMonth - 1);
	}

	public static bool TryGetDayOfWeekFor(string day, out DayOfWeek dayOfWeek)
	{
		if (int.TryParse(day, out var result))
		{
			dayOfWeek = GetDayOfWeekFor(result);
			return true;
		}
		switch (day?.ToLower())
		{
		case "mon":
		case "monday":
			dayOfWeek = DayOfWeek.Monday;
			return true;
		case "tue":
		case "tuesday":
			dayOfWeek = DayOfWeek.Tuesday;
			return true;
		case "wed":
		case "wednesday":
			dayOfWeek = DayOfWeek.Wednesday;
			return true;
		case "thu":
		case "thursday":
			dayOfWeek = DayOfWeek.Thursday;
			return true;
		case "fri":
		case "friday":
			dayOfWeek = DayOfWeek.Friday;
			return true;
		case "sat":
		case "saturday":
			dayOfWeek = DayOfWeek.Saturday;
			return true;
		case "sun":
		case "sunday":
			dayOfWeek = DayOfWeek.Sunday;
			return true;
		default:
			dayOfWeek = DayOfWeek.Sunday;
			return false;
		}
	}
}
