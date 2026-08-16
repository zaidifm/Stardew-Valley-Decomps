using System.Runtime.CompilerServices;

namespace rail;

public class RailDlcInfo
{
	public double original_price;

	public RailDlcID dlc_id;

	public string description;

	public double discount_price;

	public string version;

	public EnumRailDlcContentType content_type;

	public RailGameID game_id;

	public string name;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailDlcInfo()
	{
	}
}
