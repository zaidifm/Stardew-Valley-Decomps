/* 0x06006657 StardewValley.Mobile.AStarNode.ContainsFestivalProp @ 0x101fad508 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_AStarNode_ContainsFestivalProp_06006657(long param_1)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  uint uVar5;
  undefined8 uStack_50;
  undefined8 uStack_48;
  undefined8 uStack_40;
  undefined8 uStack_38;
  
  uStack_50 = 0;
  uStack_48 = 0;
  if (lRam0000000103976fb8 == 0) {
    lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
  }
  else {
    func_0x00010119b8f8();
    lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
  }
  if (lVar3 == 0) {
    return 0;
  }
  uVar4 = _UNK_1036d3488;
  if (param_1 != 0) {
    func_0x00010034ede4(&uStack_50,*(int *)(param_1 + 0x34) << 6,*(int *)(param_1 + 0x38) << 6,0x40,
                        0x40);
    lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
    uVar4 = _UNK_1036d34b8;
    if (lVar3 != 0) {
      uVar5 = 0;
      do {
        while( true ) {
          if (*(int *)(*(long *)(lVar3 + 0x90) + 0x18) <= (int)uVar5) {
            return 0;
          }
          lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
          if (*(uint *)(*(long *)(lVar3 + 0x90) + 0x18) <= uVar5) {
            func_0x000100331b90();
                    /* WARNING: Does not return */
            pcVar1 = (code *)SoftwareBreakpoint(1,0x101fad644);
            (*pcVar1)();
          }
          lVar3 = *(long *)(*(long *)(lVar3 + 0x90) + 0x10);
          if (*(uint *)(lVar3 + 0x18) <= uVar5) {
            func_0x0001003316f4(0xcc,_UNK_1036d34c0);
                    /* WARNING: Does not return */
            pcVar1 = (code *)SoftwareBreakpoint(1,0x101fad658);
            (*pcVar1)();
          }
          lVar3 = *(long *)(lVar3 + (long)(int)uVar5 * 8 + 0x20);
          uVar4 = _UNK_1036d34b0;
          if (lVar3 == 0) goto LAB_101fad684;
          uStack_40 = uStack_50;
          uStack_38 = uStack_48;
          if ((*(char *)(lVar3 + 0x48) != '\0') &&
             (cVar2 = func_0x00010035a4b4(&uStack_40,*(undefined8 *)(lVar3 + 0x38),
                                          *(undefined8 *)(lVar3 + 0x40)), cVar2 != '\0')) {
            return 1;
          }
          lVar3 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
          if (lRam0000000103976fb8 != 0) break;
          uVar5 = uVar5 + 1;
          uVar4 = _UNK_1036d34b8;
          if (lVar3 == 0) goto LAB_101fad684;
        }
        func_0x00010119b8f8();
        uVar5 = uVar5 + 1;
        uVar4 = _UNK_1036d34b8;
      } while (lVar3 != 0);
    }
  }
LAB_101fad684:
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fad690);
  (*pcVar1)();
}

