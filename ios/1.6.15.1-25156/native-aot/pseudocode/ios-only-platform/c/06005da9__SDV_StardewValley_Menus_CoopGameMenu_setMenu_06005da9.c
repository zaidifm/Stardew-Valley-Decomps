/* 0x06005da9 StardewValley.Menus.CoopGameMenu.setMenu @ 0x101df75e4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_setMenu_06005da9(undefined8 param_1,long param_2)

{
  long lVar1;
  long lVar2;
  undefined8 uVar3;
  char cVar4;
  code *pcVar5;
  undefined8 *puVar6;
  long lVar7;
  
  cVar4 = cRam0000000103910bb8;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103316550);
    cRam0000000103910bb8 = '\x01';
    puVar6 = (undefined8 *)SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
  }
  else {
    puVar6 = (undefined8 *)SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
  }
  if ((puVar6 == (undefined8 *)0x0) ||
     (lRam00000001038d67d8 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10))) {
    SDV_StardewValley_Game1_set_activeClickableMenu_06002fe2(param_2);
  }
  else {
    StardewValley_StardewValley_Menus_TitleMenu_set_subMenu_06006581(param_2);
    lVar7 = func_0x000100331820(uRam00000001038f3cc0,0x80);
    lVar1 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    *(long *)(lVar7 + 0x20) = (long)puVar6;
    *(undefined1 *)(((ulong)(lVar7 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar3 = uRam0000000103900180;
    lVar2 = lRam0000000103900178;
    *(long *)(lVar7 + 0x40) = lRam0000000103900178;
    *(undefined8 *)(lVar7 + 0x28) = uVar3;
    *(undefined8 *)(lVar7 + 0x18) = *(undefined8 *)(lVar2 + 0x30);
    *(undefined8 *)(lVar7 + 0x10) = *(undefined8 *)(lVar2 + 0x28);
    if (param_2 == 0) {
      func_0x0001003316f4(0xee,_UNK_10369cf28);
                    /* WARNING: Does not return */
      pcVar5 = (code *)SoftwareBreakpoint(1,0x101df7708);
      (*pcVar5)();
    }
    DataMemoryBarrier(2,3);
    *(long *)(param_2 + 0x30) = lVar7;
    *(undefined1 *)(((ulong)(param_2 + 0x30) >> 9 & 0x7fffff) + lVar1) = 1;
  }
  return;
}

