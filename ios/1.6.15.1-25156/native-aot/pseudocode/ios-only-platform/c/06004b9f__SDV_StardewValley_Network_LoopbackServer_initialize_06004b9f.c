/* 0x06004b9f StardewValley.Network.LoopbackServer.initialize @ 0x101b434e8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer_initialize_06004b9f(long param_1)

{
  code *pcVar1;
  
  if (param_1 != 0) {
    *(undefined1 *)(param_1 + 0x60) = 1;
    return;
  }
  func_0x0001003316f4(0xee,_UNK_103654c00);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101b43514);
  (*pcVar1)();
}

