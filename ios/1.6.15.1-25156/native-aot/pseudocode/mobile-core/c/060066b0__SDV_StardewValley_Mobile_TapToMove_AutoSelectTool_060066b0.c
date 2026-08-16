/* 0x060066b0 StardewValley.Mobile.TapToMove.AutoSelectTool @ 0x101fc30dc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_Mobile_TapToMove_AutoSelectTool_060066b0(long param_1,undefined8 param_2)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  cVar2 = SDV_StardewValley_Mobile_TapToMoveUtils_PlayerHasTool_060066d2(param_2);
  if (cVar2 == '\0') {
    uVar3 = 0;
  }
  else {
    if (param_1 == 0) {
      func_0x0001003316f4(0xee,_UNK_1036d6868);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc315c);
      (*pcVar1)();
    }
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0xd0) = param_2;
    uVar3 = 1;
    *(undefined1 *)(((ulong)(param_1 + 0xd0) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  }
  return uVar3;
}

