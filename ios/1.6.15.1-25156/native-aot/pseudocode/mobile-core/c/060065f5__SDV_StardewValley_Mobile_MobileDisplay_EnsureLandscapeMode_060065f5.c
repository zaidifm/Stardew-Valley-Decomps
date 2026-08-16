/* 0x060065f5 StardewValley.Mobile.MobileDisplay.EnsureLandscapeMode @ 0x101fa0d64 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_MobileDisplay_EnsureLandscapeMode_060065f5(int *param_1,int *param_2)

{
  int iVar1;
  code *pcVar2;
  undefined8 uVar3;
  
  if (cRam0000000103911404 == '\0') {
    func_0x00010119b908(&UNK_103324847);
    cRam0000000103911404 = '\x01';
  }
  uVar3 = _UNK_1036d1630;
  if ((param_2 != (int *)0x0) && (uVar3 = _UNK_1036d1638, param_1 != (int *)0x0)) {
    iVar1 = *param_1;
    if (iVar1 < *param_2) {
      *param_1 = *param_2;
      *param_2 = iVar1;
    }
    return;
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa0dec);
  (*pcVar2)();
}

