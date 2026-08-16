/* 0x06006023 StardewValley.Menus.CloudSyncMenu..ctor @ 0x101e60280 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CloudSyncMenu__ctor_06006023(long param_1)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  
  cVar2 = cRam0000000103910e32;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_10331a023);
    cRam0000000103910e32 = '\x01';
  }
  lVar4 = func_0x000100331820(uRam0000000103900358,0x20);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar4 + 0x10U) = *puRam0000000103900360;
  *(undefined1 *)((lVar4 + 0x10U >> 9 & 0x7fffff) + lVar1) = 1;
  if (param_1 != 0) {
    DataMemoryBarrier(2,3);
    *(long *)(param_1 + 0x68) = lVar4;
    *(undefined1 *)(((ulong)(param_1 + 0x68) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x20) = uRam00000001038d6940;
    *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
    SDV_StardewValley_Menus_CloudSyncMenu_SetupButtons_06006024(param_1);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036aa938);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101e60368);
  (*pcVar3)();
}

