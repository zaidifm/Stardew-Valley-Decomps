/* 0x0600684b StardewValley.iOSStuff+<>c__DisplayClass0_0.<ShowKeyboard>b__0 @ 0x101fdf508 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_iOSStuff_c_DisplayClass0_0_ShowKeyboard_b_0_0600684b
               (long param_1,long param_2)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  long lVar6;
  long *plVar7;
  
  cVar2 = cRam000000010391165a;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033264e0);
    cRam000000010391165a = '\x01';
  }
  uVar5 = _UNK_1036d9aa8;
  if (param_2 != 0) {
    DataMemoryBarrier(2,1);
    if ((*(uint *)(param_2 + 0x3c) & 0x1600000) == 0) {
      return;
    }
    uVar5 = _UNK_1036d9ab8;
    if (*(long *)(param_1 + 0x10) != 0) {
      lVar4 = func_0x00010037ebe8();
      if (lVar4 == 0) {
        if (*pcRam0000000103905030 == '\0') {
          return;
        }
        func_0x00010037ebfc(0);
        return;
      }
      plVar7 = *(long **)(param_1 + 0x18);
      uVar5 = _UNK_1036d9ad0;
      if (plVar7 != (long *)0x0) {
        if (lRam00000001039017a0 == *(long *)(*(long *)(*(long *)*plVar7 + 0x10) + 0x10)) {
          lVar6 = plVar7[0x10];
          *(undefined4 *)(plVar7 + 0x11) = 0;
          uVar5 = _UNK_1036d9ac0;
          if (lVar6 == 0) goto LAB_101fdf684;
          iVar1 = *(int *)(lVar6 + 0x18);
          *(undefined4 *)(lVar6 + 0x18) = 0;
          *(int *)(lVar6 + 0x1c) = *(int *)(lVar6 + 0x1c) + 1;
          if (0 < iVar1) {
            func_0x000100331c80(*(undefined8 *)(lVar6 + 0x10),0);
          }
          (**(code **)(*plVar7 + 0xa8))(plVar7,lVar4);
          lVar4 = *(long *)(param_1 + 0x18);
          uVar5 = _UNK_1036d9ac8;
        }
        else {
          func_0x000101f7c5d4(plVar7,lVar4);
          lVar4 = *(long *)(param_1 + 0x18);
          uVar5 = _UNK_1036d9ac8;
        }
        _UNK_1036d9ac8 = uVar5;
        if (lVar4 != 0) {
          func_0x000101f7d718();
          return;
        }
      }
    }
  }
LAB_101fdf684:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fdf690);
  (*pcVar3)();
}

