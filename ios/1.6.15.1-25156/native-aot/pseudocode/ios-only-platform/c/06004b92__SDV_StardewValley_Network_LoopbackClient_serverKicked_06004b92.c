/* 0x06004b92 StardewValley.Network.LoopbackClient.serverKicked @ 0x101b42ab8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackClient_serverKicked_06004b92(long *param_1)

{
  code *pcVar1;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_1 == (long *)0x0) {
    func_0x0001003316f4(0xee,_UNK_103654b40);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101b42b1c);
    (*pcVar1)();
  }
  *(undefined4 *)((long)param_1 + 0x3c) = 7;
  (**(code **)(*param_1 + 0x110))(param_1,0);
  return;
}

