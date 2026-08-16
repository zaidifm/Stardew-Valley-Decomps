/* 0x06005e3a StardewValley.Menus.MobileScrollbox.update @ 0x101e1c188 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileScrollbox_update_06005e3a(long param_1)

{
  int iVar1;
  char cVar2;
  int iVar3;
  code *pcVar4;
  int iVar5;
  float fVar6;
  float fVar7;
  float fVar8;
  
  if (lRam0000000103976fb8 == 0) {
    cVar2 = *(char *)(param_1 + 0x4a);
  }
  else {
    func_0x00010119b8f8();
    cVar2 = *(char *)(param_1 + 0x4a);
  }
  if (cVar2 == '\0') {
    return;
  }
  if (ABS(*(float *)(param_1 + 0x60)) <= 1.0) {
LAB_101e1c23c:
    *(undefined1 *)(param_1 + 0x4a) = 0;
    return;
  }
  iVar5 = *(int *)(param_1 + 0x4c) + (int)*(float *)(param_1 + 0x60);
  *(int *)(param_1 + 0x4c) = iVar5;
  if (*(long *)(param_1 + 0x10) != 0) {
    iVar1 = *(int *)(param_1 + 100);
    if (iVar1 == 0) {
      func_0x0001003316f4(0x95,_UNK_1036a2760);
                    /* WARNING: Does not return */
      pcVar4 = (code *)SoftwareBreakpoint(1,0x101e1c328);
      (*pcVar4)();
    }
    if ((iVar5 * 100 == -0x80000000) && (iVar1 == 1)) {
      func_0x0001003316f4(0x101,_UNK_1036a2770);
                    /* WARNING: Does not return */
      pcVar4 = (code *)SoftwareBreakpoint(1,0x101e1c33c);
      (*pcVar4)();
    }
    iVar3 = 0;
    if (-iVar1 != 0) {
      iVar3 = (iVar5 * 100) / -iVar1;
    }
    SDV_StardewValley_Menus_MobileScrollbar_setPercentage_06005e2d((float)iVar3);
    iVar5 = *(int *)(param_1 + 0x4c);
  }
  if (0 < iVar5) {
    *(undefined4 *)(param_1 + 0x60) = 0;
    *(undefined4 *)(param_1 + 0x4c) = 0;
    goto LAB_101e1c23c;
  }
  iVar1 = *(int *)(param_1 + 100);
  if (iVar5 < -iVar1) {
    *(int *)(param_1 + 0x4c) = -iVar1;
    *(undefined4 *)(param_1 + 0x60) = 0;
    goto LAB_101e1c23c;
  }
  fVar6 = *(float *)(param_1 + 0x60);
  if (fVar6 < 0.0) {
    fVar8 = (float)iVar5 / -(float)iVar1;
  }
  else {
    fVar7 = 1.0;
    if (fVar6 <= 0.0) goto LAB_101e1c2d8;
    fVar8 = ((float)iVar5 + (float)iVar1) / (float)iVar1;
  }
  fVar7 = 1.0;
  if (_UNK_103279560 < (double)fVar8) {
    fVar8 = (fVar8 + -0.9) * 20.0;
    fVar7 = 1.0;
    if (fVar8 != 1.0) {
      fVar7 = fVar8;
    }
  }
LAB_101e1c2d8:
  *(float *)(param_1 + 0x60) = fVar6 / (fVar7 * 1.05);
  return;
}

