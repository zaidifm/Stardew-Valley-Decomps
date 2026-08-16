/* 0x06004b8e StardewValley.Network.LoopbackClient.receiveMessagesImpl @ 0x101b4262c */

/* WARNING: Removing unreachable block (ram,0x000101b4283c) */
/* WARNING: Removing unreachable block (ram,0x000101b42814) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackClient_receiveMessagesImpl_06004b8e(long *param_1)

{
  undefined8 uVar1;
  undefined8 uVar2;
  char cVar3;
  undefined8 uVar4;
  code *pcVar5;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  undefined8 uStack_60;
  undefined8 *puStack_58;
  int iStack_4c;
  long lStack_48;
  
  cVar3 = cRam000000010390f99d;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1032fa945);
    cRam000000010390f99d = '\x01';
  }
  uStack_78 = 0;
  uStack_70 = 0;
  uStack_68 = 0;
  uVar4 = _UNK_103654aa8;
  uVar2 = uStack_60;
  if (param_1[0xf] != 0) {
    func_0x00010036cde4(&uStack_78);
    while (cVar3 = func_0x00010036cdf8(&uStack_78), uVar4 = uStack_68, cVar3 != '\0') {
      if (param_1 == (long *)0x0) {
        func_0x0001003316f4(0xee,_UNK_103654ab0);
                    /* WARNING: Does not return */
        pcVar5 = (code *)SoftwareBreakpoint(1,0x101b426f0);
        (*pcVar5)();
      }
      pcVar5 = *(code **)(*param_1 + 200);
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      (*pcVar5)(param_1,uVar4);
    }
    uStack_60 = 0;
    uVar1 = uStack_60;
    puStack_58 = &uStack_78;
    uVar4 = _UNK_103654ae8;
    uVar2 = uVar1;
    if (puStack_58 != (undefined8 *)0x0) {
      uStack_60 = 0;
      lStack_48 = param_1[0xf];
      uVar4 = _UNK_103654ab8;
      uVar2 = uStack_60;
      if (((lStack_48 != 0) && (uVar4 = _UNK_103654ac0, lStack_48 != 0)) &&
         (uVar4 = _UNK_103654ac8, uVar2 = uVar1, lStack_48 != 0)) {
        *(int *)(lStack_48 + 0x1c) = *(int *)(lStack_48 + 0x1c) + 1;
        iStack_4c = *(int *)(lStack_48 + 0x18);
        *(undefined4 *)(lStack_48 + 0x18) = 0;
        if (0 < iStack_4c) {
          func_0x000100331c80(*(undefined8 *)(lStack_48 + 0x10),0,iStack_4c);
        }
        return;
      }
    }
  }
  uStack_60 = uVar2;
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x101b42738);
  (*pcVar5)();
}

