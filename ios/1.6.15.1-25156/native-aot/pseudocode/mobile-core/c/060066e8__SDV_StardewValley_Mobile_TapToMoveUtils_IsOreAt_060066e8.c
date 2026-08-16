/* 0x060066e8 StardewValley.Mobile.TapToMoveUtils.IsOreAt @ 0x101fcb4d4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMoveUtils_IsOreAt_060066e8(float param_1,float param_2)

{
  undefined4 uVar1;
  code *pcVar2;
  char cVar3;
  bool bVar4;
  long lVar5;
  undefined8 uVar6;
  double dVar7;
  
  cVar3 = cRam00000001039114f7;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325907);
    cRam00000001039114f7 = '\x01';
  }
  lVar5 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  if (*(long *)(lVar5 + 0x140) == 0) {
    func_0x0001003316f4(0xee,_UNK_1036d7948);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101fcb604);
    (*pcVar2)();
  }
  uVar6 = *(undefined8 *)(*(long *)(lVar5 + 0x140) + 0x68);
  if (*(char *)(lRam00000001038c7de8 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  cVar3 = func_0x0001003502d4(uVar6,*puRam00000001038d7928);
  if (cVar3 == '\0') {
    bVar4 = false;
  }
  else {
    lVar5 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    uVar1 = *(undefined4 *)(*(long *)(lVar5 + 0x140) + 0x68);
    lVar5 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    dVar7 = (double)StardewValley_StardewValley_Utility_Distance_060042a9
                              (uVar1,*(undefined4 *)(*(long *)(lVar5 + 0x140) + 0x6c),(int)param_1,
                               (int)param_2);
    bVar4 = dVar7 <= 2.0;
  }
  return bVar4;
}

