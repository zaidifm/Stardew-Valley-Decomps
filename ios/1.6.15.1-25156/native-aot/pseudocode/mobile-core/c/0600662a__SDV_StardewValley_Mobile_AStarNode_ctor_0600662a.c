/* 0x0600662a StardewValley.Mobile.AStarNode..ctor @ 0x101fa77ec */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_AStarNode_ctor_0600662a
               (long param_1,undefined8 param_2,undefined4 param_3,undefined4 param_4)

{
  long lVar1;
  code *pcVar2;
  
  if (param_1 != 0) {
    *(undefined8 *)(param_1 + 0x3c) = 0xffffffffffffffff;
    lVar1 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x18U) = param_2;
    *(undefined1 *)((param_1 + 0x18U >> 9 & 0x7fffff) + lVar1) = 1;
    *(undefined4 *)(param_1 + 0x34) = param_3;
    *(undefined4 *)(param_1 + 0x38) = param_4;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d28a8);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa7838);
  (*pcVar2)();
}

