/* 0x06006759 StardewValley.Mobile.VirtualJoypad.UpdateButtonSizes @ 0x101fd5ce0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_UpdateButtonSizes_06006759(long param_1)

{
  int iVar1;
  code *pcVar2;
  int iVar3;
  undefined4 uVar4;
  int iVar5;
  undefined8 uVar6;
  long lVar7;
  
  if (lRam0000000103976fb8 == 0) {
    lVar7 = *(long *)(param_1 + 0x70);
  }
  else {
    func_0x00010119b8f8();
    lVar7 = *(long *)(param_1 + 0x70);
  }
  uVar6 = _UNK_1036d8d78;
  if ((lVar7 == 0) || (uVar6 = _UNK_1036d8d80, lVar7 == -0x38)) goto LAB_101fd5eb8;
  iVar5 = *(int *)(lVar7 + 0x40);
  iVar3 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
  if (iVar5 != iVar3) {
    lVar7 = *(long *)(param_1 + 0x70);
    uVar6 = _UNK_1036d8dc8;
    if (lVar7 == 0) goto LAB_101fd5eb8;
    uVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
    *(undefined4 *)(lVar7 + 0x40) = uVar4;
    *(undefined4 *)(lVar7 + 0x44) = uVar4;
    uVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
    *(undefined4 *)(param_1 + 0xdc) = uVar4;
    uVar6 = _UNK_1036d8dd8;
    if (param_1 == -0xe0) goto LAB_101fd5eb8;
    iVar3 = *(int *)(param_1 + 0xe0);
    iVar5 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
    uVar6 = _UNK_1036d8de0;
    if (param_1 == -0xf8) goto LAB_101fd5eb8;
    if (iVar5 < 0) {
      iVar5 = iVar5 + 1;
    }
    iVar1 = *(int *)(param_1 + 0xe4);
    *(float *)(param_1 + 0xf8) = (float)(iVar3 + (iVar5 >> 1));
    iVar5 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
    if (iVar5 < 0) {
      iVar5 = iVar5 + 1;
    }
    *(float *)(param_1 + 0xfc) = (float)(iVar1 + (iVar5 >> 1));
  }
  lVar7 = *(long *)(param_1 + 0x78);
  uVar6 = _UNK_1036d8d88;
  if ((lVar7 != 0) && (uVar6 = _UNK_1036d8d90, lVar7 != -0x38)) {
    iVar5 = *(int *)(lVar7 + 0x40);
    iVar3 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
    if (iVar5 != iVar3) {
      lVar7 = *(long *)(param_1 + 0x78);
      uVar6 = _UNK_1036d8db8;
      if (lVar7 == 0) goto LAB_101fd5eb8;
      uVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
      *(undefined4 *)(lVar7 + 0x40) = uVar4;
      *(undefined4 *)(lVar7 + 0x44) = uVar4;
    }
    lVar7 = *(long *)(param_1 + 0x80);
    uVar6 = _UNK_1036d8d98;
    if ((lVar7 != 0) && (uVar6 = _UNK_1036d8da0, lVar7 != -0x38)) {
      iVar5 = *(int *)(lVar7 + 0x40);
      iVar3 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
      if (iVar5 != iVar3) {
        lVar7 = *(long *)(param_1 + 0x80);
        uVar6 = _UNK_1036d8da8;
        if (lVar7 == 0) goto LAB_101fd5eb8;
        uVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
        *(undefined4 *)(lVar7 + 0x40) = uVar4;
        *(undefined4 *)(lVar7 + 0x44) = uVar4;
      }
      return;
    }
  }
LAB_101fd5eb8:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fd5ec4);
  (*pcVar2)();
}

