/* 0x060066e9 StardewValley.Mobile.TapToMoveUtils.isOnOrNearSuspensionBridge @ 0x101fcb604 */

bool SDV_StardewValley_Mobile_TapToMoveUtils_isOnOrNearSuspensionBridge_060066e9
               (uint param_1,int param_2)

{
  long lVar1;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar1 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (*(char *)(*(long *)(lVar1 + 0x438) + 0x68) == '\0') {
    if (param_2 - 0x2aU < 0xfffffffd) {
      return false;
    }
    if ((int)param_1 < 0x1a) {
      return false;
    }
    if (0x26 < param_1) {
      return 0x2a < param_1;
    }
  }
  return true;
}

