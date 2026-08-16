/* 0x060066f0 StardewValley.Mobile.TapToMoveUtils.IsMatureTreeStumpOrBoulderAt @ 0x101fcc7b0 */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_IsMatureTreeStumpOrBoulderAt_060066f0
          (float param_1,float param_2)

{
  char cVar1;
  int iVar2;
  undefined8 uVar3;
  int iVar4;
  int iVar5;
  
  iVar5 = (int)param_1;
  iVar4 = (int)param_2;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  cVar1 = SDV_StardewValley_Mobile_TapToMoveUtils_IsTreeAt_060066f7(iVar5,iVar4);
  if ((((cVar1 == '\0') &&
       (iVar2 = SDV_StardewValley_Mobile_TapToMoveUtils_TreeGrowthStage_060066f4(iVar5,iVar4),
       iVar2 < 1)) &&
      (cVar1 = SDV_StardewValley_Mobile_TapToMoveUtils_IsChoppableBushAtPoint_060066fd(iVar5,iVar4),
      cVar1 == '\0')) &&
     (cVar1 = SDV_StardewValley_Mobile_TapToMoveUtils_IsStumpAt_06006703(iVar5,iVar4), cVar1 == '\0'
     )) {
    uVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_IsBoulderAt_06006709(iVar5,iVar4);
  }
  else {
    uVar3 = 1;
  }
  return uVar3;
}

