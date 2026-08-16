using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace rail;

public interface IRailSpaceWork : IRailComponent
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	void Close();

	[MethodImpl(MethodImplOptions.NoInlining)]
	SpaceWorkID GetSpaceWorkID();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool Editable();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult StartSync(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetSyncProgress(RailSpaceWorkSyncProgress progress);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult CancelSync();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetWorkLocalFolder(out string path);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AsyncUpdateMetadata(string user_data);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetName(out string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetDescription(out string description);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetUrl(out string url);

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetCreateTime();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetLastUpdateTime();

	[MethodImpl(MethodImplOptions.NoInlining)]
	ulong GetWorkFileSize();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetTags(List<string> tags);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetPreviewImage(out string path);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetVersion(out string version);

	[MethodImpl(MethodImplOptions.NoInlining)]
	ulong GetDownloadCount();

	[MethodImpl(MethodImplOptions.NoInlining)]
	ulong GetSubscribedCount();

	[MethodImpl(MethodImplOptions.NoInlining)]
	EnumRailSpaceWorkShareLevel GetShareLevel();

	[MethodImpl(MethodImplOptions.NoInlining)]
	ulong GetScore();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetMetadata(string key, out string value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	EnumRailSpaceWorkRateValue GetMyVote();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsFavorite();

	[MethodImpl(MethodImplOptions.NoInlining)]
	bool IsSubscribed();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetName(string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetDescription(string description);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetTags(List<string> tags);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetPreviewImage(string path_filename);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetVersion(string version);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetShareLevel(EnumRailSpaceWorkShareLevel level);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetShareLevel();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetMetadata(string key, string value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetContentFromFolder(string path);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetAllMetadata(List<RailKeyValue> metadata);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetAdditionalPreviewUrls(List<string> preview_urls);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetAssociatedSpaceWorks(List<SpaceWorkID> ids);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetLanguages(List<string> languages);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult RemoveMetadata(string key);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetAdditionalPreviews(List<string> local_paths);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetAssociatedSpaceWorks(List<SpaceWorkID> ids);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetLanguages(List<string> languages);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetPreviewUrl(out string url, uint scaling);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetPreviewUrl(out string url);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetVoteDetail(List<RailSpaceWorkVoteDetail> vote_details);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetUploaderIDs(List<RailID> uploader_ids);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult SetUpdateOptions(RailSpaceWorkUpdateOptions options);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetStatistic(EnumRailSpaceWorkStatistic stat_type, out ulong value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult RemovePreviewImage();

	[MethodImpl(MethodImplOptions.NoInlining)]
	uint GetState();

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult AddAssociatedGameIDs(List<RailGameID> game_ids);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult RemoveAssociatedGameIDs(List<RailGameID> game_ids);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetAssociatedGameIDs(List<RailGameID> game_ids);

	[MethodImpl(MethodImplOptions.NoInlining)]
	RailResult GetLocalVersion(out string version);
}
