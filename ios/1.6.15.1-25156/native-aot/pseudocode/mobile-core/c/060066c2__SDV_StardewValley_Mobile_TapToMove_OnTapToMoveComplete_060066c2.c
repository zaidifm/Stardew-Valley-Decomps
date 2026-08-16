/* 0x060066c2 StardewValley.Mobile.TapToMove.OnTapToMoveComplete @ 0x101fc6ea0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_OnTapToMoveComplete_060066c2(long param_1)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  
  cVar2 = cRam00000001039114d1;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325734);
    cRam00000001039114d1 = '\x01';
  }
  lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (((*(char *)(*(long *)(lVar3 + 0x530) + 0x68) == '\0') && (*(char *)(param_1 + 0xf9) == '\0'))
     && (*(long *)(param_1 + 0x20) == 0)) {
    SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
    cVar2 = SDV_StardewValley_Mobile_TapToMoveUtils_InWarpRange_060066d7();
    if ((cVar2 != '\0') &&
       (cVar2 = SDV_StardewValley_Mobile_TapToMoveUtils_InWarpRange_060066d7
                          (*(undefined4 *)(param_1 + 0x108),*(undefined4 *)(param_1 + 0x10c)),
       cVar2 != '\0')) {
      lVar3 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      if (*(long *)(lVar3 + 0x1f0) == 0) {
        SDV_StardewValley_Mobile_TapToMoveUtils_WarpIfInRange_060066d9
                  (*(undefined4 *)(param_1 + 0x108),*(undefined4 *)(param_1 + 0x10c));
        SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
        *(undefined1 *)(param_1 + 0xf9) = 1;
        goto LAB_101fc6ef8;
      }
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      if (((*pcRam00000001038d53e0 != '\0') &&
          (lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd(), lVar3 != 0)) &&
         (*(char *)(lVar3 + 0x118) != '\0')) {
        lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
        uVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        if (lVar3 == 0) {
          func_0x0001003316f4(0xee,_UNK_1036d7110);
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc7008);
          (*pcVar1)();
        }
        StardewValley_StardewValley_Event_TryStartEndFestivalDialogue_060034c2(lVar3,uVar4);
      }
    }
  }
  SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_1,1);
LAB_101fc6ef8:
  SDV_StardewValley_Mobile_TapToMove_CheckForQueuedReadyToHarvestTaps_060066c3(param_1);
  return;
}

