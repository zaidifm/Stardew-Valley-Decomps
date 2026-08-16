/* 0x06005e14 StardewValley.Menus.MobileCustomizer.ShowAdvancedOptions @ 0x101e13f64 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_ShowAdvancedOptions_06005e14(long param_1)

{
  long lVar1;
  undefined8 uVar2;
  char cVar3;
  code *pcVar4;
  long lVar5;
  long lVar6;
  long lVar7;
  
  cVar3 = cRam0000000103910c23;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103317110);
    cRam0000000103910c23 = '\x01';
  }
  lVar5 = func_0x000100331820(uRam00000001039005c0,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(long *)(lVar5 + 0x18) = param_1;
  *(undefined1 *)(((ulong)(lVar5 + 0x18) >> 9 & 0x7fffff) + lVar1) = 1;
  if (param_1 != 0) {
    *(int *)(param_1 + 100) = *(int *)(param_1 + 100) + 1;
    lVar6 = func_0x000100331820(uRam00000001039005c8,0xf8);
    StardewValley_StardewValley_Menus_AdvancedGameOptions__ctor_06005ebc();
    if (*(char *)(lRam00000001038d60b8 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar5 + 0x10) = *puRam00000001038d67d0;
    *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
    StardewValley_StardewValley_Menus_TitleMenu_set_subMenu_06006581(lVar6);
    lVar7 = func_0x000100331820(uRam00000001038f3cc0,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar7 + 0x20) = lVar5;
    *(undefined1 *)(((ulong)(lVar7 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar2 = uRam00000001039005d8;
    lVar5 = lRam00000001039005d0;
    *(long *)(lVar7 + 0x40) = lRam00000001039005d0;
    *(undefined8 *)(lVar7 + 0x28) = uVar2;
    *(undefined8 *)(lVar7 + 0x18) = *(undefined8 *)(lVar5 + 0x30);
    *(undefined8 *)(lVar7 + 0x10) = *(undefined8 *)(lVar5 + 0x28);
    DataMemoryBarrier(2,3);
    *(long *)(lVar6 + 0x30) = lVar7;
    *(undefined1 *)(((ulong)(lVar6 + 0x30) >> 9 & 0x7fffff) + lVar1) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036a15a8);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101e140d0);
  (*pcVar4)();
}

