/* 0x06006659 StardewValley.Mobile.AStarNode.ContainsScarecrow @ 0x101fad7f4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_AStarNode_ContainsScarecrow_06006659(long param_1)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  long lVar5;
  int iVar6;
  int iVar7;
  
  if (lRam0000000103976fb8 == 0) {
    lVar5 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    lVar5 = *(long *)(param_1 + 0x18);
  }
  uVar4 = _UNK_1036d3520;
  if (*(long *)(*(long *)(lVar5 + 0x10) + 0xb8) != 0) {
    iVar6 = *(int *)(param_1 + 0x34);
    iVar7 = *(int *)(param_1 + 0x38);
    cVar3 = func_0x000101b55e1c((float)iVar6,(float)iVar7);
    if (cVar3 != '\0') {
      uVar4 = _UNK_1036d3538;
      if (*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xb8) == 0) goto LAB_101fad928;
      lVar5 = func_0x000101b547f0((float)iVar6,(float)iVar7);
      iVar6 = *(int *)(*(long *)(lVar5 + 0x58) + 0x68);
      uVar1 = iVar6 - 0x6e;
      if (((uVar1 < 0x3a) && ((1L << ((ulong)uVar1 & 0x3f) & 0x20000007c010009U) != 0)) ||
         (iVar6 == 8)) {
        return 1;
      }
    }
    return 0;
  }
LAB_101fad928:
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fad934);
  (*pcVar2)();
}

