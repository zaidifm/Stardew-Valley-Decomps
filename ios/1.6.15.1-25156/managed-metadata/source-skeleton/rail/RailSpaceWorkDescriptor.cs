using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailSpaceWorkDescriptor
{
	public List<RailSpaceWorkVoteDetail> vote_details;

	public string description;

	public string preview_scaling_url;

	public string recommendation_rate;

	public string preview_url;

	public SpaceWorkID id;

	public uint create_time;

	public string detail_url;

	public List<RailID> uploader_ids;

	public string name;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailSpaceWorkDescriptor()
	{
	}
}
