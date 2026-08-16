/* 0x06005dfd StardewValley.Menus.MobileCustomizer.DyeItem @ 0x101e06a30 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_DyeItem_06005dfd(long param_1,undefined4 param_2)

{
  code *pcVar1;
  long *plVar2;
  long lVar3;
  
  if (lRam0000000103976fb8 == 0) {
    plVar2 = *(long **)(param_1 + 0x1b0);
  }
  else {
    func_0x00010119b8f8();
    plVar2 = *(long **)(param_1 + 0x1b0);
  }
  if (plVar2 != (long *)0x0) {
    (**(code **)(*plVar2 + 0x358))(0x3f800000,plVar2,param_2);
    lVar3 = *(long *)(*(long *)(*(long *)(param_1 + 0x1a8) + 0x348) + 0x60);
    if (lVar3 == 0) {
      func_0x0001003316f4(0xee,_UNK_10369ef48);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101e06ae4);
      (*pcVar1)();
    }
    *(undefined2 *)(lVar3 + 0x61) = 0x101;
    *(undefined1 *)(lVar3 + 0x67) = 1;
    *(undefined1 *)(lVar3 + 99) = 1;
    *(undefined2 *)(lVar3 + 0x65) = 0x101;
  }
  return;
}

