/* 0x060066f8 StardewValley.Mobile.TapToMoveUtils.GetTreeAt @ 0x101fccc38 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 * SDV_StardewValley_Mobile_TapToMoveUtils_GetTreeAt_060066f8(int param_1,int param_2)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 *puStack_38;
  
  cVar1 = cRam0000000103911507;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325a1d);
    cRam0000000103911507 = '\x01';
  }
  puStack_38 = (undefined8 *)0x0;
  lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  if (*(long *)(lVar3 + 0x120) != 0) {
    func_0x0001003554a0((float)param_1,(float)param_2,*(long *)(lVar3 + 0x120),&puStack_38);
    if (((puStack_38 != (undefined8 *)0x0) &&
        (lVar3 = *(long *)(*(long *)(*(long *)*puStack_38 + 0x10) + 0x10),
        lRam00000001038c7998 != lVar3)) && (lRam00000001038c7910 != lVar3)) {
      puStack_38 = (undefined8 *)0x0;
    }
    return puStack_38;
  }
  func_0x0001003316f4(0xee,_UNK_1036d7b88);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fccd20);
  (*pcVar2)();
}

