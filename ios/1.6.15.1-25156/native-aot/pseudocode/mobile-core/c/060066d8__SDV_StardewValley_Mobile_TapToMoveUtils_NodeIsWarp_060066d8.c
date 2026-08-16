/* 0x060066d8 StardewValley.Mobile.TapToMoveUtils.NodeIsWarp @ 0x101fc9850 */

/* WARNING: Removing unreachable block (ram,0x000101fc9a4c) */
/* WARNING: Removing unreachable block (ram,0x000101fc9a2c) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1 SDV_StardewValley_Mobile_TapToMoveUtils_NodeIsWarp_060066d8(long param_1)

{
  int iVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  undefined8 uVar5;
  int iVar6;
  float fVar7;
  float fVar8;
  undefined8 uStack_90;
  undefined8 uStack_88;
  long lStack_80;
  undefined8 uStack_78;
  undefined1 uStack_61;
  undefined8 uStack_60;
  undefined8 *puStack_58;
  
  cVar3 = cRam00000001039114e7;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325846);
    cRam00000001039114e7 = '\x01';
  }
  uStack_61 = 0;
  uStack_88 = 0;
  uStack_90 = 0;
  uStack_78 = 0;
  lStack_80 = 0;
  if ((param_1 == 0) ||
     (lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb(),
     *(char *)(lVar4 + 0x2c4) != '\0')) {
    return 0;
  }
  iVar6 = *(int *)(param_1 + 0x34);
  iVar1 = *(int *)(param_1 + 0x38);
  lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar5 = _UNK_1036d7708;
  if (*(long *)(lVar4 + 0xd8) != 0) {
    func_0x000100355e78(&uStack_90);
    do {
      while( true ) {
        cVar3 = func_0x000100355e8c(&uStack_90);
        if (cVar3 == '\0') {
          iVar6 = 2;
          goto LAB_101fc9a0c;
        }
        if (((lStack_80 == 0) || (*(long *)(lStack_80 + 0x10) == 0)) ||
           (*(long *)(lStack_80 + 0x18) == 0)) {
          func_0x0001003316f4(0xee,_UNK_1036d7710);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fc9984);
          (*pcVar2)();
        }
        fVar7 = (float)func_0x000100354758((float)(*(int *)(*(long *)(lStack_80 + 0x10) + 0x68) << 6
                                                  ),(float)(*(int *)(*(long *)(lStack_80 + 0x18) +
                                                                    0x68) << 6),
                                           (float)(iVar6 << 6) + 32.0,(float)(iVar1 << 6) + 32.0);
        fVar8 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_WarpRange_060066da();
        if (lRam0000000103976fb8 != 0) break;
        if (fVar7 < fVar8) goto LAB_101fc9960;
      }
      func_0x00010119b8f8();
    } while (fVar8 <= fVar7);
LAB_101fc9960:
    iVar6 = 1;
    uStack_61 = 1;
LAB_101fc9a0c:
    uStack_60 = 0;
    puStack_58 = &uStack_90;
    if (puStack_58 != (undefined8 *)0x0) {
      if (iVar6 == 1) {
        return uStack_61;
      }
      if (iVar6 == 2) {
        return 0;
      }
      func_0x000100331c30();
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fc9a5c);
      (*pcVar2)();
    }
    puStack_58 = (undefined8 *)0x0;
    uVar5 = _UNK_1036d7718;
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fc99e4);
  (*pcVar2)();
}

