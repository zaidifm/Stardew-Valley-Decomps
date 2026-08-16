/* 0x06005e65 StardewValley.Menus.TutorialManager..ctor @ 0x101e1e270 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager__ctor_06005e65(long param_1)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  
  cVar2 = cRam0000000103910c74;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033176f0);
    cRam0000000103910c74 = '\x01';
  }
  lVar4 = func_0x000100331820(uRam00000001039007a8,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10) = *puRam00000001039007b0;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x68) = lVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x68) >> 9 & 0x7fffff) + lVar1) = 1;
    uVar5 = func_0x000100331794(uRam00000001038c4dc0,0x33);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x70) = uVar5;
    *(undefined1 *)(((ulong)(param_1 + 0x70) >> 9 & 0x7fffff) + lVar1) = 1;
    *(undefined4 *)(param_1 + 0xa8) = 0xffffffff;
    lVar4 = func_0x000100331820(uRam00000001038ce990,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar4 + 0x10) = *puRam00000001038ce998;
    *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x88) = lVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x88) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x20) = uRam00000001038d6940;
    *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036a2a60);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101e1e3bc);
  (*pcVar3)();
}

