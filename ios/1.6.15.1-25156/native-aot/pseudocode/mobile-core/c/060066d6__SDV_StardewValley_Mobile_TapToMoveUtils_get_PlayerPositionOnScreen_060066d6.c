/* 0x060066d6 StardewValley.Mobile.TapToMoveUtils.get_PlayerPositionOnScreen @ 0x101fc94e4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

float SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerPositionOnScreen_060066d6(void)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  float fVar6;
  
  cVar2 = cRam00000001039114e5;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325831);
    cRam00000001039114e5 = '\x01';
  }
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar5 = _UNK_1036d76a8;
  if (*(long *)(lVar4 + 0x20) != 0) {
    fVar6 = (float)func_0x000101b4d600();
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    iVar1 = *piRam00000001038d5380;
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar5 = _UNK_1036d76c0;
    if ((*(long *)(lVar4 + 0x20) != 0) &&
       (func_0x000101b4d714(), uVar5 = _UNK_1036d76c8, piRam00000001038d5380 != (int *)0x0)) {
      return (fVar6 + 32.0) - (float)iVar1;
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fc95fc);
  (*pcVar3)();
}

