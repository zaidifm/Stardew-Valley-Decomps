/* 0x06005e70 StardewValley.Menus.TutorialManager.getCompletedTutorialsList @ 0x101e1ed7c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Menus_TutorialManager_getCompletedTutorialsList_06005e70(undefined8 param_1)

{
  undefined4 uVar1;
  uint uVar2;
  code *pcVar3;
  char cVar4;
  long lVar5;
  long lVar6;
  long *plVar7;
  undefined8 uVar8;
  int iVar9;
  
  cVar4 = cRam0000000103910c7f;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103317770);
    cRam0000000103910c7f = '\x01';
  }
  lVar5 = func_0x000100331820(uRam00000001038ce9b8,0x20);
  func_0x000100378018(lVar5,0x33);
  iVar9 = 0;
  do {
    uVar8 = uRam00000001038ca8d8;
    lVar6 = func_0x000100331820(uRam00000001038c5070,0x14);
    *(int *)(lVar6 + 0x10) = iVar9;
    cVar4 = func_0x000100369ea0(uVar8,lVar6);
    if (cVar4 != '\0') {
      plVar7 = (long *)func_0x00010037802c(uRam00000001038ca8d8,iVar9);
      uVar8 = _UNK_1036a2b50;
      if ((*(char *)(*plVar7 + 0x34) != '\0') ||
         (uVar8 = _UNK_1036a2b58, lRam00000001038c6258 != **(long **)*plVar7)) {
        func_0x0001003316f4(0xd3,uVar8);
                    /* WARNING: Does not return */
        pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1ef30);
        (*pcVar3)();
      }
      uVar1 = (undefined4)plVar7[2];
      lVar6 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b(param_1,uVar1);
      if ((lVar6 != 0) && (*(char *)(lVar6 + 0xb0) != '\0')) {
        lVar6 = *(long *)(lVar5 + 0x10);
        *(int *)(lVar5 + 0x1c) = *(int *)(lVar5 + 0x1c) + 1;
        if (lVar6 == 0) {
          func_0x0001003316f4(0xee,_UNK_1036a2b60);
                    /* WARNING: Does not return */
          pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1ef50);
          (*pcVar3)();
        }
        uVar2 = *(uint *)(lVar5 + 0x18);
        if (uVar2 < *(uint *)(lVar6 + 0x18)) {
          *(uint *)(lVar5 + 0x18) = uVar2 + 1;
          if (*(uint *)(lVar6 + 0x18) <= uVar2) {
            func_0x0001003316f4(0xcc,_UNK_1036a2b68);
                    /* WARNING: Does not return */
            pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1ef64);
            (*pcVar3)();
          }
          *(undefined4 *)(lVar6 + (long)(int)uVar2 * 4 + 0x20) = uVar1;
        }
        else {
          func_0x000100346db0(lVar5,uVar1);
        }
      }
    }
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
    iVar9 = iVar9 + 1;
  } while (iVar9 != 0x33);
  return lVar5;
}

