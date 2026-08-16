/* 0x06006635 StardewValley.Mobile.AStarNode.get_TileClear @ 0x101fa8498 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_AStarNode_get_TileClear_06006635(long param_1)

{
  code *pcVar1;
  char cVar2;
  bool bVar3;
  long *plVar4;
  undefined8 uVar5;
  
  if (lRam0000000103976fb8 == 0) {
    cVar2 = *(char *)(param_1 + 0x45);
  }
  else {
    func_0x00010119b8f8();
    cVar2 = *(char *)(param_1 + 0x45);
  }
  if (cVar2 == '\0') {
    uVar5 = _UNK_1036d29e0;
    if (*(long *)(*(long *)(param_1 + 0x18) + 0x10) == 0) {
LAB_101fa867c:
      func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa8688);
      (*pcVar1)();
    }
    cVar2 = func_0x0001018d3404((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38));
    if (cVar2 != '\0') {
      plVar4 = *(long **)(*(long *)(param_1 + 0x18) + 0x10);
      uVar5 = _UNK_1036d29f0;
      if (plVar4 == (long *)0x0) goto LAB_101fa867c;
      cVar2 = (**(code **)(*plVar4 + 0x3d0))
                        ((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38));
      if (((((((cVar2 == '\0') ||
              (cVar2 = SDV_StardewValley_Mobile_AStarNode_isGate_0600663e(param_1), cVar2 != '\0'))
             && (cVar2 = SDV_StardewValley_Mobile_AStarNode_isTilePassable_06006643(param_1),
                cVar2 != '\0')) &&
            (((cVar2 = SDV_StardewValley_Mobile_AStarNode_ContainsStumpOrBoulder_06006647(param_1),
              cVar2 == '\0' &&
              (cVar2 = SDV_StardewValley_Mobile_AStarNode_ContainsFurniture_0600664c(param_1),
              cVar2 == '\0')) &&
             ((cVar2 = SDV_StardewValley_Mobile_AStarNode_isFence_0600663d(param_1), cVar2 == '\0'
              || (cVar2 = SDV_StardewValley_Mobile_AStarNode_isGate_0600663e(param_1), cVar2 != '\0'
                 )))))) &&
           ((cVar2 = SDV_StardewValley_Mobile_AStarNode_ContainsBuilding_06006651(param_1),
            cVar2 == '\0' ||
            (cVar2 = SDV_StardewValley_Mobile_AStarNode_IsBuildingPassable_06006644(param_1),
            cVar2 != '\0')))) &&
          ((cVar2 = SDV_StardewValley_Mobile_AStarNode_ContainsAnimals_06006655(param_1),
           cVar2 == '\0' &&
           ((((cVar2 = SDV_StardewValley_Mobile_AStarNode_ContainsNPC_06006653(param_1),
              cVar2 == '\0' &&
              (cVar2 = SDV_StardewValley_Mobile_AStarNode_ContainsFestivalProp_06006657(param_1),
              cVar2 == '\0')) &&
             (cVar2 = SDV_StardewValley_Mobile_AStarNode_isBlockingBedTile_0600663c(param_1),
             cVar2 == '\0')) &&
            ((cVar2 = SDV_StardewValley_Mobile_AStarNode_ContainsTravellingCart_06006639(param_1),
             cVar2 == '\0' &&
             (cVar2 = SDV_StardewValley_Mobile_AStarNode_ContainsTravellingDesertShop_0600663a
                                (param_1), cVar2 == '\0')))))))) &&
         ((cVar2 = SDV_StardewValley_Mobile_AStarNode_get_BrokenFestivalTile_06006638(param_1),
          cVar2 == '\0' &&
          (cVar2 = SDV_StardewValley_Mobile_AStarNode_ContainsCinema_0600663b(param_1),
          cVar2 == '\0')))) {
        cVar2 = SDV_StardewValley_Mobile_AStarNode_ContainsParrotExpress_06006636(param_1);
        return cVar2 == '\0';
      }
    }
    bVar3 = false;
  }
  else {
    bVar3 = true;
  }
  return bVar3;
}

