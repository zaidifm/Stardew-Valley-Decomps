/* 0x0600665f StardewValley.Mobile.AStarPath.set_nodes @ 0x101fae374 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_AStarPath_set_nodes_0600665f(long param_1,undefined8 param_2)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x10U) = param_2;
    *(undefined1 *)((param_1 + 0x10U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d3678);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fae3b4);
  (*pcVar1)();
}

