/* 0x06005e4b StardewValley.Menus.TutorialItem..ctor @ 0x101e1ca98 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem__ctor_06005e4b(long param_1,undefined4 param_2)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  
  cVar2 = cRam0000000103910c5a;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033175d0);
    cRam0000000103910c5a = '\x01';
  }
  lVar4 = func_0x000100331820(uRam00000001038ce9b8,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038ce9c0;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x68) = lVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x68) >> 9 & 0x7fffff) + lVar1) = 1;
    lVar4 = func_0x000100331820(uRam00000001038ce9b8,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038ce9c0;
    *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x70) = lVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x70) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x88) = uRam00000001038c4f58;
    *(undefined1 *)(((ulong)(param_1 + 0x88) >> 9 & 0x7fffff) + lVar1) = 1;
    *(undefined8 *)(param_1 + 0xb8) = 0xffffffffffffffff;
    *(undefined8 *)(param_1 + 0xc0) = 0xffffffffffffffff;
    *(undefined4 *)(param_1 + 200) = 0xffffffff;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0xa8) = uRam00000001038c4f58;
    *(undefined1 *)(((ulong)(param_1 + 0xa8) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x20) = uRam00000001038d6940;
    *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    *(undefined4 *)(param_1 + 0xcc) = param_2;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036a2850);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1cc04);
  (*pcVar3)();
}

