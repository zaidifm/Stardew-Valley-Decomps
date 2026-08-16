/* 0x06006612 StardewValley.Mobile.AStarGraph.WalkDirectionBetweenTwoTiles @ 0x101fa3b5c */

undefined4
SDV_StardewValley_Mobile_AStarGraph_WalkDirectionBetweenTwoTiles_06006612
          (float param_1,float param_2,float param_3,float param_4)

{
  bool bVar1;
  undefined4 uVar2;
  float fVar3;
  float fVar4;
  
  param_4 = param_4 - param_2;
  fVar4 = ABS(param_3 - param_1);
  bVar1 = false;
  if ((param_4 < -32.0) && (bVar1 = false, !NAN(fVar4))) {
    bVar1 = fVar4 < 32.0;
  }
  if (bVar1) {
    return 1;
  }
  if ((32.0 < param_4) && (fVar4 < 32.0)) {
    return 2;
  }
  param_3 = param_3 - param_1;
  fVar3 = ABS(param_4);
  if ((param_3 < -32.0) && (fVar3 < 32.0)) {
    return 3;
  }
  if ((32.0 < param_3) && (fVar3 < 32.0)) {
    return 4;
  }
  if ((param_3 < -32.0) && (param_4 < -32.0)) {
    return 5;
  }
  if ((32.0 < param_3) && (param_4 < -32.0)) {
    return 6;
  }
  if ((param_3 < -32.0) && (32.0 < param_4)) {
    return 7;
  }
  if ((32.0 < param_3) && (32.0 < param_4)) {
    return 8;
  }
  if (fVar4 <= fVar3) {
    uVar2 = 2;
    if (param_4 < 0.0) {
      uVar2 = 1;
    }
    return uVar2;
  }
  uVar2 = 4;
  if (param_3 < 0.0) {
    uVar2 = 3;
  }
  return uVar2;
}

