/* 0x06007424 StardewValley.Mobile.MobileDisplay+MobileMetrics.IsModel @ 0x1020b4950 */

bool SDV_StardewValley_Mobile_MobileDisplay_MobileMetrics_IsModel_06007424
               (long param_1,long param_2)

{
  int iVar1;
  long lVar2;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if ((param_2 != 0) && (*(int *)(param_2 + 0x10) != 0)) {
    lVar2 = *(long *)(param_1 + 8);
    if (lVar2 == 0) {
      return false;
    }
    if (*(int *)(lVar2 + 0x10) != 0) {
      iVar1 = func_0x000100374fd0(lVar2,param_2,5);
      return iVar1 != -1;
    }
  }
  return false;
}

