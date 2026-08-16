/* 0x060066e3 StardewValley.Mobile.TapToMoveUtils.NodeContainsMusicBlock @ 0x101fcac14 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMoveUtils_NodeContainsMusicBlock_060066e3(long param_1)

{
  code *pcVar1;
  char cVar2;
  undefined8 *puVar3;
  undefined8 uVar4;
  long lStack_38;
  
  cVar2 = cRam00000001039114f2;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033258c2);
    cRam00000001039114f2 = '\x01';
  }
  lStack_38 = 0;
  puVar3 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  if ((puVar3 == (undefined8 *)0x0) ||
     (lRam00000001038c6c08 != *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x10))) {
    return false;
  }
  puVar3 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar4 = _UNK_1036d7888;
  if (puVar3 != (undefined8 *)0x0) {
    if (lRam00000001038c6c08 != *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x10)) {
      func_0x0001003316f4(0xd3,_UNK_1036d7880);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcad30);
      (*pcVar1)();
    }
    uVar4 = _UNK_1036d78a8;
    if ((param_1 != 0) && (uVar4 = _UNK_1036d7890, puVar3[0x17] != 0)) {
      cVar2 = func_0x000101b560e8((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38),
                                  puVar3[0x17],&lStack_38);
      if (cVar2 == '\0') {
        return false;
      }
      return *(int *)(*(long *)(lStack_38 + 0x58) + 0x68) - 0x1cfU < 2;
    }
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcad68);
  (*pcVar1)();
}

