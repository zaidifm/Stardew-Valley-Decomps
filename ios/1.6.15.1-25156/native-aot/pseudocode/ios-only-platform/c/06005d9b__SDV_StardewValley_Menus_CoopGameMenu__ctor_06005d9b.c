/* 0x06005d9b StardewValley.Menus.CoopGameMenu..ctor @ 0x101df6714 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu__ctor_06005d9b
               (long param_1,undefined1 param_2,undefined8 param_3)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  int iVar6;
  
  cVar2 = cRam0000000103910baa;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103316430);
    cRam0000000103910baa = '\x01';
  }
  lVar4 = func_0x000100331820(uRam0000000103900098,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10) = *puRam00000001039000a0;
  *(undefined1 *)(((ulong)(lVar4 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  uVar5 = _UNK_10369cdd8;
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x178) = lVar4;
    *(undefined1 *)((param_1 + 0x178U >> 9 & 0x7fffff) + lVar1) = 1;
    uVar5 = func_0x000100331820(uRam00000001038c4d88,0x30);
    func_0x000100331c58();
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x1a8) = uVar5;
    *(undefined1 *)((param_1 + 0x1a8U >> 9 & 0x7fffff) + lVar1) = 1;
    StardewValley_StardewValley_Menus_LoadGameMenu__ctor_060062c5(param_1,param_3);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    lVar4 = lRam00000001038d5380;
    uVar5 = _UNK_10369cde8;
    if ((lRam00000001038d5380 != -8) && (uVar5 = _UNK_10369cde0, lRam00000001038d5380 != 0)) {
      *(float *)(param_1 + 0x1c4) = (float)*(int *)(lRam00000001038d5380 + 8) / 1280.0;
      iVar6 = *(int *)(lVar4 + 0xc);
      *(undefined1 *)(param_1 + 0x1c0) = param_2;
      *(float *)(param_1 + 0x1c8) = (float)iVar6 / 720.0;
      DataMemoryBarrier(2,3);
      *(undefined8 *)(param_1 + 0x1a0) = param_3;
      *(undefined1 *)((param_1 + 0x1a0U >> 9 & 0x7fffff) + lVar1) = 1;
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101df68b0);
  (*pcVar3)();
}

