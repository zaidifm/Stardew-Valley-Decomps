/* 0x060066ce StardewValley.Mobile.TapToMoveUtils.ContainsTravellingDesertShop @ 0x101fc8954 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_ContainsTravellingDesertShop_060066ce
          (undefined4 param_1,undefined4 param_2)

{
  char cVar1;
  code *pcVar2;
  undefined8 *puVar3;
  undefined8 uVar4;
  
  cVar1 = cRam00000001039114dd;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325801);
    cRam00000001039114dd = '\x01';
    puVar3 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    if (puVar3 == (undefined8 *)0x0) {
      return 0;
    }
  }
  else {
    puVar3 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    if (puVar3 == (undefined8 *)0x0) {
      return 0;
    }
  }
  if (lRam00000001038c6c18 == *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x10)) {
    puVar3 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    if (puVar3 == (undefined8 *)0x0) {
      func_0x0001003316f4(0xee,_UNK_1036d7468);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fc8a34);
      (*pcVar2)();
    }
    if (lRam00000001038c6c18 != *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x10)) {
      func_0x0001003316f4(0xd3,_UNK_1036d7470);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fc8a48);
      (*pcVar2)();
    }
    uVar4 = func_0x000100356238(puVar3 + 99,param_1,param_2);
  }
  else {
    uVar4 = 0;
  }
  return uVar4;
}

