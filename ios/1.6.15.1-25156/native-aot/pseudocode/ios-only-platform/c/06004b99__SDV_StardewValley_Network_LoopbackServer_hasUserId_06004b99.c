/* 0x06004b99 StardewValley.Network.LoopbackServer.hasUserId @ 0x101b430e0 */

/* WARNING: Removing unreachable block (ram,0x000101b4324c) */
/* WARNING: Removing unreachable block (ram,0x000101b432ec) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1
SDV_StardewValley_Network_LoopbackServer_hasUserId_06004b99(long param_1,undefined8 param_2)

{
  long lVar1;
  code *pcVar2;
  char cVar3;
  long *plVar4;
  int iVar5;
  long lVar6;
  undefined1 uStack_49;
  
  cVar3 = cRam000000010390f9a8;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1032fa9d0);
    cRam000000010390f9a8 = '\x01';
  }
  uStack_49 = 0;
  lVar6 = *(long *)(*(long *)(param_1 + 0x58) + 0x18);
  plVar4 = *(long **)(lVar6 + 0x28);
  if (plVar4 == (long *)0x0) {
    plVar4 = (long *)func_0x000100331820(uRam00000001038f54d0,0x18);
    lVar1 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    plVar4[2] = lVar6;
    *(undefined1 *)(((ulong)(plVar4 + 2) >> 9 & 0x7fffff) + lVar1) = 1;
    DataMemoryBarrier(2,3);
    *(long *)(lVar6 + 0x28) = (long)plVar4;
    *(undefined1 *)(((ulong)(lVar6 + 0x28) >> 9 & 0x7fffff) + lVar1) = 1;
  }
  plVar4 = (long *)(**(code **)(*plVar4 + -0x10))();
  do {
    if (plVar4 == (long *)0x0) {
LAB_101b43218:
      func_0x0001003316f4(0xee,_UNK_103654bb8);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101b4322c);
      (*pcVar2)();
    }
    cVar3 = (**(code **)(*plVar4 + -0x78))();
    if (cVar3 == '\0') {
      iVar5 = 2;
      goto joined_r0x000101b43238;
    }
    if (((plVar4 == (long *)0x0) || (lVar6 = (**(code **)(*plVar4 + -0x38))(), lVar6 == 0)) ||
       (*(long *)(lVar6 + 0x50) == 0)) goto LAB_101b43218;
    cVar3 = func_0x000100353ad8(*(long *)(lVar6 + 0x50),param_2);
    if (lRam0000000103976fb8 != 0) {
      func_0x00010119b8f8();
    }
    if (cVar3 != '\0') {
      iVar5 = 1;
      uStack_49 = 1;
joined_r0x000101b43238:
      if (plVar4 != (long *)0x0) {
        if (plVar4 == (long *)0x0) {
          func_0x0001003316f4(0xee,_UNK_103654bc0);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101b432ac);
          (*pcVar2)();
        }
        (**(code **)(*plVar4 + -0x28))();
      }
      if (iVar5 != 1) {
        if (iVar5 != 2) {
          func_0x000100331c30();
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101b43328);
          (*pcVar2)();
        }
        uStack_49 = 0;
      }
      return uStack_49;
    }
  } while( true );
}

