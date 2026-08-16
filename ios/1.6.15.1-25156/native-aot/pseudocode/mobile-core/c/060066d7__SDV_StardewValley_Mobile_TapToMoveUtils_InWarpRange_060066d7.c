/* 0x060066d7 StardewValley.Mobile.TapToMoveUtils.InWarpRange @ 0x101fc95fc */

/* WARNING: Removing unreachable block (ram,0x000101fc9830) */
/* WARNING: Removing unreachable block (ram,0x000101fc9810) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1 SDV_StardewValley_Mobile_TapToMoveUtils_InWarpRange_060066d7(void)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  int iVar5;
  float fVar6;
  undefined4 uVar7;
  float fVar8;
  float fVar9;
  float fVar10;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  long lStack_90;
  undefined8 uStack_88;
  undefined1 uStack_71;
  undefined8 uStack_70;
  undefined8 *puStack_68;
  
  cVar2 = cRam00000001039114e6;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_10332583b);
    cRam00000001039114e6 = '\x01';
  }
  uStack_71 = 0;
  uStack_98 = 0;
  uStack_a0 = 0;
  uStack_88 = 0;
  lStack_90 = 0;
  lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  if (*(char *)(lVar3 + 0x2c4) != '\0') {
    return 0;
  }
  lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar4 = _UNK_1036d76e0;
  if (*(long *)(lVar3 + 0xd8) != 0) {
    func_0x000100355e78(&uStack_a0);
    while (cVar2 = func_0x000100355e8c(&uStack_a0), cVar2 != '\0') {
      if (((lStack_90 == 0) || (*(long *)(lStack_90 + 0x10) == 0)) ||
         (*(long *)(lStack_90 + 0x18) == 0)) {
LAB_101fc9740:
        func_0x0001003316f4(0xee,_UNK_1036d76e8);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc9754);
        (*pcVar1)();
      }
      fVar10 = (float)(*(int *)(*(long *)(lStack_90 + 0x10) + 0x68) << 6);
      fVar9 = (float)(*(int *)(*(long *)(lStack_90 + 0x18) + 0x68) << 6);
      fVar8 = fVar9;
      func_0x00010035025c(fVar10,fVar9,0x4200000042000000,0x4200000042000000);
      fVar6 = (float)func_0x000100354758();
      lVar3 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if ((lVar3 == 0) || (*(long *)(lVar3 + 0x20) == 0)) goto LAB_101fc9740;
      uVar7 = func_0x0001003436c4();
      fVar8 = (float)func_0x000100354758(fVar10,fVar9,uVar7,fVar8);
      fVar9 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_WarpRange_060066da();
      if ((fVar6 < fVar9) &&
         (fVar6 = (float)SDV_StardewValley_Mobile_TapToMoveUtils_get_WarpRange_060066da(),
         fVar8 < fVar6)) {
        iVar5 = 1;
        uStack_71 = 1;
        goto LAB_101fc97f0;
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    iVar5 = 2;
LAB_101fc97f0:
    uStack_70 = 0;
    puStack_68 = &uStack_a0;
    if (puStack_68 != (undefined8 *)0x0) {
      if (iVar5 == 1) {
        return uStack_71;
      }
      if (iVar5 == 2) {
        return 0;
      }
      func_0x000100331c30();
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc9840);
      (*pcVar1)();
    }
    puStack_68 = (undefined8 *)0x0;
    uVar4 = _UNK_1036d76f0;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc97c4);
  (*pcVar1)();
}

