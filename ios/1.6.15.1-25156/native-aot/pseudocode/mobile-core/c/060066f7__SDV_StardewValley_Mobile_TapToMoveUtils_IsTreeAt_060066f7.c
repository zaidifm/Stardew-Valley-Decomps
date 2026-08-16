/* 0x060066f7 StardewValley.Mobile.TapToMoveUtils.IsTreeAt @ 0x101fccb4c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMoveUtils_IsTreeAt_060066f7(int param_1,int param_2)

{
  char cVar1;
  code *pcVar2;
  bool bVar3;
  long lVar4;
  undefined8 *puStack_38;
  
  cVar1 = cRam0000000103911506;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325a12);
    cRam0000000103911506 = '\x01';
  }
  puStack_38 = (undefined8 *)0x0;
  lVar4 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  if (*(long *)(lVar4 + 0x120) == 0) {
    func_0x0001003316f4(0xee,_UNK_1036d7b78);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101fccc38);
    (*pcVar2)();
  }
  func_0x0001003554a0((float)param_1,(float)param_2,*(long *)(lVar4 + 0x120),&puStack_38);
  if (puStack_38 == (undefined8 *)0x0) {
    bVar3 = false;
  }
  else {
    lVar4 = *(long *)(*(long *)(*(long *)*puStack_38 + 0x10) + 0x10);
    bVar3 = lRam00000001038c7998 == lVar4 || lRam00000001038c7910 == lVar4;
  }
  return bVar3;
}

