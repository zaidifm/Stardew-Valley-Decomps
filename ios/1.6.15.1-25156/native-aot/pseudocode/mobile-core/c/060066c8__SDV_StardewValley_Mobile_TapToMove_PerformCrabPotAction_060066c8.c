/* 0x060066c8 StardewValley.Mobile.TapToMove.PerformCrabPotAction @ 0x101fc7b20 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_TapToMove_PerformCrabPotAction_060066c8(long param_1)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  long lVar6;
  long *plVar7;
  
  if (lRam0000000103976fb8 == 0) {
    lVar6 = *(long *)(param_1 + 0xa8);
  }
  else {
    func_0x00010119b8f8();
    lVar6 = *(long *)(param_1 + 0xa8);
  }
  if (lVar6 == 0) {
    return 0;
  }
  lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar5 = _UNK_1036d72d8;
  if (lVar6 == 0) goto LAB_101fc7ca4;
  lVar6 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
  if (lVar6 != 0) {
    lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar5 = _UNK_1036d72f0;
    if (lVar6 == 0) goto LAB_101fc7ca4;
    lVar6 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
    if (*(int *)(*(long *)(lVar6 + 0x18) + 0x68) == -0x15) {
      plVar7 = *(long **)(param_1 + 0xa8);
      lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar5 = _UNK_1036d7308;
      if (lVar6 == 0) goto LAB_101fc7ca4;
      uVar3 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
      uVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar5 = _UNK_1036d7310;
      if (plVar7 == (long *)0x0) goto LAB_101fc7ca4;
      cVar2 = (**(code **)(*plVar7 + 0x578))(plVar7,uVar3,0,uVar4,0);
      if (cVar2 != '\0') {
        lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar5 = _UNK_1036d7318;
        if (lVar6 == 0) goto LAB_101fc7ca4;
        func_0x000101852bf0();
      }
      goto LAB_101fc7c04;
    }
  }
  plVar7 = *(long **)(param_1 + 0xa8);
  uVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar5 = _UNK_1036d72e0;
  if (plVar7 == (long *)0x0) {
LAB_101fc7ca4:
    func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc7cb0);
    (*pcVar1)();
  }
  cVar2 = (**(code **)(*plVar7 + 0x4f0))(plVar7,uVar3,0);
  if (cVar2 == '\0') {
    (**(code **)(**(long **)(param_1 + 0xa8) + 0x538))();
  }
LAB_101fc7c04:
  *(undefined8 *)(param_1 + 0xa8) = 0;
  return 1;
}

