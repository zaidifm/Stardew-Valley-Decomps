/* 0x060066cb StardewValley.Mobile.TapToMoveUtils.get_gameLocation @ 0x101fc84fc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb(void)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 *puVar4;
  undefined8 uVar5;
  
  cVar1 = cRam00000001039114da;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033257bb);
    cRam00000001039114da = '\x01';
    lVar3 = StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
  }
  else {
    lVar3 = StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
  }
  if (((lVar3 == 0) ||
      (puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3(),
      puVar4 == (undefined8 *)0x0)) ||
     (lRam00000001038d5370 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 8))) {
    uVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  }
  else {
    puVar4 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
    if (puVar4 == (undefined8 *)0x0) {
      func_0x0001003316f4(0xee,_UNK_1036d7440);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fc85c8);
      (*pcVar2)();
    }
    if (lRam00000001038d5370 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 8)) {
      func_0x0001003316f4(0xd3,_UNK_1036d7448);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fc85dc);
      (*pcVar2)();
    }
    uVar5 = puVar4[2];
  }
  return uVar5;
}

