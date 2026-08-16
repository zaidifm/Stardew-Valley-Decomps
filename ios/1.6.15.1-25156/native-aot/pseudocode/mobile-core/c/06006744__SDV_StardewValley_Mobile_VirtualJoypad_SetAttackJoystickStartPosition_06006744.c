/* 0x06006744 StardewValley.Mobile.VirtualJoypad.SetAttackJoystickStartPosition @ 0x101fd3324 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_SetAttackJoystickStartPosition_06006744(long param_1)

{
  char cVar1;
  code *pcVar2;
  int iVar3;
  int iVar4;
  int iVar5;
  undefined8 uVar6;
  
  cVar1 = cRam0000000103911553;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325d1b);
    cRam0000000103911553 = '\x01';
  }
  uVar6 = _UNK_1036d85f8;
  if (param_1 != 0) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar6 = _UNK_1036d8608;
    if ((lRam00000001038d6bc0 != -8) && (uVar6 = _UNK_1036d8600, lRam00000001038d6bc0 != 0)) {
      iVar5 = *(int *)(lRam00000001038d6bc0 + 8);
      iVar3 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
      uVar6 = _UNK_1036d8610;
      if (param_1 != -0xe0) {
        *(int *)(param_1 + 0xe0) = (iVar5 - iVar3) + -0x7c;
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        uVar6 = _UNK_1036d8618;
        if ((lRam00000001038d6bc0 != 0) && (uVar6 = _UNK_1036d8620, lRam00000001038d6bc0 != -8)) {
          iVar5 = *(int *)(lRam00000001038d6bc0 + 0xc);
          iVar4 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
          iVar3 = *(int *)(param_1 + 0xe0);
          *(int *)(param_1 + 0xe4) = (iVar5 - iVar4) + -0x7c;
          iVar5 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
          uVar6 = _UNK_1036d8628;
          if (param_1 != -0xf8) {
            if (iVar5 < 0) {
              iVar5 = iVar5 + 1;
            }
            iVar4 = *(int *)(param_1 + 0xe4);
            *(float *)(param_1 + 0xf8) = (float)(iVar3 + (iVar5 >> 1));
            iVar5 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
            if (iVar5 < 0) {
              iVar5 = iVar5 + 1;
            }
            *(float *)(param_1 + 0xfc) = (float)(iVar4 + (iVar5 >> 1));
            return;
          }
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fd34ac);
  (*pcVar2)();
}

