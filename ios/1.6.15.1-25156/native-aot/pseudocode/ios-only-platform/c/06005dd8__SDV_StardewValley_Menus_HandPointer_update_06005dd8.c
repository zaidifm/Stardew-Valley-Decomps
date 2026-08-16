/* 0x06005dd8 StardewValley.Menus.HandPointer.update @ 0x101e0125c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_HandPointer_update_06005dd8(long param_1,undefined8 param_2)

{
  int iVar1;
  float fVar2;
  char cVar3;
  code *pcVar4;
  long lVar5;
  long lVar6;
  undefined8 uVar7;
  undefined4 uVar8;
  float fVar9;
  float fVar10;
  int iVar11;
  float fVar12;
  int iVar13;
  float fVar14;
  
  cVar3 = cRam0000000103910be7;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910be7 != '\0') goto LAB_101e01290;
LAB_101e016d4:
    func_0x00010119b908(&UNK_1033169a0);
    cRam0000000103910be7 = '\x01';
    lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 == '\0') goto LAB_101e016d4;
LAB_101e01290:
    lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  }
  uVar7 = _UNK_10369e6e8;
  if (lVar5 == 0) goto LAB_101e01788;
  fVar9 = (float)SDV_StardewValley_Options_get_desiredUIScale_06003ee4();
  lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  uVar7 = _UNK_10369e6f0;
  if ((lVar5 == 0) ||
     (fVar10 = (float)SDV_StardewValley_Options_get_zoomLevel_06003ee1(), uVar7 = _UNK_10369e6f8,
     param_1 == 0)) goto LAB_101e01788;
  fVar10 = (1.0 / fVar9) * fVar10;
  if ((*(uint *)(param_1 + 0x3c) | 2) == 3) {
    iVar11 = *(int *)(param_1 + 0x28);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar7 = _UNK_10369e700;
    if (piRam00000001038d5380 == (int *)0x0) goto LAB_101e01788;
    fVar9 = (float)(int)((iVar11 << 6 | 0x20U) - *piRam00000001038d5380);
    fVar12 = (float)((*(int *)(param_1 + 0x2c) * 0x40 - piRam00000001038d5380[1]) + 0x20);
    if (*(char *)(param_1 + 0x38) == '\0') {
      uVar7 = _UNK_10369e708;
      if (*(long *)(param_1 + 0x18) == 0) goto LAB_101e01788;
      fVar14 = fVar9 + -32.0;
      fVar2 = fVar12 + 32.0;
    }
    else {
      uVar7 = _UNK_10369e788;
      fVar14 = fVar9;
      fVar2 = fVar12;
      if (*(long *)(param_1 + 0x18) == 0) goto LAB_101e01788;
    }
    SDV_StardewValley_Menus_tweeningSprite_resetVector_06005e9b
              (fVar10 * fVar14,fVar10 * fVar2,fVar10 * fVar9,fVar10 * fVar12);
  }
  lVar5 = *(long *)(param_1 + 0x18);
  if (*(char *)(lVar5 + 0x30) != '\0') {
    SDV_StardewValley_Menus_tweeningSprite_update_06005e9e(lVar5,param_2);
    return;
  }
  if (*(char *)(param_1 + 0x38) == '\0') {
    *(undefined1 *)(param_1 + 0x38) = 1;
    switch(*(undefined4 *)(param_1 + 0x3c)) {
    case 0:
      lVar6 = *(long *)(param_1 + 0x20);
      if (lVar6 == 0) {
        fVar9 = (float)*(int *)(param_1 + 0x2c);
        fVar10 = (float)*(int *)(param_1 + 0x28);
        goto code_r0x000101e01698;
      }
      uVar8 = 0x43fa0000;
code_r0x000101e01548:
      SDV_StardewValley_Menus_tweeningSprite_setUp_06005e99(uVar8,lVar5,lVar6,1);
      goto LAB_101e016ac;
    case 1:
      iVar11 = *(int *)(param_1 + 0x28);
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar7 = _UNK_10369e720;
      if ((piRam00000001038d5380 == (int *)0x0) ||
         (uVar7 = _UNK_10369e728, *(long *)(param_1 + 0x18) == 0)) goto LAB_101e01788;
      fVar9 = fVar10 * (float)((*(int *)(param_1 + 0x2c) * 0x40 - piRam00000001038d5380[1]) + 0x20);
      fVar10 = fVar10 * (float)(int)((iVar11 << 6 | 0x20U) - *piRam00000001038d5380);
code_r0x000101e01698:
      uVar8 = 0x43fa0000;
      break;
    case 2:
      lVar6 = *(long *)(param_1 + 0x20);
      if (lVar6 != 0) {
        uVar8 = 0x447a0000;
        goto code_r0x000101e01548;
      }
      iVar13 = *(int *)(param_1 + 0x28);
      iVar11 = *(int *)(param_1 + 0x2c);
      uVar8 = 0x447a0000;
      goto code_r0x000101e01680;
    case 3:
      iVar11 = *(int *)(param_1 + 0x28);
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar7 = _UNK_10369e730;
      if ((piRam00000001038d5380 == (int *)0x0) ||
         (uVar7 = _UNK_10369e738, *(long *)(param_1 + 0x18) == 0)) goto LAB_101e01788;
      uVar8 = 0x447a0000;
      fVar9 = fVar10 * (float)((*(int *)(param_1 + 0x2c) * 0x40 - piRam00000001038d5380[1]) + 0x20);
      fVar10 = fVar10 * (float)(int)((iVar11 << 6 | 0x20U) - *piRam00000001038d5380);
      break;
    case 4:
      iVar13 = *(int *)(param_1 + 0x30);
      iVar11 = *(int *)(param_1 + 0x34);
      uVar8 = 0x42480000;
code_r0x000101e01680:
      fVar9 = (float)iVar11;
      fVar10 = (float)iVar13;
      break;
    default:
      goto LAB_101e016ac;
    }
    SDV_StardewValley_Menus_tweeningSprite_setUp_06005e9a(fVar10,fVar9,fVar10,fVar9,uVar8);
LAB_101e016ac:
    lVar5 = *(long *)(param_1 + 0x18);
    uVar7 = _UNK_10369e718;
    goto joined_r0x000101e016b0;
  }
  *(undefined1 *)(param_1 + 0x38) = 0;
  switch(*(undefined4 *)(param_1 + 0x3c)) {
  case 0:
    lVar6 = *(long *)(param_1 + 0x20);
    if (lVar6 == 0) {
      fVar14 = (float)*(int *)(param_1 + 0x2c);
      fVar12 = (float)*(int *)(param_1 + 0x28);
      fVar9 = (float)(*(int *)(param_1 + 0x2c) + 0x20);
      fVar10 = (float)(*(int *)(param_1 + 0x28) + -0x20);
      goto code_r0x000101e01510;
    }
code_r0x000101e01434:
    SDV_StardewValley_Menus_tweeningSprite_setUp_06005e99(0x43fa0000,lVar5,lVar6,0);
    break;
  case 1:
    iVar11 = *(int *)(param_1 + 0x28);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar7 = _UNK_10369e748;
    if ((piRam00000001038d5380 == (int *)0x0) ||
       (uVar7 = _UNK_10369e750, piRam00000001038d5380 == (int *)0xfffffffffffffff8))
    goto LAB_101e01788;
    lVar5 = *(long *)(param_1 + 0x18);
    uVar7 = _UNK_10369e758;
    goto joined_r0x000101e01474;
  case 2:
    lVar6 = *(long *)(param_1 + 0x20);
    if (lVar6 != 0) goto code_r0x000101e01434;
    iVar11 = *(int *)(param_1 + 0x28);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0(lRam00000001038c4c88);
    }
    uVar7 = _UNK_10369e768;
    if ((piRam00000001038d5380 == (int *)0xfffffffffffffff8) ||
       (uVar7 = _UNK_10369e760, piRam00000001038d5380 == (int *)0x0)) goto LAB_101e01788;
    iVar13 = -0x20;
    if (iVar11 + 0x20 < piRam00000001038d5380[2] + -0x80) {
      iVar13 = 0x20;
    }
    fVar14 = (float)*(int *)(param_1 + 0x2c);
    fVar12 = (float)*(int *)(param_1 + 0x28);
    fVar9 = (float)(*(int *)(param_1 + 0x2c) + 0x20);
    fVar10 = (float)(iVar13 + iVar11);
    goto code_r0x000101e01510;
  case 3:
    iVar11 = *(int *)(param_1 + 0x28);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar7 = _UNK_10369e770;
    if ((piRam00000001038d5380 == (int *)0x0) ||
       (uVar7 = _UNK_10369e778, piRam00000001038d5380 == (int *)0xfffffffffffffff8))
    goto LAB_101e01788;
    lVar5 = *(long *)(param_1 + 0x18);
    uVar7 = _UNK_10369e780;
joined_r0x000101e01474:
    if (lVar5 == 0) goto LAB_101e01788;
    iVar13 = (*(int *)(param_1 + 0x2c) * 0x40 - piRam00000001038d5380[1]) + 0x20;
    iVar1 = iVar11 * 0x40 - *piRam00000001038d5380;
    iVar11 = -0x20;
    if (iVar13 < piRam00000001038d5380[3] + -0x80) {
      iVar11 = 0x20;
    }
    fVar14 = fVar10 * (float)iVar13;
    fVar12 = fVar10 * (float)(iVar1 + 0x20);
    fVar9 = fVar10 * (float)(iVar11 + iVar13);
    fVar10 = fVar10 * (float)(iVar1 + 0x40);
code_r0x000101e01510:
    uVar8 = 0x43fa0000;
code_r0x000101e01514:
    SDV_StardewValley_Menus_tweeningSprite_setUp_06005e9a(fVar10,fVar9,fVar12,fVar14,uVar8,lVar5);
    break;
  case 4:
    uVar8 = 0x442f0000;
    fVar14 = (float)*(int *)(param_1 + 0x34);
    fVar12 = (float)*(int *)(param_1 + 0x30);
    fVar9 = (float)*(int *)(param_1 + 0x2c);
    fVar10 = (float)*(int *)(param_1 + 0x28);
    goto code_r0x000101e01514;
  }
  lVar5 = *(long *)(param_1 + 0x18);
  uVar7 = _UNK_10369e740;
joined_r0x000101e016b0:
  if (lVar5 != 0) {
    SDV_StardewValley_Menus_tweeningSprite_start_06005e9c();
    return;
  }
LAB_101e01788:
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101e01794);
  (*pcVar4)();
}

