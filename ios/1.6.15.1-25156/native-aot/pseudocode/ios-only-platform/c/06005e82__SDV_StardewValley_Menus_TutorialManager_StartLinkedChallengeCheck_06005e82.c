/* 0x06005e82 StardewValley.Menus.TutorialManager.StartLinkedChallengeCheck @ 0x101e20c5c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_StartLinkedChallengeCheck_06005e82(long param_1)

{
  code *pcVar1;
  char cVar2;
  int iVar3;
  undefined8 *puVar4;
  long lVar5;
  long lVar6;
  undefined8 uVar7;
  undefined8 uVar8;
  long *plVar9;
  undefined4 uVar10;
  long *plVar11;
  char cStack_39;
  long lStack_38;
  
  cVar2 = cRam0000000103910c91;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033178e0);
    cRam0000000103910c91 = '\x01';
  }
  cStack_39 = '\0';
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  cStack_39 = '\0';
  uVar7 = *puRam00000001038d5478;
  iVar3 = func_0x000100331adc(uVar7,&cStack_39);
  if (iVar3 == 0) {
    func_0x000100331bb8(uVar7,&cStack_39);
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  if (*pcRam00000001038d5488 == '\0') {
    uVar10 = 1;
  }
  else {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (*plRam00000001038d53a0 == 0) goto LAB_101e20f6c;
    if (*(char *)(*plRam00000001038d53a0 + 0xdc) == '\0') {
      puVar4 = (undefined8 *)SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
      if ((puVar4 == (undefined8 *)0x0) ||
         (lRam00000001038d67d8 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x10))) {
        cVar2 = StardewValley_StardewValley_Game1_get_gameMode_06002fda();
        if (cVar2 == '\x03') {
          if (param_1 != 0) {
            *(undefined8 *)(param_1 + 0xa0) = 0;
            *(undefined4 *)(param_1 + 0xa8) = 1;
            lVar5 = func_0x000100331820(uRam00000001039007b8,0xe0);
            SDV_StardewValley_Menus_TutorialItem__ctor_06005e4b(lVar5,0x31);
            SDV_StardewValley_Menus_TutorialItem_Text_06005e4e(lVar5,uRam00000001039008a8);
            if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            if (*plRam00000001038d6880 != 0) {
              uVar8 = *(undefined8 *)(*plRam00000001038d6880 + 0x88);
              *(undefined4 *)(lVar5 + 200) = 0;
              *(undefined1 *)(lVar5 + 0xb4) = 1;
              lVar6 = lRam00000001038c4be0;
              DataMemoryBarrier(2,3);
              *(undefined8 *)(lVar5 + 0xa0) = uVar8;
              *(undefined1 *)(((ulong)(lVar5 + 0xa0) >> 9 & 0x7fffff) + lVar6) = 1;
              DataMemoryBarrier(2,3);
              plVar9 = (long *)(param_1 + 0x80);
              *plVar9 = lVar5;
              *(undefined1 *)(((ulong)plVar9 >> 9 & 0x7fffff) + lVar6) = 1;
              if ((*plVar9 != 0) &&
                 (*(undefined4 *)(*plVar9 + 0xd4) = 0x447a0000, *(long *)(param_1 + 0x80) != 0)) {
                SDV_StardewValley_Menus_TutorialItem_show_06005e59();
                uVar10 = 1;
                *pcRam00000001038d5488 = '\0';
                goto LAB_101e20d24;
              }
            }
          }
          goto LAB_101e20f6c;
        }
        uVar10 = 2;
      }
      else {
        if (param_1 == 0) {
LAB_101e20f6c:
          func_0x0001003316f4(0xee,_UNK_1036a2db0);
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101e20f80);
          (*pcVar1)();
        }
        if ((*(long *)(param_1 + 0x78) == 0) &&
           (*piRam00000001039008b0 <= *(int *)((long)puVar4 + 0x1b4))) {
          lVar6 = func_0x000100331820(uRam00000001039007b8,0xe0);
          SDV_StardewValley_Menus_TutorialItem__ctor_06005e4b(lVar6,0x32);
          lVar5 = lRam00000001038c4be0;
          DataMemoryBarrier(2,3);
          *(undefined8 *)(lVar6 + 0x98) = uRam00000001039008b8;
          *(undefined1 *)(((ulong)(lVar6 + 0x98) >> 9 & 0x7fffff) + lVar5) = 1;
          SDV_StardewValley_Menus_TutorialItem_Text_06005e4e(lVar6,uRam00000001039008c0);
          *(undefined1 *)(lVar6 + 0xb3) = 1;
          *(undefined4 *)(lVar6 + 0xd0) = 0x45bb8000;
          DataMemoryBarrier(2,3);
          plVar9 = (long *)(param_1 + 0x78);
          *plVar9 = lVar6;
          *(undefined1 *)(((ulong)plVar9 >> 9 & 0x7fffff) + lVar5) = 1;
          *(undefined1 *)(param_1 + 0xac) = 1;
          DataMemoryBarrier(2,3);
          plVar11 = (long *)(param_1 + 0x90);
          *plVar11 = *plVar9;
          *(undefined1 *)(((ulong)plVar11 >> 9 & 0x7fffff) + lVar5) = 1;
          if (*plVar11 == 0) goto LAB_101e20f6c;
          SDV_StardewValley_Menus_TutorialItem_show_06005e59();
        }
        uVar10 = 3;
      }
    }
    else {
      uVar10 = 4;
    }
  }
LAB_101e20d24:
  lStack_38 = 0;
  if (cStack_39 != '\0') {
    func_0x000100331c1c(uVar7);
  }
  switch(uVar10) {
  case 1:
  case 2:
  case 3:
  case 4:
    if (lStack_38 != 0) {
      func_0x000100331ba4();
    }
    return;
  default:
    func_0x000100331c30();
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101e20fa8);
    (*pcVar1)();
  }
}

