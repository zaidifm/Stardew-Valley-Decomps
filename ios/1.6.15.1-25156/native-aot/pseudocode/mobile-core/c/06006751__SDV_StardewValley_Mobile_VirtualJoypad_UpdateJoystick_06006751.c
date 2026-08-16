/* 0x06006751 StardewValley.Mobile.VirtualJoypad.UpdateJoystick @ 0x101fd4cfc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_UpdateJoystick_06006751(long param_1)

{
  int *piVar1;
  undefined4 *puVar2;
  char cVar3;
  code *pcVar4;
  undefined8 uVar5;
  int iVar6;
  long lVar7;
  int iVar8;
  
  if (lRam0000000103976fb8 == 0) {
    cVar3 = *(char *)(param_1 + 0x106);
  }
  else {
    func_0x00010119b8f8();
    cVar3 = *(char *)(param_1 + 0x106);
  }
  if (cVar3 != '\0') {
    return;
  }
  uVar5 = _UNK_1036d8ab8;
  if (((*(long *)(param_1 + 0x70) != 0) &&
      (piVar1 = (int *)(*(long *)(param_1 + 0x70) + 0x38), uVar5 = _UNK_1036d8ac0,
      piVar1 != (int *)0x0)) && (uVar5 = _UNK_1036d8ac8, param_1 != -0xe0)) {
    iVar8 = *(int *)(param_1 + 0xe0) - *piVar1;
    if (iVar8 != 0) {
      if (iVar8 < 0) {
        iVar8 = iVar8 + 1;
      }
      *piVar1 = *piVar1 + (iVar8 >> 1);
      uVar5 = _UNK_1036d8b20;
      if ((*(long *)(param_1 + 0x70) == 0) ||
         (piVar1 = (int *)(*(long *)(param_1 + 0x70) + 0x38), uVar5 = _UNK_1036d8b28,
         piVar1 == (int *)0x0)) goto LAB_101fd4f98;
      iVar8 = *piVar1;
      if ((iVar8 < 0) && (iVar8 = -iVar8, iVar8 < 0)) {
        func_0x00010034fdc0();
        iVar8 = -0x80000000;
      }
      iVar6 = *(int *)(param_1 + 0xe0);
      if ((iVar6 < 0) && (iVar6 = -iVar6, iVar6 < 0)) {
        func_0x00010034fdc0();
        iVar6 = -0x80000000;
      }
      if (iVar8 - iVar6 < 2) {
        uVar5 = _UNK_1036d8b30;
        if ((*(long *)(param_1 + 0x70) == 0) ||
           (puVar2 = (undefined4 *)(*(long *)(param_1 + 0x70) + 0x38), uVar5 = _UNK_1036d8b38,
           puVar2 == (undefined4 *)0x0)) goto LAB_101fd4f98;
        *puVar2 = *(undefined4 *)(param_1 + 0xe0);
      }
    }
    lVar7 = *(long *)(param_1 + 0x70);
    uVar5 = _UNK_1036d8ad0;
    if ((lVar7 != 0) && (uVar5 = _UNK_1036d8ad8, lVar7 != -0x38)) {
      iVar8 = *(int *)(param_1 + 0xe4) - *(int *)(lVar7 + 0x3c);
      if (iVar8 != 0) {
        piVar1 = (int *)(lVar7 + 0x3c);
        uVar5 = _UNK_1036d8af8;
        if (piVar1 == (int *)0x0) goto LAB_101fd4f98;
        if (iVar8 < 0) {
          iVar8 = iVar8 + 1;
        }
        *piVar1 = *piVar1 + (iVar8 >> 1);
        lVar7 = *(long *)(param_1 + 0x70);
        uVar5 = _UNK_1036d8b00;
        if ((lVar7 == 0) || (uVar5 = _UNK_1036d8b08, lVar7 == -0x38)) goto LAB_101fd4f98;
        iVar8 = *(int *)(lVar7 + 0x3c);
        if ((iVar8 < 0) && (iVar8 = -iVar8, iVar8 < 0)) {
          func_0x00010034fdc0();
          iVar8 = -0x80000000;
        }
        iVar6 = *(int *)(param_1 + 0xe4);
        if ((iVar6 < 0) && (iVar6 = -iVar6, iVar6 < 0)) {
          func_0x00010034fdc0();
          iVar6 = -0x80000000;
        }
        if (iVar8 - iVar6 < 2) {
          lVar7 = *(long *)(param_1 + 0x70);
          uVar5 = _UNK_1036d8b10;
          if ((lVar7 == 0) || (uVar5 = _UNK_1036d8b18, lVar7 == -0x38)) goto LAB_101fd4f98;
          *(undefined4 *)(lVar7 + 0x3c) = *(undefined4 *)(param_1 + 0xe4);
        }
      }
      lVar7 = *(long *)(param_1 + 0x70);
      uVar5 = _UNK_1036d8ae0;
      if (((lVar7 != 0) && (uVar5 = _UNK_1036d8ae8, (int *)(lVar7 + 0x38) != (int *)0x0)) &&
         (uVar5 = _UNK_1036d8af0, param_1 != -0xf0)) {
        iVar8 = *(int *)(lVar7 + 0x40);
        if (iVar8 < 0) {
          iVar8 = iVar8 + 1;
        }
        *(int *)(param_1 + 0xf0) = *(int *)(lVar7 + 0x38) + (iVar8 >> 1);
        iVar8 = *(int *)(lVar7 + 0x44);
        if (iVar8 < 0) {
          iVar8 = iVar8 + 1;
        }
        *(int *)(param_1 + 0xf4) = *(int *)(lVar7 + 0x3c) + (iVar8 >> 1);
        return;
      }
    }
  }
LAB_101fd4f98:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fd4fa4);
  (*pcVar4)();
}

