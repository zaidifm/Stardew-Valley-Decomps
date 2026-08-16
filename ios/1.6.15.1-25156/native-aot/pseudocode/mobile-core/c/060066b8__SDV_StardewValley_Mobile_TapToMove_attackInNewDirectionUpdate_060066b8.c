/* 0x060066b8 StardewValley.Mobile.TapToMove.attackInNewDirectionUpdate @ 0x101fc3d2c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_attackInNewDirectionUpdate_060066b8(long param_1)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  long *plVar4;
  undefined8 uVar5;
  
  if (lRam0000000103976fb8 == 0) {
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  else {
    func_0x00010119b8f8();
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  uVar5 = _UNK_1036d6a00;
  if (lVar3 == 0) {
LAB_101fc3e70:
    func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc3e7c);
    (*pcVar1)();
  }
  lVar3 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
  if (((lVar3 != 0) &&
      (lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
      *(char *)(lVar3 + 0x76c) != '\0')) &&
     (lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
     *(char *)(*(long *)(lVar3 + 0x530) + 0x68) == '\0')) {
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar5 = _UNK_1036d6a20;
    if (lVar3 == 0) goto LAB_101fc3e70;
    plVar4 = (long *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    cVar2 = (**(code **)(*plVar4 + 0x400))();
    if (cVar2 != '\0') {
      uVar5 = _UNK_1036d6a38;
      if (*(long *)(param_1 + 0x18) == 0) goto LAB_101fc3e70;
      SDV_StardewValley_Mobile_MobileKeyStates_SetMovePressed_06006670
                (*(long *)(param_1 + 0x18),*(undefined4 *)(param_1 + 0x154));
      plVar4 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
      (**(code **)(*plVar4 + 0x178))(plVar4,*(undefined4 *)(param_1 + 0x150));
      lVar3 = *(long *)(param_1 + 0x18);
      *(undefined1 *)(param_1 + 0x14d) = 1;
      *(undefined1 *)(param_1 + 0xf7) = 1;
      *(undefined2 *)(lVar3 + 0x16) = 0x100;
      *(bool *)(lVar3 + 0x15) = *(char *)(lVar3 + 0x17) == '\0';
      *(undefined4 *)(param_1 + 0x124) = 0;
    }
  }
  return;
}

