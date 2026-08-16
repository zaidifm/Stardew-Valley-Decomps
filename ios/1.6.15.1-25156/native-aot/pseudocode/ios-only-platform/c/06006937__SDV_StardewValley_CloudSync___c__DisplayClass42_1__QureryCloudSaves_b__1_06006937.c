/* 0x06006937 StardewValley.CloudSync+<>c__DisplayClass42_1.<QureryCloudSaves>b__1 @ 0x101ff06f8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_CloudSync___c__DisplayClass42_1__QureryCloudSaves_b__1_06006937
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
  
  cVar4 = cRam0000000103911746;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_10332713a);
    cRam0000000103911746 = '\x01';
  }
  uStack_40 = 0;
  uStack_58 = 0;
  uStack_60 = 0;
  uStack_48 = 0;
  lStack_50 = 0;
  if (param_3 == 0) {
    uVar6 = _UNK_1036dbcd8;
    if (param_1 == 0) goto LAB_101ff0888;
  }
  else {
    func_0x0001003318fc(&uStack_60,0x18,1);
    lVar3 = lRam0000000103905568;
    uVar6 = _UNK_1036dbce8;
    if (&stack0x00000000 == (undefined1 *)0x50) goto LAB_101ff0888;
    if ((uint)uStack_48 < (uint)uStack_40) {
      func_0x0001003319d8();
                    /* WARNING: Does not return */
      pcVar5 = (code *)SoftwareBreakpoint(1,0x101ff085c);
      (*pcVar5)();
    }
    uVar2 = *(uint *)(lRam0000000103905568 + 0x10);
    if ((uint)uStack_48 - (uint)uStack_40 < uVar2) {
      func_0x000100331910(&uStack_60,lRam0000000103905568);
    }
    else {
      iVar7 = 0;
      if (uVar2 != 0) {
        lVar1 = lStack_50 + (uStack_40 & 0xffffffff) * 2;
        uVar6 = _UNK_1036dbd00;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036dbd08, lRam0000000103905568 + 0x14 == 0))
        goto LAB_101ff0888;
        _memmove(lVar1,lRam0000000103905568 + 0x14,(ulong)uVar2 << 1);
        iVar7 = *(int *)(lVar3 + 0x10);
      }
      uStack_40 = CONCAT44(uStack_40._4_4_,iVar7 + (uint)uStack_40);
    }
    func_0x00010037f124(&uStack_60,param_3);
    func_0x000100331938(&uStack_60);
    func_0x00010033180c();
    uVar6 = _UNK_1036dbcf8;
    if (*(long *)(param_1 + 0x18) == 0) goto LAB_101ff0888;
    *(undefined1 *)(*(long *)(param_1 + 0x18) + 0x18) = 1;
  }
  uVar6 = _UNK_1036dbce0;
  if (*(long *)(param_1 + 0x10) != 0) {
    func_0x00010037f098();
    return;
  }
LAB_101ff0888:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x101ff0894);
  (*pcVar5)();
}

