/* 0x060066ad StardewValley.Mobile.TapToMove.TappedOnHoeDirtAndHoldingSeed @ 0x101fb9f9c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMove_TappedOnHoeDirtAndHoldingSeed_060066ad
               (long param_1,int param_2,int param_3)

{
  int iVar1;
  int iVar2;
  char cVar3;
  code *pcVar4;
  bool bVar5;
  long lVar6;
  long lVar7;
  undefined8 uVar8;
  undefined8 *puStack_48;
  
  cVar3 = cRam00000001039114bc;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325423);
    cRam00000001039114bc = '\x01';
  }
  puStack_48 = (undefined8 *)0x0;
  uVar8 = _UNK_1036d47c8;
  if (*(long *)(param_1 + 0x28) != 0) {
    iVar1 = param_2 + 0x3f;
    if (-1 < param_2) {
      iVar1 = param_2;
    }
    iVar2 = param_3 + 0x3f;
    if (-1 < param_3) {
      iVar2 = param_3;
    }
    lVar6 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (*(long *)(param_1 + 0x28),iVar1 >> 6,iVar2 >> 6);
    bVar5 = false;
    if (lVar6 != 0) {
      lVar7 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      uVar8 = _UNK_1036d47d8;
      if (*(long *)(lVar7 + 0x120) == 0) goto LAB_101fba104;
      func_0x0001003554a0((float)*(int *)(lVar6 + 0x34),(float)*(int *)(lVar6 + 0x38),
                          *(long *)(lVar7 + 0x120),&puStack_48);
      if (((puStack_48 == (undefined8 *)0x0) ||
          (lRam00000001038c7940 != *(long *)(*(long *)(*(long *)*puStack_48 + 0x10) + 0x10))) ||
         (*(long *)(puStack_48[7] + 0x60) != 0)) {
        bVar5 = false;
      }
      else {
        lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar8 = _UNK_1036d47e0;
        if (lVar6 == 0) goto LAB_101fba104;
        lVar6 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
        bVar5 = false;
        if (lVar6 != 0) {
          lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          uVar8 = _UNK_1036d47e8;
          if (lVar6 == 0) goto LAB_101fba104;
          lVar6 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
          bVar5 = *(int *)(*(long *)(lVar6 + 0x18) + 0x68) == -0x4a;
        }
      }
    }
    return bVar5;
  }
LAB_101fba104:
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fba110);
  (*pcVar4)();
}

