/* 0x06005dda StardewValley.Menus.HandPointer.draw @ 0x101e018a8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_HandPointer_draw_06005dda(long param_1,undefined8 param_2)

{
  code *pcVar1;
  long lVar2;
  
  if (lRam0000000103976fb8 == 0) {
    lVar2 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    lVar2 = *(long *)(param_1 + 0x18);
  }
  if (lVar2 != 0) {
    SDV_StardewValley_Menus_tweeningSprite_draw_06005e9f(lVar2,param_2);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_10369e7a8);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e01910);
  (*pcVar1)();
}

