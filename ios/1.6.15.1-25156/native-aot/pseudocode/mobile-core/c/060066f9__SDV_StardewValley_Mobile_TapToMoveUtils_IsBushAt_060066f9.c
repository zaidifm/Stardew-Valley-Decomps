/* 0x060066f9 StardewValley.Mobile.TapToMoveUtils.IsBushAt @ 0x101fccd20 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMoveUtils_IsBushAt_060066f9(long param_1)

{
  code *pcVar1;
  bool bVar2;
  char cVar3;
  long lVar4;
  undefined8 *puVar5;
  undefined8 uVar6;
  int iVar7;
  int iVar8;
  
  cVar3 = cRam0000000103911508;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar6 = _UNK_1036d7b90;
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325a2c);
    cRam0000000103911508 = '\x01';
    uVar6 = _UNK_1036d7b90;
  }
  _UNK_1036d7b90 = uVar6;
  if (param_1 == 0) {
LAB_101fcce68:
    func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcce74);
    (*pcVar1)();
  }
  cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_IsBushAt_060066fb
                    (*(undefined4 *)(param_1 + 0x34),*(undefined4 *)(param_1 + 0x38));
  if (cVar3 == '\0') {
    iVar7 = *(int *)(param_1 + 0x34);
    iVar8 = *(int *)(param_1 + 0x38);
    lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    uVar6 = _UNK_1036d7ba0;
    if (*(long *)(lVar4 + 0x120) == 0) goto LAB_101fcce68;
    cVar3 = func_0x00010035afb8((float)iVar7,(float)iVar8);
    if (cVar3 == '\0') {
      bVar2 = false;
    }
    else {
      lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
      uVar6 = _UNK_1036d7bb0;
      if (*(long *)(lVar4 + 0x120) == 0) goto LAB_101fcce68;
      puVar5 = (undefined8 *)func_0x000100358178((float)iVar7,(float)iVar8);
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

