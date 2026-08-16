/* 0x06005e4d StardewValley.Menus.TutorialItem.Menu @ 0x101e1cc48 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_Menu_06005e4d(long param_1,undefined8 param_2)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x98) = param_2;
    *(undefined1 *)(((ulong)(param_1 + 0x98) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036a2860);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1cc8c);
  (*pcVar1)();
}

