/* 0x06006706 StardewValley.Mobile.TapToMoveUtils.IsGiantWeedAt @ 0x101fcdbb0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_IsGiantWeedAt_06006706
          (undefined4 param_1,undefined4 param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  uint uVar5;
  
  if (lRam0000000103976fb8 == 0) {
    lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    uVar4 = _UNK_1036d7ce0;
  }
  else {
    func_0x00010119b8f8();
    lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    uVar4 = _UNK_1036d7ce0;
  }
  _UNK_1036d7ce0 = uVar4;
  if (lVar3 != 0) {
    uVar5 = 0;
    do {
      if (*(int *)(*(long *)(*(long *)(lVar3 + 0x100) + 0x58) + 0x18) <= (int)uVar5) {
        return 0;
      }
      lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
      lVar3 = *(long *)(*(long *)(lVar3 + 0x100) + 0x58);
      if (*(uint *)(lVar3 + 0x18) <= uVar5) {
        func_0x000100331b90();
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcdcfc);
        (*pcVar1)();
      }
      lVar3 = *(long *)(lVar3 + 0x10);
      if (*(uint *)(lVar3 + 0x18) <= uVar5) {
        func_0x0001003316f4(0xcc,_UNK_1036d7d20);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcdd1c);
        (*pcVar1)();
      }
      lVar3 = *(long *)(lVar3 + (long)(int)uVar5 * 8 + 0x20);
      uVar4 = _UNK_1036d7d10;
      if (lVar3 == 0) break;
      cVar2 = func_0x000101a983a0(lVar3,param_1,param_2);
      if ((cVar2 != '\0') && ((*(uint *)(*(long *)(lVar3 + 0x48) + 0x68) | 2) == 0x2e)) {
        return 1;
      }
      lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      uVar5 = uVar5 + 1;
      uVar4 = _UNK_1036d7ce0;
    } while (lVar3 != 0);
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcdd3c);
  (*pcVar1)();
}

