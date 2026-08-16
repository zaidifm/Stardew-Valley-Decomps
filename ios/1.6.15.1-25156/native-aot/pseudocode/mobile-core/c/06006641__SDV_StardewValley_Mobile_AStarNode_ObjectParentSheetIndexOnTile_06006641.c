/* 0x06006641 StardewValley.Mobile.AStarNode.ObjectParentSheetIndexOnTile @ 0x101fa951c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_AStarNode_ObjectParentSheetIndexOnTile_06006641(long param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 uVar4;
  long lStack_38;
  
  cVar1 = cRam0000000103911450;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324b2b);
    cRam0000000103911450 = '\x01';
  }
  lStack_38 = 0;
  lVar3 = *(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xb8);
  if (lVar3 != 0) {
    func_0x000101b560e8((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38),lVar3,
                        &lStack_38);
    uVar4 = uRam00000001038d74f8;
    if (lStack_38 != 0) {
      uVar4 = StardewValley_StardewValley_Item_get_ItemId_06003848();
    }
    return uVar4;
  }
  func_0x0001003316f4(0xee,_UNK_1036d2b88);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa95f8);
  (*pcVar2)();
}

