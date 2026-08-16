/* 0x0600673d StardewValley.Mobile.VirtualJoypad.SetJoystickDefaults @ 0x101fd2d50 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_SetJoystickDefaults_0600673d(long param_1)

{
  int iVar1;
  int iVar2;
  char cVar3;
  code *pcVar4;
  int iVar5;
  undefined8 uVar6;
  long lVar7;
  undefined8 uVar8;
  
  cVar3 = cRam000000010391154c;
  lVar7 = param_1;
  if (lRam0000000103976fb8 != 0) {
    lVar7 = func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    lVar7 = func_0x00010119b908(&UNK_103325d01);
    cRam000000010391154c = '\x01';
  }
  SDV_StardewValley_Mobile_VirtualJoypad_set_sizeJoystick_06006725(lVar7,0xb9);
  iVar5 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
  if (iVar5 < 0) {
    iVar5 = iVar5 + 1;
  }
  uVar8 = _UNK_1036d8520;
  if (param_1 != 0) {
    *(int *)(param_1 + 0xdc) = iVar5 >> 1;
    uVar8 = _UNK_1036d8528;
    if (*plRam00000001038e4ba8 != 0) {
      iVar1 = *(int *)(*plRam00000001038e4ba8 + 0xa8);
      if (iVar1 < 2) {
        iVar1 = 1;
      }
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar8 = _UNK_1036d8530;
      if ((lRam00000001038d6bc0 != 0) && (uVar8 = _UNK_1036d8538, lRam00000001038d6bc0 != -8)) {
        iVar2 = *(int *)(lRam00000001038d6bc0 + 0xc);
        uVar6 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
        *(int *)(param_1 + 0xe0) = (iVar5 >> 1) + iVar1 + 0x40;
        *(int *)(param_1 + 0xe4) = ((iVar2 - (int)uVar6) - *(int *)(param_1 + 0xdc)) + -0x40;
        uVar8 = _UNK_1036d8540;
        if ((int *)(param_1 + 0xe0) != (int *)0x0) {
          SDV_StardewValley_Mobile_VirtualJoypad_SetPositionJoystick_0600672c
                    (uVar6,*(undefined4 *)(param_1 + 0xe0));
          iVar1 = *(int *)(param_1 + 0xe0);
          iVar5 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
          uVar8 = _UNK_1036d8548;
          if (param_1 != -0xf8) {
            if (iVar5 < 0) {
              iVar5 = iVar5 + 1;
            }
            iVar2 = *(int *)(param_1 + 0xe4);
            *(float *)(param_1 + 0xf8) = (float)(iVar1 + (iVar5 >> 1));
            iVar5 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
            if (iVar5 < 0) {
              iVar5 = iVar5 + 1;
            }
            *(float *)(param_1 + 0xfc) = (float)(iVar2 + (iVar5 >> 1));
            return;
          }
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fd2edc);
  (*pcVar4)();
}

