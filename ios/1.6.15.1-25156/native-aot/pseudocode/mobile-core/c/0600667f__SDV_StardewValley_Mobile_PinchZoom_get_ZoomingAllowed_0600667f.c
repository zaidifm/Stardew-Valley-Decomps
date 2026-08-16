/* 0x0600667f StardewValley.Mobile.PinchZoom.get_ZoomingAllowed @ 0x101fb015c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_PinchZoom_get_ZoomingAllowed_0600667f(long param_1)

{
  undefined8 uVar1;
  char cVar2;
  code *pcVar3;
  byte bVar4;
  long lVar5;
  undefined8 *puVar6;
  
  cVar2 = cRam000000010391148e;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324ff0);
    cRam000000010391148e = '\x01';
  }
  lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if ((*(int *)(lVar5 + 0x178) == 2) ||
     (lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec(), *(int *)(lVar5 + 0x178) == 3
     )) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    lVar5 = *plRam00000001038d5360;
    bVar4 = *(char *)(lVar5 + 0x106) != '\0';
    if (*(char *)(lVar5 + 0xd8) != '\0') {
      bVar4 = bVar4 + 1;
    }
    if (*(char *)(lVar5 + 0xd9) != '\0') {
      bVar4 = bVar4 + 1;
    }
    uVar1 = _UNK_1036d39c8;
    if (1 < bVar4) goto joined_r0x000101fb0218;
  }
  lVar5 = StardewValley_StardewValley_Menus_TutorialManager_get_Instance_06005e62();
  if (*(long *)(lVar5 + 0x98) != 0) {
    return 0;
  }
  lVar5 = StardewValley_StardewValley_Menus_TutorialManager_get_Instance_06005e62();
  if (*(long *)(lVar5 + 0xa0) != 0) {
    return 0;
  }
  lVar5 = StardewValley_StardewValley_Game1_get_currentMinigame_06002fe3();
  if (lVar5 != 0) {
    return 0;
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  lVar5 = *plRam00000001038d5360;
  if ((((*(char *)(lVar5 + 0x106) == '\0') && (*(char *)(lVar5 + 0xd8) == '\0')) &&
      (*(char *)(lVar5 + 0xd9) == '\0')) ||
     ((lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec(),
      *(int *)(lVar5 + 0x178) == 2 ||
      (lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec(), uVar1 = _UNK_1036d39c0,
      *(int *)(lVar5 + 0x178) == 3)))) {
    lVar5 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
    if ((lVar5 != 0) &&
       (lVar5 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd(),
       *(char *)(lVar5 + 0x118) == '\0')) {
      return 0;
    }
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (*plRam00000001038d65b0 != 0) {
      return 0;
    }
    puVar6 = (undefined8 *)SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
    if ((((puVar6 != (undefined8 *)0x0) &&
         (lRam00000001038d52d8 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10))) ||
        ((puVar6 = (undefined8 *)SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1(),
         puVar6 != (undefined8 *)0x0 &&
         (lRam00000001038d52f0 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10))))) ||
       ((puVar6 = (undefined8 *)SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1(),
        puVar6 != (undefined8 *)0x0 &&
        (lRam00000001038d5250 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10))))) {
      return 1;
    }
    lVar5 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if (*(char *)(lVar5 + 0x17d) == '\0') {
      return 0;
    }
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (*pcRam00000001038d59f8 != '\0') {
      return 0;
    }
    puVar6 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    if (puVar6 == (undefined8 *)0x0) {
      return 1;
    }
    if (lRam00000001038c6db0 == *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10)) {
      return 0;
    }
    return 1;
  }
joined_r0x000101fb0218:
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x10) = 0x7f7fffff;
    return 0;
  }
  func_0x0001003316f4(0xee,uVar1);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fb042c);
  (*pcVar3)();
}

