/* 0x060066ab StardewValley.Mobile.TapToMove.SelectDifferentEndNode @ 0x101fb9944 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_SelectDifferentEndNode_060066ab
               (long param_1,int param_2,int param_3)

{
  code *pcVar1;
  long lVar2;
  undefined8 uVar3;
  float fVar4;
  float fVar5;
  
  if (lRam0000000103976fb8 == 0) {
    lVar2 = *(long *)(param_1 + 0x28);
  }
  else {
    func_0x00010119b8f8();
    lVar2 = *(long *)(param_1 + 0x28);
  }
  uVar3 = _UNK_1036d46a0;
  if (lVar2 != 0) {
    lVar2 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc(lVar2,param_2,param_3);
    if (lVar2 == 0) {
      return;
    }
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x40) = lVar2;
    *(undefined1 *)(((ulong)(param_1 + 0x40) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    uVar3 = _UNK_1036d46a8;
    if (param_1 != -0x110) {
      *(float *)(param_1 + 0x110) = (float)param_2;
      *(float *)(param_1 + 0x114) = (float)param_3;
      uVar3 = _UNK_1036d46b0;
      if (param_1 != -0x108) {
        fVar4 = (float)(int)(param_2 << 6 | 0x20);
        fVar5 = (float)(int)(param_3 << 6 | 0x20);
        *(float *)(param_1 + 0x108) = fVar4;
        *(float *)(param_1 + 0x10c) = fVar5;
        *(int *)(param_1 + 0x128) = (int)fVar4 - *(int *)(param_1 + 0x130);
        *(int *)(param_1 + 300) = (int)fVar5 - *(int *)(param_1 + 0x134);
        return;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fb9a54);
  (*pcVar1)();
}

