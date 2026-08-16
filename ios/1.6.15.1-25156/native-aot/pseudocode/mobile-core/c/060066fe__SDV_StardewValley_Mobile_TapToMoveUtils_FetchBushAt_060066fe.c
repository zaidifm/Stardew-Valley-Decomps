/* 0x060066fe StardewValley.Mobile.TapToMoveUtils.FetchBushAt @ 0x101fcd440 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMoveUtils_FetchBushAt_060066fe(long param_1)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 *puVar4;
  undefined8 uVar5;
  int iVar6;
  int iVar7;
  
  cVar2 = cRam000000010391150d;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325a71);
    cRam000000010391150d = '\x01';
  }
  uVar5 = _UNK_1036d7c10;
  if (param_1 != 0) {
    iVar6 = *(int *)(param_1 + 0x34);
    iVar7 = *(int *)(param_1 + 0x38);
    lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    uVar5 = _UNK_1036d7c20;
    if (*(long *)(lVar3 + 0x120) != 0) {
      cVar2 = func_0x00010035afb8((float)iVar6,(float)iVar7);
      if (cVar2 != '\0') {
        lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
        uVar5 = _UNK_1036d7c30;
        if (*(long *)(lVar3 + 0x120) == 0) goto LAB_101fcd570;
        puVar4 = (undefined8 *)func_0x000100358178((float)iVar6,(float)iVar7);
        if ((puVar4 != (undefined8 *)0x0) &&
           (lRam00000001038c78e0 == *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x18))) {
          return;
        }
      }
      SDV_StardewValley_Mobile_TapToMoveUtils_FetchBushAtPoint_060066ff
                (*(int *)(param_1 + 0x34) << 6,*(int *)(param_1 + 0x38) << 6);
      return;
    }
  }
LAB_101fcd570:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcd57c);
  (*pcVar1)();
}

