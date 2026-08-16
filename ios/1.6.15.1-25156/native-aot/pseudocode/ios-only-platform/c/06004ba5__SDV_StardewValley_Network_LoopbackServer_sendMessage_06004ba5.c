/* 0x06004ba5 StardewValley.Network.LoopbackServer.sendMessage @ 0x101b448f4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer_sendMessage_06004ba5
               (long param_1,undefined8 param_2,undefined8 *param_3)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  undefined8 uStack_58;
  undefined8 uStack_50;
  undefined8 uStack_48;
  
  cVar2 = cRam000000010390f9b4;
  if (lRam0000000103976fb8 == 0) {
    if (cRam000000010390f9b4 == '\0') goto LAB_101b449ac;
LAB_101b44930:
    cVar2 = *(char *)(param_1 + 0x60);
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 != '\0') goto LAB_101b44930;
LAB_101b449ac:
    func_0x00010119b908(&UNK_1032faaf8);
    cRam000000010390f9b4 = '\x01';
    cVar2 = *(char *)(param_1 + 0x60);
  }
  if (cVar2 != '\0') {
    uVar3 = _UNK_103654ec8;
    if (*(long *)(param_1 + 0x58) == 0) {
LAB_101b449e8:
      func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101b449f4);
      (*pcVar1)();
    }
    cVar2 = func_0x00010036ce84(*(long *)(param_1 + 0x58),param_2);
    if (cVar2 != '\0') {
      uVar3 = _UNK_103654ed0;
      if (*(long *)(param_1 + 0x58) == 0) goto LAB_101b449e8;
      uVar3 = func_0x00010036ce98(*(long *)(param_1 + 0x58),param_2);
      uStack_50 = param_3[1];
      uStack_58 = *param_3;
      uStack_48 = param_3[2];
      SDV_StardewValley_Network_LoopbackServer_sendMessage_06004ba6(uVar3,uVar3,&uStack_58);
    }
  }
  return;
}

