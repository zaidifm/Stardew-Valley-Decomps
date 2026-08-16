/* 0x060066d5 StardewValley.Mobile.TapToMoveUtils.get_PlayerOffsetPosition @ 0x101fc9448 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

float SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5(void)

{
  code *pcVar1;
  long lVar2;
  undefined8 uVar3;
  float fVar4;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar2 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar3 = _UNK_1036d7688;
  if (*(long *)(lVar2 + 0x20) != 0) {
    fVar4 = (float)func_0x000101b4d600();
    lVar2 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar3 = _UNK_1036d7698;
    if (*(long *)(lVar2 + 0x20) != 0) {
      func_0x000101b4d714();
      return fVar4 + 32.0;
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc94e4);
  (*pcVar1)();
}

