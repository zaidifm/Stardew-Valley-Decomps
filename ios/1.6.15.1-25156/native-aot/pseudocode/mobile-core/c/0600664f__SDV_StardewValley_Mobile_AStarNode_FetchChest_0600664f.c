/* 0x0600664f StardewValley.Mobile.AStarNode.FetchChest @ 0x101fabed8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 * SDV_StardewValley_Mobile_AStarNode_FetchChest_0600664f(long param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 *puStack_38;
  
  cVar1 = cRam000000010391145e;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324d4e);
    cRam000000010391145e = '\x01';
  }
  puStack_38 = (undefined8 *)0x0;
  lVar3 = *(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xb8);
  if (lVar3 != 0) {
    func_0x000101b560e8((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38),lVar3,
                        &puStack_38);
    if (puStack_38 == (undefined8 *)0x0) {
      puStack_38 = (undefined8 *)0x0;
    }
    else if (lRam00000001038c7398 != *(long *)(*(long *)(*(long *)*puStack_38 + 0x10) + 0x18)) {
      puStack_38 = (undefined8 *)0x0;
    }
    return puStack_38;
  }
  func_0x0001003316f4(0xee,_UNK_1036d30c8);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fabfcc);
  (*pcVar2)();
}

