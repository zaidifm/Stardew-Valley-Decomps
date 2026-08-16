/* 0x06006601 StardewValley.Mobile.AStarGraph.AddNode @ 0x101fa1b64 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_AStarGraph_AddNode_06006601(long param_1,undefined8 param_2)

{
  uint uVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  long *plVar5;
  
  cVar2 = cRam0000000103911410;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324908);
    cRam0000000103911410 = '\x01';
    lVar4 = *(long *)(param_1 + 0x28);
  }
  else {
    lVar4 = *(long *)(param_1 + 0x28);
  }
  plVar5 = *(long **)(lVar4 + 0x10);
  *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
  if (plVar5 != (long *)0x0) {
    uVar1 = *(uint *)(lVar4 + 0x18);
    if (uVar1 < *(uint *)(plVar5 + 3)) {
      *(uint *)(lVar4 + 0x18) = uVar1 + 1;
      (**(code **)(*plVar5 + 0x110))(plVar5,(long)(int)uVar1,param_2);
    }
    else {
      func_0x00010037d11c(lVar4,param_2);
    }
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d1750);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fa1c4c);
  (*pcVar3)();
}

