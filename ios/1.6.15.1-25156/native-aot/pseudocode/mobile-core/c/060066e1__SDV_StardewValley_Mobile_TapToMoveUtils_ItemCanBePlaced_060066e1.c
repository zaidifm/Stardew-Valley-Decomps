/* 0x060066e1 StardewValley.Mobile.TapToMoveUtils.ItemCanBePlaced @ 0x101fca3e4 */

/* WARNING: Removing unreachable block (ram,0x000101fca9a0) */
/* WARNING: Removing unreachable block (ram,0x000101fca980) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1
SDV_StardewValley_Mobile_TapToMoveUtils_ItemCanBePlaced_060066e1
          (float param_1,float param_2,long *param_3)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  long lVar4;
  undefined8 *puVar5;
  long *plVar6;
  undefined8 uVar7;
  int iVar8;
  undefined1 auVar9 [16];
  undefined8 uStack_1d0;
  undefined8 uStack_1c8;
  undefined8 uStack_1c0;
  undefined8 uStack_1b8;
  undefined8 uStack_1b0;
  undefined8 uStack_1a8;
  undefined8 uStack_1a0;
  long *plStack_198;
  undefined8 uStack_190;
  undefined1 auStack_180 [16];
  undefined1 uStack_161;
  undefined8 uStack_160;
  undefined8 uStack_158;
  undefined8 uStack_150;
  undefined8 *puStack_148;
  undefined8 uStack_140;
  undefined8 uStack_138;
  int iStack_12c;
  long lStack_128;
  long *plStack_120;
  long *plStack_118;
  undefined8 *puStack_110;
  undefined8 *puStack_108;
  undefined8 uStack_100;
  undefined8 uStack_f8;
  undefined8 uStack_f0;
  undefined8 uStack_e8;
  undefined8 uStack_e0;
  undefined8 uStack_d8;
  undefined8 uStack_d0;
  undefined8 uStack_c8;
  undefined8 uStack_c0;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  
  cVar2 = cRam00000001039114f0;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033258a0);
    cRam00000001039114f0 = '\x01';
  }
  uStack_190 = 0;
  auStack_180._0_8_ = 0;
  auStack_180._8_8_ = 0;
  uStack_161 = 0;
  uStack_1c8 = 0;
  uStack_1d0 = 0;
  uStack_1b8 = 0;
  uStack_1c0 = 0;
  uStack_1a8 = 0;
  uStack_1b0 = 0;
  plStack_198 = (long *)0x0;
  uStack_1a0 = 0;
  uVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar7 = _UNK_1036d7790;
  if (param_3 != (long *)0x0) {
    cVar2 = (**(code **)(*param_3 + 0x220))(param_1,param_2,param_3,uVar3,0xff,0);
    if (cVar2 == '\0') {
      return 0;
    }
    uVar7 = _UNK_1036d77a0;
    if (param_3 != (long *)0x0) {
      uVar7 = _UNK_1036d7798;
      if (lRam00000001038c7338 == *(long *)(*(long *)(*(long *)*param_3 + 0x10) + 0x10)) {
        cVar2 = (*(code *)((long *)*param_3)[0xa5])();
        if (cVar2 == '\0') {
          lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
          uVar7 = _UNK_1036d7840;
          if (*(long *)(lVar4 + 0xf0) == 0) goto LAB_101fca638;
          puStack_108 = &uStack_1d0;
          uStack_c0 = 0;
          uStack_c8 = 0;
          uStack_d0 = 0;
          uStack_d8 = 0;
          uStack_e0 = 0;
          uStack_e8 = 0;
          uStack_f0 = 0;
          uStack_f8 = 0;
          uStack_100 = 0;
          func_0x0001020681ec(&uStack_100,*(undefined8 *)(*(long *)(lVar4 + 0xf0) + 0x10));
          uStack_98 = uStack_e8;
          uStack_a0 = uStack_f0;
          uStack_88 = uStack_d8;
          uStack_90 = uStack_e0;
          uStack_78 = uStack_c8;
          uStack_80 = uStack_d0;
          uStack_70 = uStack_c0;
          uStack_a8 = uStack_f8;
          uStack_b0 = uStack_100;
          func_0x0001003512c4(puStack_108,&uStack_b0,0x48);
          do {
            while( true ) {
              cVar2 = func_0x000102068344(&uStack_1d0);
              if (cVar2 == '\0') {
                iVar8 = 2;
                goto LAB_101fca960;
              }
              if (plStack_198 == (long *)0x0) {
                func_0x0001003316f4(0xee,_UNK_1036d7848);
                    /* WARNING: Does not return */
                pcVar1 = (code *)SoftwareBreakpoint(1,0x101fca5d8);
                (*pcVar1)();
              }
              auVar9 = (**(code **)(*plStack_198 + 0x110))();
              uStack_158 = 0;
              uStack_150 = 0;
              auStack_180 = auVar9;
              func_0x00010034ede4(&uStack_158,(int)param_1 << 6,(int)param_2 << 6,0x40,0x40);
              cVar2 = func_0x00010035a4b4(auStack_180,uStack_158,uStack_150);
              if (lRam0000000103976fb8 != 0) break;
              if (cVar2 != '\0') goto LAB_101fca5a8;
            }
            func_0x00010119b8f8();
          } while (cVar2 == '\0');
LAB_101fca5a8:
          iVar8 = 1;
          uStack_161 = 0;
LAB_101fca960:
          uStack_160 = 0;
          puStack_148 = &uStack_1d0;
          uVar7 = _UNK_1036d7850;
          if (puStack_148 == (undefined8 *)0x0) goto LAB_101fca638;
          if (iVar8 == 1) {
            return uStack_161;
          }
          if (iVar8 != 2) {
            func_0x000100331c30();
                    /* WARNING: Does not return */
            pcVar1 = (code *)SoftwareBreakpoint(1,0x101fca9c8);
            (*pcVar1)();
          }
        }
        plVar6 = (long *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
        cVar2 = (**(code **)(*plVar6 + 0x3b8))(param_1,param_2,plVar6,param_3);
        if (cVar2 != '\0') {
          cVar2 = (**(code **)(*param_3 + 0x2d0))();
          if (cVar2 != '\0') {
            plStack_120 = param_3;
            if ((param_3 != (long *)0x0) &&
               (uVar7 = _UNK_1036d7830,
               lRam00000001038c7338 != *(long *)(*(long *)(*(long *)*param_3 + 0x10) + 0x10)))
            goto LAB_101fca8e4;
            cVar2 = (**(code **)(*param_3 + 0x528))();
            if (cVar2 != '\0') {
              return 1;
            }
            uStack_140 = 0;
            uStack_138 = 0;
            func_0x00010034ede4(&uStack_140,(int)(param_1 * 64.0),(int)(param_2 * 64.0),0x40,0x40);
            auStack_180._8_8_ = uStack_138;
            auStack_180._0_8_ = uStack_140;
            plVar6 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
            auVar9 = (**(code **)(*plVar6 + 0x110))();
            cVar2 = func_0x00010035a4b4(auStack_180,auVar9._0_8_,auVar9._8_8_);
            if (cVar2 == '\0') {
              return 1;
            }
          }
        }
        plStack_118 = param_3;
        if ((param_3 == (long *)0x0) ||
           (uVar7 = _UNK_1036d7810,
           lRam00000001038c7338 == *(long *)(*(long *)(*(long *)*param_3 + 0x10) + 0x10))) {
          lStack_128 = param_3[3];
          uVar7 = _UNK_1036d77b0;
          if (lStack_128 != 0) {
            iStack_12c = *(int *)(lStack_128 + 0x68);
            if (iStack_12c != -0x4a) {
              return 0;
            }
            lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
            uVar7 = _UNK_1036d77c8;
            if (*(long *)(lVar4 + 0x120) != 0) {
              cVar2 = func_0x00010035afb8(param_1,param_2);
              if (cVar2 == '\0') {
                return 0;
              }
              lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
              uVar7 = _UNK_1036d77d8;
              if (*(long *)(lVar4 + 0x120) != 0) {
                plVar6 = (long *)func_0x000100358178(param_1,param_2);
                if (lRam00000001038c8688 != *(long *)(*plVar6 + 0x18)) {
                  return 0;
                }
                lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
                uVar7 = _UNK_1036d77f0;
                if (*(long *)(lVar4 + 0x120) != 0) {
                  puVar5 = (undefined8 *)func_0x000100358178(param_1,param_2);
                  puStack_110 = puVar5;
                  if ((puVar5 != (undefined8 *)0x0) &&
                     (uVar7 = _UNK_1036d7808,
                     lRam00000001038c7940 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x10)))
                  goto LAB_101fca8e4;
                  uVar7 = _UNK_1036d77f8;
                  if (param_3 != (long *)0x0) {
                    uVar3 = StardewValley_StardewValley_Item_get_ItemId_06003848();
                    uVar7 = _UNK_1036d7800;
                    if (puVar5 != (undefined8 *)0x0) {
                      cVar2 = func_0x000101a91d94(puVar5,uVar3,0);
                      if (cVar2 == '\0') {
                        return 0;
                      }
                      return 1;
                    }
                  }
                }
              }
            }
          }
          goto LAB_101fca638;
        }
      }
LAB_101fca8e4:
      func_0x0001003316f4(0xd3,uVar7);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fca8f0);
      (*pcVar1)();
    }
  }
LAB_101fca638:
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fca644);
  (*pcVar1)();
}

