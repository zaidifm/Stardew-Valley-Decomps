/* 0x06004baa StardewValley.Network.LoopbackServer.clientDisconnect @ 0x101b44d38 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer_clientDisconnect_06004baa
               (long param_1,undefined8 param_2)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  undefined8 uVar5;
  long *plVar6;
  
  cVar3 = cRam000000010390f9b9;
  if (lRam0000000103976fb8 == 0) {
    if (cRam000000010390f9b9 == '\0') goto LAB_101b44df8;
LAB_101b44d68:
    lVar4 = *(long *)(param_1 + 0x50);
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 != '\0') goto LAB_101b44d68;
LAB_101b44df8:
    func_0x00010119b908(&UNK_1032fab19);
    cRam000000010390f9b9 = '\x01';
    lVar4 = *(long *)(param_1 + 0x50);
  }
  uVar5 = _UNK_103654f38;
  if (lVar4 == 0) {
LAB_101b44e40:
    func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101b44e4c);
    (*pcVar2)();
  }
  cVar3 = func_0x00010036cfb0(lVar4,param_2);
  if (cVar3 == '\0') {
    lVar4 = *(long *)(param_1 + 0x50);
    plVar6 = *(long **)(lVar4 + 0x10);
    *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
    uVar5 = _UNK_103654f48;
    if (plVar6 == (long *)0x0) goto LAB_101b44e40;
    uVar1 = *(uint *)(lVar4 + 0x18);
    if (uVar1 < *(uint *)(plVar6 + 3)) {
      *(uint *)(lVar4 + 0x18) = uVar1 + 1;
      (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,param_2);
    }
    else {
      func_0x00010036cdbc(lVar4,param_2);
    }
  }
  return;
}

