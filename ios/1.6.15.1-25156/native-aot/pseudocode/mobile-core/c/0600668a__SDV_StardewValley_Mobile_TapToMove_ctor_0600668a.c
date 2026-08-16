/* 0x0600668a StardewValley.Mobile.TapToMove..ctor @ 0x101fb107c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_ctor_0600668a(long param_1,undefined8 param_2)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  undefined8 uVar4;
  long lVar5;
  
  cVar1 = cRam0000000103911499;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033250d0);
    cRam0000000103911499 = '\x01';
  }
  lVar3 = func_0x000100331794(uRam00000001038c4dc0,0x2a);
  func_0x0001003321f8(lVar3 + 0x20,uRam0000000103904890,0xa8);
  uVar4 = func_0x000100331820(uRam00000001038ce878,0x20);
  func_0x00010036ffa8(uVar4,lVar3);
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x10) = uVar4;
    lVar3 = lRam00000001038c4be0;
    *(undefined1 *)(((ulong)(param_1 + 0x10) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
    uVar4 = func_0x000100331820(uRam0000000103904898,0x28);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x18) = uVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x18) >> 9 & 0x7fffff) + lVar3) = 1;
    *(undefined8 *)(param_1 + 0xe4) = 0xbf800000bf800000;
    *(undefined8 *)(param_1 + 0xec) = 0xbf800000bf800000;
    *(undefined8 *)(param_1 + 0x108) = 0xbf800000bf800000;
    *(undefined8 *)(param_1 + 0x110) = 0xbf800000bf800000;
    *(undefined1 *)(param_1 + 0xfa) = 1;
    *(undefined8 *)(param_1 + 0x128) = 0xffffffffffffffff;
    *(undefined8 *)(param_1 + 0x130) = 0xffffffffffffffff;
    lVar5 = func_0x000100331820(uRam00000001039048a0,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar5 + 0x10) = *puRam00000001039048a8;
    *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar3) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0xc0) = lVar5;
    *(undefined1 *)(((ulong)(param_1 + 0xc0) >> 9 & 0x7fffff) + lVar3) = 1;
    lVar5 = func_0x000100331820(uRam00000001039048b0,0x20);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(lVar5 + 0x10) = *puRam00000001039048b8;
    *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar3) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 200) = lVar5;
    *(undefined1 *)(((ulong)(param_1 + 200) >> 9 & 0x7fffff) + lVar3) = 1;
    if (*(char *)(lRam00000001038c7e00 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    *(undefined8 *)(param_1 + 0x158) = *puRam00000001038d4510;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x90) = param_2;
    *(undefined1 *)(((ulong)(param_1 + 0x90) >> 9 & 0x7fffff) + lVar3) = 1;
    SDV_StardewValley_Mobile_TapToMove_Init_0600668b(param_1,param_2);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036d3b30);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fb1274);
  (*pcVar2)();
}

