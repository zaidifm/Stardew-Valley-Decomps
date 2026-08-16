/* 0x060066c4 StardewValley.Mobile.TapToMove.CheckToWaterNextTile @ 0x101fc7388 */

void SDV_StardewValley_Mobile_TapToMove_CheckToWaterNextTile_060066c4(long param_1)

{
  char cVar1;
  long lVar2;
  
  if (lRam0000000103976fb8 == 0) {
    cVar1 = *(char *)(param_1 + 0x101);
  }
  else {
    func_0x00010119b8f8();
    cVar1 = *(char *)(param_1 + 0x101);
  }
  if (cVar1 != '\0') {
    lVar2 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (*(char *)(*(long *)(lVar2 + 0x530) + 0x68) == '\0') {
      *(undefined1 *)(param_1 + 0x101) = 0;
      *(undefined1 *)(param_1 + 0xfd) = 0;
      SDV_StardewValley_Mobile_TapToMove_CheckForQueuedReadyToHarvestTaps_060066c3(param_1);
    }
  }
  return;
}

