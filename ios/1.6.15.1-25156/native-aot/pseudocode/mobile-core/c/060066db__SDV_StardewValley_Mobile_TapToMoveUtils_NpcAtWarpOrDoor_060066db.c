/* 0x060066db StardewValley.Mobile.TapToMoveUtils.NpcAtWarpOrDoor @ 0x101fc9f28 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMoveUtils_NpcAtWarpOrDoor_060066db(long *param_1,long param_2)

{
  char cVar1;
  code *pcVar2;
  bool bVar3;
  uint uVar4;
  ulong uVar5;
  long *plVar6;
  undefined8 uVar7;
  long lVar8;
  ulong uVar9;
  undefined1 auVar10 [16];
  long lStack_38;
  
  cVar1 = cRam00000001039114ea;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039114ea != '\0') goto LAB_101fc9f5c;
LAB_101fca0ac:
    func_0x00010119b908(&UNK_103325880);
    cRam00000001039114ea = '\x01';
    lVar8 = *param_1;
  }
  else {
    func_0x00010119b8f8();
    if (cVar1 == '\0') goto LAB_101fca0ac;
LAB_101fc9f5c:
    lVar8 = *param_1;
  }
  auVar10 = (**(code **)(lVar8 + 0x110))(param_1);
  uVar7 = _UNK_1036d7768;
  if (param_2 != 0) {
    lVar8 = func_0x0001018cbf34(param_2,auVar10._0_8_,auVar10._8_8_,param_1);
    if (lVar8 != 0) {
      return true;
    }
    lStack_38 = 0;
    uVar7 = _UNK_1036d7770;
    if (*(long *)(param_2 + 0x88) != 0) {
      lVar8 = func_0x00010035f1f8(*(long *)(param_2 + 0x88),uRam00000001038cc720);
      uVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(param_1);
      uVar4 = func_0x000101795614(param_1);
      if (uVar4 < 4) {
        uVar9 = uVar5 >> 0x20;
        switch(uVar4) {
        case 0:
          uVar9 = uVar9 - 0x40;
          break;
        case 1:
          uVar5 = uVar5 + 0x40;
          break;
        case 2:
          uVar9 = uVar9 + 0x40;
          break;
        case 3:
          uVar5 = uVar5 + 0xffffffc0;
        }
      }
      else {
        uVar5 = 0;
        uVar9 = 0;
      }
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar7 = _UNK_1036d7778;
      if ((lRam00000001038d5380 != 0) && (uVar7 = _UNK_1036d7780, lVar8 != 0)) {
        plVar6 = (long *)func_0x00010035c840(lVar8,uVar5 & 0xffffffff | uVar9 << 0x20,
                                             *(undefined8 *)(lRam00000001038d5380 + 8));
        bVar3 = false;
        if (plVar6 != (long *)0x0) {
          plVar6 = (long *)(**(code **)(*plVar6 + 0x70))();
          uVar7 = _UNK_1036d7788;
          if (plVar6 == (long *)0x0) goto LAB_101fca114;
          (**(code **)(*plVar6 + -0x28))(plVar6,uRam00000001038e3670,&lStack_38);
          bVar3 = lStack_38 != 0;
        }
        return bVar3;
      }
    }
  }
LAB_101fca114:
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fca120);
  (*pcVar2)();
}

