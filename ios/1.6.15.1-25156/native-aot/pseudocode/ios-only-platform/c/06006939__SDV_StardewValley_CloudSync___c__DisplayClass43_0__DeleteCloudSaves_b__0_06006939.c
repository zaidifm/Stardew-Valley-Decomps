/* 0x06006939 StardewValley.CloudSync+<>c__DisplayClass43_0.<DeleteCloudSaves>b__0 @ 0x101ff0898 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync___c__DisplayClass43_0__DeleteCloudSaves_b__0_06006939
               (long param_1,undefined8 param_2,long param_3,long param_4)

{
  long lVar1;
  uint uVar2;
  long lVar3;
  char cVar4;
  code *pcVar5;
  undefined8 uVar6;
  int iVar7;
  long *plVar8;
  ulong uVar9;
  undefined8 uStack_70;
  undefined8 uStack_68;
  long lStack_60;
  undefined8 uStack_58;
  ulong uStack_50;
  
  cVar4 = cRam0000000103911748;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103327148);
    cRam0000000103911748 = '\x01';
  }
  uStack_50 = 0;
  uStack_68 = 0;
  uStack_70 = 0;
  uStack_58 = 0;
  lStack_60 = 0;
  if (param_4 != 0) {
    func_0x0001003318fc(&uStack_70,0x32,1);
    lVar3 = lRam0000000103905570;
    uVar6 = _UNK_1036dbd30;
    if (&stack0x00000000 == (undefined1 *)0x60) goto LAB_101ff0a10;
    if ((uint)uStack_58 < (uint)uStack_50) {
      func_0x0001003319d8();
                    /* WARNING: Does not return */
      pcVar5 = (code *)SoftwareBreakpoint(1,0x101ff0a54);
      (*pcVar5)();
    }
    uVar2 = *(uint *)(lRam0000000103905570 + 0x10);
    if ((uint)uStack_58 - (uint)uStack_50 < uVar2) {
      func_0x000100331910(&uStack_70,lRam0000000103905570);
    }
    else {
      iVar7 = 0;
      if (uVar2 != 0) {
        lVar1 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
        uVar6 = _UNK_1036dbd38;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036dbd40, lRam0000000103905570 + 0x14 == 0))
        goto LAB_101ff0a10;
        _memmove(lVar1,lRam0000000103905570 + 0x14,(ulong)uVar2 << 1);
        iVar7 = *(int *)(lVar3 + 0x10);
      }
      uStack_50 = CONCAT44(uStack_50._4_4_,iVar7 + (uint)uStack_50);
    }
    func_0x00010037f124(&uStack_70,param_4);
    func_0x000100331938(&uStack_70);
    func_0x00010033180c();
  }
  uVar9 = (ulong)*(uint *)(param_3 + 0x18);
  if (0 < (int)*(uint *)(param_3 + 0x18)) {
    plVar8 = (long *)(param_3 + 0x20);
    do {
      uVar6 = _UNK_1036dbd18;
      if (*plVar8 == 0) goto LAB_101ff0a10;
      func_0x00010037f188();
      SDV_StardewValley_CloudSync_DeleteSyncronizedState_060032e4();
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      plVar8 = plVar8 + 1;
      uVar9 = uVar9 - 1;
    } while (uVar9 != 0);
  }
  uVar6 = _UNK_1036dbd28;
  if (*(long *)(param_1 + 0x10) != 0) {
    func_0x00010037f098();
    return;
  }
LAB_101ff0a10:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x101ff0a1c);
  (*pcVar5)();
}

