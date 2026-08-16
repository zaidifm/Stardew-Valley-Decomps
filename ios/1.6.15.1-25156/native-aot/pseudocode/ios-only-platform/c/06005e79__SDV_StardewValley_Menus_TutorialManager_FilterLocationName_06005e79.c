/* 0x06005e79 StardewValley.Menus.TutorialManager.FilterLocationName @ 0x101e1f884 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Menus_TutorialManager_FilterLocationName_06005e79(undefined8 param_1)

{
  code *pcVar1;
  char cVar2;
  long *plVar3;
  undefined8 uVar4;
  int iVar5;
  long lStack_70;
  undefined8 uStack_68;
  undefined8 uStack_60;
  long lStack_58;
  
  cVar2 = cRam0000000103910c88;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033177d0);
    cRam0000000103910c88 = '\x01';
  }
  lStack_70 = 0;
  uStack_68 = 0;
  uStack_60 = 0;
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  plVar3 = *(long **)(*(long *)(*plRam00000001038cbf38 + 0x60) + 400);
  uVar4 = _UNK_1036a2c58;
  if (plVar3 == (long *)0x0) {
LAB_101e1fab4:
    func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1fac0);
    (*pcVar1)();
  }
  plVar3 = (long *)(**(code **)(*plVar3 + -0x10))();
  while (plVar3 != (long *)0x0) {
    cVar2 = (**(code **)(*plVar3 + -0x78))(plVar3);
    if (cVar2 == '\0') {
      iVar5 = 2;
LAB_101e1fac4:
      lStack_58 = 0;
      if (plVar3 != (long *)0x0) {
        uVar4 = _UNK_1036a2c68;
        if (plVar3 == (long *)0x0) goto LAB_101e1fab4;
        (**(code **)(*plVar3 + -0x28))();
      }
      if (iVar5 == 1) {
        param_1 = uStack_60;
        if (lStack_58 != 0) {
          func_0x000100331ba4();
          param_1 = uStack_60;
        }
      }
      else {
        if (iVar5 != 2) {
          func_0x000100331c30();
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1fb54);
          (*pcVar1)();
        }
        if (lStack_58 != 0) {
          func_0x000100331ba4();
        }
      }
      return param_1;
    }
    if (plVar3 == (long *)0x0) break;
    uVar4 = (**(code **)(*plVar3 + -0x38))();
    cVar2 = StardewValley_StardewValley_Utility_TryGetPassiveFestivalData_06004237(uVar4,&lStack_70)
    ;
    if (cVar2 != '\0') {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      if (lStack_70 == 0) break;
      if (*(int *)(lStack_70 + 0x50) <= *piRam00000001038d5780) {
        if ((*(char *)(lRam00000001038c4c88 + 0x35) == '\0') &&
           (func_0x0001003319b0(), lStack_70 == 0)) break;
        if (*piRam00000001038d5780 <= *(int *)(lStack_70 + 0x54)) {
          iVar5 = *(int *)(lStack_70 + 0x4c);
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          if (iVar5 == *piRam00000001038d5670) {
            if (lStack_70 == 0) break;
            if ((*(long *)(lStack_70 + 0x28) != 0) &&
               (cVar2 = func_0x0001003549c4(*(long *)(lStack_70 + 0x28),param_1,&uStack_68),
               cVar2 != '\0')) {
              iVar5 = 1;
              uStack_60 = uStack_68;
              goto LAB_101e1fac4;
            }
          }
        }
      }
    }
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
  }
  func_0x0001003316f4(0xee,_UNK_1036a2c60);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1fa48);
  (*pcVar1)();
}

