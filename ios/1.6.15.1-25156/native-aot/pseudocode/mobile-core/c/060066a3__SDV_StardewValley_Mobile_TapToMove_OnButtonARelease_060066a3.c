/* 0x060066a3 StardewValley.Mobile.TapToMove.OnButtonARelease @ 0x101fb322c */

void SDV_StardewValley_Mobile_TapToMove_OnButtonARelease_060066a3(long param_1)

{
  char cVar1;
  long lVar2;
  
  if (lRam0000000103976fb8 == 0) {
    cVar1 = *(char *)(param_1 + 0x14d);
  }
  else {
    func_0x00010119b8f8();
    cVar1 = *(char *)(param_1 + 0x14d);
  }
  if (cVar1 != '\0') {
    lVar2 = *(long *)(param_1 + 0x18);
    *(undefined1 *)(param_1 + 0x14d) = 0;
    *(undefined1 *)(param_1 + 0xf7) = 0;
    *(undefined1 *)(lVar2 + 0x15) = 0;
    *(undefined1 *)(lVar2 + 0x16) = *(undefined1 *)(lVar2 + 0x17);
    *(undefined1 *)(lVar2 + 0x17) = 0;
    SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
    *(undefined4 *)(param_1 + 0x124) = 0;
  }
  return;
}

