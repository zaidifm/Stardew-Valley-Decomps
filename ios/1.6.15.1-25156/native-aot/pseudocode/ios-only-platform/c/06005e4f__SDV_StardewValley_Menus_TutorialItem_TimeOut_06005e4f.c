/* 0x06005e4f StardewValley.Menus.TutorialItem.TimeOut @ 0x101e1cd10 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_TimeOut_06005e4f(float param_1,long param_2)

{
  code *pcVar1;
  
  if (param_2 != 0) {
    *(float *)(param_2 + 0xd0) = param_1;
    *(bool *)(param_2 + 0xb3) = 0.0 < param_1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036a2870);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e1cd44);
  (*pcVar1)();
}

