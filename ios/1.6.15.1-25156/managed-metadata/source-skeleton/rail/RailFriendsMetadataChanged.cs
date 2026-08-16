using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public class RailFriendsMetadataChanged : EventBase
{
	public List<RailFriendMetadata> friends_changed_metadata;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RailFriendsMetadataChanged()
	{
	}
}
