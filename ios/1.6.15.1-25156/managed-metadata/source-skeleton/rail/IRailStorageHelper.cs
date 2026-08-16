using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailStorageHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailFile OpenFile(string filename, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailFile OpenFile(string filename);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailFile CreateFile(string filename, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailFile CreateFile(string filename);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsFileExist(string filename);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool ListFiles(List<string> filelist);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult RemoveFile(string filename);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsFileSyncedToCloud(string filename);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetFileTimestamp(string filename, out ulong time_stamp);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetFileCount();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetFileNameAndSize(uint file_index, out string filename, out ulong file_size);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncQueryQuota();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetSyncFileOption(string filename, RailSyncFileOption option);

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsCloudStorageEnabledForApp();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsCloudStorageEnabledForPlayer();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncPublishFileToUserSpace(RailPublishFileToUserSpaceOption option, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailStreamFile OpenStreamFile(string filename, RailStreamFileOption option, out RailResult result);

	[MethodImpl(MethodImplOptions.NoInlining)]
	IRailStreamFile OpenStreamFile(string filename, RailStreamFileOption option);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncListStreamFiles(string contents, RailListStreamFileOption option, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncRenameStreamFile(string old_filename, string new_filename, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncDeleteStreamFile(string filename, string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetRailFileEnabledOS(string filename);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetRailFileEnabledOS(string filename, EnumRailStorageFileEnabledOS sync_os);
}
