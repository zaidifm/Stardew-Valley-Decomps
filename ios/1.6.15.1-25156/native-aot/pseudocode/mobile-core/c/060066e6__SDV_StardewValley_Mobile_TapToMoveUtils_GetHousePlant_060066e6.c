/* 0x060066e6 StardewValley.Mobile.TapToMoveUtils.GetHousePlant @ 0x101fcb268 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long * SDV_StardewValley_Mobile_TapToMoveUtils_GetHousePlant_060066e6(long param_1)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  long *plVar5;
  long *plStack_38;
  
  cVar2 = cRam00000001039114f5;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033258ee);
    cRam00000001039114f5 = '\x01';
  }
  plStack_38 = (long *)0x0;
  lVar3 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  uVar4 = _UNK_1036d7908;
  if (((lVar3 != 0) && (uVar4 = _UNK_1036d7910, param_1 != 0)) &&
     (uVar4 = _UNK_1036d7918, *(long *)(lVar3 + 0xb8) != 0)) {
    func_0x000101b560e8((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38),
                        *(long *)(lVar3 + 0xb8),&plStack_38);
    plVar5 = plStack_38;
    if (plStack_38 != (long *)0x0) {
      uVar4 = (**(code **)(*plStack_38 + 0x1e8))();
      cVar2 = func_0x000100345aa0(uVar4,uRam00000001038ed7b8);
      plVar5 = (long *)0x0;
      if (cVar2 != '\0') {
        plVar5 = plStack_38;
      }
    }
    return plVar5;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcb350);
  (*pcVar1)();
}

