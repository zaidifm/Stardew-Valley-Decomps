/* 0x06006700 StardewValley.Mobile.TapToMoveUtils.IsTerrainFeatureAt @ 0x101fcd754 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMoveUtils_IsTerrainFeatureAt_06006700(long param_1)

{
  bool bVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  long *plStack_40;
  undefined4 uStack_34;
  
  cVar2 = cRam000000010391150f;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325aa0);
    cRam000000010391150f = '\x01';
  }
  plStack_40 = (long *)0x0;
  lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar5 = _UNK_1036d7c50;
  if (((lVar4 != 0) && (uVar5 = _UNK_1036d7c58, param_1 != 0)) &&
     (uVar5 = _UNK_1036d7c60, *(long *)(lVar4 + 0x120) != 0)) {
    func_0x0001003554a0((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38),
                        *(long *)(lVar4 + 0x120),&plStack_40);
    bVar1 = plStack_40 != (long *)0x0;
    if (bVar1) {
      uVar5 = func_0x000100331794(uRam00000001038c4f40,6);
      func_0x000100331f8c(uVar5,0,uRam0000000103904aa8);
      uStack_34 = *(undefined4 *)(param_1 + 0x34);
      uVar6 = func_0x00010034eec0(&uStack_34);
      func_0x000100331f8c(uVar5,1,uVar6);
      func_0x000100331f8c(uVar5,2,uRam00000001038d7758);
      uStack_34 = *(undefined4 *)(param_1 + 0x38);
      uVar6 = func_0x00010034eec0(&uStack_34);
      func_0x000100331f8c(uVar5,3,uVar6);
      func_0x000100331f8c(uVar5,4,uRam0000000103904ab0);
      uVar6 = (**(code **)(**(long **)(*plStack_40 + 0x18) + 0x60))();
      func_0x000100331f8c(uVar5,5,uVar6);
      func_0x000100351da0(uVar5);
      StardewValley_Log_It_06000016();
    }
    return bVar1;
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fcd904);
  (*pcVar3)();
}

