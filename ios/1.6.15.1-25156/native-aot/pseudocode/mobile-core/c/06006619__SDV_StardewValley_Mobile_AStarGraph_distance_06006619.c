/* 0x06006619 StardewValley.Mobile.AStarGraph.distance @ 0x101fa7310 */

undefined1  [16]
SDV_StardewValley_Mobile_AStarGraph_distance_06006619
          (undefined8 param_1,int param_2,int param_3,int param_4,int param_5)

{
  undefined1 auVar1 [16];
  undefined1 auVar2 [16];
  
  auVar1._0_8_ = (long)(param_2 - param_3);
  auVar1._8_8_ = (long)(param_4 - param_5);
  auVar1 = NEON_scvtf(auVar1,8);
  auVar2._0_8_ = SQRT(auVar1._0_8_ * auVar1._0_8_ + auVar1._8_8_ * auVar1._8_8_);
  auVar2._8_8_ = 0;
  return auVar2;
}

