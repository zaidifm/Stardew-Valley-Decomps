/* 0x0600660c StardewValley.Mobile.AStarGraph.AreOppositeWalkDirection @ 0x101fa35c0 */

ulong SDV_StardewValley_Mobile_AStarGraph_AreOppositeWalkDirection_0600660c
                (undefined8 param_1,int param_2,uint param_3)

{
  ulong uVar1;
  
  switch(param_2) {
  case 1:
  case 5:
  case 6:
    if ((param_3 < 9) && ((1 << (ulong)(param_3 & 0x1f) & 0x184U) != 0)) {
      return 1;
    }
    switch(param_2) {
    case 2:
      goto code_r0x000101fa3678;
    case 3:
    case 5:
      goto code_r0x000101fa3624;
    case 4:
    case 6:
      goto code_r0x000101fa3658;
    default:
      goto LAB_101fa3680;
    }
  case 2:
code_r0x000101fa3678:
    if (6 < param_3) {
LAB_101fa3680:
      return 0;
    }
    break;
  case 3:
  case 7:
code_r0x000101fa3624:
    if ((param_3 < 9) && ((1 << (ulong)(param_3 & 0x1f) & 0x150U) != 0)) {
      return 1;
    }
    if (param_2 != 4) {
      if (param_2 == 7) goto code_r0x000101fa3678;
      if (param_2 != 6) {
        return 0;
      }
    }
  case 4:
  case 8:
code_r0x000101fa3658:
    if ((((param_3 < 8) && (uVar1 = 1, (1 << (ulong)(param_3 & 0x1f) & 0xa8U) != 0)) ||
        (uVar1 = 0, 1 < param_2 - 7U)) || (6 < param_3)) {
      return uVar1;
    }
    break;
  default:
    goto LAB_101fa3680;
  }
  return 0x1010000000100 >> (((ulong)param_3 & 7) << 3);
}

