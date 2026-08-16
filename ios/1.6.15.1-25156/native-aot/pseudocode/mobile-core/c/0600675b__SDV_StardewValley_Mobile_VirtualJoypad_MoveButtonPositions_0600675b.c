/* 0x0600675b StardewValley.Mobile.VirtualJoypad.MoveButtonPositions @ 0x101fd5fd8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_MoveButtonPositions_0600675b
               (long param_1,int param_2,int param_3)

{
  int *piVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  long lVar6;
  long lVar7;
  
  if (lRam0000000103976fb8 == 0) {
    cVar2 = *(char *)(param_1 + 0x14c);
    lVar4 = param_1;
  }
  else {
    lVar4 = func_0x00010119b8f8();
    cVar2 = *(char *)(param_1 + 0x14c);
  }
  if (cVar2 != '\0') {
    lVar7 = *(long *)(param_1 + 0x88);
    param_2 = param_2 - *(int *)(param_1 + 0x144);
    param_3 = param_3 - *(int *)(param_1 + 0x148);
    if (lVar7 == *(long *)(param_1 + 0x70)) {
      uVar5 = _UNK_1036d8e88;
      if ((lVar7 != 0) &&
         (piVar1 = (int *)(lVar7 + 0x38), uVar5 = _UNK_1036d8e90, piVar1 != (int *)0x0)) {
        *piVar1 = *piVar1 + param_2;
        uVar5 = _UNK_1036d8e98;
        if ((*(long *)(param_1 + 0x70) != 0) &&
           (piVar1 = (int *)(*(long *)(param_1 + 0x70) + 0x3c), uVar5 = _UNK_1036d8ea0,
           piVar1 != (int *)0x0)) {
          *piVar1 = *piVar1 + param_3;
          lVar7 = *(long *)(param_1 + 0x70);
          uVar5 = _UNK_1036d8ea8;
          if (((lVar7 != 0) &&
              (uVar5 = _UNK_1036d8eb0, (undefined4 *)(lVar7 + 0x38) != (undefined4 *)0x0)) &&
             (uVar5 = _UNK_1036d8eb8, param_1 != -0xe0)) {
            *(undefined4 *)(param_1 + 0xe0) = *(undefined4 *)(lVar7 + 0x38);
            lVar6 = *(long *)(param_1 + 0x70);
            *(undefined4 *)(param_1 + 0xe4) = *(undefined4 *)(lVar7 + 0x3c);
            uVar5 = _UNK_1036d8ec0;
            if ((lVar6 != 0) &&
               (uVar5 = _UNK_1036d8ec8, (undefined4 *)(lVar6 + 0x38) != (undefined4 *)0x0)) {
              SDV_StardewValley_Mobile_VirtualJoypad_SetPositionJoystick_0600672c
                        (lVar4,*(undefined4 *)(lVar6 + 0x38),*(undefined4 *)(lVar6 + 0x3c));
              return;
            }
          }
        }
      }
    }
    else if (lVar7 == *(long *)(param_1 + 0x78)) {
      uVar5 = _UNK_1036d8e58;
      if ((lVar7 != 0) &&
         (piVar1 = (int *)(lVar7 + 0x38), uVar5 = _UNK_1036d8e60, piVar1 != (int *)0x0)) {
        *piVar1 = *piVar1 + param_2;
        uVar5 = _UNK_1036d8e68;
        if ((*(long *)(param_1 + 0x78) != 0) &&
           (piVar1 = (int *)(*(long *)(param_1 + 0x78) + 0x3c), uVar5 = _UNK_1036d8e70,
           piVar1 != (int *)0x0)) {
          *piVar1 = *piVar1 + param_3;
          lVar7 = *(long *)(param_1 + 0x78);
          uVar5 = _UNK_1036d8e78;
          if ((lVar7 != 0) &&
             (uVar5 = _UNK_1036d8e80, (undefined4 *)(lVar7 + 0x38) != (undefined4 *)0x0)) {
            SDV_StardewValley_Mobile_VirtualJoypad_SetPositionButtonA_0600672f
                      (lVar4,*(undefined4 *)(lVar7 + 0x38),*(undefined4 *)(lVar7 + 0x3c));
            return;
          }
        }
      }
    }
    else {
      if (lVar7 != *(long *)(param_1 + 0x80)) {
        return;
      }
      uVar5 = _UNK_1036d8e28;
      if ((lVar7 != 0) &&
         (piVar1 = (int *)(lVar7 + 0x38), uVar5 = _UNK_1036d8e30, piVar1 != (int *)0x0)) {
        *piVar1 = *piVar1 + param_2;
        uVar5 = _UNK_1036d8e38;
        if ((*(long *)(param_1 + 0x80) != 0) &&
           (piVar1 = (int *)(*(long *)(param_1 + 0x80) + 0x3c), uVar5 = _UNK_1036d8e40,
           piVar1 != (int *)0x0)) {
          *piVar1 = *piVar1 + param_3;
          lVar7 = *(long *)(param_1 + 0x80);
          uVar5 = _UNK_1036d8e48;
          if ((lVar7 != 0) &&
             (uVar5 = _UNK_1036d8e50, (undefined4 *)(lVar7 + 0x38) != (undefined4 *)0x0)) {
            SDV_StardewValley_Mobile_VirtualJoypad_SetPositionButtonB_06006732
                      (lVar4,*(undefined4 *)(lVar7 + 0x38),*(undefined4 *)(lVar7 + 0x3c));
            return;
          }
        }
      }
    }
    func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
    pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd6280);
    (*pcVar3)();
  }
  return;
}

