/* 0x060066cf StardewValley.Mobile.TapToMoveUtils.ContainsCinemaDoor @ 0x101fc8a48 */

undefined8
SDV_StardewValley_Mobile_TapToMoveUtils_ContainsCinemaDoor_060066cf(int param_1,int param_2)

{
  char cVar1;
  undefined8 *puVar2;
  undefined8 uVar3;
  
  cVar1 = cRam00000001039114de;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039114de != '\0') goto LAB_101fc8a78;
LAB_101fc8b0c:
    func_0x00010119b908(&UNK_10332580a);
    cRam00000001039114de = '\x01';
    puVar2 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    if (puVar2 == (undefined8 *)0x0) {
      return 0;
    }
  }
  else {
    func_0x00010119b8f8();
    if (cVar1 == '\0') goto LAB_101fc8b0c;
LAB_101fc8a78:
    puVar2 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    if (puVar2 == (undefined8 *)0x0) {
      return 0;
    }
  }
  if ((lRam00000001038c6e88 == *(long *)(*(long *)(*(long *)*puVar2 + 0x10) + 0x10)) &&
     (cVar1 = StardewValley_StardewValley_Utility_doesMasterPlayerHaveMailReceivedButNotMailForTomorrow_06004145
                        (uRam00000001038e79a0), cVar1 != '\0')) {
    if (param_1 == 0x34) {
      if (param_2 - 0x14U < 0xfffffffe) goto LAB_101fc8aa0;
    }
    else {
      if (param_1 != 0x35) {
        return 0;
      }
      if (param_2 < 0x12) {
        return 0;
      }
      if (0x13 < param_2) {
        return 0;
      }
    }
    uVar3 = 1;
  }
  else {
LAB_101fc8aa0:
    uVar3 = 0;
  }
  return uVar3;
}

