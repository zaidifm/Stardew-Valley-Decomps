/* 0x06005e88 StardewValley.Menus.TutorialManager.initializeStartTutorials @ 0x101e2122c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_initializeStartTutorials_06005e88(long param_1)

{
  int iVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  long *plVar5;
  undefined8 uVar6;
  undefined1 uVar7;
  long lVar8;
  ulong uVar9;
  
  cVar3 = cRam0000000103910c97;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103317920);
    cRam0000000103910c97 = '\x01';
    lVar8 = *(long *)(param_1 + 0x68);
  }
  else {
    lVar8 = *(long *)(param_1 + 0x68);
  }
  uVar6 = _UNK_1036a2de8;
  if (lVar8 != 0) {
    iVar1 = *(int *)(lVar8 + 0x18);
    *(undefined4 *)(lVar8 + 0x18) = 0;
    *(int *)(lVar8 + 0x1c) = *(int *)(lVar8 + 0x1c) + 1;
    if (0 < iVar1) {
      func_0x000100331c80(*(undefined8 *)(lVar8 + 0x10),0);
    }
    uVar9 = 0;
    lVar8 = 0x20;
    *(undefined1 *)(param_1 + 0xce) = 0;
    *(undefined8 *)(param_1 + 0x80) = 0;
    *(undefined8 *)(param_1 + 0xc4) = 0;
    *(undefined8 *)(param_1 + 0xbc) = 0;
    *(undefined1 *)(param_1 + 0xcc) = 0;
    *(undefined8 *)(param_1 + 0x98) = 0;
    *(undefined8 *)(param_1 + 0x90) = 0;
    *(undefined8 *)(param_1 + 0xa8) = 0;
    *(undefined8 *)(param_1 + 0xa0) = 0;
    *(undefined8 *)(param_1 + 0xb2) = 0;
    *(undefined8 *)(param_1 + 0xaa) = 0;
    do {
      if (*(uint *)(*(long *)(param_1 + 0x70) + 0x18) <= uVar9) {
        func_0x0001003316f4(0xcc,_UNK_1036a2e20);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101e214f8);
        (*pcVar2)();
      }
      *(undefined4 *)(lVar8 + *(long *)(param_1 + 0x70)) = 0xffffffff;
      uVar6 = uRam00000001038ca8d8;
      lVar4 = func_0x000100331820(uRam00000001038c5070,0x14);
      *(int *)(lVar4 + 0x10) = (int)uVar9;
      lVar4 = func_0x0001003781e4(uVar6,lVar4);
      if ((lVar4 != 0) && (cVar3 = func_0x000100357df4(lVar4,uRam00000001039008d0), cVar3 != '\0'))
      {
        plVar5 = (long *)func_0x00010037802c(uRam00000001038ca8d8,uVar9 & 0xffffffff);
        uVar6 = _UNK_1036a2e08;
        if ((*(char *)(*plVar5 + 0x34) != '\0') ||
           (uVar6 = _UNK_1036a2e10, lRam00000001038c6258 != **(long **)*plVar5)) {
          func_0x0001003316f4(0xd3,uVar6);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101e2152c);
          (*pcVar2)();
        }
        SDV_StardewValley_Menus_TutorialManager_Register_06005e6a(param_1,(int)plVar5[2]);
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      uVar9 = uVar9 + 1;
      lVar8 = lVar8 + 4;
    } while (uVar9 != 0x33);
    lVar4 = SDV_StardewValley_Menus_TutorialManager_Register_06005e6a(param_1,1);
    lVar8 = lRam00000001038c4be0;
    uVar6 = _UNK_1036a2df8;
    if (lVar4 != 0) {
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar4 + 0x98) = uRam00000001039008d8;
      *(undefined1 *)(((ulong)(lVar4 + 0x98) >> 9 & 0x7fffff) + lVar8) = 1;
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      plVar5 = (long *)*plRam00000001038d5338;
      uVar6 = _UNK_1036a2e18;
      if (plVar5 != (long *)0x0) {
        uVar6 = (**(code **)(*plVar5 + 0x100))(plVar5,uRam00000001039008e0);
        uVar6 = StardewValley_StardewValley_TokenizableStrings_TokenParser_ParseText_0600445a
                          (uVar6,0,0,0);
        DataMemoryBarrier(2,3);
        *(undefined8 *)(lVar4 + 0x80) = uVar6;
        *(undefined1 *)(((ulong)(lVar4 + 0x80) >> 9 & 0x7fffff) + lVar8) = 1;
        *(undefined1 *)(lVar4 + 0xb3) = 1;
        *(undefined4 *)(lVar4 + 0xd0) = 0x45bb8000;
        lVar8 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b(param_1,0x2c);
        if (lVar8 != 0) {
          *(undefined1 *)(lVar8 + 0xb3) = 1;
          *(undefined4 *)(lVar8 + 0xd0) = 0x45bb8000;
          lVar4 = func_0x000100331794(uRam00000001039008e8,1);
          *(undefined4 *)(lVar4 + 0x20) = 1;
          SDV_StardewValley_Menus_TutorialItem_Requires_06005e50(lVar8,lVar4);
        }
        cVar3 = SDV_StardewValley_Game1_isGamePadConnected_06002f76();
        if (cVar3 == '\0') {
          uVar7 = 0;
        }
        else {
          if (*(char *)(param_1 + 0xce) == '\0') {
            SDV_StardewValley_Menus_TutorialManager_completeAllTutorials_06005e72(param_1);
            SDV_StardewValley_Menus_TutorialManager_showTutorials_06005e68(param_1,0);
          }
          uVar7 = 1;
        }
        *(undefined1 *)(param_1 + 0xce) = uVar7;
        return;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e2150c);
  (*pcVar2)();
}

