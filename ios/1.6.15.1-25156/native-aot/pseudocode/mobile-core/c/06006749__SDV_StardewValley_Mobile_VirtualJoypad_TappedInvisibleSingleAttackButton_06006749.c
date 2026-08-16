/* 0x06006749 StardewValley.Mobile.VirtualJoypad.TappedInvisibleSingleAttackButton @ 0x101fd3cec */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_VirtualJoypad_TappedInvisibleSingleAttackButton_06006749
               (undefined8 param_1,int param_2,int param_3)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  bool bVar4;
  long lVar5;
  undefined8 uVar6;
  
  cVar2 = cRam0000000103911558;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325d80);
    cRam0000000103911558 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar6 = _UNK_1036d87f0;
  if ((lRam00000001038d6bc0 != -8) && (uVar6 = _UNK_1036d87e8, lRam00000001038d6bc0 != 0)) {
    iVar1 = *(int *)(lRam00000001038d6bc0 + 8);
    if (iVar1 < 0) {
      iVar1 = iVar1 + 1;
    }
    if (iVar1 >> 1 < param_2) {
      lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
      if (*(char *)(lVar5 + 0x168) == '\0') {
        if (*(char *)(*plRam00000001038e4ba8 + 0xc5) == '\0') {
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          uVar6 = _UNK_1036d8808;
          if ((lRam00000001038d6bc0 == 0) || (uVar6 = _UNK_1036d8810, lRam00000001038d6bc0 == -8))
          goto LAB_101fd3e70;
          iVar1 = *(int *)(*plRam00000001038e4ba8 + 0xa8);
          if (iVar1 < 2) {
            iVar1 = 1;
          }
          bVar4 = param_3 < *(int *)(lRam00000001038d6bc0 + 0xc) - iVar1;
        }
        else {
          iVar1 = *(int *)(*plRam00000001038e4ba8 + 0xa8);
          if (iVar1 < 2) {
            iVar1 = 1;
          }
          bVar4 = iVar1 < param_3;
        }
      }
      else {
        bVar4 = true;
      }
    }
    else {
      bVar4 = false;
    }
    return bVar4;
  }
LAB_101fd3e70:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd3e7c);
  (*pcVar3)();
}

