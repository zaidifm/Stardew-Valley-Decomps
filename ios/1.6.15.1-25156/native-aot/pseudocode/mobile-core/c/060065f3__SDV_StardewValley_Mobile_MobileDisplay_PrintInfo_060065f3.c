/* 0x060065f3 StardewValley.Mobile.MobileDisplay.PrintInfo @ 0x101fa0418 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_MobileDisplay_PrintInfo_060065f3
               (ulong param_1,undefined4 param_2,undefined4 param_3,undefined4 param_4)

{
  long lVar1;
  uint uVar2;
  char cVar3;
  code *pcVar4;
  long lVar5;
  undefined8 uVar6;
  uint uVar7;
  int iVar8;
  undefined8 uStack_70;
  undefined8 uStack_68;
  long lStack_60;
  undefined8 uStack_58;
  ulong uStack_50;
  
  cVar3 = cRam0000000103911402;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1033247f0);
    cRam0000000103911402 = '\x01';
  }
  uStack_50 = 0;
  uStack_68 = 0;
  uStack_70 = 0;
  uStack_58 = 0;
  lStack_60 = 0;
  func_0x0001003318fc(&uStack_70,0x69,8);
  lVar5 = lRam0000000103904520;
  uVar6 = _UNK_1036d1558;
  if (&stack0x00000000 == (undefined1 *)0x60) goto LAB_101fa0bf4;
  if ((uint)uStack_58 < (uint)uStack_50) goto LAB_101fa0aac;
  uVar7 = *(uint *)(lRam0000000103904520 + 0x10);
  if ((uint)uStack_58 - (uint)uStack_50 < uVar7) {
    func_0x000100331910(&uStack_70,lRam0000000103904520);
    if ((param_1 & 0xff) != 0) goto LAB_101fa04b8;
LAB_101fa0514:
    uVar6 = *puRam00000001038c4cd8;
  }
  else {
    iVar8 = 0;
    if (uVar7 != 0) {
      lVar1 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
      uVar6 = _UNK_1036d1620;
      if ((lVar1 == 0) || (uVar6 = _UNK_1036d1628, lRam0000000103904520 + 0x14 == 0))
      goto LAB_101fa0bf4;
      _memmove(lVar1,lRam0000000103904520 + 0x14,(ulong)uVar7 << 1);
      iVar8 = *(int *)(lVar5 + 0x10);
    }
    uStack_50 = CONCAT44(uStack_50._4_4_,iVar8 + (uint)uStack_50);
    if ((param_1 & 0xff) == 0) goto LAB_101fa0514;
LAB_101fa04b8:
    lVar5 = func_0x000100331820(uRam0000000103904510,0x14);
    *(int *)(lVar5 + 0x10) = (int)(param_1 >> 0x20);
    uVar6 = func_0x000100356abc();
  }
  func_0x00010034ef38(&uStack_70,uVar6);
  lVar5 = lRam00000001038c4d00;
  if ((uint)uStack_50 <= (uint)uStack_58) {
    uVar7 = *(uint *)(lRam00000001038c4d00 + 0x10);
    if ((uint)uStack_58 - (uint)uStack_50 < uVar7) {
      func_0x000100331910(&uStack_70,lRam00000001038c4d00);
    }
    else {
      iVar8 = 0;
      if (uVar7 != 0) {
        lVar1 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
        uVar6 = _UNK_1036d1610;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036d1618, lRam00000001038c4d00 + 0x14 == 0))
        goto LAB_101fa0bf4;
        _memmove(lVar1,lRam00000001038c4d00 + 0x14,(ulong)uVar7 << 1);
        iVar8 = *(int *)(lVar5 + 0x10);
      }
      uStack_50 = CONCAT44(uStack_50._4_4_,iVar8 + (uint)uStack_50);
    }
    func_0x000100331924(&uStack_70,param_2);
    lVar5 = lRam00000001038e1030;
    if ((uint)uStack_58 < (uint)uStack_50) goto LAB_101fa0aac;
    uVar7 = *(uint *)(lRam00000001038e1030 + 0x10);
    if ((uint)uStack_58 - (uint)uStack_50 < uVar7) {
      func_0x000100331910(&uStack_70,lRam00000001038e1030);
    }
    else {
      iVar8 = 0;
      if (uVar7 != 0) {
        lVar1 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
        uVar6 = _UNK_1036d1600;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036d1608, lRam00000001038e1030 + 0x14 == 0))
        goto LAB_101fa0bf4;
        _memmove(lVar1,lRam00000001038e1030 + 0x14,(ulong)uVar7 << 1);
        iVar8 = *(int *)(lVar5 + 0x10);
      }
      uStack_50 = CONCAT44(uStack_50._4_4_,iVar8 + (uint)uStack_50);
    }
    func_0x000100331924(&uStack_70,param_3);
    lVar5 = lRam00000001038c4d00;
    if ((uint)uStack_58 < (uint)uStack_50) goto LAB_101fa0aac;
    uVar7 = *(uint *)(lRam00000001038c4d00 + 0x10);
    if ((uint)uStack_58 - (uint)uStack_50 < uVar7) {
      func_0x000100331910(&uStack_70,lRam00000001038c4d00);
    }
    else {
      iVar8 = 0;
      if (uVar7 != 0) {
        lVar1 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
        uVar6 = _UNK_1036d15f0;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036d15f8, lRam00000001038c4d00 + 0x14 == 0))
        goto LAB_101fa0bf4;
        _memmove(lVar1,lRam00000001038c4d00 + 0x14,(ulong)uVar7 << 1);
        iVar8 = *(int *)(lVar5 + 0x10);
      }
      uStack_50 = CONCAT44(uStack_50._4_4_,iVar8 + (uint)uStack_50);
    }
    func_0x000100331924(&uStack_70,param_4);
    lVar5 = lRam0000000103904528;
    if ((uint)uStack_58 < (uint)uStack_50) goto LAB_101fa0aac;
    uVar7 = *(uint *)(lRam0000000103904528 + 0x10);
    if ((uint)uStack_58 - (uint)uStack_50 < uVar7) {
      func_0x000100331910(&uStack_70,lRam0000000103904528);
      uVar7 = (uint)uStack_50;
    }
    else {
      iVar8 = 0;
      if (uVar7 != 0) {
        lVar1 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
        uVar6 = _UNK_1036d15e0;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036d15e8, lRam0000000103904528 + 0x14 == 0))
        goto LAB_101fa0bf4;
        _memmove(lVar1,lRam0000000103904528 + 0x14,(ulong)uVar7 << 1);
        iVar8 = *(int *)(lVar5 + 0x10);
      }
      uVar7 = iVar8 + (uint)uStack_50;
      uStack_50 = CONCAT44(uStack_50._4_4_,uVar7);
    }
    lVar5 = lRam0000000103904530;
    if ((uint)uStack_58 < uVar7) goto LAB_101fa0aac;
    uVar2 = *(uint *)(lRam0000000103904530 + 0x10);
    if ((uint)uStack_58 - uVar7 < uVar2) {
      func_0x000100331910(&uStack_70,lRam0000000103904530);
    }
    else {
      iVar8 = 0;
      if (uVar2 != 0) {
        lVar1 = lStack_60 + (ulong)uVar7 * 2;
        uVar6 = _UNK_1036d15d0;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036d15d8, lRam0000000103904530 + 0x14 == 0))
        goto LAB_101fa0bf4;
        _memmove(lVar1,lRam0000000103904530 + 0x14,(ulong)uVar2 << 1);
        iVar8 = *(int *)(lVar5 + 0x10);
        uVar7 = (uint)uStack_50;
      }
      uStack_50 = CONCAT44(uStack_50._4_4_,iVar8 + uVar7);
    }
    SDV_StardewValley_Mobile_MobileDisplay_get_ZoomScale_060065e4();
    func_0x000100361bec(&uStack_70);
    lVar5 = lRam00000001038d7278;
    if ((uint)uStack_58 < (uint)uStack_50) goto LAB_101fa0aac;
    uVar7 = *(uint *)(lRam00000001038d7278 + 0x10);
    if ((uint)uStack_58 - (uint)uStack_50 < uVar7) {
      func_0x000100331910(&uStack_70,lRam00000001038d7278);
      uVar7 = (uint)uStack_50;
    }
    else {
      iVar8 = 0;
      if (uVar7 != 0) {
        lVar1 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
        uVar6 = _UNK_1036d15c0;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036d15c8, lRam00000001038d7278 + 0x14 == 0))
        goto LAB_101fa0bf4;
        _memmove(lVar1,lRam00000001038d7278 + 0x14,(ulong)uVar7 << 1);
        iVar8 = *(int *)(lVar5 + 0x10);
      }
      uVar7 = iVar8 + (uint)uStack_50;
      uStack_50 = CONCAT44(uStack_50._4_4_,uVar7);
    }
    lVar5 = lRam0000000103904538;
    if ((uint)uStack_58 < uVar7) goto LAB_101fa0aac;
    uVar2 = *(uint *)(lRam0000000103904538 + 0x10);
    if ((uint)uStack_58 - uVar7 < uVar2) {
      func_0x000100331910(&uStack_70,lRam0000000103904538);
    }
    else {
      iVar8 = 0;
      if (uVar2 != 0) {
        lVar1 = lStack_60 + (ulong)uVar7 * 2;
        uVar6 = _UNK_1036d15b0;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036d15b8, lRam0000000103904538 + 0x14 == 0))
        goto LAB_101fa0bf4;
        _memmove(lVar1,lRam0000000103904538 + 0x14,(ulong)uVar2 << 1);
        iVar8 = *(int *)(lVar5 + 0x10);
        uVar7 = (uint)uStack_50;
      }
      uStack_50 = CONCAT44(uStack_50._4_4_,iVar8 + uVar7);
    }
    SDV_StardewValley_Mobile_MobileDisplay_get_MenuButtonScale_060065e6();
    func_0x000100361bec(&uStack_70);
    lVar5 = lRam00000001038d7278;
    if ((uint)uStack_58 < (uint)uStack_50) goto LAB_101fa0aac;
    uVar7 = *(uint *)(lRam00000001038d7278 + 0x10);
    if ((uint)uStack_58 - (uint)uStack_50 < uVar7) {
      func_0x000100331910(&uStack_70,lRam00000001038d7278);
      uVar7 = (uint)uStack_50;
    }
    else {
      iVar8 = 0;
      if (uVar7 != 0) {
        lVar1 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
        uVar6 = _UNK_1036d15a0;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036d15a8, lRam00000001038d7278 + 0x14 == 0))
        goto LAB_101fa0bf4;
        _memmove(lVar1,lRam00000001038d7278 + 0x14,(ulong)uVar7 << 1);
        iVar8 = *(int *)(lVar5 + 0x10);
      }
      uVar7 = iVar8 + (uint)uStack_50;
      uStack_50 = CONCAT44(uStack_50._4_4_,uVar7);
    }
    lVar5 = lRam0000000103904540;
    if ((uint)uStack_58 < uVar7) goto LAB_101fa0aac;
    uVar2 = *(uint *)(lRam0000000103904540 + 0x10);
    if ((uint)uStack_58 - uVar7 < uVar2) {
      func_0x000100331910(&uStack_70,lRam0000000103904540);
    }
    else {
      iVar8 = 0;
      if (uVar2 != 0) {
        lVar1 = lStack_60 + (ulong)uVar7 * 2;
        uVar6 = _UNK_1036d1590;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036d1598, lRam0000000103904540 + 0x14 == 0))
        goto LAB_101fa0bf4;
        _memmove(lVar1,lRam0000000103904540 + 0x14,(ulong)uVar2 << 1);
        iVar8 = *(int *)(lVar5 + 0x10);
        uVar7 = (uint)uStack_50;
      }
      uStack_50 = CONCAT44(uStack_50._4_4_,iVar8 + uVar7);
    }
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    func_0x000100331924(&uStack_70,*puRam00000001038d57b0);
    lVar5 = lRam00000001038d7278;
    if ((uint)uStack_58 < (uint)uStack_50) goto LAB_101fa0aac;
    uVar7 = *(uint *)(lRam00000001038d7278 + 0x10);
    if ((uint)uStack_58 - (uint)uStack_50 < uVar7) {
      func_0x000100331910(&uStack_70,lRam00000001038d7278);
      uVar7 = (uint)uStack_50;
    }
    else {
      iVar8 = 0;
      if (uVar7 != 0) {
        lVar1 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
        uVar6 = _UNK_1036d1580;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036d1588, lRam00000001038d7278 + 0x14 == 0))
        goto LAB_101fa0bf4;
        _memmove(lVar1,lRam00000001038d7278 + 0x14,(ulong)uVar7 << 1);
        iVar8 = *(int *)(lVar5 + 0x10);
      }
      uVar7 = iVar8 + (uint)uStack_50;
      uStack_50 = CONCAT44(uStack_50._4_4_,uVar7);
    }
    lVar5 = lRam0000000103904548;
    if ((uint)uStack_58 < uVar7) goto LAB_101fa0aac;
    uVar2 = *(uint *)(lRam0000000103904548 + 0x10);
    if ((uint)uStack_58 - uVar7 < uVar2) {
      func_0x000100331910(&uStack_70,lRam0000000103904548);
    }
    else {
      iVar8 = 0;
      if (uVar2 != 0) {
        lVar1 = lStack_60 + (ulong)uVar7 * 2;
        uVar6 = _UNK_1036d1570;
        if ((lVar1 == 0) || (uVar6 = _UNK_1036d1578, lRam0000000103904548 + 0x14 == 0))
        goto LAB_101fa0bf4;
        _memmove(lVar1,lRam0000000103904548 + 0x14,(ulong)uVar2 << 1);
        iVar8 = *(int *)(lVar5 + 0x10);
        uVar7 = (uint)uStack_50;
      }
      uStack_50 = CONCAT44(uStack_50._4_4_,iVar8 + uVar7);
    }
    func_0x000100331924(&uStack_70,*puRam00000001038d57b8);
    lVar5 = lRam00000001038d7278;
    if ((uint)uStack_50 <= (uint)uStack_58) {
      uVar7 = *(uint *)(lRam00000001038d7278 + 0x10);
      if ((uint)uStack_58 - (uint)uStack_50 < uVar7) {
        func_0x000100331910(&uStack_70,lRam00000001038d7278);
      }
      else {
        iVar8 = 0;
        if (uVar7 != 0) {
          lVar1 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
          uVar6 = _UNK_1036d1560;
          if ((lVar1 == 0) || (uVar6 = _UNK_1036d1568, lRam00000001038d7278 + 0x14 == 0)) {
LAB_101fa0bf4:
            func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
            pcVar4 = (code *)SoftwareBreakpoint(1,0x101fa0c00);
            (*pcVar4)();
          }
          _memmove(lVar1,lRam00000001038d7278 + 0x14,(ulong)uVar7 << 1);
          iVar8 = *(int *)(lVar5 + 0x10);
        }
        uStack_50 = CONCAT44(uStack_50._4_4_,iVar8 + (uint)uStack_50);
      }
      func_0x000100331938(&uStack_70);
      func_0x00010033180c();
      return;
    }
  }
LAB_101fa0aac:
  func_0x0001003319d8();
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fa0ab4);
  (*pcVar4)();
}

