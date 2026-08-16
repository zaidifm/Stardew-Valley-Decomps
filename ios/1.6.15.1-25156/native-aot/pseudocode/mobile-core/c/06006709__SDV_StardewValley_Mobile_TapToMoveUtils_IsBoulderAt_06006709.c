/* 0x06006709 StardewValley.Mobile.TapToMoveUtils.IsBoulderAt @ 0x101fcddcc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_TapToMoveUtils_IsBoulderAt_06006709(int param_1,int param_2)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  undefined8 *puVar4;
  long lVar5;
  undefined8 uVar6;
  ulong uVar7;
  long lVar8;
  long *plStack_58;
  
  cVar3 = cRam0000000103911518;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325ac0);
    cRam0000000103911518 = '\x01';
  }
  plStack_58 = (long *)0x0;
  puVar4 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  if ((puVar4 == (undefined8 *)0x0) ||
     (lRam00000001038c69d0 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x10))) {
    puVar4 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    if ((puVar4 == (undefined8 *)0x0) ||
       (lRam00000001038c6de0 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x10))) {
LAB_101fcde5c:
      lVar5 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
      uVar6 = _UNK_1036d7d38;
      if (*(long *)(lVar5 + 0xb8) != 0) {
        func_0x000101b560e8((float)param_1,(float)param_2,*(long *)(lVar5 + 0xb8),&plStack_58);
        uVar6 = 0;
        if (plStack_58 != (long *)0x0) {
          uVar6 = (**(code **)(*plStack_58 + 0x1e8))();
          cVar3 = func_0x000100345aa0(uVar6,uRam00000001038e5bd8);
          if (cVar3 == '\0') {
            uVar6 = (**(code **)(*plStack_58 + 0x1e8))();
            cVar3 = func_0x000100345aa0(uVar6,uRam00000001038ecef0);
            if (cVar3 == '\0') {
              return 0;
            }
          }
LAB_101fcdec4:
          uVar6 = 1;
        }
        return uVar6;
      }
    }
    else {
      puVar4 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
      uVar6 = _UNK_1036d7d50;
      if (((puVar4 != (undefined8 *)0x0) &&
          (lRam00000001038c6de0 == *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x10))) &&
         (lVar5 = puVar4[0x20], uVar6 = _UNK_1036d7d58, lVar5 != 0)) {
        uVar7 = 0xffffffffffffffff;
        lVar8 = 0x20;
        do {
          while( true ) {
            uVar1 = *(uint *)(*(long *)(lVar5 + 0x58) + 0x18);
            if ((long)(int)uVar1 <= (long)(uVar7 + 1)) goto LAB_101fcde5c;
            if ((ulong)uVar1 <= uVar7 + 1) goto LAB_101fce074;
            lVar5 = *(long *)(*(long *)(lVar5 + 0x58) + 0x10);
            uVar7 = uVar7 + 1;
            uVar6 = _UNK_1036d7d68;
            if (*(uint *)(lVar5 + 0x18) <= uVar7) goto LAB_101fce0c0;
            cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_isResourceClumpBoulderAt_0600670a
                              (*(undefined8 *)(lVar8 + lVar5),param_1,param_2);
            if (cVar3 != '\0') goto LAB_101fcdec4;
            lVar5 = puVar4[0x20];
            if (lRam0000000103976fb8 == 0) break;
            func_0x00010119b8f8();
            lVar8 = lVar8 + 8;
            uVar6 = _UNK_1036d7d58;
            if (lVar5 == 0) goto LAB_101fce104;
          }
          lVar8 = lVar8 + 8;
          uVar6 = _UNK_1036d7d58;
        } while (lVar5 != 0);
      }
    }
  }
  else {
    puVar4 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    uVar6 = _UNK_1036d7d78;
    if (((puVar4 != (undefined8 *)0x0) &&
        (lRam00000001038c69d0 == *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x10))) &&
       (lVar5 = puVar4[0x20], uVar6 = _UNK_1036d7d80, lVar5 != 0)) {
      uVar7 = 0xffffffffffffffff;
      lVar8 = 0x20;
LAB_101fcdf1c:
      do {
        uVar1 = *(uint *)(*(long *)(lVar5 + 0x58) + 0x18);
        if ((long)(int)uVar1 <= (long)(uVar7 + 1)) goto LAB_101fcde5c;
        if ((ulong)uVar1 <= uVar7 + 1) {
LAB_101fce074:
          func_0x000100331b90();
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fce07c);
          (*pcVar2)();
        }
        lVar5 = *(long *)(*(long *)(lVar5 + 0x58) + 0x10);
        uVar7 = uVar7 + 1;
        uVar6 = _UNK_1036d7d90;
        if (*(uint *)(lVar5 + 0x18) <= uVar7) {
LAB_101fce0c0:
          func_0x0001003316f4(0xcc,uVar6);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fce0cc);
          (*pcVar2)();
        }
        cVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_isResourceClumpBoulderAt_0600670a
                          (*(undefined8 *)(lVar8 + lVar5),param_1,param_2);
        if (cVar3 != '\0') goto LAB_101fcdec4;
        lVar5 = puVar4[0x20];
        if (lRam0000000103976fb8 == 0) {
          lVar8 = lVar8 + 8;
          uVar6 = _UNK_1036d7d80;
          if (lVar5 == 0) break;
          goto LAB_101fcdf1c;
        }
        func_0x00010119b8f8();
        lVar8 = lVar8 + 8;
        uVar6 = _UNK_1036d7d80;
      } while (lVar5 != 0);
    }
  }
LAB_101fce104:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fce110);
  (*pcVar2)();
}

