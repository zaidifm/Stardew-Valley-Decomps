/* 0x060066e5 StardewValley.Mobile.TapToMoveUtils.NodeContainsHousePlant @ 0x101fcb184 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMoveUtils_NodeContainsHousePlant_060066e5(long param_1)

{
  code *pcVar1;
  bool bVar2;
  char cVar3;
  long lVar4;
  undefined8 uVar5;
  long *plStack_38;
  
  cVar3 = cRam00000001039114f4;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1033258e5);
    cRam00000001039114f4 = '\x01';
  }
  plStack_38 = (long *)0x0;
  lVar4 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  uVar5 = _UNK_1036d78f0;
  if (((lVar4 != 0) && (uVar5 = _UNK_1036d78f8, param_1 != 0)) &&
     (uVar5 = _UNK_1036d7900, *(long *)(lVar4 + 0xb8) != 0)) {
    func_0x000101b560e8((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38),
                        *(long *)(lVar4 + 0xb8),&plStack_38);
    bVar2 = false;
    if (plStack_38 != (long *)0x0) {
      uVar5 = (**(code **)(*plStack_38 + 0x1e8))();
      cVar3 = func_0x000100345aa0(uVar5,uRam00000001038ed7b8);
      bVar2 = cVar3 != '\0';
    }
    return bVar2;
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcb268);
  (*pcVar1)();
}

