/* 0x06005da5 StardewValley.Menus.CoopGameMenu.readLobbyFarmData @ 0x101df7074 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Menus_CoopGameMenu_readLobbyFarmData_06005da5
               (undefined8 param_1,undefined8 param_2)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  undefined4 uVar4;
  int iVar5;
  long lVar6;
  undefined8 uVar7;
  long *plVar8;
  int iVar9;
  long lVar10;
  
  cVar2 = cRam0000000103910bb4;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033164c0);
    cRam0000000103910bb4 = '\x01';
  }
  lVar6 = func_0x000100331820(uRam0000000103900110,0x40);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar6 + 0x10) = param_2;
  lVar1 = lRam00000001038c4be0;
  *(undefined1 *)(((ulong)(lVar6 + 0x10) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  uVar7 = func_0x000100331820(uRam00000001038ce0b8,0x30);
  StardewValley_StardewValley_WorldDate__ctor_060042cf();
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar6 + 0x28) = uVar7;
  *(undefined1 *)(((ulong)(lVar6 + 0x28) >> 9 & 0x7fffff) + lVar1) = 1;
  plVar8 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
  uVar7 = _UNK_10369ceb0;
  if ((plVar8 != (long *)0x0) &&
     (plVar8 = (long *)(**(code **)(*plVar8 + -0x38))(), uVar7 = _UNK_10369ceb8,
     plVar8 != (long *)0x0)) {
    uVar7 = (**(code **)(*plVar8 + -8))(plVar8,param_2);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar6 + 0x18) = uVar7;
    *(undefined1 *)(((ulong)(lVar6 + 0x18) >> 9 & 0x7fffff) + lVar1) = 1;
    plVar8 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
    plVar8 = (long *)(**(code **)(*plVar8 + -0x38))();
    uVar7 = _UNK_10369cec8;
    if (plVar8 != (long *)0x0) {
      uVar7 = (**(code **)(*plVar8 + -0x58))(plVar8,param_2,uRam00000001038c9ca0);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar6 + 0x20) = uVar7;
      *(undefined1 *)(((ulong)(lVar6 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
      plVar8 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
      plVar8 = (long *)(**(code **)(*plVar8 + -0x38))();
      uVar7 = _UNK_10369ced8;
      if (plVar8 != (long *)0x0) {
        (**(code **)(*plVar8 + -0x58))(plVar8,param_2,uRam00000001038f5108);
        uVar4 = func_0x000100354a14();
        lVar10 = *(long *)(lVar6 + 0x28);
        *(undefined4 *)(lVar6 + 0x38) = uVar4;
        plVar8 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
        plVar8 = (long *)(**(code **)(*plVar8 + -0x38))();
        uVar7 = _UNK_10369cee8;
        if (plVar8 != (long *)0x0) {
          (**(code **)(*plVar8 + -0x58))(plVar8,param_2,uRam00000001038f5118);
          iVar5 = func_0x000100354a14();
          uVar7 = _UNK_10369cef0;
          if (lVar10 != 0) {
            StardewValley_StardewValley_WorldDate_set_DayOfMonth_060042c4(lVar10,iVar5 % 0x1c + 1);
            iVar9 = 3;
            if (-0x1c < iVar5) {
              iVar9 = 0;
            }
            StardewValley_StardewValley_WorldDate_set_Season_060042c7
                      (lVar10,(iVar9 + iVar5 / 0x1c & 3U) - iVar9);
            StardewValley_StardewValley_WorldDate_set_Year_060042c1(lVar10,iVar5 / 0x70 + 1);
            plVar8 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
            plVar8 = (long *)(**(code **)(*plVar8 + -0x38))();
            uVar7 = _UNK_10369cf00;
            if (plVar8 != (long *)0x0) {
              uVar7 = (**(code **)(*plVar8 + -0x58))(plVar8,param_2,uRam0000000103900128);
              DataMemoryBarrier(2,3);
              *(undefined8 *)(lVar6 + 0x30) = uVar7;
              *(undefined1 *)(((ulong)(lVar6 + 0x30) >> 9 & 0x7fffff) + lVar1) = 1;
              return lVar6;
            }
          }
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101df73ac);
  (*pcVar3)();
}

