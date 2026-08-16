/* 0x06005da6 StardewValley.Menus.CoopGameMenu.checkFriendFarmCompatibility @ 0x101df73ac */

undefined8
SDV_StardewValley_Menus_CoopGameMenu_checkFriendFarmCompatibility_06005da6
          (undefined8 param_1,long param_2)

{
  uint uVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  
  if (lRam0000000103976fb8 == 0) {
    uVar1 = *(uint *)(param_2 + 0x38);
  }
  else {
    func_0x00010119b8f8();
    uVar1 = *(uint *)(param_2 + 0x38);
  }
  if (uVar1 < 8) {
    uVar3 = *(undefined8 *)(param_2 + 0x30);
    uVar2 = StardewValley_StardewValley_Multiplayer_get_protocolVersion_06003c1a();
    uVar2 = func_0x000100345aa0(uVar3,uVar2);
  }
  else {
    uVar2 = 0;
  }
  return uVar2;
}

