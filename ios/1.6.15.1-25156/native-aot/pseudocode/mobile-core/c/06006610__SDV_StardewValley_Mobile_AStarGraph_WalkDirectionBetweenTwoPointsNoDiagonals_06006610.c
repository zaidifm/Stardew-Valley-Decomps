/* 0x06006610 StardewValley.Mobile.AStarGraph.WalkDirectionBetweenTwoPointsNoDiagonals @ 0x101fa3a04 */

long SDV_StardewValley_Mobile_AStarGraph_WalkDirectionBetweenTwoPointsNoDiagonals_06006610
               (float param_1,float param_2,float param_3,float param_4)

{
  if ((param_4 < param_2) && (ABS(param_1 - param_3) < ABS(param_2 - param_4))) {
    return 1;
  }
  if ((param_2 < param_4) && (ABS(param_1 - param_3) < ABS(param_2 - param_4))) {
    return 2;
  }
  if (param_1 <= param_3) {
    return (ulong)(param_1 < param_3) << 2;
  }
  return 3;
}

