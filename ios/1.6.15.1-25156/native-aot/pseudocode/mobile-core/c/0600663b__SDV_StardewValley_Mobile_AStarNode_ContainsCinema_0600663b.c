/* 0x0600663b StardewValley.Mobile.AStarNode.ContainsCinema @ 0x101fa8df4 */

bool SDV_StardewValley_Mobile_AStarNode_ContainsCinema_0600663b(long param_1)

{
  uint uVar1;
  char cVar2;
  long lVar3;
  
  cVar2 = cRam000000010391144a;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324afa);
    cRam000000010391144a = '\x01';
    lVar3 = *(long *)(param_1 + 0x18);
  }
  else {
    lVar3 = *(long *)(param_1 + 0x18);
  }
  if (((*(undefined8 **)(lVar3 + 0x10) != (undefined8 *)0x0) &&
      (lRam00000001038c6e88 ==
       *(long *)(*(long *)(*(long *)**(undefined8 **)(lVar3 + 0x10) + 0x10) + 0x10))) &&
     (cVar2 = StardewValley_StardewValley_Utility_doesMasterPlayerHaveMailReceivedButNotMailForTomorrow_06004145
                        (uRam00000001038e79a0), cVar2 != '\0')) {
    uVar1 = *(int *)(param_1 + 0x34) - 0x3b;
    if (0xfffffff3 < uVar1) {
      if (0xfffffffc < *(int *)(param_1 + 0x38) - 0x14U) {
        return true;
      }
      if (*(int *)(param_1 + 0x34) == 0x2f) {
        return *(int *)(param_1 + 0x38) == 0x14;
      }
      if (0xfffffffb < uVar1) {
        return *(int *)(param_1 + 0x38) == 0x14;
      }
    }
  }
  return false;
}

