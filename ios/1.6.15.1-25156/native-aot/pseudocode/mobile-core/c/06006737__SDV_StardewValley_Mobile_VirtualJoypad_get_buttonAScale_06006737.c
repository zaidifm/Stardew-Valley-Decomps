/* 0x06006737 StardewValley.Mobile.VirtualJoypad.get_buttonAScale @ 0x101fd2144 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

float SDV_StardewValley_Mobile_VirtualJoypad_get_buttonAScale_06006737(long param_1)

{
  code *pcVar1;
  int iVar2;
  undefined8 uVar3;
  
  if (lRam0000000103976fb8 == 0) {
    iVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
  }
  else {
    func_0x00010119b8f8();
    iVar2 = SDV_StardewValley_Mobile_VirtualJoypad_get_sizeButtonA_06006726();
  }
  uVar3 = _UNK_1036d8440;
  if (param_1 != 0) {
    uVar3 = _UNK_1036d8448;
    if (param_1 != -0x130) {
      return ((float)iVar2 / ((float)*(int *)(param_1 + 0x138) * 4.0)) * 4.0;
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd21c4);
  (*pcVar1)();
}

