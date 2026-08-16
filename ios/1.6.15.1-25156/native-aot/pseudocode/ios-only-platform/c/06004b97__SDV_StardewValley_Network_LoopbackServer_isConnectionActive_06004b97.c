/* 0x06004b97 StardewValley.Network.LoopbackServer.isConnectionActive @ 0x101b42e58 */

/* WARNING: Removing unreachable block (ram,0x000101b42fc0) */
/* WARNING: Removing unreachable block (ram,0x000101b42fa4) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1
SDV_StardewValley_Network_LoopbackServer_isConnectionActive_06004b97
          (long param_1,undefined8 param_2)

{
  long lVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  int iVar5;
  undefined8 uStack_70;
  undefined8 uStack_68;
  long lStack_60;
  undefined1 uStack_51;
  undefined8 uStack_50;
  undefined8 *puStack_48;
  
  cVar3 = cRam000000010390f9a6;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1032fa9a9);
    cRam000000010390f9a6 = '\x01';
  }
  uStack_70 = 0;
  uStack_68 = 0;
  lStack_60 = 0;
  uStack_51 = 0;
  uVar4 = _UNK_103654b68;
  if (*(long *)(param_1 + 0x48) != 0) {
    func_0x00010036ce5c(&uStack_70);
    while (cVar3 = func_0x00010036ce70(&uStack_70), lVar1 = lStack_60, cVar3 != '\0') {
      if (lStack_60 == 0) {
        func_0x0001003316f4(0xee,_UNK_103654b70);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101b42f28);
        (*pcVar2)();
      }
      cVar3 = func_0x000100345aa0(*(undefined8 *)(lStack_60 + 0x50),param_2);
      if ((cVar3 != '\0') && (*(long *)(lVar1 + 0x58) != 0)) {
        iVar5 = 1;
        uStack_51 = 1;
        goto LAB_101b42f84;
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    iVar5 = 2;
LAB_101b42f84:
    uStack_50 = 0;
    puStack_48 = &uStack_70;
    if (puStack_48 != (undefined8 *)0x0) {
      if (iVar5 != 1) {
        if (iVar5 != 2) {
          func_0x000100331c30();
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101b42ff0);
          (*pcVar2)();
        }
        uStack_51 = 0;
      }
      return uStack_51;
    }
    puStack_48 = (undefined8 *)0x0;
    uVar4 = _UNK_103654b78;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101b42f80);
  (*pcVar2)();
}

