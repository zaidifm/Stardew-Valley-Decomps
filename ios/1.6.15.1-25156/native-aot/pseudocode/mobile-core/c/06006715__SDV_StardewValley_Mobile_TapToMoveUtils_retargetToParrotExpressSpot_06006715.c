/* 0x06006715 StardewValley.Mobile.TapToMoveUtils.retargetToParrotExpressSpot @ 0x101fcf268 */

/* WARNING: Removing unreachable block (ram,0x000101fcf3f4) */
/* WARNING: Removing unreachable block (ram,0x000101fcf3dc) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_retargetToParrotExpressSpot_06006715
          (undefined8 param_1,undefined8 param_2)

{
  long *plVar1;
  code *pcVar2;
  char cVar3;
  undefined8 *puVar4;
  undefined8 uVar5;
  int iVar6;
  int iVar7;
  int iVar8;
  int iVar9;
  int iVar10;
  float fVar11;
  float fVar12;
  undefined8 uStack_78;
  undefined8 uStack_70;
  long *plStack_68;
  undefined8 uStack_60;
  undefined8 *puStack_58;
  
  cVar3 = cRam0000000103911524;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325b20);
    cRam0000000103911524 = '\x01';
  }
  uStack_78 = 0;
  uStack_70 = 0;
  plStack_68 = (long *)0x0;
  puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  iVar10 = (int)((ulong)param_2 >> 0x20);
  iVar7 = (int)param_2;
  iVar8 = iVar10;
  iVar9 = iVar7;
  if ((puVar4 == (undefined8 *)0x0) ||
     (lRam00000001038c6ce0 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x10))) {
LAB_101fcf400:
    return CONCAT44(iVar8,iVar9);
  }
  puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  uVar5 = _UNK_1036d7f70;
  if ((puVar4 != (undefined8 *)0x0) &&
     ((lRam00000001038c6ce0 == *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x10) &&
      (uVar5 = _UNK_1036d7f78, puVar4[0x5f] != 0)))) {
    func_0x00010037226c(&uStack_78);
    do {
      while( true ) {
        cVar3 = func_0x0001003722a8(&uStack_78);
        plVar1 = plStack_68;
        if (cVar3 == '\0') {
          iVar8 = 0;
          iVar9 = 0;
          iVar6 = 2;
          goto LAB_101fcf3b8;
        }
        if (plStack_68 == (long *)0x0) {
          func_0x0001003316f4(0xee,_UNK_1036d7f80);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fcf444);
          (*pcVar2)();
        }
        cVar3 = (**(code **)(*plStack_68 + 0x80))((float)iVar7,(float)iVar10,plStack_68);
        if (lRam0000000103976fb8 != 0) break;
        if (cVar3 != '\0') goto LAB_101fcf374;
      }
      func_0x00010119b8f8();
    } while (cVar3 == '\0');
LAB_101fcf374:
    fVar12 = *(float *)((long)plVar1 + 0x4c) * 0.015625;
    fVar11 = (float)func_0x00010035025c(*(float *)(plVar1 + 9) * 0.015625,fVar12,0x3f800000,0);
    iVar9 = (int)fVar11;
    iVar8 = (int)fVar12;
    iVar6 = 1;
LAB_101fcf3b8:
    uStack_60 = 0;
    puStack_58 = &uStack_78;
    if (puStack_58 != (undefined8 *)0x0) {
      if ((iVar6 != 1) && (iVar8 = iVar10, iVar9 = iVar7, iVar6 != 2)) {
        func_0x000100331c30();
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101fcf49c);
        (*pcVar2)();
      }
      goto LAB_101fcf400;
    }
    puStack_58 = (undefined8 *)0x0;
    uVar5 = _UNK_1036d7f88;
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fcf494);
  (*pcVar2)();
}

