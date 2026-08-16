/* 0x060072dc StardewValley.Menus.CoopGameMenu+LobbyUpdateCallback.OnLobbyUpdate @ 0x1020a7dc0 */

void SDV_StardewValley_Menus_CoopGameMenu_LobbyUpdateCallback_OnLobbyUpdate_060072dc
               (long param_1,undefined8 param_2)

{
  long lVar1;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *(long *)(param_1 + 0x10);
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *(long *)(param_1 + 0x10);
  }
  if (lVar1 != 0) {
    (**(code **)(lVar1 + 0x18))(lVar1,param_2);
  }
  return;
}

