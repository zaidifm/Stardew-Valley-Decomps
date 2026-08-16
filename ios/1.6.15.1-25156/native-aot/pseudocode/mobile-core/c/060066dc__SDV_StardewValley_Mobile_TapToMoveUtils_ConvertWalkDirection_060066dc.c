/* 0x060066dc StardewValley.Mobile.TapToMoveUtils.ConvertWalkDirection @ 0x101fca120 */

undefined4 SDV_StardewValley_Mobile_TapToMoveUtils_ConvertWalkDirection_060066dc(int param_1)

{
  if (param_1 - 1U < 4) {
    return *(undefined4 *)(&UNK_103333ef0 + (long)(int)(param_1 - 1U) * 4);
  }
  return 0xffffffff;
}

