using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace StardewValley.GameData.Pets;

public class PetBehavior
{
	public string Id;

	[ContentSerializer(Optional = true)]
	public bool IsSideBehavior;

	[ContentSerializer(Optional = true)]
	public bool RandomizeDirection;

	[ContentSerializer(Optional = true)]
	public string Direction;

	[ContentSerializer(Optional = true)]
	public bool WalkInDirection;

	[ContentSerializer(Optional = true)]
	public int MoveSpeed = -1;

	[ContentSerializer(Optional = true)]
	public string SoundOnStart;

	[ContentSerializer(Optional = true)]
	public int SoundRangeFromBorder = -1;

	[ContentSerializer(Optional = true)]
	public int SoundRange = -1;

	[ContentSerializer(Optional = true)]
	public bool SoundIsVoice;

	[ContentSerializer(Optional = true)]
	public int Shake;

	[ContentSerializer(Optional = true)]
	public List<PetAnimationFrame> Animation;

	[ContentSerializer(Optional = true)]
	public PetAnimationLoopMode LoopMode;

	[ContentSerializer(Optional = true)]
	public int AnimationMinimumLoops = -1;

	[ContentSerializer(Optional = true)]
	public int AnimationMaximumLoops = -1;

	[ContentSerializer(Optional = true)]
	public List<PetBehaviorChanges> AnimationEndBehaviorChanges;

	[ContentSerializer(Optional = true)]
	public int Duration = -1;

	[ContentSerializer(Optional = true)]
	public int MinimumDuration = -1;

	[ContentSerializer(Optional = true)]
	public int MaximumDuration = -1;

	[ContentSerializer(Optional = true)]
	public List<PetBehaviorChanges> TimeoutBehaviorChanges;

	[ContentSerializer(Optional = true)]
	public List<PetBehaviorChanges> PlayerNearbyBehaviorChanges;

	[ContentSerializer(Optional = true)]
	public float RandomBehaviorChangeChance;

	[ContentSerializer(Optional = true)]
	public List<PetBehaviorChanges> RandomBehaviorChanges;

	[ContentSerializer(Optional = true)]
	public List<PetBehaviorChanges> JumpLandBehaviorChanges;
}
