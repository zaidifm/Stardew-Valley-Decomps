/* 0x060066fa StardewValley.Mobile.TapToMoveUtils.IsBushAt @ 0x101fcce74 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMoveUtils_IsBushAt_060066fa(float param_1,float param_2)

{
  code *pcVar1;
  bool bVar2;
  char cVar3;
  long lVar4;
  undefined8 *puVar5;
  undefined8 uVar6;
  
  cVar3 = cRam0000000103911509;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325a37);
    cRam0000000103911509 = '\x01';
  }
  cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_IsBushAt_060066fb((int)param_1,(int)param_2);
  if (cVar3 == '\0') {
    lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    uVar6 = _UNK_1036d7bc0;
    if (*(long *)(lVar4 + 0x120) == 0) {
LAB_101fccf98:
      func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fccfa4);
      (*pcVar1)();
    }
    cVar3 = func_0x00010035afb8(param_1,param_2);
    if (cVar3 == '\0') {
      bVar2 = false;
    }
    else {
      lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
      uVar6 = _UNK_1036d7bd0;
      if (*(long *)(lVar4 + 0x120) == 0) goto LAB_101fccf98;
      puVar5 = (undefined8 *)func_0x000100358178(param_1,param_2);
      if ((puVar5 != (undefined8 *)0x0) &&
         (lRam00000001038c78e0 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18))) {
        puVar5 = (undefined8 *)0x0;
      }
      bVar2 = puVar5 != (undefined8 *)0x0;
    }
  }
  else {
    bVar2 = true;
  }
  return bVar2;
}

