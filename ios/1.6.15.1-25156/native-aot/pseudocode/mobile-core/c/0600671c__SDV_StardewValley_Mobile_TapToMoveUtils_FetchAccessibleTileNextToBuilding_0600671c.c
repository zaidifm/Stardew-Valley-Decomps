/* 0x0600671c StardewValley.Mobile.TapToMoveUtils.FetchAccessibleTileNextToBuilding @ 0x101fd0e0c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

float SDV_StardewValley_Mobile_TapToMoveUtils_FetchAccessibleTileNextToBuilding_0600671c
                (long param_1,uint param_2,long param_3,undefined8 param_4)

{
  uint uVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  long *plVar5;
  long lVar6;
  int iVar7;
  
  cVar2 = cRam000000010391152b;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325bf1);
    cRam000000010391152b = '\x01';
    uVar1 = *(uint *)(param_1 + 0x18);
  }
  else {
    uVar1 = *(uint *)(param_1 + 0x18);
  }
  if (uVar1 <= param_2) {
    func_0x000100331b90();
                    /* WARNING: Does not return */
    pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd0f5c);
    (*pcVar3)();
  }
  if (*(uint *)(*(long *)(param_1 + 0x10) + 0x18) <= param_2) {
    func_0x0001003316f4(0xcc,_UNK_1036d8288);
                    /* WARNING: Does not return */
    pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd0f7c);
    (*pcVar3)();
  }
  if (param_3 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036d8278);
                    /* WARNING: Does not return */
    pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd0f9c);
    (*pcVar3)();
  }
  lVar4 = *(long *)(param_1 + 0x10) + (long)(int)param_2 * 8;
  iVar7 = (int)*(float *)(lVar4 + 0x20);
  lVar4 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                    (param_3,iVar7,(int)*(float *)(lVar4 + 0x24));
  if (lVar4 != 0) {
    *(undefined1 *)(lVar4 + 0x45) = 1;
    plVar5 = (long *)SDV_StardewValley_Mobile_AStarGraph_GetShortestPathAStarWithBubbleCheck_0600661a
                               (param_3,param_4,lVar4);
    if (((plVar5 != (long *)0x0) && (lVar6 = (**(code **)(*plVar5 + 0x88))(), lVar6 != 0)) &&
       (lVar6 = (**(code **)(*plVar5 + 0x88))(plVar5), 0 < *(int *)(lVar6 + 0x18))) {
      return (float)iVar7;
    }
    *(undefined1 *)(lVar4 + 0x45) = 0;
  }
  if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  return *pfRam00000001038d4510;
}

