/* 0x06005da4 StardewValley.Menus.CoopGameMenu.saveFileScanComplete @ 0x101df6ec4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_saveFileScanComplete_06005da4(long param_1)

{
  char cVar1;
  code *pcVar2;
  long *plVar3;
  long lVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  long lVar7;
  
  cVar1 = cRam0000000103910bb3;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103316490);
    cRam0000000103910bb3 = '\x01';
    plVar3 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
  }
  else {
    plVar3 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
  }
  uVar5 = _UNK_10369ce80;
  if (plVar3 != (long *)0x0) {
    lVar4 = (**(code **)(*plVar3 + -0x38))();
    if (lVar4 == 0) {
      return;
    }
    uVar5 = func_0x00010034ef4c(param_1,uRam00000001039000e0);
    uVar6 = func_0x000100331820(uRam00000001039000e8,0x80);
    func_0x000100377348(uVar6,param_1,uVar5);
    lVar7 = func_0x000100331820(uRam00000001039000f8,0x18);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar7 + 0x10) = uVar6;
    lVar4 = lRam00000001038c4be0;
    *(undefined1 *)(((ulong)(lVar7 + 0x10) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    uVar5 = _UNK_10369ce88;
    if (param_1 != 0) {
      DataMemoryBarrier(2,3);
      *(long *)(param_1 + 0x198) = lVar7;
      *(undefined1 *)((param_1 + 0x198U >> 9 & 0x7fffff) + lVar4) = 1;
      plVar3 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
      plVar3 = (long *)(**(code **)(*plVar3 + -0x38))();
      uVar5 = _UNK_10369ce98;
      if (plVar3 != (long *)0x0) {
        (**(code **)(*plVar3 + -0x88))(plVar3,*(undefined8 *)(param_1 + 0x198));
        plVar3 = (long *)StardewValley_StardewValley_Program_get_sdk_06003f56();
        plVar3 = (long *)(**(code **)(*plVar3 + -0x38))();
        uVar5 = _UNK_10369cea8;
        if (plVar3 != (long *)0x0) {
          (**(code **)(*plVar3 + -0x38))();
          return;
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101df7074);
  (*pcVar2)();
}

