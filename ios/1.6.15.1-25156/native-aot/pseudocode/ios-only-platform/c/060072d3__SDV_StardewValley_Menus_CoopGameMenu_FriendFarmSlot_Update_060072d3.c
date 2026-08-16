/* 0x060072d3 StardewValley.Menus.CoopGameMenu+FriendFarmSlot.Update @ 0x1020a72d0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_FriendFarmSlot_Update_060072d3
               (long param_1,undefined8 param_2)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x30U) = param_2;
    *(undefined1 *)((param_1 + 0x30U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036edb98);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x1020a7310);
  (*pcVar1)();
}

