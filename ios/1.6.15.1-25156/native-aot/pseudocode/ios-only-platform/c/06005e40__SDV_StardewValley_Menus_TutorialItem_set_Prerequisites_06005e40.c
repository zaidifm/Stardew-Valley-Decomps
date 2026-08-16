/* 0x06005e40 StardewValley.Menus.TutorialItem.set_Prerequisites @ 0x101e1c8d4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_set_Prerequisites_06005e40
               (long param_1,undefined8 param_2)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x68U) = param_2;
    *(undefined1 *)((param_1 + 0x68U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036a27f8);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1c914);
  (*pcVar1)();
}

