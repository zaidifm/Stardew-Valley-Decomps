/* 0x06006606 StardewValley.Mobile.AStarGraph.Distance @ 0x101fa33c4 */

void SDV_StardewValley_Mobile_AStarGraph_Distance_06006606
               (undefined8 param_1,int param_2,int param_3,int param_4,int param_5)

{
  undefined1 auVar1 [16];
  
  auVar1._0_8_ = (long)(param_2 - param_4);
  auVar1._8_8_ = (long)(param_3 - param_5);
  NEON_scvtf(auVar1,8);
  return;
}

