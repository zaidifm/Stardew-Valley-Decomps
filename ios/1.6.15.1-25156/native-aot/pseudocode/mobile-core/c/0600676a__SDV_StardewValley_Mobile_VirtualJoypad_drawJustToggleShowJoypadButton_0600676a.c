/* 0x0600676a StardewValley.Mobile.VirtualJoypad.drawJustToggleShowJoypadButton @ 0x101fd7c44 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_drawJustToggleShowJoypadButton_0600676a
               (long param_1,undefined8 param_2)

{
  int *piVar1;
  int iVar2;
  char cVar3;
  code *pcVar4;
  undefined8 uVar5;
  long lVar6;
  
  cVar3 = cRam0000000103911579;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325e77);
    cRam0000000103911579 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  iVar2 = *piRam00000001038d57b0;
  if (iVar2 < 0xd) {
    iVar2 = 0xc;
  }
  lVar6 = *(long *)(param_1 + 0x68);
  uVar5 = _UNK_1036d9360;
  if (lVar6 != 0) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar5 = _UNK_1036d9370;
    if (((lRam00000001038d6bc0 != -8) && (uVar5 = _UNK_1036d9368, lRam00000001038d6bc0 != 0)) &&
       (piVar1 = (int *)(lVar6 + 0x38), uVar5 = _UNK_1036d9378, piVar1 != (int *)0x0)) {
      *piVar1 = (int)((((float)*(int *)(lRam00000001038d6bc0 + 8) + -64.0) - (float)iVar2) + -80.0);
      lVar6 = *(long *)(param_1 + 0x68);
      uVar5 = _UNK_1036d9380;
      if ((lVar6 != 0) && (uVar5 = _UNK_1036d9388, lVar6 != -0x38)) {
        *(undefined4 *)(lVar6 + 0x3c) = 0xc;
        SDV_StardewValley_Mobile_VirtualJoypad_drawToggleShowJoypadButton_0600676b(param_1,param_2);
        return;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fd7dc4);
  (*pcVar4)();
}

