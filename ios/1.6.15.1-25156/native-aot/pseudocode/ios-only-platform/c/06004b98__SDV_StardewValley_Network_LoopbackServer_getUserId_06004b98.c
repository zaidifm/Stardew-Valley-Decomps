/* 0x06004b98 StardewValley.Network.LoopbackServer.getUserId @ 0x101b43000 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Network_LoopbackServer_getUserId_06004b98(long param_1,undefined8 param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  
  cVar2 = cRam000000010390f9a7;
  if (lRam0000000103976fb8 == 0) {
    if (cRam000000010390f9a7 == '\0') goto LAB_101b4308c;
LAB_101b43030:
    lVar3 = *(long *)(param_1 + 0x58);
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 != '\0') goto LAB_101b43030;
LAB_101b4308c:
    func_0x00010119b908(&UNK_1032fa9b6);
    cRam000000010390f9a7 = '\x01';
    lVar3 = *(long *)(param_1 + 0x58);
  }
  uVar4 = _UNK_103654b88;
  if (lVar3 == 0) {
LAB_101b430d4:
    func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101b430e0);
    (*pcVar1)();
  }
  cVar2 = func_0x00010036ce84(lVar3,param_2);
  if (cVar2 == '\0') {
    uVar4 = 0;
  }
  else {
    uVar4 = _UNK_103654b90;
    if (*(long *)(param_1 + 0x58) == 0) goto LAB_101b430d4;
    lVar3 = func_0x00010036ce98(*(long *)(param_1 + 0x58),param_2);
    uVar4 = *(undefined8 *)(lVar3 + 0x50);
  }
  return uVar4;
}

