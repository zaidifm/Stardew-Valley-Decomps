/* 0x06005e90 StardewValley.Menus.TutorialManager.triggerAttackChoice @ 0x101e22f64 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_triggerAttackChoice_06005e90(long param_1)

{
  long lVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  long *plVar5;
  undefined8 uVar6;
  long lVar7;
  undefined8 uVar8;
  undefined8 uVar9;
  
  cVar3 = cRam0000000103910c9f;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103317ae0);
    cRam0000000103910c9f = '\x01';
    cVar3 = *(char *)(param_1 + 0xcc);
  }
  else {
    cVar3 = *(char *)(param_1 + 0xcc);
  }
  if ((cVar3 == '\0') &&
     (cVar3 = SDV_StardewValley_Game1_isGamePadConnected_06002f76(), cVar3 == '\0')) {
    lVar4 = func_0x000100331820(uRam00000001038d5af8,0x20);
    lVar1 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038d5b00;
    *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar8 = uRam00000001038e8320;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    plVar5 = (long *)*plRam00000001038d5338;
    uVar6 = _UNK_1036a3018;
    if (plVar5 != (long *)0x0) {
      uVar6 = (**(code **)(*plVar5 + 0x100))(plVar5,uRam00000001038e8328);
      lVar7 = func_0x000100331820(uRam00000001038e38c8,0x28);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar7 + 0x10) = uVar8;
      *(undefined1 *)(((ulong)(lVar7 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar7 + 0x18) = uVar6;
      *(undefined1 *)(((ulong)(lVar7 + 0x18) >> 9 & 0x7fffff) + lVar1) = 1;
      plVar5 = *(long **)(lVar4 + 0x10);
      *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
      uVar6 = _UNK_1036a3020;
      if (plVar5 != (long *)0x0) {
        if (*(uint *)(lVar4 + 0x18) < *(uint *)(plVar5 + 3)) {
          *(uint *)(lVar4 + 0x18) = *(uint *)(lVar4 + 0x18) + 1;
          (**(code **)(*plVar5 + 0x110))();
        }
        else {
          func_0x0001003548d4(lVar4,lVar7);
        }
        uVar8 = uRam00000001038e3928;
        plVar5 = (long *)*plRam00000001038d5338;
        uVar6 = _UNK_1036a3028;
        if (plVar5 != (long *)0x0) {
          uVar6 = (**(code **)(*plVar5 + 0x100))(plVar5,uRam00000001038e8330);
          lVar7 = func_0x000100331820(uRam00000001038e38c8,0x28);
          DataMemoryBarrier(2,3);
          *(undefined8 *)(lVar7 + 0x10) = uVar8;
          *(undefined1 *)(((ulong)(lVar7 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
          DataMemoryBarrier(2,3);
          *(undefined8 *)(lVar7 + 0x18) = uVar6;
          *(undefined1 *)(((ulong)(lVar7 + 0x18) >> 9 & 0x7fffff) + lVar1) = 1;
          plVar5 = *(long **)(lVar4 + 0x10);
          *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
          uVar6 = _UNK_1036a3030;
          if (plVar5 != (long *)0x0) {
            if (*(uint *)(lVar4 + 0x18) < *(uint *)(plVar5 + 3)) {
              *(uint *)(lVar4 + 0x18) = *(uint *)(lVar4 + 0x18) + 1;
              (**(code **)(*plVar5 + 0x110))();
            }
            else {
              func_0x0001003548d4(lVar4,lVar7);
            }
            plVar5 = (long *)*plRam00000001038d5338;
            uVar6 = _UNK_1036a3038;
            if (plVar5 != (long *)0x0) {
              uVar8 = (**(code **)(*plVar5 + 0x100))(plVar5,uRam0000000103900a08);
              uVar6 = func_0x00010036164c(lVar4);
              StardewValley_StardewValley_Menus_DialogueBox_GetWidth_0600609a();
              uVar9 = func_0x000100331820(uRam00000001038d6f90,0x108);
              StardewValley_StardewValley_Menus_DialogueBox__ctor_06006077(uVar9,uVar8,uVar6);
              DataMemoryBarrier(2,3);
              *(undefined8 *)(param_1 + 0x98) = uVar9;
              *(undefined1 *)(((ulong)(param_1 + 0x98) >> 9 & 0x7fffff) + lVar1) = 1;
              *(undefined1 *)(param_1 + 0xcd) = 1;
              return;
            }
          }
        }
      }
    }
    func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101e23238);
    (*pcVar2)();
  }
  return;
}

