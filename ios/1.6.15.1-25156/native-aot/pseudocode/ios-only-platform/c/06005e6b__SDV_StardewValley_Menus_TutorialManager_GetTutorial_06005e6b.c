/* 0x06005e6b StardewValley.Menus.TutorialManager.GetTutorial @ 0x101e1e944 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b(long param_1,uint param_2)

{
  uint uVar1;
  uint uVar2;
  code *pcVar3;
  undefined8 uVar4;
  long lVar5;
  
  if (lRam0000000103976fb8 == 0) {
    lVar5 = *(long *)(param_1 + 0x70);
  }
  else {
    func_0x00010119b8f8();
    lVar5 = *(long *)(param_1 + 0x70);
  }
  uVar4 = _UNK_1036a2af8;
  if (param_2 < *(uint *)(lVar5 + 0x18)) {
    uVar1 = *(uint *)(lVar5 + (long)(int)param_2 * 4 + 0x20);
    if (-1 < (int)uVar1) {
      uVar2 = *(uint *)(*(long *)(param_1 + 0x68) + 0x18);
      if ((int)uVar1 < (int)uVar2) {
        if (uVar2 <= uVar1) {
          func_0x000100331b90();
                    /* WARNING: Does not return */
          pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1ea18);
          (*pcVar3)();
        }
        lVar5 = *(long *)(*(long *)(param_1 + 0x68) + 0x10);
        uVar4 = _UNK_1036a2b10;
        if ((ulong)(long)*(int *)(lVar5 + 0x18) <= (ulong)uVar1) goto LAB_101e1ea34;
        lVar5 = *(long *)(lVar5 + (ulong)uVar1 * 8 + 0x20);
        if (lVar5 != 0) {
          if (*(uint *)(lVar5 + 0xcc) == param_2) {
            return lVar5;
          }
          return 0;
        }
      }
    }
    return 0;
  }
LAB_101e1ea34:
  func_0x0001003316f4(0xcc,uVar4);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1ea40);
  (*pcVar3)();
}

