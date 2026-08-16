/* 0x060066da StardewValley.Mobile.TapToMoveUtils.get_WarpRange @ 0x101fc9e60 */

undefined1  [16] SDV_StardewValley_Mobile_TapToMoveUtils_get_WarpRange_060066da(void)

{
  char cVar1;
  long lVar2;
  undefined8 *puVar3;
  ulong uVar4;
  undefined1 auVar5 [16];
  
  cVar1 = cRam00000001039114e9;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332586d);
    cRam00000001039114e9 = '\x01';
    lVar2 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  }
  else {
    lVar2 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  }
  if ((lVar2 == 0) ||
     ((lVar2 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8(),
      *(char *)(*(long *)(lVar2 + 0x1a0) + 0x68) == '\0' &&
      ((puVar3 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8(),
       puVar3 == (undefined8 *)0x0 ||
       (lRam00000001038c6b50 != *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x10))))))) {
    uVar4 = 0x42c00000;
  }
  else {
    uVar4 = 0x4300000043000000;
  }
  auVar5._8_8_ = 0;
  auVar5._0_8_ = uVar4;
  return auVar5;
}

