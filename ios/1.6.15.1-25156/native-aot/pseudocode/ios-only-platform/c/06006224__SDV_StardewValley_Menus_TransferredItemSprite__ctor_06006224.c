/* 0x06006224 StardewValley.Menus.TransferredItemSprite..ctor @ 0x101ecd9e4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TransferredItemSprite__ctor_06006224
               (long param_1,undefined8 param_2,int param_3,int param_4)

{
  long lVar1;
  code *pcVar2;
  undefined8 uVar3;
  
  uVar3 = _UNK_1036b7070;
  if (param_1 != 0) {
    *(undefined4 *)(param_1 + 0x24) = 0x3f800000;
    lVar1 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x10) = param_2;
    *(undefined1 *)(((ulong)(param_1 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar3 = _UNK_1036b7078;
    if (param_1 != -0x18) {
      *(float *)(param_1 + 0x18) = (float)param_3;
      *(float *)(param_1 + 0x1c) = (float)param_4;
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101ecda54);
  (*pcVar2)();
}

