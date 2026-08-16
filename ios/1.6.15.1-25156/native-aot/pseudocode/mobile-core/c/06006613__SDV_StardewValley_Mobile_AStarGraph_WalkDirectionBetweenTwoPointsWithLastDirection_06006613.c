/* 0x06006613 StardewValley.Mobile.AStarGraph.WalkDirectionBetweenTwoPointsWithLastDirection @ 0x101fa3c84 */

undefined4
SDV_StardewValley_Mobile_AStarGraph_WalkDirectionBetweenTwoPointsWithLastDirection_06006613
          (float param_1,float param_2,float param_3,float param_4,float param_5,undefined8 param_6,
          uint param_7)

{
  undefined4 uVar1;
  float fVar2;
  float fVar3;
  
  fVar2 = ABS(param_2 - param_4);
  fVar3 = ABS(param_1 - param_3);
  if (((((param_3 < param_1) && (param_4 < param_2)) && (param_5 <= fVar3)) &&
      ((param_5 <= fVar2 && (param_7 < 6)))) && ((0x2bU >> (ulong)(param_7 & 0x1f) & 1) != 0)) {
    return 5;
  }
  if (((param_1 < param_3) && (param_4 < param_2)) &&
     ((param_5 <= fVar3 &&
      (((param_5 <= fVar2 && (param_7 < 7)) && ((0x53U >> (ulong)(param_7 & 0x1f) & 1) != 0)))))) {
    return 6;
  }
  if (((param_3 < param_1) && (param_2 < param_4)) &&
     (((param_5 <= fVar3 && ((param_5 <= fVar2 && (param_7 < 8)))) &&
      ((0x8dU >> (ulong)(param_7 & 0x1f) & 1) != 0)))) {
    return 7;
  }
  if ((((param_1 < param_3) && (param_2 < param_4)) && (param_5 <= fVar3)) &&
     (((param_5 <= fVar2 && (param_7 < 9)) && ((0x115U >> (ulong)(param_7 & 0x1f) & 1) != 0)))) {
    return 8;
  }
  if (((param_2 <= param_4) || (fVar2 < param_5)) ||
     ((6 < param_7 || ((99U >> (ulong)(param_7 & 0x1f) & 1) == 0)))) {
    if ((((param_2 < param_4) && (param_5 <= fVar2)) && (param_7 < 9)) &&
       ((0x185U >> (ulong)(param_7 & 0x1f) & 1) != 0)) {
      return 2;
    }
    if (((param_3 < param_1) && (param_7 < 8)) && ((0xa9U >> (ulong)(param_7 & 0x1f) & 1) != 0)) {
      return 3;
    }
    uVar1 = 0;
    if ((param_1 < param_3) && (param_7 < 9)) {
      return *(undefined4 *)(&UNK_1033334dc + (long)(int)param_7 * 4);
    }
  }
  else {
    uVar1 = 1;
  }
  return uVar1;
}

