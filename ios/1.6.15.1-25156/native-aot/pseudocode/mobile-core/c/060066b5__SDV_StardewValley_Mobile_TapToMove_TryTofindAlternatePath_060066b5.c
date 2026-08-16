/* 0x060066b5 StardewValley.Mobile.TapToMove.TryTofindAlternatePath @ 0x101fc3660 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_TryTofindAlternatePath_060066b5
               (long param_1,undefined8 param_2)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  long lVar4;
  
  if (lRam0000000103976fb8 == 0) {
    lVar4 = *(long *)(param_1 + 0x48);
  }
  else {
    func_0x00010119b8f8();
    lVar4 = *(long *)(param_1 + 0x48);
  }
  if (lVar4 == 0) {
LAB_101fc3728:
    SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
    return;
  }
  lVar4 = *(long *)(param_1 + 0x40);
  uVar3 = _UNK_1036d6930;
  if (lVar4 != 0) {
    cVar2 = SDV_StardewValley_Mobile_TapToMove_FindAlternatePath_060066b6
                      (param_1,param_2,*(int *)(lVar4 + 0x34) + 1,*(int *)(lVar4 + 0x38) + 1);
    if (cVar2 != '\0') {
      return;
    }
    lVar4 = *(long *)(param_1 + 0x40);
    uVar3 = _UNK_1036d6938;
    if (lVar4 != 0) {
      cVar2 = SDV_StardewValley_Mobile_TapToMove_FindAlternatePath_060066b6
                        (param_1,param_2,*(int *)(lVar4 + 0x34) + -1,*(int *)(lVar4 + 0x38) + 1);
      if (cVar2 != '\0') {
        return;
      }
      lVar4 = *(long *)(param_1 + 0x40);
      uVar3 = _UNK_1036d6940;
      if (lVar4 != 0) {
        cVar2 = SDV_StardewValley_Mobile_TapToMove_FindAlternatePath_060066b6
                          (param_1,param_2,*(int *)(lVar4 + 0x34) + 1,*(int *)(lVar4 + 0x38) + -1);
        if (cVar2 != '\0') {
          return;
        }
        lVar4 = *(long *)(param_1 + 0x40);
        uVar3 = _UNK_1036d6948;
        if (lVar4 != 0) {
          cVar2 = SDV_StardewValley_Mobile_TapToMove_FindAlternatePath_060066b6
                            (param_1,param_2,*(int *)(lVar4 + 0x34) + -1,*(int *)(lVar4 + 0x38) + -1
                            );
          if (cVar2 != '\0') {
            return;
          }
          goto LAB_101fc3728;
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc3790);
  (*pcVar1)();
}

