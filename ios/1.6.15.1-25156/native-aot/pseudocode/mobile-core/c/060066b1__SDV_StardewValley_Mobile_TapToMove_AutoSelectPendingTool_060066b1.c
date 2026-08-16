/* 0x060066b1 StardewValley.Mobile.TapToMove.AutoSelectPendingTool @ 0x101fc315c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_AutoSelectPendingTool_060066b1(long param_1)

{
  undefined4 uVar1;
  undefined1 uVar2;
  uint uVar3;
  char cVar4;
  code *pcVar5;
  undefined8 uVar6;
  long lVar7;
  long lVar8;
  long lVar9;
  
  cVar4 = cRam00000001039114c0;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103325604);
    cRam00000001039114c0 = '\x01';
    lVar7 = *(long *)(param_1 + 0xd0);
  }
  else {
    lVar7 = *(long *)(param_1 + 0xd0);
  }
  if (lVar7 == 0) {
    return;
  }
  lVar9 = *(long *)(param_1 + 200);
  lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar1 = *(undefined4 *)(*(long *)(lVar7 + 0x450) + 0x68);
  lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar6 = _UNK_1036d6890;
  if (*(long *)(lVar7 + 0x468) != 0) {
    lVar8 = *(long *)(lVar9 + 0x10);
    uVar2 = *(undefined1 *)(*(long *)(lVar7 + 0x468) + 0x68);
    *(int *)(lVar9 + 0x1c) = *(int *)(lVar9 + 0x1c) + 1;
    uVar6 = _UNK_1036d68a0;
    if (lVar8 != 0) {
      uVar3 = *(uint *)(lVar9 + 0x18);
      if (uVar3 < *(uint *)(lVar8 + 0x18)) {
        *(uint *)(lVar9 + 0x18) = uVar3 + 1;
        if (*(uint *)(lVar8 + 0x18) <= uVar3) {
          func_0x0001003316f4(0xcc,_UNK_1036d68a8);
                    /* WARNING: Does not return */
          pcVar5 = (code *)SoftwareBreakpoint(1,0x101fc32c4);
          (*pcVar5)();
        }
        lVar8 = lVar8 + (long)(int)uVar3 * 8;
        *(undefined4 *)(lVar8 + 0x20) = uVar1;
        *(undefined1 *)(lVar8 + 0x24) = uVar2;
        *(undefined1 *)(lVar8 + 0x27) = 0;
        *(undefined2 *)(lVar8 + 0x25) = 0;
      }
      else {
        func_0x00010037ddc4(lVar9,(ulong)CONCAT14(uVar2,uVar1));
      }
      SDV_StardewValley_Mobile_TapToMoveUtils_SelectTool_060066d1(*(undefined8 *)(param_1 + 0xd0));
      *(undefined8 *)(param_1 + 0xd0) = 0;
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x101fc32b0);
  (*pcVar5)();
}

