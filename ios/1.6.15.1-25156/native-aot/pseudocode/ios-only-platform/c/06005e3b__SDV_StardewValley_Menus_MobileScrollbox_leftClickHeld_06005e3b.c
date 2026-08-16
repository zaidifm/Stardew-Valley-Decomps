/* 0x06005e3b StardewValley.Menus.MobileScrollbox.leftClickHeld @ 0x101e1c33c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileScrollbox_leftClickHeld_06005e3b
               (long param_1,undefined8 param_2,int param_3)

{
  int iVar1;
  int iVar2;
  int *piVar3;
  char cVar4;
  code *pcVar5;
  int iVar6;
  long lVar7;
  
  cVar4 = cRam0000000103910c4a;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910c4a != '\0') goto LAB_101e1c36c;
LAB_101e1c55c:
    func_0x00010119b908(&UNK_1033175b0);
    cRam0000000103910c4a = '\x01';
    iVar6 = *(int *)(param_1 + 0x50);
  }
  else {
    func_0x00010119b8f8();
    if (cVar4 == '\0') goto LAB_101e1c55c;
LAB_101e1c36c:
    iVar6 = *(int *)(param_1 + 0x50);
  }
  if (((iVar6 < param_3) && (-1 < *(int *)(param_1 + 0x54))) ||
     ((param_3 < iVar6 && (*(int *)(param_1 + 0x54) <= -*(int *)(param_1 + 100))))) {
LAB_101e1c470:
    *(int *)(param_1 + 0x50) = param_3;
    return;
  }
  if (*(char *)(param_1 + 0x48) == '\0') {
    if (*(char *)(param_1 + 0x49) == '\0') {
      return;
    }
  }
  else if (*(char *)(param_1 + 0x49) == '\0') {
    if (((iVar6 <= param_3) && (-1 < *(int *)(param_1 + 0x54))) ||
       ((param_3 <= iVar6 && (*(int *)(param_1 + 0x54) <= -*(int *)(param_1 + 100)))))
    goto LAB_101e1c470;
    if ((param_3 <= iVar6 + 0xc) && (iVar6 + -0xc <= param_3)) {
      return;
    }
    *(int *)(param_1 + 0x58) = param_3;
    *(undefined1 *)(param_1 + 0x49) = 1;
  }
  piVar3 = piRam0000000103900778;
  if (((iVar6 <= param_3) && (-1 < *(int *)(param_1 + 0x54))) ||
     ((param_3 <= iVar6 && (*(int *)(param_1 + 0x54) <= -*(int *)(param_1 + 100)))))
  goto LAB_101e1c470;
  iVar2 = param_3 - *(int *)(param_1 + 0x58);
  if (iVar2 < 1) {
    if (-1 < iVar2) goto LAB_101e1c48c;
    if (-1 < *piRam0000000103900778) goto LAB_101e1c524;
    iVar6 = (param_3 - iVar6) + *(int *)(param_1 + 0x54);
    if (iVar6 <= -*(int *)(param_1 + 100)) {
      iVar6 = -*(int *)(param_1 + 100);
    }
  }
  else {
    if (*piRam0000000103900778 < 1) {
LAB_101e1c524:
      *(int *)(param_1 + 0x50) = param_3;
      *(undefined4 *)(param_1 + 0x54) = *(undefined4 *)(param_1 + 0x4c);
      *piVar3 = iVar2;
      return;
    }
    iVar6 = (param_3 - iVar6) + *(int *)(param_1 + 0x54);
    if (-1 < iVar6) {
      iVar6 = 0;
    }
  }
  *(int *)(param_1 + 0x4c) = iVar6;
LAB_101e1c48c:
  *piVar3 = iVar2;
  lVar7 = *(long *)(param_1 + 0x18);
  if (lVar7 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036a2780);
                    /* WARNING: Does not return */
    pcVar5 = (code *)SoftwareBreakpoint(1,0x101e1c58c);
    (*pcVar5)();
  }
  if (*(uint *)(lVar7 + 0x18) <= *(uint *)(param_1 + 0x5c)) {
    func_0x0001003316f4(0xcc,_UNK_1036a2798);
                    /* WARNING: Does not return */
    pcVar5 = (code *)SoftwareBreakpoint(1,0x101e1c5ac);
    (*pcVar5)();
  }
  *(float *)(lVar7 + (long)(int)*(uint *)(param_1 + 0x5c) * 4 + 0x20) = (float)iVar2;
  *(int *)(param_1 + 0x58) = param_3;
  if (*(long *)(param_1 + 0x10) != 0) {
    iVar6 = *(int *)(param_1 + 100);
    if (iVar6 == 0) {
      func_0x0001003316f4(0x95,_UNK_1036a2790);
                    /* WARNING: Does not return */
      pcVar5 = (code *)SoftwareBreakpoint(1,0x101e1c5cc);
      (*pcVar5)();
    }
    iVar2 = *(int *)(param_1 + 0x4c) * 100;
    if ((iVar6 == 1) && (iVar2 == -0x80000000)) {
      func_0x0001003316f4(0x101,_UNK_1036a27a0);
                    /* WARNING: Does not return */
      pcVar5 = (code *)SoftwareBreakpoint(1,0x101e1c5e0);
      (*pcVar5)();
    }
    iVar1 = 0;
    if (-iVar6 != 0) {
      iVar1 = iVar2 / -iVar6;
    }
    SDV_StardewValley_Menus_MobileScrollbar_setPercentage_06005e2d((float)iVar1);
  }
  iVar6 = *(int *)(param_1 + 0x5c) + 1;
  *(int *)(param_1 + 0x5c) = iVar6;
  if (iVar6 < *(int *)(*(long *)(param_1 + 0x18) + 0x18)) {
    return;
  }
  *(undefined4 *)(param_1 + 0x5c) = 0;
  return;
}

