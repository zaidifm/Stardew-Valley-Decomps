/* 0x060066a8 StardewValley.Mobile.TapToMove.CheckToDoDefenseAction @ 0x101fb95e0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMove_CheckToDoDefenseAction_060066a8
          (long param_1,undefined4 param_2,undefined4 param_3)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  long *plVar4;
  ulong uVar5;
  undefined8 uVar6;
  
  if (lRam0000000103976fb8 == 0) {
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  else {
    func_0x00010119b8f8();
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  }
  uVar6 = _UNK_1036d4618;
  if (lVar3 == 0) {
LAB_101fb96ac:
    func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fb96b8);
    (*pcVar1)();
  }
  lVar3 = StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
  uVar6 = 0;
  if (lVar3 != 0) {
    lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar6 = _UNK_1036d4620;
    if (lVar3 == 0) goto LAB_101fb96ac;
    plVar4 = (long *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    uVar5 = (**(code **)(*plVar4 + 0x400))();
    if (((uVar5 & 0xff) == 0) ||
       (cVar2 = SDV_StardewValley_Mobile_TapToMove_TappedOnFarmer_060066a9(uVar5,param_2,param_3),
       cVar2 == '\0')) {
      uVar6 = 0;
    }
    else {
      uVar6 = _UNK_1036d4630;
      if (param_1 == 0) goto LAB_101fb96ac;
      uVar6 = 1;
      *(undefined4 *)(param_1 + 0x124) = 10;
    }
  }
  return uVar6;
}

