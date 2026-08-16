/* 0x06006689 StardewValley.Mobile.TapToMove.isTapToMoveWeaponControl @ 0x101fb1000 */

bool SDV_StardewValley_Mobile_TapToMove_isTapToMoveWeaponControl_06006689(void)

{
  char cVar1;
  long lVar2;
  
  cVar1 = cRam0000000103911498;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033250c2);
    cRam0000000103911498 = '\x01';
  }
  lVar2 = StardewValley_StardewValley_Game1_get_options_06002fec();
  return *(uint *)(lVar2 + 0x178) < 2 || (*(uint *)(lVar2 + 0x178) & 0xfffffffc) == 4;
}

