/* 0x060066b4 StardewValley.Mobile.TapToMove.ClearAutoSelectTool @ 0x101fc35f8 */

void SDV_StardewValley_Mobile_TapToMove_ClearAutoSelectTool_060066b4(long param_1)

{
  long lVar1;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *(long *)(param_1 + 200);
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *(long *)(param_1 + 200);
  }
  *(undefined4 *)(lVar1 + 0x18) = 0;
  *(int *)(lVar1 + 0x1c) = *(int *)(lVar1 + 0x1c) + 1;
  *(undefined8 *)(param_1 + 0xd0) = 0;
  return;
}

