/* 0x06005daf StardewValley.Menus.CoopGameMenu.drawBefore @ 0x101df7c6c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_drawBefore_06005daf(long param_1)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    return;
  }
  func_0x0001003316f4(0xee,_UNK_10369cf98);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101df7c8c);
  (*pcVar1)();
}

