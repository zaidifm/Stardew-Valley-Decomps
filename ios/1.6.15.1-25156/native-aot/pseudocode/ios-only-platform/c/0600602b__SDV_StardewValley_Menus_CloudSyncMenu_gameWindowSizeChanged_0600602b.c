/* 0x0600602b StardewValley.Menus.CloudSyncMenu.gameWindowSizeChanged @ 0x101e6159c */

void SDV_StardewValley_Menus_CloudSyncMenu_gameWindowSizeChanged_0600602b
               (undefined8 param_1,undefined8 param_2,undefined8 param_3,undefined8 param_4,
               undefined8 param_5)

{
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  StardewValley_StardewValley_Menus_IClickableMenu_gameWindowSizeChanged_06006186
            (param_1,param_2,param_3,param_4,param_5);
  SDV_StardewValley_Menus_CloudSyncMenu_SetupButtons_06006024(param_1);
  return;
}

