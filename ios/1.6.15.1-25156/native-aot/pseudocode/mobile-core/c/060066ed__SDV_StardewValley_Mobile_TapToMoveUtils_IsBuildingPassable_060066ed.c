/* 0x060066ed StardewValley.Mobile.TapToMoveUtils.IsBuildingPassable @ 0x101fcbdd8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMoveUtils_IsBuildingPassable_060066ed
               (float param_1,float param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  long *plVar4;
  long *plVar5;
  undefined8 uVar6;
  long lStack_58;
  long lStack_50;
  long lStack_48;
  
  cVar2 = cRam00000001039114fc;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325960);
    cRam00000001039114fc = '\x01';
  }
  lStack_58 = 0;
  lVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar6 = _UNK_1036d7a18;
  if (*(long *)(lVar3 + 0x88) != 0) {
    lVar3 = func_0x00010035f1f8(*(long *)(lVar3 + 0x88),uRam00000001038cc720);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0(lRam00000001038c4c88);
    }
    uVar6 = _UNK_1036d7a20;
    if ((lRam00000001038d5380 != 0) && (uVar6 = _UNK_1036d7a28, lVar3 != 0)) {
      plVar4 = (long *)func_0x00010035c840(lVar3,CONCAT44((int)param_2 << 6,(int)param_1 << 6),
                                           *(undefined8 *)(lRam00000001038d5380 + 8));
      if (plVar4 == (long *)0x0) {
        return false;
      }
      plVar5 = (long *)func_0x00010035c854();
      uVar6 = _UNK_1036d7a30;
      if (plVar5 != (long *)0x0) {
        cVar2 = (**(code **)(*plVar5 + -0x28))(plVar5,uRam00000001038e0408,&lStack_58);
        if (cVar2 != '\0') {
          if (lStack_58 != 0) {
            uVar6 = func_0x000100374f30();
            cVar2 = func_0x000100345aa0(uVar6,uRam00000001038c9248);
            if (cVar2 != '\0') {
              return true;
            }
          }
          uVar6 = func_0x000100374f30(lStack_58);
          cVar2 = func_0x000100345aa0(uVar6,uRam0000000103904aa0);
          if (cVar2 != '\0') {
            return true;
          }
        }
        lStack_50 = 0;
        plVar5 = (long *)(**(code **)(*plVar4 + 0x70))(plVar4);
        (**(code **)(*plVar5 + -0x28))(plVar5,uRam00000001038e0408,&lStack_50);
        if (lStack_50 != 0) {
          return true;
        }
        lStack_48 = 0;
        plVar4 = (long *)func_0x00010035c854(plVar4);
        uVar6 = _UNK_1036d7a40;
        if (plVar4 != (long *)0x0) {
          (**(code **)(*plVar4 + -0x28))(plVar4,uRam00000001038e5238,&lStack_48);
          return lStack_48 != 0;
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcbff8);
  (*pcVar1)();
}

