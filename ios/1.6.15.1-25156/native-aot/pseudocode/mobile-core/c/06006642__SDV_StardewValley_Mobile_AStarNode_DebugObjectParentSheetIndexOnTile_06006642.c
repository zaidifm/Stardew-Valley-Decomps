/* 0x06006642 StardewValley.Mobile.AStarNode.DebugObjectParentSheetIndexOnTile @ 0x101fa95f8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_AStarNode_DebugObjectParentSheetIndexOnTile_06006642(long param_1)

{
  undefined8 uVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  undefined8 uVar7;
  long *plStack_38;
  
  cVar2 = cRam0000000103911451;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324b32);
    cRam0000000103911451 = '\x01';
  }
  plStack_38 = (long *)0x0;
  lVar4 = *(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xb8);
  uVar7 = _UNK_1036d2ba8;
  if (lVar4 != 0) {
    func_0x000101b560e8((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38),lVar4,
                        &plStack_38);
    uVar1 = uRam00000001039046b0;
    if (plStack_38 != (long *)0x0) {
      if ((long *)plStack_38[0xb] == (long *)0x0) {
        uVar5 = 0;
      }
      else {
        uVar5 = (**(code **)(*(long *)plStack_38[0xb] + 0x60))();
        uVar7 = _UNK_1036d2bb0;
        if (plStack_38 == (long *)0x0) goto LAB_101fa9724;
      }
      uVar7 = uRam00000001038d7758;
      uVar6 = (**(code **)(*plStack_38 + 0x60))(plStack_38);
      func_0x00010035048c(uVar1,uVar5,uVar7,uVar6);
      StardewValley_Log_It_06000016();
    }
    return;
  }
LAB_101fa9724:
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fa9730);
  (*pcVar3)();
}

