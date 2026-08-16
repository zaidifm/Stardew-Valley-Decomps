/* 0x06006025 StardewValley.Menus.CloudSyncMenu.snapToDefaultClickableComponent @ 0x101e6061c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CloudSyncMenu_snapToDefaultClickableComponent_06006025(long *param_1)

{
  code *pcVar1;
  long lVar2;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar2 = StardewValley_StardewValley_Menus_IClickableMenu_getComponentWithID_06006181(param_1,0);
  if (param_1 != (long *)0x0) {
    DataMemoryBarrier(2,3);
    param_1[9] = lVar2;
    *(undefined1 *)(((ulong)(param_1 + 9) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    (**(code **)(*param_1 + 0x168))(param_1);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036aa970);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101e606a0);
  (*pcVar1)();
}

