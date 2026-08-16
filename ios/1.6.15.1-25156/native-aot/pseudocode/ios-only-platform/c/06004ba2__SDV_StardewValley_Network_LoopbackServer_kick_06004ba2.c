/* 0x06004ba2 StardewValley.Network.LoopbackServer.kick @ 0x101b4439c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer_kick_06004ba2(long *param_1,undefined8 param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  long *plVar4;
  undefined8 uVar5;
  
  cVar2 = cRam000000010390f9b1;
  if (lRam0000000103976fb8 == 0) {
    if (cRam000000010390f9b1 == '\0') goto LAB_101b4444c;
LAB_101b443cc:
    lVar3 = param_1[0xb];
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 != '\0') goto LAB_101b443cc;
LAB_101b4444c:
    func_0x00010119b908(&UNK_1032faa92);
    cRam000000010390f9b1 = '\x01';
    lVar3 = param_1[0xb];
  }
  uVar5 = _UNK_103654e30;
  if (lVar3 != 0) {
    cVar2 = func_0x00010036ce84(lVar3,param_2);
    if (cVar2 != '\0') {
      uVar5 = _UNK_103654e38;
      if ((param_1[0xb] == 0) ||
         (plVar4 = (long *)func_0x00010036ce98(param_1[0xb],param_2), uVar5 = _UNK_103654e40,
         plVar4 == (long *)0x0)) goto LAB_101b44494;
      *(undefined4 *)((long)plVar4 + 0x3c) = 7;
      (**(code **)(*plVar4 + 0x110))(plVar4,0);
      (**(code **)(*param_1 + 0x88))(param_1,param_2);
    }
    return;
  }
LAB_101b44494:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101b444a0);
  (*pcVar1)();
}

