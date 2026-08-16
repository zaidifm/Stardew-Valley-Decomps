/* 0x06005e53 StardewValley.Menus.TutorialItem.Target @ 0x101e1d01c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_Target_06005e53(long param_1,undefined8 param_2)

{
  long lVar1;
  code *pcVar2;
  
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 200) = 0;
    *(undefined1 *)(param_1 + 0xb4) = 1;
    lVar1 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0xa0) = param_2;
    *(undefined1 *)(((ulong)(param_1 + 0xa0) >> 9 & 0x7fffff) + lVar1) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036a28d8);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1d068);
  (*pcVar2)();
}

