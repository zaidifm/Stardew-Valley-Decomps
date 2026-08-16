/* 0x06006645 StardewValley.Mobile.AStarNode.DebugIsTilePassable @ 0x101fa9a74 */

/* WARNING: Removing unreachable block (ram,0x000101faa984) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

bool SDV_StardewValley_Mobile_AStarNode_DebugIsTilePassable_06006645(long param_1)

{
  undefined8 *puVar1;
  undefined8 *puVar2;
  undefined8 *puVar3;
  int iVar4;
  int iVar5;
  undefined1 auVar6 [16];
  undefined1 auVar7 [16];
  undefined1 auVar8 [16];
  undefined1 auVar9 [16];
  code *pcVar10;
  char cVar11;
  char cVar12;
  undefined8 uVar13;
  undefined8 uVar14;
  long lVar15;
  long *plVar16;
  long lVar17;
  undefined8 uVar18;
  undefined8 uVar19;
  undefined1 auVar20 [16];
  long *plStack_d8;
  long *plStack_d0;
  undefined4 uStack_c4;
  long lStack_c0;
  long *plStack_b8;
  undefined1 auStack_b0 [16];
  long lStack_a0;
  long *plStack_98;
  long lStack_90;
  long lStack_88;
  undefined8 uStack_80;
  undefined1 *puStack_78;
  undefined8 uStack_70;
  undefined1 *puStack_68;
  
  cVar11 = cRam0000000103911454;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar11 == '\0') {
    func_0x00010119b908(&UNK_103324b80);
    cRam0000000103911454 = '\x01';
  }
  plStack_d8 = (long *)0x0;
  plStack_d0 = (long *)0x0;
  uStack_c4 = 0;
  lStack_c0 = 0;
  plStack_b8 = (long *)0x0;
  auStack_b0._0_8_ = 0;
  auStack_b0._8_8_ = 0;
  lStack_a0 = 0;
  plStack_98 = (long *)0x0;
  uVar13 = func_0x000100331794(uRam00000001038c4f40,6);
  func_0x000100331f8c(uVar13,0,uRam00000001039046b8);
  uStack_c4 = *(undefined4 *)(param_1 + 0x34);
  uVar14 = func_0x00010034eec0(&uStack_c4);
  func_0x000100331f8c(uVar13,1,uVar14);
  func_0x000100331f8c(uVar13,2,uRam00000001038d3dd0);
  uStack_c4 = *(undefined4 *)(param_1 + 0x38);
  uVar14 = func_0x00010034eec0(&uStack_c4);
  func_0x000100331f8c(uVar13,3,uVar14);
  func_0x000100331f8c(uVar13,4,uRam00000001039046c0);
  cVar11 = SDV_StardewValley_Mobile_AStarNode_isTilePassable_06006643(param_1);
  puVar1 = (undefined8 *)0x1038d6090;
  if (cVar11 != '\0') {
    puVar1 = (undefined8 *)0x1038d6088;
  }
  func_0x000100331f8c(uVar13,5,*puVar1);
  func_0x000100351da0(uVar13);
  StardewValley_Log_It_06000016();
  lVar15 = *(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x88);
  uVar13 = _UNK_1036d2c58;
  if (lVar15 != 0) {
    lVar15 = func_0x00010035f1f8(lVar15,uRam00000001038c90d0);
    iVar4 = *(int *)(param_1 + 0x34);
    iVar5 = *(int *)(param_1 + 0x38);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    auVar20._8_8_ = auStack_b0._8_8_;
    auVar20._0_8_ = auStack_b0._0_8_;
    uVar13 = _UNK_1036d2c60;
    if ((lRam00000001038d5380 != 0) && (uVar13 = _UNK_1036d2c68, auStack_b0 = auVar20, lVar15 != 0))
    {
      lVar15 = func_0x00010035c840(lVar15,CONCAT44(iVar5 << 6,iVar4 << 6),
                                   *(undefined8 *)(lRam00000001038d5380 + 8));
      if (lVar15 == 0) {
        uVar14 = func_0x000100331794(uRam00000001038c4f40,5);
        func_0x000100331f8c(uVar14,0,uRam0000000103904768);
        uStack_c4 = *(undefined4 *)(param_1 + 0x34);
        uVar13 = func_0x00010034eec0(&uStack_c4);
        func_0x000100331f8c(uVar14,1,uVar13);
        func_0x000100331f8c(uVar14,2,uRam00000001038d3dd0);
        uStack_c4 = *(undefined4 *)(param_1 + 0x38);
        uVar13 = func_0x00010034eec0(&uStack_c4);
        func_0x000100331f8c(uVar14,3,uVar13);
        uVar19 = 4;
        uVar13 = uRam0000000103904770;
      }
      else {
        plVar16 = (long *)func_0x00010035c854();
        uVar13 = _UNK_1036d2c70;
        if (plVar16 == (long *)0x0) goto LAB_101faa758;
        (**(code **)(*plVar16 + -0x28))(plVar16,uRam00000001038e0408,&plStack_d8);
        if (plStack_d8 == (long *)0x0) {
          lVar17 = *(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x88);
          uVar13 = _UNK_1036d2c88;
          if (lVar17 == 0) goto LAB_101faa758;
          lVar17 = func_0x00010035f1f8(lVar17,uRam00000001038cc720);
          iVar4 = *(int *)(param_1 + 0x34);
          iVar5 = *(int *)(param_1 + 0x38);
          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
            func_0x0001003319b0();
          }
          auVar6._8_8_ = auStack_b0._8_8_;
          auVar6._0_8_ = auStack_b0._0_8_;
          uVar13 = _UNK_1036d2c90;
          if ((lRam00000001038d5380 == 0) ||
             (uVar13 = _UNK_1036d2c98, auStack_b0 = auVar6, lVar17 == 0)) goto LAB_101faa758;
          plStack_d0 = (long *)func_0x00010035c840(lVar17,CONCAT44(iVar5 << 6,iVar4 << 6),
                                                   *(undefined8 *)(lRam00000001038d5380 + 8));
          if (plStack_d0 != (long *)0x0) {
            uVar13 = _UNK_1036d2d30;
            if (plStack_d0 != (long *)0x0) {
              plVar16 = (long *)func_0x00010035c854();
              (**(code **)(*plVar16 + -0x28))(plVar16,uRam00000001038e0408,&plStack_d8);
              plVar16 = (long *)func_0x000100331794(uRam00000001038c4f40,8);
              func_0x000100331f8c(plVar16,0,uRam0000000103904728);
              uStack_c4 = *(undefined4 *)(param_1 + 0x34);
              uVar13 = func_0x00010034eec0(&uStack_c4);
              func_0x000100331f8c(plVar16,1,uVar13);
              func_0x000100331f8c(plVar16,2,uRam00000001038d3dd0);
              uStack_c4 = *(undefined4 *)(param_1 + 0x38);
              uVar13 = func_0x00010034eec0(&uStack_c4);
              func_0x000100331f8c(plVar16,3,uVar13);
              func_0x000100331f8c(plVar16,4,uRam0000000103904700);
              uVar13 = uRam00000001038f0638;
              if (plStack_d8 != (long *)0x0) {
                uVar13 = (**(code **)(*plStack_d8 + 0x60))();
              }
              (**(code **)(*plVar16 + 0x110))(plVar16,5,uVar13);
              (**(code **)(*plVar16 + 0x110))(plVar16,6,uRam0000000103904730);
              cVar11 = SDV_StardewValley_Mobile_AStarNode_IsBuildingPassable_06006644(param_1);
              puVar1 = (undefined8 *)0x1038d6090;
              if (cVar11 != '\0') {
                puVar1 = (undefined8 *)0x1038d6088;
              }
              (**(code **)(*plVar16 + 0x110))(plVar16,7,*puVar1);
              func_0x000100351da0(plVar16);
              StardewValley_Log_It_06000016();
              uVar13 = _UNK_1036d2d40;
              if (plStack_d0 != (long *)0x0) {
                plVar16 = (long *)func_0x00010035c854();
                uVar13 = _UNK_1036d2d48;
                if (plVar16 != (long *)0x0) {
                  plStack_b8 = (long *)(**(code **)(*plVar16 + -0x10))();
                  while (plStack_b8 != (long *)0x0) {
                    cVar11 = (**(code **)(*plStack_b8 + -0x78))();
                    if (cVar11 == '\0') {
                      lStack_90 = 0;
                      if (plStack_b8 != (long *)0x0) {
                        uVar13 = _UNK_1036d2d88;
                        if (plStack_b8 == (long *)0x0) goto LAB_101faa758;
                        (**(code **)(*plStack_b8 + -0x28))();
                      }
                      if (lStack_90 != 0) {
                        func_0x000100331ba4();
                      }
                      plVar16 = (long *)(**(code **)(*plStack_d0 + 0x70))();
                      plStack_b8 = (long *)(**(code **)(*plVar16 + -0x10))();
                      goto LAB_101faa794;
                    }
                    if (plStack_b8 == (long *)0x0) break;
                    auVar20 = (**(code **)(*plStack_b8 + -0x38))();
                    uVar14 = uRam0000000103904750;
                    uVar13 = uRam0000000103904748;
                    uVar19 = func_0x000100374f30(auVar20._8_8_);
                    uVar13 = func_0x00010035048c(uVar14,auVar20._0_8_,uVar13,uVar19);
                    if (lRam0000000103976fb8 != 0) {
                      func_0x00010119b8f8();
                    }
                    StardewValley_Log_It_06000016(uVar13);
                  }
                  func_0x0001003316f4(0xee,_UNK_1036d2d50);
                  goto LAB_101faa850;
                }
              }
            }
            goto LAB_101faa758;
          }
          plVar16 = (long *)func_0x00010035c854(lVar15);
          uVar13 = _UNK_1036d2ca0;
          if (plVar16 == (long *)0x0) goto LAB_101faa758;
          (**(code **)(*plVar16 + -0x28))(plVar16,uRam00000001038e7d30,&plStack_d8);
          if (plStack_d8 == (long *)0x0) {
            plVar16 = (long *)func_0x00010035c854(lVar15);
            uVar13 = _UNK_1036d2ca8;
            if (plVar16 == (long *)0x0) goto LAB_101faa758;
            (**(code **)(*plVar16 + -0x28))(plVar16,uRam00000001038e7e60,&plStack_d8);
            if (plStack_d8 == (long *)0x0) {
              uVar14 = func_0x000100331794(uRam00000001038c4f40,8);
              func_0x000100331f8c(uVar14,0,uRam00000001039046c8);
              uStack_c4 = *(undefined4 *)(param_1 + 0x34);
              uVar13 = func_0x00010034eec0(&uStack_c4);
              func_0x000100331f8c(uVar14,1,uVar13);
              func_0x000100331f8c(uVar14,2,uRam00000001038d3dd0);
              uStack_c4 = *(undefined4 *)(param_1 + 0x38);
              uVar13 = func_0x00010034eec0(&uStack_c4);
              func_0x000100331f8c(uVar14,3,uVar13);
              func_0x000100331f8c(uVar14,4,uRam00000001039046d0);
              cVar11 = SDV_StardewValley_Mobile_AStarNode_isTilePassable_06006643(param_1);
              puVar1 = (undefined8 *)0x1038d6090;
              if (cVar11 != '\0') {
                puVar1 = (undefined8 *)0x1038d6088;
              }
              func_0x000100331f8c(uVar14,5,*puVar1);
              func_0x000100331f8c(uVar14,6,uRam00000001039046d8);
              uVar13 = _UNK_1036d2cb0;
              if (*(long *)(param_1 + 0x18) != 0) {
                iVar4 = *(int *)(param_1 + 0x34);
                iVar5 = *(int *)(param_1 + 0x38);
                lVar15 = *(long *)(*(long *)(param_1 + 0x18) + 0x10);
                uVar13 = _UNK_1036d2cb8;
                if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                  func_0x0001003319b0();
                  uVar13 = _UNK_1036d2cb8;
                }
                _UNK_1036d2cb8 = uVar13;
                if (lVar15 != 0) {
                  cVar11 = func_0x0001018d3064((float)iVar4,(float)iVar5,lVar15);
                  puVar1 = (undefined8 *)0x1038d6090;
                  puVar2 = puVar1;
                  if (cVar11 != '\0') {
                    puVar2 = (undefined8 *)0x1038d6088;
                  }
                  func_0x000100331f8c(uVar14,7,*puVar2);
                  func_0x000100351da0(uVar14);
                  StardewValley_Log_It_06000016();
                  cVar11 = SDV_StardewValley_Mobile_AStarNode_isTilePassable_06006643(param_1);
                  auVar7._8_8_ = auStack_b0._8_8_;
                  auVar7._0_8_ = auStack_b0._0_8_;
                  uVar13 = _UNK_1036d2cc0;
                  if ((*(long *)(param_1 + 0x18) != 0) &&
                     (uVar13 = _UNK_1036d2cc8, auStack_b0 = auVar7,
                     *(long *)(*(long *)(param_1 + 0x18) + 0x10) != 0)) {
                    cVar12 = func_0x0001018d3064((float)*(int *)(param_1 + 0x34),
                                                 (float)*(int *)(param_1 + 0x38));
                    if (cVar11 == cVar12) {
                      return true;
                    }
                    lStack_a0 = 0;
                    lVar15 = *(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x88);
                    uVar13 = _UNK_1036d2ce0;
                    if (lVar15 != 0) {
                      lVar15 = func_0x00010035f1f8(lVar15,uRam00000001038c90d0);
                      iVar4 = *(int *)(param_1 + 0x34);
                      iVar5 = *(int *)(param_1 + 0x38);
                      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                        func_0x0001003319b0();
                      }
                      auVar8._8_8_ = auStack_b0._8_8_;
                      auVar8._0_8_ = auStack_b0._0_8_;
                      uVar13 = _UNK_1036d2ce8;
                      if ((lRam00000001038d5380 != 0) &&
                         (uVar13 = _UNK_1036d2cf0, auStack_b0 = auVar8, lVar15 != 0)) {
                        lVar15 = func_0x00010035c840(lVar15,CONCAT44(iVar5 << 6,iVar4 << 6),
                                                     *(undefined8 *)(lRam00000001038d5380 + 8));
                        if (lVar15 != 0) {
                          plVar16 = (long *)func_0x00010035c854(lVar15);
                          (**(code **)(*plVar16 + -0x28))(plVar16,uRam00000001038e0408,&lStack_a0);
                        }
                        lVar17 = *(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0x88);
                        uVar13 = _UNK_1036d2d08;
                        if (lVar17 != 0) {
                          lVar17 = func_0x00010035f1f8(lVar17,uRam00000001038cc720);
                          iVar4 = *(int *)(param_1 + 0x34);
                          iVar5 = *(int *)(param_1 + 0x38);
                          if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
                            func_0x0001003319b0();
                          }
                          auVar9._8_8_ = auStack_b0._8_8_;
                          auVar9._0_8_ = auStack_b0._0_8_;
                          uVar13 = _UNK_1036d2d10;
                          if ((lRam00000001038d5380 != 0) &&
                             (uVar13 = _UNK_1036d2d18, auStack_b0 = auVar9, lVar17 != 0)) {
                            lVar17 = func_0x00010035c840(lVar17,CONCAT44(iVar5 << 6,iVar4 << 6),
                                                         *(undefined8 *)(lRam00000001038d5380 + 8));
                            if (lVar17 != 0) {
                              plVar16 = (long *)func_0x00010035c854(lVar17);
                              (**(code **)(*plVar16 + -0x28))
                                        (plVar16,uRam00000001038e0408,&plStack_98);
                              plVar16 = (long *)func_0x000100331794(uRam00000001038c4f40,6);
                              func_0x000100331f8c(plVar16,0,uRam00000001039046f8);
                              uStack_c4 = *(undefined4 *)(param_1 + 0x34);
                              uVar13 = func_0x00010034eec0(&uStack_c4);
                              func_0x000100331f8c(plVar16,1,uVar13);
                              func_0x000100331f8c(plVar16,2,uRam00000001038d3dd0);
                              uStack_c4 = *(undefined4 *)(param_1 + 0x38);
                              uVar13 = func_0x00010034eec0(&uStack_c4);
                              func_0x000100331f8c(plVar16,3,uVar13);
                              func_0x000100331f8c(plVar16,4,uRam0000000103904700);
                              uVar13 = uRam00000001038f0638;
                              if (plStack_98 != (long *)0x0) {
                                uVar13 = (**(code **)(*plStack_98 + 0x60))();
                              }
                              (**(code **)(*plVar16 + 0x110))(plVar16,5,uVar13);
                              func_0x000100351da0(plVar16);
                              StardewValley_Log_It_06000016();
                            }
                            uVar13 = func_0x000100331794(uRam00000001038c4f40,6);
                            func_0x000100331f8c(uVar13,0,uRam00000001039046e0);
                            puVar2 = (undefined8 *)0x1038d6088;
                            puVar3 = puVar2;
                            if (lStack_a0 != 0) {
                              puVar3 = puVar1;
                            }
                            func_0x000100331f8c(uVar13,1,*puVar3);
                            func_0x000100331f8c(uVar13,2,uRam00000001039046e8);
                            puVar3 = puVar2;
                            if (lVar17 != 0) {
                              puVar3 = puVar1;
                            }
                            func_0x000100331f8c(uVar13,3,*puVar3);
                            func_0x000100331f8c(uVar13,4,uRam00000001039046f0);
                            if (lVar15 == 0) {
                              puVar2 = puVar1;
                            }
                            func_0x000100331f8c(uVar13,5,*puVar2);
                            func_0x000100351da0(uVar13);
                            StardewValley_Log_It_06000016();
                            if (lStack_a0 != 0 || lVar17 != 0) {
                              return false;
                            }
                            return lVar15 != 0;
                          }
                        }
                      }
                    }
                  }
                }
              }
              goto LAB_101faa758;
            }
            uVar14 = func_0x000100331794(uRam00000001038c4f40,6);
            func_0x000100331f8c(uVar14,0,uRam0000000103904708);
            uStack_c4 = *(undefined4 *)(param_1 + 0x34);
            uVar13 = func_0x00010034eec0(&uStack_c4);
            func_0x000100331f8c(uVar14,1,uVar13);
            func_0x000100331f8c(uVar14,2,uRam00000001038d3dd0);
            uStack_c4 = *(undefined4 *)(param_1 + 0x38);
            uVar13 = func_0x00010034eec0(&uStack_c4);
            func_0x000100331f8c(uVar14,3,uVar13);
            uVar13 = uRam0000000103904710;
          }
          else {
            uVar14 = func_0x000100331794(uRam00000001038c4f40,6);
            func_0x000100331f8c(uVar14,0,uRam0000000103904718);
            uStack_c4 = *(undefined4 *)(param_1 + 0x34);
            uVar13 = func_0x00010034eec0(&uStack_c4);
            func_0x000100331f8c(uVar14,1,uVar13);
            func_0x000100331f8c(uVar14,2,uRam00000001038d3dd0);
            uStack_c4 = *(undefined4 *)(param_1 + 0x38);
            uVar13 = func_0x00010034eec0(&uStack_c4);
            func_0x000100331f8c(uVar14,3,uVar13);
            uVar13 = uRam0000000103904720;
          }
        }
        else {
          uVar14 = func_0x000100331794(uRam00000001038c4f40,6);
          func_0x000100331f8c(uVar14,0,uRam0000000103904758);
          uStack_c4 = *(undefined4 *)(param_1 + 0x34);
          uVar13 = func_0x00010034eec0(&uStack_c4);
          func_0x000100331f8c(uVar14,1,uVar13);
          func_0x000100331f8c(uVar14,2,uRam00000001038d3dd0);
          uStack_c4 = *(undefined4 *)(param_1 + 0x38);
          uVar13 = func_0x00010034eec0(&uStack_c4);
          func_0x000100331f8c(uVar14,3,uVar13);
          uVar13 = uRam0000000103904760;
        }
        func_0x000100331f8c(uVar14,4,uVar13);
        uVar13 = func_0x000100374f30(plStack_d8);
        uVar19 = 5;
      }
      func_0x000100331f8c(uVar14,uVar19,uVar13);
      func_0x000100351da0(uVar14);
      StardewValley_Log_It_06000016();
      return false;
    }
  }
LAB_101faa758:
  func_0x0001003316f4(0xee,uVar13);
                    /* WARNING: Does not return */
  pcVar10 = (code *)SoftwareBreakpoint(1,0x101faa764);
  (*pcVar10)();
LAB_101faa794:
  auVar20 = auStack_b0;
  if (plStack_b8 == (long *)0x0) goto LAB_101faa840;
  cVar11 = (**(code **)(*plStack_b8 + -0x78))();
  if (cVar11 == '\0') {
    lStack_88 = 0;
    if (plStack_b8 != (long *)0x0) {
      uVar13 = _UNK_1036d2d90;
      if (plStack_b8 == (long *)0x0) goto LAB_101faa758;
      (**(code **)(*plStack_b8 + -0x28))();
    }
    if (lStack_88 != 0) {
      func_0x000100331ba4();
    }
    lStack_c0 = 0;
    uVar13 = _UNK_1036d2d70;
    if (plStack_d0 != (long *)0x0) {
      plVar16 = (long *)func_0x00010035c854();
      uVar13 = _UNK_1036d2d68;
      if (plVar16 != (long *)0x0) {
        (**(code **)(*plVar16 + -0x28))(plVar16,uRam00000001038e5238,&lStack_c0);
        if (lStack_c0 != 0) {
          StardewValley_Log_It_06000016(uRam0000000103904738);
        }
        if (plStack_d8 != (long *)0x0) {
          return true;
        }
        return lStack_c0 != 0;
      }
    }
    goto LAB_101faa758;
  }
  auVar20 = auStack_b0;
  if (plStack_b8 == (long *)0x0) goto LAB_101faa840;
  auVar20 = (**(code **)(*plStack_b8 + -0x38))();
  uVar14 = uRam0000000103904748;
  uVar13 = uRam0000000103904740;
  uVar19 = auVar20._0_8_;
  puStack_78 = auStack_b0;
  if ((auStack_b0 == (undefined1 *)0x0) ||
     (uStack_80 = uVar19, puStack_68 = auStack_b0, auStack_b0 == (undefined1 *)0x0))
  goto LAB_101faa840;
  uStack_70 = auVar20._8_8_;
  auStack_b0 = auVar20;
  uVar18 = func_0x000100374f30(auVar20._8_8_);
  uVar13 = func_0x00010035048c(uVar13,uVar19,uVar14,uVar18);
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  StardewValley_Log_It_06000016(uVar13);
  goto LAB_101faa794;
LAB_101faa840:
  auStack_b0 = auVar20;
  func_0x0001003316f4(0xee,_UNK_1036d2d60);
LAB_101faa850:
                    /* WARNING: Does not return */
  pcVar10 = (code *)SoftwareBreakpoint(1,0x101faa854);
  (*pcVar10)();
}

