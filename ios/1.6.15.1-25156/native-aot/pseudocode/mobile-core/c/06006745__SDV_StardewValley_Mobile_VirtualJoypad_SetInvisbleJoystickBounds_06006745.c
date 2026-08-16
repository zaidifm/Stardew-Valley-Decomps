/* 0x06006745 StardewValley.Mobile.VirtualJoypad.SetInvisbleJoystickBounds @ 0x101fd34ac */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_SetInvisbleJoystickBounds_06006745(long param_1)

{
  int *piVar1;
  int iVar2;
  char cVar3;
  code *pcVar4;
  long lVar5;
  undefined8 uVar6;
  long lVar7;
  
  cVar3 = cRam0000000103911554;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325d30);
    cRam0000000103911554 = '\x01';
    lVar7 = *(long *)(param_1 + 0x78);
  }
  else {
    lVar7 = *(long *)(param_1 + 0x78);
  }
  uVar6 = _UNK_1036d8638;
  if (lVar7 != 0) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar6 = _UNK_1036d8648;
    if ((lRam00000001038d6bc0 != -8) && (uVar6 = _UNK_1036d8640, lRam00000001038d6bc0 != 0)) {
      iVar2 = *(int *)(lRam00000001038d6bc0 + 8);
      lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
      uVar6 = _UNK_1036d8650;
      if ((lVar5 != 0) && (uVar6 = _UNK_1036d8658, (int *)(lVar7 + 0x38) != (int *)0x0)) {
        *(int *)(lVar7 + 0x38) = iVar2 + *(int *)(lVar5 + 0x180) * -2;
        lVar7 = *(long *)(param_1 + 0x78);
        uVar6 = _UNK_1036d8660;
        if (lVar7 != 0) {
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          uVar6 = _UNK_1036d8668;
          if (((lRam00000001038d6bc0 != 0) && (uVar6 = _UNK_1036d8670, lRam00000001038d6bc0 != -8))
             && (uVar6 = _UNK_1036d8678, lVar7 != -0x38)) {
            iVar2 = *(int *)(lRam00000001038d6bc0 + 0xc);
            if (iVar2 < 0) {
              iVar2 = iVar2 + 1;
            }
            *(int *)(lVar7 + 0x3c) = iVar2 >> 1;
            lVar7 = *(long *)(param_1 + 0x80);
            uVar6 = _UNK_1036d8680;
            if (lVar7 != 0) {
              if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                func_0x0001003319b0();
              }
              uVar6 = _UNK_1036d8690;
              if ((lRam00000001038d6bc0 != -8) &&
                 (uVar6 = _UNK_1036d8688, lRam00000001038d6bc0 != 0)) {
                iVar2 = *(int *)(lRam00000001038d6bc0 + 8);
                lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
                uVar6 = _UNK_1036d8698;
                if ((lVar5 != 0) &&
                   (piVar1 = (int *)(lVar7 + 0x38), uVar6 = _UNK_1036d86a0, piVar1 != (int *)0x0)) {
                  *piVar1 = iVar2 - *(int *)(lVar5 + 0x180);
                  lVar7 = *(long *)(param_1 + 0x80);
                  uVar6 = _UNK_1036d86a8;
                  if (lVar7 != 0) {
                    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                      func_0x0001003319b0();
                    }
                    uVar6 = _UNK_1036d86b0;
                    if (((lRam00000001038d6bc0 != 0) &&
                        (uVar6 = _UNK_1036d86b8, lRam00000001038d6bc0 != -8)) &&
                       (uVar6 = _UNK_1036d86c0, lVar7 != -0x38)) {
                      iVar2 = *(int *)(lRam00000001038d6bc0 + 0xc);
                      if (iVar2 < 0) {
                        iVar2 = iVar2 + 1;
                      }
                      *(int *)(lVar7 + 0x3c) = iVar2 >> 1;
                      return;
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fd3738);
  (*pcVar4)();
}

