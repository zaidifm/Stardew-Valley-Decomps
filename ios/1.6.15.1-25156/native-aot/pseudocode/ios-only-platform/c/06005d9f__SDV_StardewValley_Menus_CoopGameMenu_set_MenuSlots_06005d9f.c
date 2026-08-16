/* 0x06005d9f StardewValley.Menus.CoopGameMenu.set_MenuSlots @ 0x101df697c */

void SDV_StardewValley_Menus_CoopGameMenu_set_MenuSlots_06005d9f(long param_1,undefined8 param_2)

{
  long lVar1;
  long lVar2;
  
  lVar2 = lRam00000001038c4be0;
  lVar1 = 0xd0;
  if (*(char *)(param_1 + 0x1c0) != '\0') {
    lVar1 = 0x178;
  }
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + lVar1) = param_2;
  *(undefined1 *)(lVar2 + (ulong)((uint)((int)lVar1 + (int)param_1) >> 9)) = 1;
  return;
}

