/* 0x06006736 StardewValley.Mobile.VirtualJoypad.get_joystickScale @ 0x101fd20c4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

float SDV_StardewValley_Mobile_VirtualJoypad_get_joystickScale_06006736(long param_1)

{
  code *pcVar1;
  int iVar2;
  undefined8 uVar3;
  
  if (lRam0000000103976fb8 == 0) {
    iVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
  }
  else {
    func_0x00010119b8f8();
    iVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
  }
  uVar3 = _UNK_1036d8430;
  if (param_1 != 0) {
    uVar3 = _UNK_1036d8438;
    if (param_1 != -0x130) {
      return ((float)iVar2 / ((float)*(int *)(param_1 + 0x138) * 4.0)) * 4.0;
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd2144);
  (*pcVar1)();
}

