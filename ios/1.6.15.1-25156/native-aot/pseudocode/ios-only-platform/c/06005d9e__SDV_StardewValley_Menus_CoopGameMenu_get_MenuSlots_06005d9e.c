/* 0x06005d9e StardewValley.Menus.CoopGameMenu.get_MenuSlots @ 0x101df6944 */

undefined8 SDV_StardewValley_Menus_CoopGameMenu_get_MenuSlots_06005d9e(long param_1)

{
  long lVar1;
  
  lVar1 = 0xd0;
  if (*(char *)(param_1 + 0x1c0) != '\0') {
    lVar1 = 0x178;
  }
  return *(undefined8 *)(param_1 + lVar1);
}

