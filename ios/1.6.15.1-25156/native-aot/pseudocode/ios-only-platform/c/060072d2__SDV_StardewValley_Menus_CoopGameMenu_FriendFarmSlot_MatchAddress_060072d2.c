/* 0x060072d2 StardewValley.Menus.CoopGameMenu+FriendFarmSlot.MatchAddress @ 0x1020a7268 */

void SDV_StardewValley_Menus_CoopGameMenu_FriendFarmSlot_MatchAddress_060072d2
               (long param_1,undefined8 param_2)

{
  long lVar1;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *(long *)(param_1 + 0x30);
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *(long *)(param_1 + 0x30);
  }
  func_0x00010034f078(*(undefined8 *)(lVar1 + 0x10),param_2);
  return;
}

