/* 0x06006748 StardewValley.Mobile.VirtualJoypad.TappedInvisibleAttackButtonB @ 0x101fd3bc0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_VirtualJoypad_TappedInvisibleAttackButtonB_06006748
               (undefined8 param_1,int param_2,int param_3)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  bool bVar4;
  long lVar5;
  undefined8 uVar6;
  
  cVar2 = cRam0000000103911557;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325d72);
    cRam0000000103911557 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar6 = _UNK_1036d87c0;
  if ((lRam00000001038d6bc0 != 0) && (uVar6 = _UNK_1036d87c8, lRam00000001038d6bc0 != -8)) {
    iVar1 = *(int *)(lRam00000001038d6bc0 + 0xc);
    if (iVar1 < 0) {
      iVar1 = iVar1 + 1;
    }
    if (iVar1 >> 1 < param_3) {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar6 = _UNK_1036d87d8;
      if ((lRam00000001038d6bc0 == -8) || (uVar6 = _UNK_1036d87d0, lRam00000001038d6bc0 == 0))
      goto LAB_101fd3ce0;
      iVar1 = *(int *)(lRam00000001038d6bc0 + 8);
      lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
      bVar4 = iVar1 - *(int *)(lVar5 + 0x180) < param_2;
    }
    else {
      bVar4 = false;
    }
    return bVar4;
  }
LAB_101fd3ce0:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd3cec);
  (*pcVar3)();
}

