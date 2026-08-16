/* 0x0600692d StardewValley.CloudSync+<>c__DisplayClass35_1.<UploadToCloud>b__1 @ 0x101feffc4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync___c__DisplayClass35_1__UploadToCloud_b__1_0600692d
               (long param_1,undefined8 param_2,long param_3)

{
  long lVar1;
  uint uVar2;
  long lVar3;
  char cVar4;
  code *pcVar5;
  undefined8 uVar6;
  int iVar7;
  undefined8 uStack_60;
  undefined8 uStack_58;
  long lStack_50;
  undefined8 uStack_48;
  ulong uStack_40;
  
  cVar4 = cRam000000010391173c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103327101);
    cRam000000010391173c = '\x01';
  }
  uStack_40 = 0;
  uStack_58 = 0;
  uStack_60 = 0;
  uStack_48 = 0;
  lStack_50 = 0;
  if (param_3 == 0) {
    uVar6 = _UNK_1036dbbe8;
    if (param_1 == 0) goto LAB_101ff014c;
  }
  else {
    func_0x0001003318fc(&uStack_60,0x27,1);
    lVar3 = lRam0000000103905540;
    uVar6 = _UNK_1036dbbf8;
    if (&stack0x00000000 == (undefined1 *)0x50) goto LAB_101ff014c;
    if ((uint)uStack_48 < (uint)uStack_40) {
      func_0x0001003319d8();
                    /* WARNING: Does not return */
      pcVar5 = (code *)SoftwareBreakpoint(1,0x101ff0120);
      (*pcVar5)();
    }
    uVar2 = *(uint *)(lRam0000000103905540 + 0x10);
    if ((uint)uStack_48 - (uint)uStack_40 < uVar2) {
      func_0x000100331910(&uStack_60,lRam0000000103905540);
    }
    else {
      iVar7 = 0;
      if (uVar2 != 0) {
        lVar1 = lStack_50 + (uStack_40 & 0xffffffff) * 2;
        uVar6 = _UNK_1036dbc10;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036dbc18, lRam0000000103905540 + 0x14 == 0))
        goto LAB_101ff014c;
        _memmove(lVar1,lRam0000000103905540 + 0x14,(ulong)uVar2 << 1);
        iVar7 = *(int *)(lVar3 + 0x10);
      }
      uStack_40 = CONCAT44(uStack_40._4_4_,iVar7 + (uint)uStack_40);
    }
    func_0x00010037f124(&uStack_60,param_3);
    func_0x000100331938(&uStack_60);
    func_0x00010033180c();
    *(undefined1 *)(*(long *)(param_1 + 0x18) + 0x20) = 0;
  }
  uVar6 = _UNK_1036dbbf0;
  if (*(long *)(param_1 + 0x10) != 0) {
    func_0x00010037f098();
    return;
  }
LAB_101ff014c:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x101ff0158);
  (*pcVar5)();
}

