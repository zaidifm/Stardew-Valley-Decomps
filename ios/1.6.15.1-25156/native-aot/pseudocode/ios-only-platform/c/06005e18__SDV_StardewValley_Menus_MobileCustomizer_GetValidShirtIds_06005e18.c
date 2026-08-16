/* 0x06005e18 StardewValley.Menus.MobileCustomizer.GetValidShirtIds @ 0x101e144dc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_GetValidShirtIds_06005e18(undefined8 param_1)

{
  long lVar1;
  long *plVar2;
  undefined8 uVar3;
  char cVar4;
  code *pcVar5;
  long lVar6;
  undefined8 uVar7;
  undefined8 uVar8;
  long lVar9;
  
  cVar4 = cRam0000000103910c27;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103317180);
    cRam0000000103910c27 = '\x01';
  }
  lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (*(long *)(lVar6 + 0x370) == 0) {
    func_0x0001003316f4(0xee,_UNK_1036a15e8);
                    /* WARNING: Does not return */
    pcVar5 = (code *)SoftwareBreakpoint(1,0x101e14634);
    (*pcVar5)();
  }
  uVar7 = *(undefined8 *)(*(long *)(lVar6 + 0x370) + 0x60);
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  lVar6 = *plRam0000000103900618;
  uVar8 = *puRam00000001038e50c8;
  if (lVar6 == 0) {
    lVar9 = *plRam0000000103900448;
    if (lVar9 == 0) {
      func_0x0001003316f4(0x69,_UNK_1036a15f0);
                    /* WARNING: Does not return */
      pcVar5 = (code *)SoftwareBreakpoint(1,0x101e14648);
      (*pcVar5)();
    }
    lVar6 = func_0x000100331820(uRam0000000103900628,0x80);
    lVar1 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    *(long *)(lVar6 + 0x20U) = lVar9;
    *(undefined1 *)((lVar6 + 0x20U >> 9 & 0x7fffff) + lVar1) = 1;
    uVar3 = uRam0000000103900638;
    lVar9 = lRam0000000103900630;
    *(long *)(lVar6 + 0x40) = lRam0000000103900630;
    *(undefined8 *)(lVar6 + 0x28) = uVar3;
    *(undefined8 *)(lVar6 + 0x18) = *(undefined8 *)(lVar9 + 0x30);
    plVar2 = plRam0000000103900618;
    *(undefined8 *)(lVar6 + 0x10) = *(undefined8 *)(lVar9 + 0x28);
    DataMemoryBarrier(2,3);
    *plVar2 = lVar6;
  }
  func_0x000100377cd0(param_1,uVar7,uVar8,lVar6);
  return;
}

