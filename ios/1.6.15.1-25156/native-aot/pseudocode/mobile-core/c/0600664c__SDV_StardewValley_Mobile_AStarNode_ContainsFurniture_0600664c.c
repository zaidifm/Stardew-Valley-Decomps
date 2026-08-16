/* 0x0600664c StardewValley.Mobile.AStarNode.ContainsFurniture @ 0x101fab848 */

/* WARNING: Removing unreachable block (ram,0x000101faba00) */
/* WARNING: Removing unreachable block (ram,0x000101fab9e4) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1 SDV_StardewValley_Mobile_AStarNode_ContainsFurniture_0600664c(long param_1)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  int iVar4;
  long lVar5;
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  undefined8 uStack_78;
  undefined8 uStack_70;
  long lStack_68;
  undefined1 auStack_60 [16];
  undefined1 uStack_41;
  undefined8 uStack_40;
  undefined8 *puStack_38;
  
  cVar2 = cRam000000010391145b;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324d31);
    cRam000000010391145b = '\x01';
  }
  uStack_78 = 0;
  uStack_70 = 0;
  lStack_68 = 0;
  auStack_60._0_8_ = 0;
  auStack_60._8_8_ = 0;
  uStack_41 = 0;
  auVar6 = SDV_StardewValley_Mobile_AStarNode_get_rect_0600665c(param_1);
  auVar7._8_8_ = auStack_60._8_8_;
  auVar7._0_8_ = auStack_60._0_8_;
  lVar5 = *(long *)(*(long *)(param_1 + 0x18) + 0x10);
  uVar3 = _UNK_1036d3010;
  if ((lVar5 != 0) && (uVar3 = _UNK_1036d3018, auStack_60 = auVar7, *(long *)(lVar5 + 0x248) != 0))
  {
    func_0x000100343278(&uStack_78);
    while( true ) {
      cVar2 = func_0x0001003598d4(&uStack_78);
      if (cVar2 == '\0') break;
      if ((lStack_68 == 0) || (*(long *)(lStack_68 + 0x208) == 0)) {
        func_0x0001003316f4(0xee,_UNK_1036d3020);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fab944);
        (*pcVar1)();
      }
      iVar4 = *(int *)(*(long *)(lStack_68 + 0x208) + 0x68);
      if ((iVar4 != 0xc) && (iVar4 != 0xf)) {
        auVar7 = func_0x0001019aa6d8();
        auStack_60 = auVar7;
        cVar2 = func_0x00010035a4b4(auStack_60,auVar6._0_8_,auVar6._8_8_);
        if (cVar2 != '\0') {
          iVar4 = 1;
          uStack_41 = 1;
          goto LAB_101fab9c4;
        }
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    iVar4 = 2;
LAB_101fab9c4:
    uStack_40 = 0;
    puStack_38 = &uStack_78;
    if (puStack_38 != (undefined8 *)0x0) {
      if (iVar4 != 1) {
        if (iVar4 != 2) {
          func_0x000100331c30();
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101faba2c);
          (*pcVar1)();
        }
        uStack_41 = 0;
      }
      return uStack_41;
    }
    puStack_38 = (undefined8 *)0x0;
    uVar3 = _UNK_1036d3028;
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fab9c0);
  (*pcVar1)();
}

