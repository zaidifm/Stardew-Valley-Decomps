using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Netcode;
using StardewValley.Network;
using xTile.Dimensions;

namespace StardewValley.BellsAndWhistles;

public class ParrotUpgradePerch : INetObject<NetFields>
{
	public enum UpgradeState
	{
		Idle,
		StartBuilding,
		Building,
		Complete
	}

	public class Parrot
	{
		public Vector2 position;

		public float height;

		protected ParrotUpgradePerch _perch;

		protected Vector2 targetPosition;

		protected Vector2 startPosition;

		public Texture2D texture;

		public bool bounced;

		public bool flipped;

		public bool isPerchedParrot;

		private int baseFrame;

		private int birdType;

		private int flapFrame;

		private float nextFlapTime;

		public float alpha;

		public float moveTime;

		public float moveDuration;

		public bool firstBounce;

		public bool flyAway;

		private bool soundBird;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Parrot(ParrotUpgradePerch perch, Vector2 start_position, bool soundBird = false, bool goldenParrot = false)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void FindNewTarget()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool Update(GameTime time)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private float EaseInOutQuad(float t, float b, float c, float d)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private float EaseInQuad(float t, float b, float c, float d)
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Draw(SpriteBatch b)
		{
		}
	}

	public const string GoldenParrotMailKey = "activateGoldenParrotsTonight";

	public NetEvent0 animationEvent;

	public NetMutex upgradeMutex;

	public NetPoint tilePosition;

	public Texture2D texture;

	public NetRectangle upgradeRect;

	public List<Parrot> parrots;

	public NetEvent0 upgradeCompleteEvent;

	public NetEnum<UpgradeState> currentState;

	public float stateTimer;

	public NetInt requiredNuts;

	public float squawkTime;

	public float timeUntilChomp;

	public float timeUntilSqwawk;

	public float shakeTime;

	public float costShakeTime;

	public const int PARROT_COUNT = 24;

	public bool parrotPresent;

	public bool isPlayerNearby;

	public NetString upgradeName;

	public NetString requiredMail;

	public float nextParrotSpawn;

	public NetLocationRef locationRef;

	public Action onApplyUpgrade;

	public Func<bool> onUpdateCompletionStatus;

	protected bool _cachedAvailablity;

	public NetFields NetFields
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[CompilerGenerated]
		get
		{
			/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParrotUpgradePerch()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateCompletionStatus()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNetFields()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PerformCompleteAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParrotUpgradePerch(GameLocation location, Point tile_position, Microsoft.Xna.Framework.Rectangle upgrade_rectangle, int required_nuts, Action apply_upgrade, Func<bool> update_completion_status, string upgrade_name = "", string required_mail = "")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsAtTile(int x, int y)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PerformAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsAvailable(bool use_cached_value = false)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartAnimation()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckAction(Location tile_location, Farmer farmer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool AnswerQuestion(Response answer)
	{
		/*Error: Method body consists only of 'ret', but nothing is being returned. Decompiled assembly might be a reference assembly.*/;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ActivateGoldenParrot()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AttemptConstruction()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ShowInsufficientNuts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyUpgrade()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Cleanup()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetForPlayerEntry()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void resetCache()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateEvenIfFarmerIsntHere(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(GameTime time)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw(SpriteBatch b)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DrawAboveAlwaysFrontLayer(SpriteBatch b)
	{
	}
}
