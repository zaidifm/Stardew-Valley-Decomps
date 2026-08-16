/* 0x06006665 StardewValley.Mobile.AStarPath.ContainsGate @ 0x101faec1c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_AStarPath_ContainsGate_06006665(long *param_1)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  long lVar4;
  long lVar5;
  uint uVar6;
  
  if (lRam0000000103976fb8 == 0) {
    lVar4 = *param_1;
  }
  else {
    func_0x00010119b8f8();
    lVar4 = *param_1;
  }
  lVar4 = (**(code **)(lVar4 + 0x88))(param_1);
  uVar3 = _UNK_1036d3780;
  if (lVar4 != 0) {
    uVar6 = 0;
    lVar5 = 0x20;
    do {
      if (*(int *)(lVar4 + 0x18) <= (int)uVar6) {
        return 0;
      }
      lVar4 = (**(code **)(*param_1 + 0x88))(param_1);
      if (*(uint *)(lVar4 + 0x18) <= uVar6) {
LAB_101faed5c:
        func_0x000100331b90();
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101faed64);
        (*pcVar1)();
      }
      uVar3 = _UNK_1036d3770;
      if (*(uint *)(*(long *)(lVar4 + 0x10) + 0x18) <= uVar6) {
LAB_101faed6c:
        func_0x0001003316f4(0xcc,uVar3);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101faed78);
        (*pcVar1)();
      }
      uVar3 = _UNK_1036d3778;
      if (*(long *)(lVar5 + *(long *)(lVar4 + 0x10)) == 0) break;
      cVar2 = SDV_StardewValley_Mobile_AStarNode_isGate_0600663e();
      if (cVar2 != '\0') {
        lVar4 = (**(code **)(*param_1 + 0x88))(param_1);
        if (*(uint *)(lVar4 + 0x18) <= uVar6) goto LAB_101faed5c;
        uVar3 = _UNK_1036d3798;
        if (uVar6 < *(uint *)(*(long *)(lVar4 + 0x10) + 0x18)) {
          return *(undefined8 *)(*(long *)(lVar4 + 0x10) + lVar5);
        }
        goto LAB_101faed6c;
      }
      lVar4 = (**(code **)(*param_1 + 0x88))(param_1);
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      lVar5 = lVar5 + 8;
      uVar6 = uVar6 + 1;
      uVar3 = _UNK_1036d3780;
    } while (lVar4 != 0);
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101faed98);
  (*pcVar1)();
}

