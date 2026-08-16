/* 0x06006625 StardewValley.Mobile.AStarNode.set_parentNode @ 0x101fa771c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_AStarNode_set_parentNode_06006625(long param_1,undefined8 param_2)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x10U) = param_2;
    *(undefined1 *)((param_1 + 0x10U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d2880);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa775c);
  (*pcVar1)();
}

