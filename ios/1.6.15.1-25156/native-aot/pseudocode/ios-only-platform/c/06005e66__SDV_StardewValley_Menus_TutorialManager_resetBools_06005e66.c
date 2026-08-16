/* 0x06005e66 StardewValley.Menus.TutorialManager.resetBools @ 0x101e1e3bc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_resetBools_06005e66(long param_1)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    *(undefined1 *)(param_1 + 0xce) = 0;
    *(undefined8 *)(param_1 + 0x80) = 0;
    *(undefined2 *)(param_1 + 0xb8) = 0;
    *(undefined8 *)(param_1 + 0xc4) = 0;
    *(undefined8 *)(param_1 + 0xa0) = 0;
    *(undefined8 *)(param_1 + 0x98) = 0;
    *(undefined8 *)(param_1 + 0xb0) = 0;
    *(undefined8 *)(param_1 + 0xa8) = 0;
    *(undefined8 *)(param_1 + 0xbc) = 0;
    *(undefined1 *)(param_1 + 0xcc) = 0;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036a2a68);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1e404);
  (*pcVar1)();
}

