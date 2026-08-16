/* 0x0600664e StardewValley.Mobile.AStarNode.ContainsChest @ 0x101fabde4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_AStarNode_ContainsChest_0600664e(long param_1)

{
  char cVar1;
  code *pcVar2;
  bool bVar3;
  long lVar4;
  undefined8 *puStack_38;
  
  cVar1 = cRam000000010391145d;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324d47);
    cRam000000010391145d = '\x01';
  }
  puStack_38 = (undefined8 *)0x0;
  lVar4 = *(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xb8);
  if (lVar4 != 0) {
    func_0x000101b560e8((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38),lVar4,
                        &puStack_38);
    if (puStack_38 == (undefined8 *)0x0) {
      bVar3 = false;
    }
    else {
      bVar3 = lRam00000001038c7398 == *(long *)(*(long *)(*(long *)*puStack_38 + 0x10) + 0x18);
    }
    return bVar3;
  }
  func_0x0001003316f4(0xee,_UNK_1036d30a8);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fabed8);
  (*pcVar2)();
}

