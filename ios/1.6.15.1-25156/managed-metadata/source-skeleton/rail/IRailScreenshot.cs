using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailScreenshot : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetLocation(string location);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool SetUsers(List<RailID> users);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool AssociatePublishedFiles(List<SpaceWorkID> work_files);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncPublishScreenshot(string work_name, string user_data);
}
