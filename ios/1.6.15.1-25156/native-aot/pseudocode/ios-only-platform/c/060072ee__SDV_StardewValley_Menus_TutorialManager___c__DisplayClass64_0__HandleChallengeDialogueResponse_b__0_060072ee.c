/* 0x060072ee StardewValley.Menus.TutorialManager+<>c__DisplayClass64_0.<HandleChallengeDialogueResponse>b__0 @ 0x1020a844c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager___c__DisplayClass64_0__HandleChallengeDialogueResponse_b__0_060072ee
               (long param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  long *plVar6;
  
  cVar1 = cRam00000001039120fd;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332fd4f);
    cRam00000001039120fd = '\x01';
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  else {
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  uVar4 = _UNK_1036eddd8;
  if ((lVar3 != 0) &&
     (lVar3 = StardewValley_StardewValley_Character_get_currentLocation_0600326b(),
     uVar4 = _UNK_1036edde0, param_1 != 0)) {
    uVar4 = (**(code **)(**(long **)(param_1 + 0x10) + 0x60))();
    uVar5 = func_0x000100331870(uRam00000001038e2108);
    StardewValley_StardewValley_Event__ctor_06003458(uVar5,uVar4,0);
    uVar4 = _UNK_1036eddf0;
    if (lVar3 != 0) {
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar3 + 0x1f0) = uVar5;
      *(undefined1 *)((lVar3 + 0x1f0U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
      lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar4 = _UNK_1036eddf8;
      if (lVar3 != 0) {
        plVar6 = (long *)StardewValley_StardewValley_Character_get_currentLocation_0600326b();
        (**(code **)(*plVar6 + 0x170))();
        return;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a857c);
  (*pcVar2)();
}

