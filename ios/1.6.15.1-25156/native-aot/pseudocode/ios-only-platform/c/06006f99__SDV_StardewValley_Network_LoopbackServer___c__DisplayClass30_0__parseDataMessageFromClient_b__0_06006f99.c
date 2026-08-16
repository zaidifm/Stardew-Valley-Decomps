/* 0x06006f99 StardewValley.Network.LoopbackServer+<>c__DisplayClass30_0.<parseDataMessageFromClient>b__0 @ 0x10206977c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer___c__DisplayClass30_0__parseDataMessageFromClient_b__0_06006f99
               (long param_1,undefined8 *param_2)

{
  code *pcVar1;
  long lVar2;
  undefined8 uStack_38;
  undefined8 uStack_30;
  undefined8 uStack_28;
  
  lVar2 = param_1;
  if (lRam0000000103976fb8 != 0) {
    lVar2 = func_0x00010119b8f8();
  }
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036e6930);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x1020697ec);
    (*pcVar1)();
  }
  uStack_30 = param_2[1];
  uStack_38 = *param_2;
  uStack_28 = param_2[2];
  SDV_StardewValley_Network_LoopbackServer_sendMessage_06004ba6
            (lVar2,*(undefined8 *)(param_1 + 0x18),&uStack_38);
  return;
}

