/* 0x060066b3 StardewValley.Mobile.TapToMove.chooseActiveWeapon @ 0x101fc3568 */

long SDV_StardewValley_Mobile_TapToMove_chooseActiveWeapon_060066b3(void)

{
  char cVar1;
  undefined8 uVar2;
  long lVar3;
  
  cVar1 = cRam00000001039114c2;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325630);
    cRam00000001039114c2 = '\x01';
  }
  if ((long *)*plRam00000001039041e0 != (long *)0x0) {
    uVar2 = (**(code **)(*(long *)*plRam00000001039041e0 + 0x1e8))();
    cVar1 = func_0x00010035011c(uVar2,uRam00000001038f0c60);
    if (cVar1 != '\0') goto LAB_101fc35c4;
  }
  lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_getBestAvailableWeapon_060066d3();
  if (lVar3 != 0) {
    return lVar3;
  }
LAB_101fc35c4:
  return *plRam00000001039041e0;
}

