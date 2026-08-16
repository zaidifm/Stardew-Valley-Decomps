/* 0x06007422 StardewValley.Mobile.MobileDisplay+MobileMetrics..ctor @ 0x1020b48c4 */

void SDV_StardewValley_Mobile_MobileDisplay_MobileMetrics_ctor_06007422
               (undefined4 *param_1,undefined4 param_2,undefined8 param_3,undefined4 param_4,
               undefined4 param_5,undefined4 param_6,undefined4 param_7)

{
  *param_1 = param_2;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 2) = param_3;
  *(undefined1 *)(((ulong)(param_1 + 2) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  param_1[4] = param_4;
  param_1[5] = param_5;
  param_1[6] = param_6;
  param_1[7] = param_7;
  return;
}

