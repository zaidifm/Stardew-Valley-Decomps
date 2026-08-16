/* 0x06005dfe StardewValley.Menus.MobileCustomizer.GetOrCreateDisplayFarmer @ 0x101e06ae4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Menus_MobileCustomizer_GetOrCreateDisplayFarmer_06005dfe(long param_1)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  long *plVar6;
  long lVar7;
  
  cVar2 = cRam0000000103910c0d;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910c0d == '\0') goto LAB_101e06bfc;
LAB_101e06b10:
    lVar4 = *(long *)(param_1 + 0x1a8);
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 != '\0') goto LAB_101e06b10;
LAB_101e06bfc:
    func_0x00010119b908(&UNK_103316c62);
    cRam0000000103910c0d = '\x01';
    lVar4 = *(long *)(param_1 + 0x1a8);
  }
  if (lVar4 == 0) {
    iVar1 = *(int *)(param_1 + 0x1ec);
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (iVar1 - 5U < 2) {
      uVar5 = _UNK_10369ef58;
      if (lVar4 == 0) goto LAB_101e06c80;
      lVar4 = StardewValley_StardewValley_Farmer_CreateFakeEventFarmer_060036e2();
    }
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x1a8) = lVar4;
    *(undefined1 *)((param_1 + 0x1a8U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    if (*(int *)(param_1 + 0x1ec) == 1) {
      lVar4 = *(long *)(param_1 + 0x1a8);
      lVar7 = *(long *)(lVar4 + 0x3a0);
      if (*(long *)(lVar7 + 0x60) == 0) {
        uVar5 = StardewValley_StardewValley_Farmer_GetPantsId_0600367e();
        func_0x000100354118(lVar7,uVar5);
        lVar4 = *(long *)(param_1 + 0x1a8);
        uVar5 = _UNK_10369ef88;
        if (lVar4 == 0) goto LAB_101e06c80;
      }
      lVar4 = *(long *)(lVar4 + 0x370);
      if (*(long *)(lVar4 + 0x60) == 0) {
        uVar5 = StardewValley_StardewValley_Farmer_GetShirtId_06003683();
        func_0x000100354118(lVar4,uVar5);
      }
    }
    (**(code **)(**(long **)(param_1 + 0x1a8) + 0x178))(*(long **)(param_1 + 0x1a8),2);
    uVar5 = _UNK_10369ef68;
    if (*(long *)(param_1 + 0x1a8) == 0) {
LAB_101e06c80:
      func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
      pcVar3 = (code *)SoftwareBreakpoint(1,0x101e06c8c);
      (*pcVar3)();
    }
    plVar6 = (long *)StardewValley_StardewValley_Farmer_get_FarmerSprite_060035b3();
    (**(code **)(*plVar6 + 0x108))();
    lVar4 = *(long *)(param_1 + 0x1a8);
  }
  return lVar4;
}

