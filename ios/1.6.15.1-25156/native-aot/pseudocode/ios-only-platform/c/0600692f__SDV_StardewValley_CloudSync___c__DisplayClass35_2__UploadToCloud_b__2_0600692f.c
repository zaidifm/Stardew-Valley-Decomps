/* 0x0600692f StardewValley.CloudSync+<>c__DisplayClass35_2.<UploadToCloud>b__2 @ 0x101ff015c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync___c__DisplayClass35_2__UploadToCloud_b__2_0600692f
               (long param_1,long param_2,undefined8 param_3,long param_4)

{
  long lVar1;
  uint uVar2;
  char cVar3;
  code *pcVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  int iVar7;
  long lVar8;
  undefined8 *puVar9;
  undefined8 uStack_70;
  undefined8 uStack_68;
  long lStack_60;
  undefined8 uStack_58;
  ulong uStack_50;
  
  cVar3 = cRam000000010391173e;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_10332710f);
    cRam000000010391173e = '\x01';
  }
  uStack_50 = 0;
  uStack_68 = 0;
  uStack_70 = 0;
  uStack_58 = 0;
  lStack_60 = 0;
  if (param_4 == 0) {
    uVar6 = _UNK_1036dbc20;
    if (param_1 == 0) goto LAB_101ff0364;
    if (*(int *)(param_2 + 0x18) == 0) {
      func_0x0001003316f4(0xcc,_UNK_1036dbc70);
                    /* WARNING: Does not return */
      pcVar4 = (code *)SoftwareBreakpoint(1,0x101ff0338);
      (*pcVar4)();
    }
    uVar6 = _UNK_1036dbc30;
    if (*(long *)(param_2 + 0x20) == 0) goto LAB_101ff0364;
    lVar8 = *(long *)(param_1 + 0x18);
    uVar5 = func_0x00010037f138();
    uVar6 = _UNK_1036dbc38;
    if (lVar8 == 0) goto LAB_101ff0364;
    DataMemoryBarrier(2,3);
    puVar9 = (undefined8 *)(lVar8 + 0x10);
    *puVar9 = uVar5;
    *(undefined1 *)(((ulong)puVar9 >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  }
  else {
    func_0x0001003318fc(&uStack_70,0x2f,1);
    lVar8 = lRam0000000103905550;
    uVar6 = _UNK_1036dbc48;
    if (&stack0x00000000 == (undefined1 *)0x60) goto LAB_101ff0364;
    if ((uint)uStack_58 < (uint)uStack_50) {
      func_0x0001003319d8();
                    /* WARNING: Does not return */
      pcVar4 = (code *)SoftwareBreakpoint(1,0x101ff02f4);
      (*pcVar4)();
    }
    uVar2 = *(uint *)(lRam0000000103905550 + 0x10);
    if ((uint)uStack_58 - (uint)uStack_50 < uVar2) {
      func_0x000100331910(&uStack_70,lRam0000000103905550);
    }
    else {
      iVar7 = 0;
      if (uVar2 != 0) {
        lVar1 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
        uVar6 = _UNK_1036dbc60;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036dbc68, lRam0000000103905550 + 0x14 == 0))
        goto LAB_101ff0364;
        _memmove(lVar1,lRam0000000103905550 + 0x14,(ulong)uVar2 << 1);
        iVar7 = *(int *)(lVar8 + 0x10);
      }
      uStack_50 = CONCAT44(uStack_50._4_4_,iVar7 + (uint)uStack_50);
    }
    func_0x00010037f124(&uStack_70,param_4);
    func_0x000100331938(&uStack_70);
    func_0x00010033180c();
    *(undefined1 *)(*(long *)(param_1 + 0x18) + 0x20) = 0;
  }
  uVar6 = _UNK_1036dbc40;
  if (*(long *)(param_1 + 0x10) != 0) {
    func_0x00010037f098();
    return;
  }
LAB_101ff0364:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101ff0370);
  (*pcVar4)();
}

