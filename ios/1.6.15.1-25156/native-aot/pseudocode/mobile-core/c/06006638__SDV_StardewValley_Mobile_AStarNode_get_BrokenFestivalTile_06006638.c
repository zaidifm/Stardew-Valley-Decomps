/* 0x06006638 StardewValley.Mobile.AStarNode.get_BrokenFestivalTile @ 0x101fa8920 */

bool SDV_StardewValley_Mobile_AStarNode_get_BrokenFestivalTile_06006638(long param_1)

{
  char cVar1;
  bool bVar2;
  long lVar3;
  undefined8 uVar4;
  int iVar5;
  
  cVar1 = cRam0000000103911447;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103911447 == '\0') goto LAB_101fa8acc;
LAB_101fa894c:
    lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
    if (lVar3 == 0) {
      return false;
    }
  }
  else {
    func_0x00010119b8f8();
    if (cVar1 != '\0') goto LAB_101fa894c;
LAB_101fa8acc:
    func_0x00010119b908(&UNK_103324ab0);
    cRam0000000103911447 = '\x01';
    lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
    if (lVar3 == 0) {
      return false;
    }
  }
  iVar5 = *(int *)(param_1 + 0x34);
  if (iVar5 == 0x12) {
    if (*(int *)(param_1 + 0x38) != 0x1f) {
LAB_101fa89a8:
      iVar5 = *(int *)(param_1 + 0x34);
      goto LAB_101fa89ac;
    }
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (*piRam00000001038d5780 != 0x10) goto LAB_101fa89a8;
    uVar4 = StardewValley_StardewValley_Game1_get_currentSeason_06002fc4();
    cVar1 = func_0x000100345aa0(uVar4,uRam00000001038ef1f8);
    if (cVar1 == '\0') goto LAB_101fa89a8;
LAB_101fa8a50:
    bVar2 = true;
  }
  else {
LAB_101fa89ac:
    if ((iVar5 == 0x10) && (*(int *)(param_1 + 0x38) == 0x13)) {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      if (*piRam00000001038d5780 == 0x1b) {
        uVar4 = StardewValley_StardewValley_Game1_get_currentSeason_06002fc4();
        cVar1 = func_0x000100345aa0(uVar4,uRam00000001038ef1f8);
        if (cVar1 != '\0') goto LAB_101fa8a50;
      }
    }
    iVar5 = *(int *)(param_1 + 0x34);
    if (iVar5 == 0x42) {
      if (*(int *)(param_1 + 0x38) == 4) {
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        if (*piRam00000001038d5780 == 8) {
          uVar4 = StardewValley_StardewValley_Game1_get_currentSeason_06002fc4();
          cVar1 = func_0x000100345aa0(uVar4,uRam00000001038ef200);
          if (cVar1 != '\0') goto LAB_101fa8a50;
        }
      }
      iVar5 = *(int *)(param_1 + 0x34);
    }
    if ((iVar5 == 0x67) && (*(int *)(param_1 + 0x38) == 0x1c)) {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      if (*piRam00000001038d5780 == 8) {
        uVar4 = StardewValley_StardewValley_Game1_get_currentSeason_06002fc4();
        cVar1 = func_0x000100345aa0(uVar4,uRam00000001038ef200);
        return cVar1 != '\0';
      }
    }
    bVar2 = false;
  }
  return bVar2;
}

