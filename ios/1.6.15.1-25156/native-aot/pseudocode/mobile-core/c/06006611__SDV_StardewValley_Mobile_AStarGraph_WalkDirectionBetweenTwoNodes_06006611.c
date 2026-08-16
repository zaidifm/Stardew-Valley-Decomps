/* 0x06006611 StardewValley.Mobile.AStarGraph.WalkDirectionBetweenTwoNodes @ 0x101fa3a58 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

long SDV_StardewValley_Mobile_AStarGraph_WalkDirectionBetweenTwoNodes_06006611
               (undefined8 param_1,long param_2,long param_3)

{
  code *pcVar1;
  long lVar2;
  undefined8 uVar3;
  int iVar4;
  int iVar5;
  int iVar6;
  int iVar7;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar3 = _UNK_1036d1a08;
  if ((param_2 != 0) && (uVar3 = _UNK_1036d1a10, param_3 != 0)) {
    iVar7 = *(int *)(param_2 + 0x34) - *(int *)(param_3 + 0x34);
    if ((iVar7 < 0) && (iVar7 = -iVar7, iVar7 < 0)) {
      func_0x00010034fdc0();
      iVar7 = -0x80000000;
    }
    iVar4 = *(int *)(param_2 + 0x38);
    iVar5 = *(int *)(param_3 + 0x38);
    iVar6 = iVar4 - iVar5;
    if ((iVar6 < 0) && (iVar6 = -iVar6, iVar6 < 0)) {
      func_0x00010034fdc0();
      iVar4 = *(int *)(param_2 + 0x38);
      iVar6 = -0x80000000;
      iVar5 = *(int *)(param_3 + 0x38);
    }
    if ((iVar4 <= iVar5) || ((float)iVar6 <= (float)iVar7)) {
      if ((iVar5 <= iVar4) || ((float)iVar6 <= (float)iVar7)) {
        if (*(int *)(param_3 + 0x34) < *(int *)(param_2 + 0x34)) {
          lVar2 = 3;
        }
        else {
          lVar2 = (ulong)(*(int *)(param_2 + 0x34) < *(int *)(param_3 + 0x34)) << 2;
        }
      }
      else {
        lVar2 = 2;
      }
    }
    else {
      lVar2 = 1;
    }
    return lVar2;
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa3b5c);
  (*pcVar1)();
}

