/* 0x06006734 StardewValley.Mobile.VirtualJoypad.get_screenWidth @ 0x101fd1f84 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined4 SDV_StardewValley_Mobile_VirtualJoypad_get_screenWidth_06006734(void)

{
  char cVar1;
  code *pcVar2;
  undefined8 uVar3;
  
  cVar1 = cRam0000000103911543;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325c52);
    cRam0000000103911543 = '\x01';
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar3 = _UNK_1036d8418;
  if ((lRam00000001038d6bc0 != -8) && (uVar3 = _UNK_1036d8410, lRam00000001038d6bc0 != 0)) {
    return *(undefined4 *)(lRam00000001038d6bc0 + 8);
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fd2024);
  (*pcVar2)();
}

