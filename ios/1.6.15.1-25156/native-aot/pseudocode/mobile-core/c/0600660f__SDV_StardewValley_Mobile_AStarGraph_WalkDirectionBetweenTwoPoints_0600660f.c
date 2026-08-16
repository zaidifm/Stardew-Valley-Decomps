/* 0x0600660f StardewValley.Mobile.AStarGraph.WalkDirectionBetweenTwoPoints @ 0x101fa391c */

int SDV_StardewValley_Mobile_AStarGraph_WalkDirectionBetweenTwoPoints_0600660f
              (float param_1,float param_2,float param_3,float param_4,float param_5)

{
  int iVar1;
  bool bVar2;
  float fVar3;
  float fVar4;
  
  fVar3 = ABS(param_1 - param_3);
  fVar4 = ABS(param_2 - param_4);
  if ((((param_3 < param_1) && (param_4 < param_2)) && (param_5 <= fVar3)) && (param_5 <= fVar4)) {
    return 5;
  }
  if (((param_1 < param_3) && (param_4 < param_2)) && ((param_5 <= fVar3 && (param_5 <= fVar4)))) {
    return 6;
  }
  if (((param_3 < param_1) && (param_2 < param_4)) && ((param_5 <= fVar3 && (param_5 <= fVar4)))) {
    return 7;
  }
  if ((((param_1 < param_3) && (param_2 < param_4)) && (param_5 <= fVar3)) && (param_5 <= fVar4)) {
    return 8;
  }
  if ((param_4 < param_2) && (fVar3 < fVar4)) {
    return 1;
  }
  iVar1 = (uint)(param_1 < param_3) << 2;
  if (param_3 < param_1) {
    iVar1 = 3;
  }
  bVar2 = false;
  if ((fVar3 < fVar4) && (bVar2 = false, !NAN(param_2) && !NAN(param_4))) {
    bVar2 = param_2 < param_4;
  }
  if (bVar2) {
    iVar1 = 2;
  }
  return iVar1;
}

