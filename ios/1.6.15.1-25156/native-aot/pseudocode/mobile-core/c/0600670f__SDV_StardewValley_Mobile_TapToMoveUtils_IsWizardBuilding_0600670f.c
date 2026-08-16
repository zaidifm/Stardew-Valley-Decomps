/* 0x0600670f StardewValley.Mobile.TapToMoveUtils.IsWizardBuilding @ 0x101fce7e0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_IsWizardBuilding_0600670f
          (undefined4 param_1,undefined4 param_2)

{
  code *pcVar1;
  char cVar2;
  long *plVar3;
  long lVar4;
  undefined8 uVar5;
  long lVar6;
  
  cVar2 = cRam000000010391151e;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325ae4);
    cRam000000010391151e = '\x01';
  }
  plVar3 = (long *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  cVar2 = (**(code **)(*plVar3 + 0x510))();
  if (cVar2 == '\0') {
LAB_101fce88c:
    uVar5 = 0;
  }
  else {
    lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    uVar5 = _UNK_1036d7ec8;
    if (lVar4 == 0) {
LAB_101fce8ec:
      func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fce8f8);
      (*pcVar1)();
    }
    lVar4 = func_0x000101938908(param_1,param_2);
    if (lVar4 == 0) {
      return 0;
    }
    lVar6 = *(long *)(lVar4 + 0x88);
    if (*(long *)(lVar6 + 0x60) == 0) {
LAB_101fce86c:
      cVar2 = func_0x000100345aa0(*(undefined8 *)(lVar6 + 0x60),uRam00000001038ff320);
      if (cVar2 == '\0') goto LAB_101fce88c;
    }
    else {
      cVar2 = func_0x000100350144(*(long *)(lVar6 + 0x60),uRam00000001038fae90);
      if (cVar2 == '\0') {
        lVar6 = *(long *)(lVar4 + 0x88);
        uVar5 = _UNK_1036d7ed8;
        if (lVar6 == 0) goto LAB_101fce8ec;
        goto LAB_101fce86c;
      }
    }
    uVar5 = 1;
  }
  return uVar5;
}

