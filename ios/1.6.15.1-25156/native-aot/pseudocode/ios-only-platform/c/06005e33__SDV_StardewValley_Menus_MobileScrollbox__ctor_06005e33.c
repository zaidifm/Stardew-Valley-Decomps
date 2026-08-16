/* 0x06005e33 StardewValley.Menus.MobileScrollbox..ctor @ 0x101e1bac4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileScrollbox__ctor_06005e33
               (long param_1,undefined4 param_2,undefined4 param_3,undefined4 param_4,
               undefined4 param_5,int param_6,undefined8 param_7,undefined8 param_8,
               undefined8 param_9)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  undefined8 uVar4;
  
  cVar2 = cRam0000000103910c42;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103317560);
    cRam0000000103910c42 = '\x01';
  }
  uVar4 = _UNK_1036a26e8;
  if ((param_1 != 0) && (uVar4 = _UNK_1036a26f0, param_1 != -0x28)) {
    *(undefined4 *)(param_1 + 0x28) = param_2;
    *(undefined4 *)(param_1 + 0x2c) = param_3;
    *(undefined4 *)(param_1 + 0x30) = param_4;
    *(undefined4 *)(param_1 + 0x34) = param_5;
    *(undefined8 *)(param_1 + 0x38) = param_7;
    *(undefined8 *)(param_1 + 0x40) = param_8;
    lVar1 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x10U) = param_9;
    *(undefined1 *)((param_1 + 0x10U >> 9 & 0x7fffff) + lVar1) = 1;
    uVar4 = func_0x000100331794(uRam00000001038eea40,8);
    if (param_6 == 0) {
      param_6 = 1;
    }
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x18) = uVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x18) >> 9 & 0x7fffff) + lVar1) = 1;
    *(undefined1 *)(param_1 + 0x4a) = 0;
    *(undefined4 *)(param_1 + 0x60) = 0;
    *(int *)(param_1 + 100) = param_6;
    if (*(char *)(lRam00000001038d78f0 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar4 = func_0x000100331870(lRam00000001038d78f0);
    func_0x000100367790();
    func_0x0001003677a4(uVar4,1);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x20) = uVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    return;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1bc2c);
  (*pcVar3)();
}

