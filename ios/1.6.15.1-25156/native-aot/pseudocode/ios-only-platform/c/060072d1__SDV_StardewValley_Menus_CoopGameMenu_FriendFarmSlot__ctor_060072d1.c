/* 0x060072d1 StardewValley.Menus.CoopGameMenu+FriendFarmSlot..ctor @ 0x1020a71e8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_FriendFarmSlot__ctor_060072d1
               (long param_1,undefined8 param_2,undefined8 param_3)

{
  code *pcVar1;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  SDV_StardewValley_Menus_CoopGameMenu_CoopGameMenuSlot__ctor_060072c0(param_1,param_2);
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x30) = param_3;
    *(undefined1 *)(((ulong)(param_1 + 0x30) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036edb80);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x1020a7268);
  (*pcVar1)();
}

