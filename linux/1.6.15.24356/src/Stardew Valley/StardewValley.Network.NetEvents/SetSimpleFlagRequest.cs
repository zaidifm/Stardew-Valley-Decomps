using System.IO;
using StardewValley.Extensions;

namespace StardewValley.Network.NetEvents;

public sealed class SetSimpleFlagRequest : BaseSetFlagRequest
{
	public SimpleFlagType FlagType { get; private set; }

	public SetSimpleFlagRequest()
	{
	}

	public SetSimpleFlagRequest(SimpleFlagType flagType, PlayerActionTarget target, string flagId, bool flagState, long? onlyPlayerId)
		: base(target, flagId, flagState, onlyPlayerId)
	{
		FlagType = flagType;
	}

	public override void Read(BinaryReader reader)
	{
		base.Read(reader);
		FlagType = (SimpleFlagType)reader.ReadByte();
	}

	public override void Write(BinaryWriter writer)
	{
		base.Write(writer);
		writer.Write((byte)FlagType);
	}

	public override void PerformAction(Farmer farmer)
	{
		switch (FlagType)
		{
		case SimpleFlagType.ActionApplied:
			farmer.triggerActionsRun.Toggle(base.FlagId, base.FlagState);
			break;
		case SimpleFlagType.CookingRecipeKnown:
			if (base.FlagState)
			{
				farmer.cookingRecipes.TryAdd(base.FlagId, 0);
			}
			else
			{
				farmer.cookingRecipes.Remove(base.FlagId);
			}
			break;
		case SimpleFlagType.CraftingRecipeKnown:
			if (base.FlagState)
			{
				farmer.craftingRecipes.TryAdd(base.FlagId, 0);
			}
			else
			{
				farmer.craftingRecipes.Remove(base.FlagId);
			}
			break;
		case SimpleFlagType.DialogueAnswerSelected:
			farmer.dialogueQuestionsAnswered.Toggle(base.FlagId, base.FlagState);
			break;
		case SimpleFlagType.EventSeen:
			farmer.eventsSeen.Toggle(base.FlagId, base.FlagState);
			break;
		case SimpleFlagType.HasQuest:
			if (base.FlagState)
			{
				farmer.addQuest(base.FlagId);
			}
			else
			{
				farmer.removeQuest(base.FlagId);
			}
			break;
		case SimpleFlagType.SongHeard:
			farmer.songsHeard.Toggle(base.FlagId, base.FlagState);
			break;
		}
	}
}
