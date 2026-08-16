/* 0x06005da1 StardewValley.Menus.CoopGameMenu.connectionFinished @ 0x101df69d4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_connectionFinished_06005da1(long param_1)

{
  uint uVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  code *pcVar4;
  char cVar5;
  long *plVar6;
  undefined8 uVar7;
  long lVar8;
  undefined8 uVar9;
  long lVar10;
  float fVar11;
  undefined8 uStack_50;
  undefined8 uStack_48;
  
  cVar5 = cRam0000000103910bb0;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar5 == '\0') {
    func_0x00010119b908(&UNK_103316450);
    cRam0000000103910bb0 = '\x01';
  }
  uVar9 = _UNK_10369ce08;
  if (param_1 != 0) {
    *(undefined1 *)(param_1 + 0x1b0) = 1;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    plVar6 = (long *)*plRam00000001038d5338;
    uVar9 = _UNK_10369ce10;
    if (plVar6 != (long *)0x0) {
      uVar7 = (**(code **)(*plVar6 + 0x100))(plVar6,uRam00000001039000a8);
      uVar9 = _UNK_10369ce18;
      if (*plRam00000001038c4c90 != 0) {
        fVar11 = (float)func_0x0001003560e4(*plRam00000001038c4c90,uVar7);
        uStack_50 = 0;
        uStack_48 = 0;
        func_0x00010034ede4(&uStack_50,100,100,(int)fVar11 + 0x40,0x60);
        uVar3 = uStack_48;
        uVar2 = uStack_50;
        uVar9 = uRam00000001038c4f58;
        lVar8 = func_0x000100331820(uRam00000001038f6cb0,0x78);
        *(undefined8 *)(lVar8 + 0x38) = uVar2;
        *(undefined8 *)(lVar8 + 0x40) = uVar3;
        *(undefined4 *)(lVar8 + 0x48) = 0x3f800000;
        *(undefined8 *)(lVar8 + 0x54) = 0xfffffe0cfffffe0c;
        *(undefined1 *)(lVar8 + 0x4c) = 1;
        *(undefined8 *)(lVar8 + 0x5c) = 0xffffffffffffffff;
        *(undefined8 *)(lVar8 + 100) = 0xffffffffffffffff;
        lVar10 = lRam00000001038c4be0;
        DataMemoryBarrier(2,3);
        *(undefined8 *)(lVar8 + 0x10) = uVar9;
        *(undefined1 *)(((ulong)(lVar8 + 0x10) >> 9 & 0x7fffff) + lVar10) = 1;
        DataMemoryBarrier(2,3);
        *(undefined8 *)(lVar8 + 0x18) = uVar7;
        *(undefined1 *)(((ulong)(lVar8 + 0x18) >> 9 & 0x7fffff) + lVar10) = 1;
        DataMemoryBarrier(2,3);
        *(long *)(param_1 + 0x180) = lVar8;
        *(undefined1 *)((param_1 + 0x180U >> 9 & 0x7fffff) + lVar10) = 1;
        lVar10 = *(long *)(param_1 + 0x178);
        uVar7 = func_0x000100331820(uRam00000001039000b0,0x38);
        SDV_StardewValley_Menus_CoopGameMenu_HostNewFarmSlot__ctor_060072c8(uVar7,param_1);
        plVar6 = *(long **)(lVar10 + 0x10);
        *(int *)(lVar10 + 0x1c) = *(int *)(lVar10 + 0x1c) + 1;
        uVar9 = _UNK_10369ce28;
        if (plVar6 != (long *)0x0) {
          uVar1 = *(uint *)(lVar10 + 0x18);
          if (uVar1 < *(uint *)(plVar6 + 3)) {
            *(uint *)(lVar10 + 0x18) = uVar1 + 1;
            (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,uVar7);
          }
          else {
            func_0x0001003772e4(lVar10,uVar7);
          }
          lVar10 = *(long *)(param_1 + 0xd0);
          uVar7 = func_0x000100331820(uRam00000001039000c0,0x38);
          SDV_StardewValley_Menus_CoopGameMenu_LanSlot__ctor_060072c4(uVar7,param_1);
          plVar6 = *(long **)(lVar10 + 0x10);
          *(int *)(lVar10 + 0x1c) = *(int *)(lVar10 + 0x1c) + 1;
          uVar9 = _UNK_10369ce38;
          if (plVar6 != (long *)0x0) {
            uVar1 = *(uint *)(lVar10 + 0x18);
            if (uVar1 < *(uint *)(plVar6 + 3)) {
              *(uint *)(lVar10 + 0x18) = uVar1 + 1;
              (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,uVar7);
            }
            else {
              func_0x0001003772e4(lVar10,uVar7);
            }
            plVar6 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
            uVar9 = _UNK_10369ce40;
            if (plVar6 != (long *)0x0) {
              lVar10 = (**(code **)(*plVar6 + -0x38))();
              if (lVar10 != 0) {
                plVar6 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
                plVar6 = (long *)(**(code **)(*plVar6 + -0x38))();
                uVar9 = _UNK_10369ce50;
                if (plVar6 == (long *)0x0) goto LAB_101df6d9c;
                cVar5 = (**(code **)(*plVar6 + -0x58))();
                if (cVar5 != '\0') {
                  lVar10 = *(long *)(param_1 + 0xd0);
                  uVar7 = func_0x000100331820(uRam00000001039000d0,0x38);
                  SDV_StardewValley_Menus_CoopGameMenu_InviteCodeSlot__ctor_060072c6(uVar7,param_1);
                  plVar6 = *(long **)(lVar10 + 0x10);
                  *(int *)(lVar10 + 0x1c) = *(int *)(lVar10 + 0x1c) + 1;
                  uVar9 = _UNK_10369ce60;
                  if (plVar6 == (long *)0x0) goto LAB_101df6d9c;
                  uVar1 = *(uint *)(lVar10 + 0x18);
                  if (uVar1 < *(uint *)(plVar6 + 3)) {
                    *(uint *)(lVar10 + 0x18) = uVar1 + 1;
                    (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,uVar7);
                  }
                  else {
                    func_0x0001003772e4(lVar10,uVar7);
                  }
                }
              }
              StardewValley_StardewValley_Menus_LoadGameMenu_startListPopulation_060062c7
                        (param_1,*(undefined8 *)(param_1 + 0x1a0));
              return;
            }
          }
        }
      }
    }
  }
LAB_101df6d9c:
  func_0x0001003316f4(0xee,uVar9);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101df6da8);
  (*pcVar4)();
}

