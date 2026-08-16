/* 0x0600664d StardewValley.Mobile.AStarNode.GetFurniture @ 0x101faba3c */

/* WARNING: Removing unreachable block (ram,0x000101fabd40) */
/* WARNING: Removing unreachable block (ram,0x000101fabdb0) */
/* WARNING: Removing unreachable block (ram,0x000101fabd58) */
/* WARNING: Removing unreachable block (ram,0x000101fabd98) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

long SDV_StardewValley_Mobile_AStarNode_GetFurniture_0600664d(long param_1)

{
  undefined8 uVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  int iVar5;
  long lVar6;
  undefined1 auVar7 [16];
  undefined1 auVar8 [16];
  undefined8 uStack_100;
  undefined8 uStack_f8;
  long lStack_f0;
  undefined1 auStack_e0 [16];
  long lStack_c8;
  long lStack_c0;
  undefined8 uStack_b8;
  undefined8 uStack_b0;
  undefined8 *puStack_a8;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  long lStack_90;
  long lStack_88;
  undefined8 *puStack_80;
  int iStack_74;
  long lStack_70;
  int iStack_64;
  long lStack_60;
  undefined8 *puStack_58;
  
  cVar3 = cRam000000010391145c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103324d3a);
    cRam000000010391145c = '\x01';
  }
  uStack_100 = 0;
  uStack_f8 = 0;
  lStack_f0 = 0;
  auStack_e0._0_8_ = 0;
  auStack_e0._8_8_ = 0;
  lStack_c8 = 0;
  lStack_c0 = 0;
  auVar7 = SDV_StardewValley_Mobile_AStarNode_get_rect_0600665c(param_1);
  auVar8._8_8_ = auStack_e0._8_8_;
  auVar8._0_8_ = auStack_e0._0_8_;
  lVar6 = *(long *)(*(long *)(param_1 + 0x18) + 0x10);
  uVar4 = _UNK_1036d3040;
  uVar1 = uStack_b8;
  if ((lVar6 != 0) && (uVar4 = _UNK_1036d3048, auStack_e0 = auVar8, *(long *)(lVar6 + 0x248) != 0))
  {
    func_0x000100343278(&uStack_100);
    while( true ) {
      cVar3 = func_0x0001003598d4(&uStack_100);
      lVar6 = lStack_f0;
      if (cVar3 == '\0') break;
      if (lStack_f0 == 0) {
        func_0x0001003316f4(0xee,_UNK_1036d3050);
        goto LAB_101fabcd4;
      }
      if ((*(long *)(lStack_f0 + 0x208) == 0) ||
         (*(int *)(*(long *)(lStack_f0 + 0x208) + 0x68) != 0xc)) {
        auVar8 = func_0x0001019aa6d8(lStack_f0);
        auStack_e0 = auVar8;
        cVar3 = func_0x00010035a4b4(auStack_e0,auVar7._0_8_,auVar7._8_8_);
        if (cVar3 != '\0') {
          iVar5 = 1;
          lStack_c8 = lVar6;
          goto LAB_101fabd78;
        }
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    iVar5 = 2;
LAB_101fabd78:
    uStack_b8 = 0;
    uVar1 = uStack_b8;
    puStack_a8 = &uStack_100;
    uVar4 = _UNK_1036d3080;
    if (puStack_a8 != (undefined8 *)0x0) {
      if (iVar5 == 1) {
        return lStack_c8;
      }
      if (iVar5 != 2) {
LAB_101fabdcc:
        func_0x000100331c30();
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101fabdd4);
        (*pcVar2)();
      }
      uStack_b8 = 0;
      uVar4 = _UNK_1036d3068;
      if (*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x248) != 0) {
        func_0x000100343278(&uStack_a0);
        uStack_f8 = uStack_98;
        uStack_100 = uStack_a0;
        lStack_f0 = lStack_90;
        while( true ) {
          cVar3 = func_0x0001003598d4(&uStack_100);
          if (cVar3 == '\0') break;
          puStack_80 = &uStack_100;
          if ((&uStack_100 == (undefined8 *)0x0) ||
             (lStack_c0 = lStack_f0, lStack_88 = lStack_c0, lStack_f0 == 0)) {
LAB_101fabcc4:
            func_0x0001003316f4(0xee,_UNK_1036d3078);
LAB_101fabcd4:
                    /* WARNING: Does not return */
            pcVar2 = (code *)SoftwareBreakpoint(1,0x101fabcd8);
            (*pcVar2)();
          }
          lStack_70 = *(long *)(lStack_f0 + 0x208);
          iVar5 = 0;
          if (lStack_70 != 0) {
            lStack_60 = lStack_70;
            if (lStack_70 == 0) goto LAB_101fabcc4;
            iStack_64 = *(int *)(lStack_70 + 0x68);
            iVar5 = iStack_64;
          }
          iStack_74 = iVar5;
          if (iStack_74 == 0xc) {
            if (lStack_f0 == 0) goto LAB_101fabcc4;
            auVar8 = func_0x0001019aa6d8();
            auStack_e0 = auVar8;
            cVar3 = func_0x00010035a4b4(auStack_e0,auVar7._0_8_,auVar7._8_8_);
            if (cVar3 != '\0') {
              iVar5 = 1;
              lStack_c8 = lStack_c0;
              goto LAB_101fabd20;
            }
          }
          if (lRam0000000103976fb8 != 0) {
            func_0x00010119b8f8();
          }
        }
        iVar5 = 2;
LAB_101fabd20:
        uStack_b0 = 0;
        puStack_58 = &uStack_100;
        if (puStack_58 != (undefined8 *)0x0) {
          if (iVar5 == 1) {
            return lStack_c8;
          }
          if (iVar5 == 2) {
            return 0;
          }
          goto LAB_101fabdcc;
        }
        puStack_58 = (undefined8 *)0x0;
        uVar4 = _UNK_1036d3070;
        uVar1 = uStack_b8;
      }
    }
  }
  uStack_b8 = uVar1;
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fabbbc);
  (*pcVar2)();
}

