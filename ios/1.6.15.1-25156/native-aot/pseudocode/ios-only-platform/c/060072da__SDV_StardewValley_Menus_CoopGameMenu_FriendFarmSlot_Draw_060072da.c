/* 0x060072da StardewValley.Menus.CoopGameMenu+FriendFarmSlot.Draw @ 0x1020a7cc8 */

void SDV_StardewValley_Menus_CoopGameMenu_FriendFarmSlot_Draw_060072da
               (long *param_1,undefined8 param_2,undefined4 param_3)

{
  long lVar1;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *param_1;
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *param_1;
  }
  (**(code **)(lVar1 + 0xb0))(param_1,param_2,param_3);
  (**(code **)(*param_1 + 0xa8))(param_1,param_2,param_3);
  (**(code **)(*param_1 + 0xa0))(param_1,param_2,param_3);
  (**(code **)(*param_1 + 0x98))(param_1,param_2,param_3);
  return;
}

