/* 0x06006717 StardewValley.Mobile.TapToMoveUtils.TappedEggAtEggFestival @ 0x101fcf6c0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_TappedEggAtEggFestival_06006717(float param_1,float param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  uint uVar5;
  long lVar6;
  
  cVar2 = cRam0000000103911526;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325b38);
    cRam0000000103911526 = '\x01';
    lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
    if (lVar3 == 0) {
      return 0;
    }
  }
  else {
    lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
    if (lVar3 == 0) {
      return 0;
    }
  }
  lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
  uVar4 = _UNK_1036d7fb0;
  if (lVar3 != 0) {
    uVar4 = StardewValley_StardewValley_Event_get_FestivalName_06003451();
    cVar2 = func_0x000100345aa0(uVar4,uRam0000000103904ac0);
    if (cVar2 == '\0') {
      return 0;
    }
    lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
    uVar4 = _UNK_1036d7fc0;
    if (lVar3 != 0) {
      uVar5 = 0;
      lVar6 = 0x20;
      do {
        if (*(int *)(*(long *)(lVar3 + 0x90) + 0x18) <= (int)uVar5) {
          return 0;
        }
        lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
        if (*(uint *)(*(long *)(lVar3 + 0x90) + 0x18) <= uVar5) {
          func_0x000100331b90();
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcf85c);
          (*pcVar1)();
        }
        lVar3 = *(long *)(*(long *)(lVar3 + 0x90) + 0x10);
        if (*(uint *)(lVar3 + 0x18) <= uVar5) {
          func_0x0001003316f4(0xcc,_UNK_1036d7fe8);
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcf870);
          (*pcVar1)();
        }
        lVar3 = *(long *)(lVar6 + lVar3);
        uVar4 = _UNK_1036d7fe0;
        if (lVar3 == 0) break;
        cVar2 = func_0x000100356238(lVar3 + 0x38,(int)param_1,(int)param_2);
        if (cVar2 != '\0') {
          return 1;
        }
        lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        lVar6 = lVar6 + 8;
        uVar5 = uVar5 + 1;
        uVar4 = _UNK_1036d7fc0;
      } while (lVar3 != 0);
    }
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcf854);
  (*pcVar1)();
}

