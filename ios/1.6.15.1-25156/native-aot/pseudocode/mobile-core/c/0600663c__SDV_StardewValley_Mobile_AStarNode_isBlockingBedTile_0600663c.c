/* 0x0600663c StardewValley.Mobile.AStarNode.isBlockingBedTile @ 0x101fa8f0c */

undefined8 SDV_StardewValley_Mobile_AStarNode_isBlockingBedTile_0600663c(long param_1)

{
  char cVar1;
  undefined8 *puVar2;
  undefined8 uVar3;
  long *plVar4;
  undefined8 uStack_40;
  undefined8 uStack_38;
  
  cVar1 = cRam000000010391144b;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324b05);
    cRam000000010391144b = '\x01';
  }
  uStack_40 = 0;
  uStack_38 = 0;
  puVar2 = *(undefined8 **)(*(long *)(param_1 + 0x18) + 0x10);
  uVar3 = 0;
  if (puVar2 != (undefined8 *)0x0) {
    if (lRam00000001038c6c08 == *(long *)(*(long *)(*(long *)*puVar2 + 0x10) + 0x10)) {
      plVar4 = (long *)func_0x000101add830(puVar2,*(undefined4 *)(param_1 + 0x34),
                                           *(undefined4 *)(param_1 + 0x38));
      uVar3 = 0;
      if (plVar4 != (long *)0x0) {
        func_0x00010034ede4(&uStack_40,*(int *)(param_1 + 0x34) << 6,*(int *)(param_1 + 0x38) << 6,
                            0x40,0x40);
        uVar3 = (**(code **)(*plVar4 + 0x660))(plVar4,uStack_40,uStack_38);
      }
    }
    else {
      uVar3 = 0;
    }
  }
  return uVar3;
}

