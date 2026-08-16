/* 0x0600674c StardewValley.Mobile.VirtualJoypad.OnTapJoystick @ 0x101fd42c8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_VirtualJoypad_OnTapJoystick_0600674c
          (long param_1,undefined4 param_2,undefined4 param_3)

{
  code *pcVar1;
  int iVar2;
  undefined8 uVar3;
  long lVar4;
  double dVar5;
  double dVar6;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar3 = _UNK_1036d88f8;
  if ((param_1 != 0) && (uVar3 = _UNK_1036d8900, param_1 != -0xe0)) {
    StardewValley_StardewValley_Utility_Distance_060042a9
              (*(undefined4 *)(param_1 + 0xe0),*(undefined4 *)(param_1 + 0xe4),param_2,param_3);
    lVar4 = *(long *)(param_1 + 0x70);
    uVar3 = _UNK_1036d8908;
    if ((lVar4 != 0) && (uVar3 = _UNK_1036d8910, (undefined4 *)(lVar4 + 0x38) != (undefined4 *)0x0))
    {
      dVar5 = (double)StardewValley_StardewValley_Utility_Distance_060042a9
                                (*(undefined4 *)(lVar4 + 0x38),*(undefined4 *)(lVar4 + 0x3c),param_2
                                 ,param_3);
      if (*(char *)(param_1 + 0x106) == '\0') {
        iVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeJoystick_06006724();
        if (iVar2 < 0) {
          iVar2 = iVar2 + 1;
        }
        if (dVar5 <= (double)(iVar2 >> 1)) {
          uVar3 = _UNK_1036d8940;
          if ((param_1 == -0xf0) ||
             (*(undefined4 *)(param_1 + 0xf0) = param_2, uVar3 = _UNK_1036d8948, param_1 == -0xe8))
          goto LAB_101fd44b0;
          *(undefined4 *)(param_1 + 0xf4) = param_3;
          *(undefined4 *)(param_1 + 0xe8) = param_2;
          *(undefined4 *)(param_1 + 0xec) = param_3;
          *(undefined1 *)(param_1 + 0x106) = 1;
          if (*(char *)(param_1 + 0xda) != '\0') {
            *(undefined1 *)(param_1 + 0xda) = 0;
          }
        }
      }
      lVar4 = *(long *)(param_1 + 0x78);
      uVar3 = _UNK_1036d8918;
      if ((lVar4 != 0) &&
         (uVar3 = _UNK_1036d8920, (undefined4 *)(lVar4 + 0x38) != (undefined4 *)0x0)) {
        dVar5 = (double)StardewValley_StardewValley_Utility_Distance_060042a9
                                  (*(undefined4 *)(lVar4 + 0x38),*(undefined4 *)(lVar4 + 0x3c),
                                   param_2,param_3);
        lVar4 = *(long *)(param_1 + 0x80);
        uVar3 = _UNK_1036d8928;
        if ((lVar4 != 0) &&
           (uVar3 = _UNK_1036d8930, (undefined4 *)(lVar4 + 0x38) != (undefined4 *)0x0)) {
          dVar6 = (double)StardewValley_StardewValley_Utility_Distance_060042a9
                                    (*(undefined4 *)(lVar4 + 0x38),*(undefined4 *)(lVar4 + 0x3c),
                                     param_2,param_3);
          if (*(char *)(param_1 + 0x106) != '\0') {
            iVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
            if (iVar2 < 0) {
              iVar2 = iVar2 + 1;
            }
            if ((double)(iVar2 >> 1) < dVar5) {
              iVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonB_06006728();
              if (iVar2 < 0) {
                iVar2 = iVar2 + 1;
              }
              if ((double)(iVar2 >> 1) < dVar6) {
                SDV_StardewValley_Mobile_VirtualJoypad_OnTapHeldJoystick_0600674f
                          (param_1,param_2,param_3);
                uVar3 = _UNK_1036d8938;
                if (param_1 != -0xf0) {
                  *(undefined4 *)(param_1 + 0xf0) = param_2;
                  *(undefined4 *)(param_1 + 0xf4) = param_3;
                  return 1;
                }
                goto LAB_101fd44b0;
              }
            }
          }
          return 0;
        }
      }
    }
  }
LAB_101fd44b0:
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd44bc);
  (*pcVar1)();
}

