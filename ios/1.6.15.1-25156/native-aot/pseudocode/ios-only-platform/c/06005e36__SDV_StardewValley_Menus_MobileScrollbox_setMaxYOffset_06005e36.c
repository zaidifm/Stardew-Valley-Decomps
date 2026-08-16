/* 0x06005e36 StardewValley.Menus.MobileScrollbox.setMaxYOffset @ 0x101e1c034 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileScrollbox_setMaxYOffset_06005e36(long param_1,int param_2)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    *(undefined1 *)(param_1 + 0x49) = 0;
    if (param_2 == 0) {
      param_2 = 1;
    }
    *(int *)(param_1 + 100) = param_2;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036a2730);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1c068);
  (*pcVar1)();
}

