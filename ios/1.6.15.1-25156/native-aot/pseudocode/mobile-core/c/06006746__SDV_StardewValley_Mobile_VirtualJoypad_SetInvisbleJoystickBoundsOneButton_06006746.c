/* 0x06006746 StardewValley.Mobile.VirtualJoypad.SetInvisbleJoystickBoundsOneButton @ 0x101fd3738 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_SetInvisbleJoystickBoundsOneButton_06006746
               (long param_1)

{
  undefined4 *puVar1;
  int iVar2;
  char cVar3;
  code *pcVar4;
  undefined8 uVar5;
  long lVar6;
  
  cVar3 = cRam0000000103911555;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325d50);
    cRam0000000103911555 = '\x01';
    lVar6 = *(long *)(param_1 + 0x78);
  }
  else {
    lVar6 = *(long *)(param_1 + 0x78);
  }
  uVar5 = _UNK_1036d86d0;
  if (lVar6 != 0) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar5 = _UNK_1036d86e0;
    if (((lRam00000001038d6bc0 != -8) && (uVar5 = _UNK_1036d86d8, lRam00000001038d6bc0 != 0)) &&
       (uVar5 = _UNK_1036d86e8, (int *)(lVar6 + 0x38) != (int *)0x0)) {
      iVar2 = *(int *)(lRam00000001038d6bc0 + 8);
      if (iVar2 < 0) {
        iVar2 = iVar2 + 1;
      }
      *(int *)(lVar6 + 0x38) = iVar2 >> 1;
      lVar6 = *(long *)(param_1 + 0x78);
      uVar5 = _UNK_1036d86f0;
      if (lVar6 != 0) {
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        uVar5 = _UNK_1036d86f8;
        if (((lRam00000001038d6bc0 != 0) && (uVar5 = _UNK_1036d8700, lRam00000001038d6bc0 != -8)) &&
           (uVar5 = _UNK_1036d8708, lVar6 != -0x38)) {
          iVar2 = *(int *)(lRam00000001038d6bc0 + 0xc);
          if (iVar2 < 0) {
            iVar2 = iVar2 + 1;
          }
          *(int *)(lVar6 + 0x3c) = iVar2 >> 1;
          lVar6 = *(long *)(param_1 + 0x78);
          uVar5 = _UNK_1036d8710;
          if (lVar6 != 0) {
            if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            uVar5 = _UNK_1036d8720;
            if (((lRam00000001038d6bc0 != -8) && (uVar5 = _UNK_1036d8718, lRam00000001038d6bc0 != 0)
                ) && (uVar5 = _UNK_1036d8728, lVar6 != -0x38)) {
              iVar2 = *(int *)(lRam00000001038d6bc0 + 8);
              if (iVar2 < 0) {
                iVar2 = iVar2 + 1;
              }
              *(int *)(lVar6 + 0x40) = iVar2 >> 1;
              lVar6 = *(long *)(param_1 + 0x80);
              uVar5 = _UNK_1036d8730;
              if (lVar6 != 0) {
                if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                  func_0x0001003319b0();
                }
                uVar5 = _UNK_1036d8740;
                if (((lRam00000001038d6bc0 != -8) &&
                    (uVar5 = _UNK_1036d8738, lRam00000001038d6bc0 != 0)) &&
                   (puVar1 = (undefined4 *)(lVar6 + 0x38), uVar5 = _UNK_1036d8748,
                   puVar1 != (undefined4 *)0x0)) {
                  *puVar1 = *(undefined4 *)(lRam00000001038d6bc0 + 8);
                  lVar6 = *(long *)(param_1 + 0x80);
                  uVar5 = _UNK_1036d8750;
                  if (lVar6 != 0) {
                    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                      func_0x0001003319b0();
                    }
                    uVar5 = _UNK_1036d8758;
                    if (((lRam00000001038d6bc0 != 0) &&
                        (uVar5 = _UNK_1036d8760, lRam00000001038d6bc0 != -8)) &&
                       (uVar5 = _UNK_1036d8768, lVar6 != -0x38)) {
                      iVar2 = *(int *)(lRam00000001038d6bc0 + 0xc);
                      if (iVar2 < 0) {
                        iVar2 = iVar2 + 1;
                      }
                      *(int *)(lVar6 + 0x3c) = iVar2 >> 1;
                      lVar6 = *(long *)(param_1 + 0x80);
                      uVar5 = _UNK_1036d8770;
                      if ((lVar6 != 0) && (uVar5 = _UNK_1036d8778, lVar6 != -0x38)) {
                        *(undefined4 *)(lVar6 + 0x40) = 0;
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
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fd3a34);
  (*pcVar4)();
}

