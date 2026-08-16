using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CloudKit;
using StardewValley.Menus;

namespace StardewValley;

public class CloudSync
{
	private class SaveRecord
	{
		public string FarmName;

		public string Title;

		public DateTime Timestamp;

		public string ChangeTag;

		public int DirtyCount;

		public string Path;

		public byte[] Data;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveRecord()
		{
		}
	}

	private class SaveConflict
	{
		public SaveRecord Cloud;

		public SaveRecord Local;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SaveConflict()
		{
		}
	}

	private readonly object _locker;

	private Task _sync;

	private float _progress;

	private bool _requestStop;

	private bool _syncDisabled;

	private bool _showSyncMenu;

	private CloudSyncMenu _syncMenu;

	private readonly List<string> _cloudDelete;

	private readonly List<string> _cloudSave;

	private const string Save_RecordType = "SV1_Save";

	private const string ContainerId = "iCloud.com.concernedape.stardewvalley";

	private const string TimeField = "Time";

	private const string DataField = "Data";

	private const string Data_RecordType = "SV1_Data";

	public CloudSyncMenu SyncMenu
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsSyncing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public int Progress
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	public bool IsStopping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestStop()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BeginSync(bool skipConflicts = false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Wait()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteSave(string path)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UploadSave(string path)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveRecord ShowConflictBox(SaveRecord cloud, SaveRecord local)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SyncTask()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool GatherSyncOps(out List<SaveRecord> localUpload, out List<SaveRecord> cloudDownload, out List<SaveRecord> localDelete, out List<SaveConflict> conflicts)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void ReadSyncronizedState(string save, out string syncronizedChangeTag, out int dirtyCount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void WriteSyncronizedState(string save, string syncronizedChangeTag, int dirtyCount)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void DeleteSyncronizedState(string save)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool UploadToCloud(SaveRecord save)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SafeDelete(string file)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private SaveRecord CompressSave(SaveRecord save)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool DownloadCloudSave(SaveRecord save)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static DateTime GetTimestamp(string filepath)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<SaveRecord> GetLocalSaves()
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void GetDbAndZoneId(out CKDatabase db, out CKRecordZoneID zoneId)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool QureryCloudSaves(out List<SaveRecord> outSaves)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DeleteCloudSaves()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void DeleteLocalSave(string save)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void GetSaveInfoAndFarmer(string saveDir, out string title, out string infoFile, out string farmerFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void GetInfoAndFarmerFromTitle(string title, out string folder, out string infoFile, out string farmerFile)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool GetNameAndSeedFromTitle(string title, out string farmName, out int seed)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CloudSync()
	{
	}
}
