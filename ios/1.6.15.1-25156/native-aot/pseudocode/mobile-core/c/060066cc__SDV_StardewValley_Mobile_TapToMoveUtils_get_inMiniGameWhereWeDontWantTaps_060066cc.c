/* 0x060066cc StardewValley.Mobile.TapToMoveUtils.get_inMiniGameWhereWeDontWantTaps @ 0x101fc85dc */

bool SDV_StardewValley_Mobile_TapToMoveUtils_get_inMiniGameWhereWeDontWantTaps_060066cc(void)

{
  char cVar1;
  bool bVar2;
  long lVar3;
  undefined8 *puVar4;
  
  cVar1 = cRam00000001039114db;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033257d0);
    cRam00000001039114db = '\x01';
    lVar3 = StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
    if (lVar3 == 0) {
      return false;
    }
  }
  else {
    lVar3 = StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
    if (lVar3 == 0) {
      return false;
    }
  }
  puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
  if ((((((puVar4 == (undefined8 *)0x0) ||
         (lRam0000000103904a90 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 8))) &&
        ((puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3(),
         puVar4 == (undefined8 *)0x0 ||
         (lRam0000000103904a88 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 8))))) &&
       ((puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3(),
        puVar4 == (undefined8 *)0x0 ||
        (lRam00000001038d54f0 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 8))))) &&
      ((puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3(),
       puVar4 == (undefined8 *)0x0 ||
       (lRam0000000103904a80 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 8))))) &&
     (((puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3(),
       puVar4 == (undefined8 *)0x0 ||
       (lRam0000000103904a78 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 8))) &&
      ((puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3(),
       puVar4 == (undefined8 *)0x0 ||
       (lRam0000000103904a70 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 8))))))) {
    puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
    if ((puVar4 != (undefined8 *)0x0) &&
       (lRam0000000103904a68 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 8))) {
      puVar4 = (undefined8 *)0x0;
    }
    bVar2 = puVar4 != (undefined8 *)0x0;
  }
  else {
    bVar2 = true;
  }
  return bVar2;
}

