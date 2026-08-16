/* 0x06005dd6 StardewValley.Menus.HandPointer..ctor @ 0x101e00d88 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_HandPointer__ctor_06005dd6
               (long param_1,undefined4 param_2,undefined4 param_3,undefined4 param_4,int param_5,
               int param_6,undefined8 param_7)

{
  int iVar1;
  long lVar2;
  char cVar3;
  undefined8 uVar4;
  code *pcVar5;
  undefined8 uVar6;
  undefined8 uVar7;
  undefined8 uVar8;
  undefined4 uVar9;
  undefined8 uVar10;
  undefined8 uVar11;
  int iVar12;
  int iVar13;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  
  cVar3 = cRam0000000103910be5;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910be5 == '\0') goto LAB_101e01160;
LAB_101e00dd8:
    *(undefined4 *)(param_1 + 0x28) = param_2;
    *(undefined4 *)(param_1 + 0x2c) = param_3;
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 != '\0') goto LAB_101e00dd8;
LAB_101e01160:
    func_0x00010119b908(&UNK_103316960);
    cRam0000000103910be5 = '\x01';
    *(undefined4 *)(param_1 + 0x28) = param_2;
    *(undefined4 *)(param_1 + 0x2c) = param_3;
  }
  *(int *)(param_1 + 0x30) = param_5;
  *(int *)(param_1 + 0x34) = param_6;
  *(undefined4 *)(param_1 + 0x3c) = param_4;
  lVar2 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x20) = param_7;
  *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lVar2) = 1;
  uStack_98 = 0;
  uStack_a0 = 0;
  func_0x00010034ede4(&uStack_a0,0xffffff9c,0xffffff9c,0x28,0x28);
  uVar10 = uStack_98;
  uVar7 = uStack_a0;
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar11 = *puRam00000001038d5350;
  uStack_90 = 0;
  uStack_88 = 0;
  func_0x00010034ede4(&uStack_90,0x58,100,0xf,0x10);
  uVar4 = uStack_88;
  uVar8 = uStack_90;
  uVar6 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
  StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601b
            (0x40800000,uVar6,uVar7,uVar10,uVar11,uVar8,uVar4,1);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x10) = uVar6;
  *(undefined1 *)(((ulong)(param_1 + 0x10) >> 9 & 0x7fffff) + lVar2) = 1;
  switch(param_4) {
  case 0:
    param_5 = *(int *)(param_1 + 0x28);
    param_6 = *(int *)(param_1 + 0x2c);
    uVar10 = *(undefined8 *)(param_1 + 0x10);
    iVar12 = param_5 + -100;
    iVar13 = param_6 + 100;
    uVar7 = func_0x000100331820(uRam0000000103900320,0x58);
    uVar9 = 0x43fa0000;
    break;
  case 1:
    iVar13 = *(int *)(param_1 + 0x28);
    uVar7 = _UNK_10369e6b0;
    uVar10 = _UNK_10369e6b8;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
      uVar7 = _UNK_10369e6b0;
      uVar10 = _UNK_10369e6b8;
    }
    goto joined_r0x000101e01028;
  case 2:
    uVar10 = *(undefined8 *)(param_1 + 0x10);
    iVar1 = *(int *)(param_1 + 0x28);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar7 = _UNK_10369e6c8;
    if ((piRam00000001038d5380 == (int *)0xfffffffffffffff8) ||
       (uVar7 = _UNK_10369e6c0, piRam00000001038d5380 == (int *)0x0)) goto code_r0x000101e0119c;
    param_6 = *(int *)(param_1 + 0x2c);
    param_5 = *(int *)(param_1 + 0x28);
    iVar12 = -0x20;
    if (iVar1 + 0x20 < piRam00000001038d5380[2] + -0x80) {
      iVar12 = 0x20;
    }
    iVar13 = param_6 + 0x20;
    iVar12 = iVar12 + iVar1;
    uVar7 = func_0x000100331820(uRam0000000103900320,0x58);
    uVar9 = 0x43fa0000;
    break;
  case 3:
    iVar13 = *(int *)(param_1 + 0x28);
    uVar7 = _UNK_10369e6d0;
    uVar10 = _UNK_10369e6d8;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
      uVar7 = _UNK_10369e6d0;
      uVar10 = _UNK_10369e6d8;
    }
joined_r0x000101e01028:
    if ((piRam00000001038d5380 == (int *)0x0) ||
       (uVar7 = uVar10, piRam00000001038d5380 == (int *)0xfffffffffffffff8)) {
code_r0x000101e0119c:
      func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
      pcVar5 = (code *)SoftwareBreakpoint(1,0x101e011a8);
      (*pcVar5)();
    }
    uVar10 = *(undefined8 *)(param_1 + 0x10);
    param_6 = (*(int *)(param_1 + 0x2c) * 0x40 - piRam00000001038d5380[1]) + 0x20;
    param_5 = iVar13 * 0x40 - *piRam00000001038d5380;
    iVar12 = param_5 + 0x40;
    iVar13 = -0x20;
    if (param_6 < piRam00000001038d5380[3] + -0x80) {
      iVar13 = 0x20;
    }
    param_5 = param_5 + 0x20;
    iVar13 = iVar13 + param_6;
    uVar7 = func_0x000100331820(uRam0000000103900320,0x58);
    uVar9 = 0x43fa0000;
    uVar8 = 1;
    param_7 = 0;
    goto code_r0x000101e010f8;
  case 4:
    iVar12 = *(int *)(param_1 + 0x28);
    iVar13 = *(int *)(param_1 + 0x2c);
    uVar10 = *(undefined8 *)(param_1 + 0x10);
    uVar7 = func_0x000100331820(uRam0000000103900320,0x58);
    uVar9 = 0x442f0000;
    break;
  default:
    goto LAB_101e01114;
  }
  uVar8 = 0;
code_r0x000101e010f8:
  SDV_StardewValley_Menus_tweeningSprite__ctor_06005e98
            ((float)iVar12,(float)iVar13,(float)param_5,(float)param_6,uVar9,0x40800000,uVar7,0,
             uVar10,uVar8,param_7);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x18U) = uVar7;
  *(undefined1 *)((param_1 + 0x18U >> 9 & 0x7fffff) + lVar2) = 1;
LAB_101e01114:
  *(undefined1 *)(param_1 + 0x38) = 0;
  return;
}

