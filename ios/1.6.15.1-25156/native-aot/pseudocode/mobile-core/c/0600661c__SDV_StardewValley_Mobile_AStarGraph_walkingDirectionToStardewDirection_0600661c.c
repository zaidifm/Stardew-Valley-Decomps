/* 0x0600661c StardewValley.Mobile.AStarGraph.walkingDirectionToStardewDirection @ 0x101fa7538 */

undefined4
SDV_StardewValley_Mobile_AStarGraph_walkingDirectionToStardewDirection_0600661c(int param_1)

{
  if (param_1 - 5U < 0xfffffffc) {
    return 0xffffffff;
  }
  return *(undefined4 *)(&UNK_103333ef0 + (long)(param_1 + -1) * 4);
}

