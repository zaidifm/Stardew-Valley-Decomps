/* 0x06005dff StardewValley.Menus.MobileCustomizer.setUpSkinColorData @ 0x101e06c8c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_setUpSkinColorData_06005dff(long param_1)

{
  char cVar1;
  code *pcVar2;
  long *plVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  long lVar6;
  long lVar7;
  undefined1 auVar8 [16];
  undefined8 uStack_60;
  undefined8 uStack_58;
  undefined4 uStack_50;
  undefined4 uStack_48;
  undefined4 uStack_44;
  undefined4 uStack_40;
  undefined4 uStack_3c;
  undefined4 uStack_38;
  
  cVar1 = cRam0000000103910c0e;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103316c70);
    cRam0000000103910c0e = '\x01';
    plVar3 = (long *)StardewValley_StardewValley_Game1_get_temporaryContent_06002f98();
  }
  else {
    plVar3 = (long *)StardewValley_StardewValley_Game1_get_temporaryContent_06002f98();
  }
  uVar5 = _UNK_10369ef98;
  if ((plVar3 != (long *)0x0) &&
     (uVar4 = (**(code **)(*plVar3 + 0xa0))(plVar3,uRam00000001038e5b60), uVar5 = _UNK_10369efa0,
     param_1 != 0)) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x1b8) = uVar4;
    lVar7 = lRam00000001038c4be0;
    *(undefined1 *)((param_1 + 0x1b8U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    lVar6 = *(long *)(param_1 + 0x1b8);
    uVar5 = _UNK_10369efa8;
    if (lVar6 != 0) {
      uVar5 = func_0x000100331794(uRam00000001038d5600,
                                  (long)(*(int *)(lVar6 + 0x74) * *(int *)(lVar6 + 0x70)));
      DataMemoryBarrier(2,3);
      *(undefined8 *)(param_1 + 0x1c0) = uVar5;
      *(undefined1 *)((param_1 + 0x1c0U >> 9 & 0x7fffff) + lVar7) = 1;
      lVar7 = *(long *)(param_1 + 0x1b8);
      uVar5 = _UNK_10369efb0;
      if (lVar7 != 0) {
        auVar8 = func_0x000100355f2c(lVar7);
        uStack_44 = auVar8._0_4_;
        uStack_40 = auVar8._4_4_;
        uStack_3c = auVar8._8_4_;
        uStack_38 = auVar8._12_4_;
        uStack_48 = 1;
        uStack_58 = auVar8._4_8_;
        uStack_60 = CONCAT44(uStack_44,1);
        lVar6 = *(long *)(param_1 + 0x1c0);
        uStack_50 = uStack_38;
        uVar5 = _UNK_10369efb8;
        if (lVar6 != 0) {
          func_0x00010035d240(lVar7,0,&uStack_60,lVar6,0,*(undefined4 *)(lVar6 + 0x18));
          return;
        }
      }
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e06e14);
  (*pcVar2)();
}

