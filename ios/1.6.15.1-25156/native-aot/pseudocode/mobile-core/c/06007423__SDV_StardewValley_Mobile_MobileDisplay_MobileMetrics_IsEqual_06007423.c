/* 0x06007423 StardewValley.Mobile.MobileDisplay+MobileMetrics.IsEqual @ 0x1020b490c */

bool SDV_StardewValley_Mobile_MobileDisplay_MobileMetrics_IsEqual_06007423
               (long param_1,int param_2,int param_3)

{
  if (*(int *)(param_1 + 0x10) == param_2) {
    return *(int *)(param_1 + 0x14) == param_3;
  }
  return false;
}

