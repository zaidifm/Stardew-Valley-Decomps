/* 0x06004ba0 StardewValley.Network.LoopbackServer.stopServer @ 0x101b43514 */

/* WARNING: Removing unreachable block (ram,0x000101b43980) */
/* WARNING: Removing unreachable block (ram,0x000101b43958) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Network_LoopbackServer_stopServer_06004ba0(long param_1)

{
  long lVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  code *pcVar4;
  char cVar5;
  undefined8 uVar6;
  undefined8 uStack_98;
  undefined8 uStack_90;
  long lStack_88;
  undefined8 uStack_80;
  undefined8 *puStack_78;
  int iStack_6c;
  long lStack_68;
  int iStack_5c;
  long lStack_58;
  int iStack_4c;
  long lStack_48;
  int iStack_3c;
  long lStack_38;
  
  cVar5 = cRam000000010390f9af;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar5 == '\0') {
    func_0x00010119b908(&UNK_1032faa10);
    cRam000000010390f9af = '\x01';
  }
  uStack_98 = 0;
  uStack_90 = 0;
  lStack_88 = 0;
  uVar6 = _UNK_103654c10;
  uVar3 = uStack_80;
  if (*(long *)(param_1 + 0x48) != 0) {
    func_0x00010036ce5c(&uStack_98);
    while (cVar5 = func_0x00010036ce70(&uStack_98), lVar1 = lStack_88, cVar5 != '\0') {
      if (lStack_88 == 0) {
        func_0x0001003316f4(0xee,_UNK_103654c18);
                    /* WARNING: Does not return */
        pcVar4 = (code *)SoftwareBreakpoint(1,0x101b435c4);
        (*pcVar4)();
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      SDV_StardewValley_Network_LoopbackClient_serverDisconnect_06004b91(lVar1);
    }
    uStack_80 = 0;
    uVar2 = uStack_80;
    puStack_78 = &uStack_98;
    uVar6 = _UNK_103654d10;
    uVar3 = uVar2;
    if (puStack_78 != (undefined8 *)0x0) {
      uStack_80 = 0;
      lStack_68 = *(long *)(param_1 + 0x20);
      iStack_6c = 0;
      uVar6 = _UNK_103654c20;
      uVar3 = uStack_80;
      if (((lStack_68 != 0) && (uVar6 = _UNK_103654c28, lStack_68 != 0)) &&
         (uVar6 = _UNK_103654c30, uVar3 = uVar2, lStack_68 != 0)) {
        *(int *)(lStack_68 + 0x1c) = *(int *)(lStack_68 + 0x1c) + 1;
        iStack_6c = *(int *)(lStack_68 + 0x18);
        *(undefined4 *)(lStack_68 + 0x18) = 0;
        if (0 < iStack_6c) {
          func_0x000100331c80(*(undefined8 *)(lStack_68 + 0x10),0,iStack_6c);
        }
        lStack_58 = *(long *)(param_1 + 0x48);
        iStack_5c = 0;
        uVar6 = _UNK_103654c40;
        uVar3 = uStack_80;
        if (((lStack_58 != 0) && (uVar6 = _UNK_103654c48, lStack_58 != 0)) &&
           (uVar6 = _UNK_103654c50, lStack_58 != 0)) {
          *(int *)(lStack_58 + 0x1c) = *(int *)(lStack_58 + 0x1c) + 1;
          iStack_5c = *(int *)(lStack_58 + 0x18);
          *(undefined4 *)(lStack_58 + 0x18) = 0;
          if (0 < iStack_5c) {
            func_0x000100331c80(*(undefined8 *)(lStack_58 + 0x10),0,iStack_5c);
          }
          lStack_48 = *(long *)(param_1 + 0x40);
          uVar6 = _UNK_103654c60;
          uVar3 = uStack_80;
          if (((lStack_48 != 0) && (uVar6 = _UNK_103654c68, lStack_48 != 0)) &&
             (uVar6 = _UNK_103654c70, lStack_48 != 0)) {
            *(int *)(lStack_48 + 0x1c) = *(int *)(lStack_48 + 0x1c) + 1;
            iStack_4c = *(int *)(lStack_48 + 0x18);
            *(undefined4 *)(lStack_48 + 0x18) = 0;
            if (0 < iStack_4c) {
              func_0x000100331c80(*(undefined8 *)(lStack_48 + 0x10),0,iStack_4c);
            }
            lStack_38 = *(long *)(param_1 + 0x50);
            uVar6 = _UNK_103654c80;
            uVar3 = uStack_80;
            if (((lStack_38 != 0) && (uVar6 = _UNK_103654c88, lStack_38 != 0)) &&
               (uVar6 = _UNK_103654c90, lStack_38 != 0)) {
              *(int *)(lStack_38 + 0x1c) = *(int *)(lStack_38 + 0x1c) + 1;
              iStack_3c = *(int *)(lStack_38 + 0x18);
              *(undefined4 *)(lStack_38 + 0x18) = 0;
              if (0 < iStack_3c) {
                func_0x000100331c80(*(undefined8 *)(lStack_38 + 0x10),0,iStack_3c);
              }
              uVar6 = _UNK_103654ca0;
              uVar3 = uStack_80;
              if (*(long *)(param_1 + 0x58) != 0) {
                func_0x00010036ceac();
                *(undefined1 *)(param_1 + 0x60) = 0;
                return;
              }
            }
          }
        }
      }
    }
  }
  uStack_80 = uVar3;
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101b4360c);
  (*pcVar4)();
}

