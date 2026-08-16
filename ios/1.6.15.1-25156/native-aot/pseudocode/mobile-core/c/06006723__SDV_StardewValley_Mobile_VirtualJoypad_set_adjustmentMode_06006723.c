/* 0x06006723 StardewValley.Mobile.VirtualJoypad.set_adjustmentMode @ 0x101fd1550 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_set_adjustmentMode_06006723(long param_1,char param_2)

{
  int *piVar1;
  code *pcVar2;
  undefined4 uVar3;
  undefined8 uVar4;
  long lVar5;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar4 = _UNK_1036d8368;
  if (param_1 != 0) {
    *(char *)(param_1 + 0x107) = param_2;
    if (param_2 == '\0') {
      return;
    }
    SDV_StardewValley_Mobile_VirtualJoypad_CheckToSetDefaults_0600673c(param_1);
    SDV_StardewValley_Mobile_VirtualJoypad_UpdateSettings_06006741(param_1);
    uVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionJoystick_0600672a();
    *(undefined8 *)(param_1 + 0x108) = uVar4;
    uVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonA_0600672d();
    *(undefined8 *)(param_1 + 0x110) = uVar4;
    uVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_positionButtonB_06006730();
    *(undefined8 *)(param_1 + 0x118) = uVar4;
    uVar3 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
    *(undefined4 *)(param_1 + 0x120) = uVar3;
    uVar3 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
    *(undefined4 *)(param_1 + 0x124) = uVar3;
    uVar3 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
    *(undefined4 *)(param_1 + 0x128) = uVar3;
    if (*(long *)(param_1 + 0x90) == 0) {
      SDV_StardewValley_Mobile_VirtualJoypad_CreateAdjusterControls_06006739(param_1);
    }
    uVar4 = _UNK_1036d8370;
    if ((*(long *)(param_1 + 0xb0) != 0) &&
       (piVar1 = (int *)(*(long *)(param_1 + 0xb0) + 0x38), uVar4 = _UNK_1036d8378,
       piVar1 != (int *)0x0)) {
      *(int *)(param_1 + 0x140) = *piVar1 + -4;
      uVar4 = _UNK_1036d8380;
      if (*(long *)(param_1 + 0xa0) != 0) {
        *(undefined4 *)(*(long *)(param_1 + 0xa0) + 0x80) = 0x8f;
        lVar5 = *(long *)(param_1 + 0xa0);
        uVar3 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
        uVar4 = _UNK_1036d8388;
        if (lVar5 != 0) {
          func_0x000101f10d44(lVar5,uVar3);
          SDV_StardewValley_Mobile_VirtualJoypad_UpdateButtonSizes_06006759(param_1);
          return;
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fd1674);
  (*pcVar2)();
}

