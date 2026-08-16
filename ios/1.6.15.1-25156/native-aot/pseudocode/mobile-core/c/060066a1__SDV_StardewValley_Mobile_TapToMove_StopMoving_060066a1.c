/* 0x060066a1 StardewValley.Mobile.TapToMove.StopMoving @ 0x101fb2d1c */

void SDV_StardewValley_Mobile_TapToMove_StopMoving_060066a1(long param_1)

{
  long lVar1;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *(long *)(param_1 + 0x18);
  }
  *(undefined4 *)(lVar1 + 0x19) = 0;
  *(undefined4 *)(lVar1 + 0x1d) = *(undefined4 *)(lVar1 + 0x21);
  *(undefined4 *)(lVar1 + 0x21) = 0;
  return;
}

