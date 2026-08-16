/* 0x06006750 StardewValley.Mobile.VirtualJoypad.get_showJoystick @ 0x101fd4ae4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_VirtualJoypad_get_showJoystick_06006750(void)

{
  code *pcVar1;
  char cVar2;
  bool bVar3;
  long lVar4;
  undefined8 *puVar5;
  long *plVar6;
  undefined8 uVar7;
  
  cVar2 = cRam000000010391155f;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325dbf);
    cRam000000010391155f = '\x01';
  }
  cVar2 = func_0x00010170ed74();
  if ((cVar2 == '\0') && (cVar2 = func_0x00010170efbc(), cVar2 == '\0')) {
    lVar4 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
    if ((lVar4 != 0) &&
       (lVar4 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd(),
       *(char *)(lVar4 + 0x11b) != '\0')) {
      lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      return *(char *)(lVar4 + 0x76c) != '\0';
    }
    lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
    if ((((*(int *)(lVar4 + 0x178) != 4) &&
         (lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec(),
         *(int *)(lVar4 + 0x178) != 7)) &&
        (lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec(),
        *(int *)(lVar4 + 0x178) != 6)) &&
       (lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec(),
       *(int *)(lVar4 + 0x178) != 8)) {
      lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar7 = _UNK_1036d8a70;
      if (lVar4 == 0) goto LAB_101fd4cf0;
      puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      if ((puVar5 == (undefined8 *)0x0) ||
         (lRam00000001038c7a50 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18))) {
        lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar7 = _UNK_1036d8a98;
        if (lVar4 == 0) goto LAB_101fd4cf0;
        puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
        if (puVar5 == (undefined8 *)0x0) {
          return false;
        }
        if (lRam00000001038c7ab0 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18))
        goto LAB_101fd4b20;
      }
      lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar7 = _UNK_1036d8a78;
      if (lVar4 == 0) {
LAB_101fd4cf0:
        func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fd4cfc);
        (*pcVar1)();
      }
      plVar6 = (long *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      cVar2 = (**(code **)(*plVar6 + 0x3f8))();
      if ((cVar2 != '\0') ||
         ((lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec(),
          *(int *)(lVar4 + 0x178) != 1 &&
          (lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec(),
          *(int *)(lVar4 + 0x178) != 5)))) goto LAB_101fd4b20;
    }
    bVar3 = true;
  }
  else {
LAB_101fd4b20:
    bVar3 = false;
  }
  return bVar3;
}

