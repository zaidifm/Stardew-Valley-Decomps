/* 0x060072db StardewValley.Menus.CoopGameMenu+LobbyUpdateCallback..ctor @ 0x1020a7d80 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_LobbyUpdateCallback__ctor_060072db
               (long param_1,undefined8 param_2)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x10U) = param_2;
    *(undefined1 *)((param_1 + 0x10U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036edd38);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x1020a7dc0);
  (*pcVar1)();
}

