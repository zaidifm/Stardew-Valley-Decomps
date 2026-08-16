/* 0x060066a4 StardewValley.Mobile.TapToMove.AddToTapQueueItemList @ 0x101fb32b4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMove_AddToTapQueueItemList_060066a4
          (long param_1,int param_2,int param_3,int param_4,int param_5)

{
  int iVar1;
  int iVar2;
  long lVar3;
  int iVar4;
  uint uVar5;
  uint uVar6;
  char cVar7;
  code *pcVar8;
  undefined8 uVar9;
  long lVar10;
  ulong uVar11;
  long lVar12;
  long lVar13;
  int iStack_78;
  int iStack_74;
  int iStack_70;
  int iStack_6c;
  int iStack_68;
  int iStack_64;
  
  cVar7 = cRam00000001039114b3;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar7 == '\0') {
    func_0x00010119b908(&UNK_1033251ab);
    cRam00000001039114b3 = '\x01';
  }
  iVar1 = param_4 + param_2;
  iVar2 = param_5 + param_3;
  iVar4 = iVar1 + 0x3f;
  if (-1 < iVar1) {
    iVar4 = iVar1;
  }
  iVar1 = iVar2 + 0x3f;
  if (-1 < iVar2) {
    iVar1 = iVar2;
  }
  lVar13 = *(long *)(param_1 + 0xc0);
  uVar6 = *(uint *)(lVar13 + 0x18);
  iVar4 = iVar4 >> 6;
  iVar1 = iVar1 >> 6;
  uVar5 = uVar6;
  if ((int)uVar6 < 1) {
    uVar5 = 0;
  }
  if (0 < (int)uVar6) {
    lVar10 = 0;
    uVar11 = 0;
    lVar12 = *(long *)(lVar13 + 0x10);
    do {
      if (uVar6 == uVar11) {
        func_0x000100331b90();
                    /* WARNING: Does not return */
        pcVar8 = (code *)SoftwareBreakpoint(1,0x101fb34cc);
        (*pcVar8)();
      }
      uVar9 = _UNK_1036d3fa8;
      if (*(uint *)(lVar12 + 0x18) <= uVar11) goto LAB_101fb34b8;
      lVar3 = lVar12 + (lVar10 >> 0x20);
      if ((*(int *)(lVar3 + 0x30) == iVar4) && (*(int *)(lVar3 + 0x34) == iVar1)) {
        return 0;
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      uVar11 = uVar11 + 1;
      lVar10 = lVar10 + 0x1800000000;
    } while (uVar5 != uVar11);
  }
  lVar10 = *(long *)(lVar13 + 0x10);
  *(int *)(lVar13 + 0x1c) = *(int *)(lVar13 + 0x1c) + 1;
  iStack_78 = param_2;
  iStack_74 = param_3;
  iStack_70 = param_4;
  iStack_6c = param_5;
  iStack_68 = iVar4;
  iStack_64 = iVar1;
  if (lVar10 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036d3fb0);
                    /* WARNING: Does not return */
    pcVar8 = (code *)SoftwareBreakpoint(1,0x101fb34e0);
    (*pcVar8)();
  }
  uVar5 = *(uint *)(lVar13 + 0x18);
  if (uVar5 < *(uint *)(lVar10 + 0x18)) {
    *(uint *)(lVar13 + 0x18) = uVar5 + 1;
    uVar9 = _UNK_1036d3fb8;
    if (*(uint *)(lVar10 + 0x18) <= uVar5) {
LAB_101fb34b8:
      func_0x0001003316f4(0xcc,uVar9);
                    /* WARNING: Does not return */
      pcVar8 = (code *)SoftwareBreakpoint(1,0x101fb34c4);
      (*pcVar8)();
    }
    lVar10 = lVar10 + (int)(uVar5 * 0x18);
    *(ulong *)(lVar10 + 0x30) = CONCAT44(iVar1,iVar4);
    *(ulong *)(lVar10 + 0x28) = CONCAT44(param_5,param_4);
    *(ulong *)(lVar10 + 0x20) = CONCAT44(param_3,param_2);
  }
  else {
    func_0x00010037d810(lVar13,&iStack_78);
  }
  return 1;
}

