/* 0x060066d0 StardewValley.Mobile.TapToMoveUtils.ContainsCinemaTicketOffice @ 0x101fc8b2c */

bool SDV_StardewValley_Mobile_TapToMoveUtils_ContainsCinemaTicketOffice_060066d0
               (int param_1,int param_2)

{
  char cVar1;
  bool bVar2;
  undefined8 *puVar3;
  
  cVar1 = cRam00000001039114df;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325815);
    cRam00000001039114df = '\x01';
    puVar3 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    if (puVar3 == (undefined8 *)0x0) {
      return false;
    }
  }
  else {
    puVar3 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    if (puVar3 == (undefined8 *)0x0) {
      return false;
    }
  }
  if (lRam00000001038c6e88 == *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x10)) {
    cVar1 = StardewValley_StardewValley_Utility_doesMasterPlayerHaveMailReceivedButNotMailForTomorrow_06004145
                      (uRam00000001038e79a0);
    bVar2 = false;
    if (cVar1 != '\0') {
      bVar2 = (((-(param_1 < 0x39) & 1U | (-(param_2 < 0x15) & 1U) << 1 |
                 (-(0x35 < param_1) & 1U) << 2 | (0x12 < param_2) * -8) ^ 0xff) & 0xf) == 0;
    }
  }
  else {
    bVar2 = false;
  }
  return bVar2;
}

