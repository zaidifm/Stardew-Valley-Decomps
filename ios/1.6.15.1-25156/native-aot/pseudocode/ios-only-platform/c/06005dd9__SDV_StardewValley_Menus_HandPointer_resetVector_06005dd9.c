/* 0x06005dd9 StardewValley.Menus.HandPointer.resetVector @ 0x101e01818 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_HandPointer_resetVector_06005dd9
               (undefined4 param_1,undefined4 param_2,undefined4 param_3,undefined4 param_4,
               long param_5)

{
  code *pcVar1;
  long lVar2;
  
  if (lRam0000000103976fb8 == 0) {
    lVar2 = *(long *)(param_5 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    lVar2 = *(long *)(param_5 + 0x18);
  }
  if (lVar2 != 0) {
    SDV_StardewValley_Menus_tweeningSprite_resetVector_06005e9b(param_1,param_2,param_3,param_4);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_10369e798);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e018a8);
  (*pcVar1)();
}

