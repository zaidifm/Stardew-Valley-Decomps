/* 0x06006747 StardewValley.Mobile.VirtualJoypad.TappedInvisibleAttackButtonA @ 0x101fd3a34 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_VirtualJoypad_TappedInvisibleAttackButtonA_06006747
               (undefined8 param_1,int param_2,int param_3)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  
  cVar2 = cRam0000000103911556;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325d64);
    cRam0000000103911556 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar5 = _UNK_1036d8780;
  if ((lRam00000001038d6bc0 != 0) && (uVar5 = _UNK_1036d8788, lRam00000001038d6bc0 != -8)) {
    iVar1 = *(int *)(lRam00000001038d6bc0 + 0xc);
    if (iVar1 < 0) {
      iVar1 = iVar1 + 1;
    }
    if (param_3 <= iVar1 >> 1) {
      return false;
    }
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar5 = _UNK_1036d8798;
    if ((lRam00000001038d6bc0 != -8) && (uVar5 = _UNK_1036d8790, lRam00000001038d6bc0 != 0)) {
      iVar1 = *(int *)(lRam00000001038d6bc0 + 8);
      lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
      if (param_2 <= iVar1 + *(int *)(lVar4 + 0x180) * -2) {
        return false;
      }
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar5 = _UNK_1036d87b0;
      if ((lRam00000001038d6bc0 != -8) && (uVar5 = _UNK_1036d87a8, lRam00000001038d6bc0 != 0)) {
        iVar1 = *(int *)(lRam00000001038d6bc0 + 8);
        lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
        return param_2 < iVar1 - *(int *)(lVar4 + 0x180);
      }
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd3bc0);
  (*pcVar3)();
}

