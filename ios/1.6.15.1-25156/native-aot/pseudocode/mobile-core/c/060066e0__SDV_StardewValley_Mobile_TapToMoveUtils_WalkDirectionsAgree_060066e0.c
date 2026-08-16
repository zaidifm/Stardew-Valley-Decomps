/* 0x060066e0 StardewValley.Mobile.TapToMoveUtils.WalkDirectionsAgree @ 0x101fca330 */

uint SDV_StardewValley_Mobile_TapToMoveUtils_WalkDirectionsAgree_060066e0
               (undefined4 param_1,uint param_2)

{
  uint uVar1;
  
  switch(param_1) {
  case 1:
    if (param_2 < 7) {
      uVar1 = 0x62;
code_r0x000101fca3d0:
      return uVar1 >> (ulong)(param_2 & 0x1f) & 1;
    }
    break;
  case 2:
    if (param_2 < 9) {
      uVar1 = 0x184;
      goto code_r0x000101fca3d0;
    }
    break;
  case 3:
    if (param_2 < 8) {
      uVar1 = 0xa8;
      goto code_r0x000101fca3d0;
    }
    break;
  case 4:
    if (param_2 < 9) {
      uVar1 = 0x150;
      goto code_r0x000101fca3d0;
    }
    break;
  case 5:
    return param_2 < 6 & param_2;
  case 6:
    if (param_2 < 7) {
      uVar1 = 0x52;
      goto code_r0x000101fca3d0;
    }
    break;
  case 7:
    if (param_2 < 8) {
      uVar1 = 0x8c;
      goto code_r0x000101fca3d0;
    }
    break;
  case 8:
    if (param_2 < 9) {
      uVar1 = 0x114;
      goto code_r0x000101fca3d0;
    }
  }
  return 0;
}

