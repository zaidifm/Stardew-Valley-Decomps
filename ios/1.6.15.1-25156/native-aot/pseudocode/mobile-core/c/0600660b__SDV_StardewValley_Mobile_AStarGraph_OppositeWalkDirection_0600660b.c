/* 0x0600660b StardewValley.Mobile.AStarGraph.OppositeWalkDirection @ 0x101fa359c */

undefined4
SDV_StardewValley_Mobile_AStarGraph_OppositeWalkDirection_0600660b(undefined8 param_1,int param_2)

{
  if (param_2 - 1U < 8) {
    return *(undefined4 *)(&UNK_103333500 + (long)(int)(param_2 - 1U) * 4);
  }
  return 0;
}

