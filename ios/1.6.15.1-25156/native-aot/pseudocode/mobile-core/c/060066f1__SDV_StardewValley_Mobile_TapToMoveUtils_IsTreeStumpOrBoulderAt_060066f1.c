/* 0x060066f1 StardewValley.Mobile.TapToMoveUtils.IsTreeStumpOrBoulderAt @ 0x101fcc848 */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_IsTreeStumpOrBoulderAt_060066f1(float param_1,float param_2)

{
  char cVar1;
  undefined8 uVar2;
  int iVar3;
  int iVar4;
  
  iVar4 = (int)param_1;
  iVar3 = (int)param_2;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  cVar1 = SDV_StardewValley_Mobile_TapToMoveUtils_IsTreeAt_060066f7(iVar4,iVar3);
  if (((cVar1 == '\0') &&
      (cVar1 = SDV_StardewValley_Mobile_TapToMoveUtils_IsStumpAt_06006703(iVar4,iVar3),
      cVar1 == '\0')) &&
     (cVar1 = SDV_StardewValley_Mobile_TapToMoveUtils_IsBoulderAt_06006709(iVar4,iVar3),
     cVar1 == '\0')) {
    uVar2 = SDV_StardewValley_Mobile_TapToMoveUtils_IsChoppableBushAtPoint_060066fd(iVar4,iVar3);
  }
  else {
    uVar2 = 1;
  }
  return uVar2;
}

