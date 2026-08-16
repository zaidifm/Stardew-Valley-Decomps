/* 0x0600665d StardewValley.Mobile.AStarNode.ToString @ 0x101fadb24 */

/* WARNING: Removing unreachable block (ram,0x000101fae220) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

undefined8 SDV_StardewValley_Mobile_AStarNode_ToString_0600665d(long param_1)

{
  code *pcVar1;
  char cVar2;
  int iVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  long *plVar6;
  long *plVar7;
  int iVar8;
  undefined1 auVar9 [16];
  undefined8 uStack_1d0;
  undefined8 uStack_1c0;
  long *plStack_1b8;
  undefined1 auStack_1b0 [16];
  undefined1 auStack_1a0 [16];
  long lStack_190;
  long lStack_188;
  long lStack_180;
  long lStack_178;
  long lStack_170;
  long lStack_168;
  undefined4 uStack_15c;
  long lStack_158;
  undefined4 uStack_14c;
  long lStack_148;
  undefined8 uStack_140;
  undefined8 uStack_138;
  undefined8 uStack_130;
  undefined8 uStack_128;
  undefined8 uStack_120;
  undefined8 uStack_118;
  undefined8 uStack_110;
  undefined8 uStack_108;
  undefined8 uStack_100;
  undefined8 uStack_f8;
  undefined1 *puStack_f0;
  undefined8 uStack_e8;
  undefined8 uStack_e0;
  undefined8 uStack_d8;
  undefined1 *puStack_d0;
  undefined8 uStack_c8;
  undefined8 uStack_c0;
  undefined8 uStack_b8;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  undefined1 *puStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined1 *puStack_80;
  undefined8 uStack_78;
  long lStack_70;
  long lStack_68;
  
  cVar2 = cRam000000010391146c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324dc0);
    cRam000000010391146c = '\x01';
  }
  uStack_1c0 = 0;
  plStack_1b8 = (long *)0x0;
  auStack_1b0._0_8_ = 0;
  auStack_1b0._8_8_ = 0;
  auStack_1a0._0_8_ = 0;
  auStack_1a0._8_8_ = 0;
  uVar4 = func_0x000100331794(uRam00000001038c4f40,5);
  func_0x000100331f8c(uVar4,0,uRam0000000103904778);
  uStack_1c0._0_4_ = *(undefined4 *)(param_1 + 0x34);
  uVar5 = func_0x00010034eec0(&uStack_1c0);
  func_0x000100331f8c(uVar4,1,uVar5);
  func_0x000100331f8c(uVar4,2,uRam0000000103904780);
  uStack_1c0._0_4_ = *(undefined4 *)(param_1 + 0x38);
  uVar5 = func_0x00010034eec0(&uStack_1c0);
  func_0x000100331f8c(uVar4,3,uVar5);
  func_0x000100331f8c(uVar4,4,uRam00000001038d7278);
  uStack_1d0 = func_0x000100351da0(uVar4);
  uStack_1c0._4_4_ = 0;
  iVar3 = uStack_1c0._4_4_;
  uStack_1c0._4_4_ = 0;
  uVar4 = _UNK_1036d3640;
  if (param_1 == 0) {
LAB_101fae32c:
    uStack_1c0._4_4_ = iVar3;
    func_0x0001003316f4(0xee,uVar4);
LAB_101fae334:
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fae338);
    (*pcVar1)();
  }
  iVar8 = uStack_1c0._4_4_;
  uStack_1c0._4_4_ = iVar3;
LAB_101fadc34:
  lStack_68 = *(long *)(*(long *)(param_1 + 0x18) + 0x18);
  uVar4 = _UNK_1036d35b8;
  iVar3 = uStack_1c0._4_4_;
  if ((lStack_68 != 0) &&
     (lStack_70 = *(long *)(lStack_68 + 0x48), uVar4 = _UNK_1036d35c8, lStack_70 != 0)) {
    iVar3 = func_0x00010035fc70();
    if (iVar3 <= iVar8) {
      return uStack_1d0;
    }
    lStack_178 = *(long *)(*(long *)(param_1 + 0x18) + 0x18);
    uVar4 = _UNK_1036d35e0;
    iVar3 = uStack_1c0._4_4_;
    if ((lStack_178 != 0) &&
       (lStack_180 = *(long *)(lStack_178 + 0x48), uVar4 = _UNK_1036d35f0, lStack_180 != 0)) {
      lStack_168 = func_0x000100353ce0(lStack_180,uStack_1c0._4_4_);
      uVar4 = _UNK_1036d35f8;
      iVar3 = uStack_1c0._4_4_;
      if (lStack_168 != 0) {
        lStack_170 = *(long *)(lStack_168 + 0x50);
        uStack_15c = *(undefined4 *)(param_1 + 0x34);
        uStack_14c = *(undefined4 *)(param_1 + 0x38);
        uVar4 = _UNK_1036d3618;
        lStack_158 = param_1;
        lStack_148 = param_1;
        if (lStack_170 != 0) {
          plVar6 = (long *)func_0x000100355ec8(lStack_170,uStack_15c,uStack_14c);
          uVar4 = uRam0000000103904788;
          if (plVar6 == (long *)0x0) {
            uVar5 = func_0x00010034eec0((long)&uStack_1c0 + 4);
            uStack_1d0 = func_0x00010035048c(uStack_1d0,uVar4,uVar5,uRam00000001039047b0);
            goto LAB_101fae1a0;
          }
          uVar4 = func_0x000100331794(uRam00000001038c4f40,6);
          uStack_140 = uVar4;
          func_0x000100331f8c(uVar4,0,uStack_1d0);
          uStack_138 = uVar4;
          func_0x000100331f8c(uVar4,1,uRam0000000103904788);
          uStack_130 = uVar4;
          uVar5 = func_0x00010034eec0((long)&uStack_1c0 + 4);
          func_0x000100331f8c(uVar4,2,uVar5);
          uStack_128 = uVar4;
          func_0x000100331f8c(uVar4,3,uRam0000000103904790);
          uStack_120 = uVar4;
          uVar5 = (**(code **)(*plVar6 + 0x60))();
          func_0x000100331f8c(uVar4,4,uVar5);
          uStack_118 = uVar4;
          func_0x000100331f8c(uVar4,5,uRam00000001038d7278);
          uStack_1d0 = func_0x000100351da0(uVar4);
          uVar4 = _UNK_1036d3628;
          iVar3 = uStack_1c0._4_4_;
          if (plVar6 != (long *)0x0) {
            plVar7 = (long *)func_0x00010035c854();
            plVar7 = (long *)(**(code **)(*plVar7 + -0x10))();
            plStack_1b8 = plVar7;
            while (plVar7 != (long *)0x0) {
              while( true ) {
                cVar2 = (**(code **)(*plVar7 + -0x78))(plVar7);
                if (cVar2 == '\0') {
                  lStack_190 = 0;
                  if (plStack_1b8 != (long *)0x0) {
                    uVar4 = _UNK_1036d3660;
                    iVar3 = uStack_1c0._4_4_;
                    if (plStack_1b8 == (long *)0x0) goto LAB_101fae32c;
                    (**(code **)(*plStack_1b8 + -0x28))();
                  }
                  if (lStack_190 != 0) {
                    func_0x000100331ba4();
                  }
                  plVar6 = (long *)(**(code **)(*plVar6 + 0x70))();
                  plVar6 = (long *)(**(code **)(*plVar6 + -0x10))();
                  plStack_1b8 = plVar6;
                  goto joined_r0x000101fae000;
                }
                if (plStack_1b8 == (long *)0x0) goto LAB_101fadf40;
                auVar9 = (**(code **)(*plStack_1b8 + -0x38))();
                auStack_1b0 = auVar9;
                uVar4 = func_0x000100331794(uRam00000001038c4f40,6);
                uStack_110 = uVar4;
                func_0x000100331f8c(uVar4,0,uStack_1d0);
                uStack_108 = uVar4;
                func_0x000100331f8c(uVar4,1,uRam00000001039047a8);
                uStack_100 = uVar4;
                puStack_f0 = auStack_1b0;
                if (auStack_1b0 == (undefined1 *)0x0) goto LAB_101fadf40;
                uStack_f8 = auStack_1b0._0_8_;
                func_0x000100331f8c(uVar4,2,auStack_1b0._0_8_);
                uStack_e8 = uVar4;
                func_0x000100331f8c(uVar4,3,uRam00000001039047a0);
                uStack_e0 = uVar4;
                puStack_d0 = auStack_1b0;
                if (auStack_1b0 == (undefined1 *)0x0) goto LAB_101fadf40;
                uStack_d8 = auStack_1b0._8_8_;
                uVar5 = func_0x000100374f30(auStack_1b0._8_8_);
                func_0x000100331f8c(uVar4,4,uVar5);
                uStack_c8 = uVar4;
                func_0x000100331f8c(uVar4,5,uRam00000001038d7278);
                uStack_1d0 = func_0x000100351da0(uVar4);
                plVar7 = plStack_1b8;
                if (lRam0000000103976fb8 != 0) break;
                if (plStack_1b8 == (long *)0x0) goto LAB_101fadf40;
              }
              func_0x00010119b8f8();
            }
LAB_101fadf40:
            func_0x0001003316f4(0xee,_UNK_1036d3650);
            goto LAB_101fae334;
          }
        }
      }
    }
  }
  goto LAB_101fae32c;
joined_r0x000101fae000:
  if (plVar6 == (long *)0x0) {
LAB_101fae13c:
    func_0x0001003316f4(0xee,_UNK_1036d3648);
    goto LAB_101fae334;
  }
  cVar2 = (**(code **)(*plVar6 + -0x78))(plVar6);
  if (cVar2 != '\0') {
    if (plStack_1b8 == (long *)0x0) goto LAB_101fae13c;
    auVar9 = (**(code **)(*plStack_1b8 + -0x38))();
    auStack_1a0 = auVar9;
    uVar4 = func_0x000100331794(uRam00000001038c4f40,6);
    uStack_c0 = uVar4;
    func_0x000100331f8c(uVar4,0,uStack_1d0);
    uStack_b8 = uVar4;
    func_0x000100331f8c(uVar4,1,uRam0000000103904798);
    uStack_b0 = uVar4;
    puStack_a0 = auStack_1a0;
    if (auStack_1a0 == (undefined1 *)0x0) goto LAB_101fae13c;
    uStack_a8 = auStack_1a0._0_8_;
    func_0x000100331f8c(uVar4,2,auStack_1a0._0_8_);
    uStack_98 = uVar4;
    func_0x000100331f8c(uVar4,3,uRam00000001039047a0);
    uStack_90 = uVar4;
    puStack_80 = auStack_1a0;
    if (auStack_1a0 == (undefined1 *)0x0) goto LAB_101fae13c;
    uStack_88 = auStack_1a0._8_8_;
    uVar5 = func_0x000100374f30(auStack_1a0._8_8_);
    func_0x000100331f8c(uVar4,4,uVar5);
    uStack_78 = uVar4;
    func_0x000100331f8c(uVar4,5,uRam00000001038d7278);
    uStack_1d0 = func_0x000100351da0(uVar4);
    plVar6 = plStack_1b8;
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
    goto joined_r0x000101fae000;
  }
  lStack_188 = 0;
  if (plStack_1b8 != (long *)0x0) {
    uVar4 = _UNK_1036d3668;
    iVar3 = uStack_1c0._4_4_;
    if (plStack_1b8 == (long *)0x0) goto LAB_101fae32c;
    (**(code **)(*plStack_1b8 + -0x28))();
  }
  if (lStack_188 != 0) {
    func_0x000100331ba4();
  }
LAB_101fae1a0:
  iVar8 = uStack_1c0._4_4_ + 1;
  uStack_1c0._4_4_ = iVar8;
  uVar4 = _UNK_1036d3640;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
    uVar4 = _UNK_1036d3640;
  }
  _UNK_1036d3640 = uVar4;
  iVar3 = uStack_1c0._4_4_;
  if (param_1 == 0) goto LAB_101fae32c;
  goto LAB_101fadc34;
}

