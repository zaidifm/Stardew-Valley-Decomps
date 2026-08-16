/* 0x060066fb StardewValley.Mobile.TapToMoveUtils.IsBushAt @ 0x101fccfa4 */

undefined8 SDV_StardewValley_Mobile_TapToMoveUtils_IsBushAt_060066fb(int param_1,int param_2)

{
  char cVar1;
  undefined8 *puVar2;
  undefined8 uVar3;
  
  cVar1 = cRam000000010391150a;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325a42);
    cRam000000010391150a = '\x01';
  }
  if ((param_1 == 0x20) && (param_2 == 9)) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (((*piRam00000001038d6430 == 2) &&
        (puVar2 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8(),
        puVar2 != (undefined8 *)0x0)) &&
       (lRam00000001038c69d0 == *(long *)(*(long *)(*(long *)*puVar2 + 0x10) + 0x10))) {
      return 0;
    }
  }
  uVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_IsBushAtPoint_060066fc(param_1 << 6,param_2 << 6);
  return uVar3;
}

