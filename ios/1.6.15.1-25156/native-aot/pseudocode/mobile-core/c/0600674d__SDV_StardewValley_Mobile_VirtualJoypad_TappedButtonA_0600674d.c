/* 0x0600674d StardewValley.Mobile.VirtualJoypad.TappedButtonA @ 0x101fd44e0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_VirtualJoypad_TappedButtonA_0600674d
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  code *pcVar1;
  int iVar2;
  undefined8 uVar3;
  long lVar4;
  double dVar5;
  
  if (lRam0000000103976fb8 == 0) {
    lVar4 = *(long *)(param_1 + 0x78);
  }
  else {
    func_0x00010119b8f8();
    lVar4 = *(long *)(param_1 + 0x78);
  }
  uVar3 = _UNK_1036d8958;
  if ((lVar4 != 0) && (uVar3 = _UNK_1036d8960, (undefined4 *)(lVar4 + 0x38) != (undefined4 *)0x0)) {
    dVar5 = (double)StardewValley_StardewValley_Utility_Distance_060042a9
                              (*(undefined4 *)(lVar4 + 0x38),*(undefined4 *)(lVar4 + 0x3c),param_2,
                               param_3);
    iVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
    if (iVar2 < 0) {
      iVar2 = iVar2 + 1;
    }
    return dVar5 <= (double)(iVar2 >> 1);
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd4598);
  (*pcVar1)();
}

