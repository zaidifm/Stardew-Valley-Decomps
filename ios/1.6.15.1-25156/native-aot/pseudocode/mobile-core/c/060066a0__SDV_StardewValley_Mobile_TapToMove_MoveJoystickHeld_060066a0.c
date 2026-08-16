/* 0x060066a0 StardewValley.Mobile.TapToMove.MoveJoystickHeld @ 0x101fb2b6c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_MoveJoystickHeld_060066a0(float param_1,long param_2)

{
  code *pcVar1;
  bool bVar2;
  undefined8 uVar3;
  undefined4 uVar4;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_1 < 22.5 && -22.5 <= param_1) {
    uVar4 = 4;
  }
  else if ((param_1 < 22.5) || (67.5 <= param_1)) {
    if ((param_1 < 67.5) || (112.5 <= param_1)) {
      if ((param_1 < 112.5) || (157.5 <= param_1)) {
        if ((-112.5 <= param_1) || (param_1 < -157.5)) {
          if ((-22.5 <= param_1) || (param_1 < -67.5)) {
            bVar2 = false;
            if ((-112.5 <= param_1) && (bVar2 = false, !NAN(param_1))) {
              bVar2 = param_1 < -67.5;
            }
            uVar4 = 3;
            if (bVar2) {
              uVar4 = 1;
            }
          }
          else {
            uVar4 = 6;
          }
        }
        else {
          uVar4 = 5;
        }
      }
      else {
        uVar4 = 7;
      }
    }
    else {
      uVar4 = 2;
    }
  }
  else {
    uVar4 = 8;
  }
  uVar3 = _UNK_1036d3f10;
  if (*(long *)(param_2 + 0x18) != 0) {
    SDV_StardewValley_Mobile_MobileKeyStates_SetMovePressed_06006670
              (*(long *)(param_2 + 0x18),uVar4);
    *(undefined4 *)(param_2 + 0x124) = 0xc;
    uVar3 = _UNK_1036d3f18;
    if (param_2 != -0x110) {
      *(undefined8 *)(param_2 + 0x78) = 0;
      *(undefined8 *)(param_2 + 0x110) = 0xbf800000bf800000;
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fb2d1c);
  (*pcVar1)();
}

