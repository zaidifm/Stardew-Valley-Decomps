/* 0x0600669a StardewValley.Mobile.TapToMove.JoystickOverride @ 0x101fb1728 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_JoystickOverride_0600669a(long param_1)

{
  code *pcVar1;
  undefined8 uVar2;
  
  uVar2 = _UNK_1036d3bf0;
  if ((param_1 != 0) &&
     (*(undefined4 *)(param_1 + 0x124) = 0, uVar2 = _UNK_1036d3bf8, param_1 != -0x110)) {
    *(undefined8 *)(param_1 + 0x78) = 0;
    *(undefined8 *)(param_1 + 0x110) = 0xbf800000bf800000;
    return;
  }
  func_0x0001003316f4(0xee,uVar2);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fb1774);
  (*pcVar1)();
}

