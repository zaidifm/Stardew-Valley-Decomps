/* 0x06005e56 StardewValley.Menus.TutorialItem.setComplete @ 0x101e1d0d8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_setComplete_06005e56(long param_1)

{
  long lVar1;
  code *pcVar2;
  
  if (cRam0000000103910c65 == '\0') {
    func_0x00010119b908(&UNK_1033175f1);
    cRam0000000103910c65 = '\x01';
  }
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036a28f0);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1d15c);
    (*pcVar2)();
  }
  *(undefined8 *)(param_1 + 0x78) = 0;
  *(undefined2 *)(param_1 + 0xb0) = 0x101;
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x80) = uRam00000001038c4f58;
  *(undefined1 *)(((ulong)(param_1 + 0x80) >> 9 & 0x7fffff) + lVar1) = 1;
  return;
}

