/* 0x06005e01 StardewValley.Menus.MobileCustomizer.setUpShirts @ 0x101e06f14 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_setUpShirts_06005e01(long param_1)

{
  char cVar1;
  code *pcVar2;
  long *plVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  
  cVar1 = cRam0000000103910c10;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103316c81);
    cRam0000000103910c10 = '\x01';
    plVar3 = (long *)StardewValley_StardewValley_Game1_get_temporaryContent_06002f98();
  }
  else {
    plVar3 = (long *)StardewValley_StardewValley_Game1_get_temporaryContent_06002f98();
  }
  uVar5 = _UNK_10369eff0;
  if ((plVar3 != (long *)0x0) &&
     (uVar4 = (**(code **)(*plVar3 + 0xa0))(plVar3,uRam00000001038fd320), uVar5 = _UNK_10369eff8,
     param_1 != 0)) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x1c8) = uVar4;
    *(undefined1 *)((param_1 + 0x1c8U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    return;
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e06fdc);
  (*pcVar2)();
}

