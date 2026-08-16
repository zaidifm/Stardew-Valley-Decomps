/* 0x060072d9 StardewValley.Menus.CoopGameMenu+FriendFarmSlot.drawSlotOwnerName @ 0x1020a7a68 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_FriendFarmSlot_drawSlotOwnerName_060072d9
               (long param_1,undefined8 param_2,uint param_3)

{
  int *piVar1;
  int iVar2;
  int iVar3;
  char cVar4;
  code *pcVar5;
  undefined8 uVar6;
  long lVar7;
  long lVar8;
  long lVar9;
  undefined8 uVar10;
  float fVar11;
  
  cVar4 = cRam00000001039120e8;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039120e8 == '\0') goto LAB_1020a7bcc;
LAB_1020a7aa4:
    lVar7 = *(long *)(param_1 + 0x30);
  }
  else {
    func_0x00010119b8f8();
    if (cVar4 != '\0') goto LAB_1020a7aa4;
LAB_1020a7bcc:
    func_0x00010119b908(&UNK_10332fcd9);
    cRam00000001039120e8 = '\x01';
    lVar7 = *(long *)(param_1 + 0x30);
  }
  uVar6 = _UNK_1036edcb8;
  if (lVar7 != 0) {
    uVar10 = *(undefined8 *)(lVar7 + 0x18);
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    lVar7 = *(long *)(*(long *)(param_1 + 0x28) + 0x90);
    if (*(uint *)(lVar7 + 0x18) <= param_3) {
LAB_1020a7bfc:
      func_0x000100331b90();
                    /* WARNING: Does not return */
      pcVar5 = (code *)SoftwareBreakpoint(1,0x1020a7c04);
      (*pcVar5)();
    }
    lVar7 = *(long *)(lVar7 + 0x10);
    uVar6 = _UNK_1036edcd8;
    if (*(uint *)(lVar7 + 0x18) <= param_3) {
LAB_1020a7c9c:
      func_0x0001003316f4(0xcc,uVar6);
                    /* WARNING: Does not return */
      pcVar5 = (code *)SoftwareBreakpoint(1,0x1020a7ca8);
      (*pcVar5)();
    }
    lVar9 = (-(ulong)(param_3 >> 0x1f) & 0xfffffff800000000 | (ulong)param_3 << 3) + 0x20;
    lVar7 = *(long *)(lVar9 + lVar7);
    uVar6 = _UNK_1036edce0;
    if ((((lVar7 != 0) &&
         (piVar1 = (int *)(lVar7 + 0x38), uVar6 = _UNK_1036edce8, piVar1 != (int *)0x0)) &&
        (uVar6 = _UNK_1036edcf0, *(long *)(param_1 + 0x30) != 0)) &&
       (lVar7 = *plRam00000001038c4c90, uVar6 = _UNK_1036edcf8, lVar7 != 0)) {
      iVar2 = *piVar1;
      iVar3 = *(int *)(*(long *)(param_1 + 0x28) + 0x58);
      fVar11 = (float)func_0x0001003560e4(lVar7,*(undefined8 *)(*(long *)(param_1 + 0x30) + 0x18));
      lVar8 = *(long *)(*(long *)(param_1 + 0x28) + 0x90);
      if (*(uint *)(lVar8 + 0x18) <= param_3) goto LAB_1020a7bfc;
      lVar8 = *(long *)(lVar8 + 0x10);
      uVar6 = _UNK_1036edd18;
      if (*(uint *)(lVar8 + 0x18) <= param_3) goto LAB_1020a7c9c;
      lVar9 = *(long *)(lVar9 + lVar8);
      uVar6 = _UNK_1036edd20;
      if ((lVar9 != 0) && (uVar6 = _UNK_1036edd28, lVar9 != -0x38)) {
        StardewValley_StardewValley_Utility_drawTextWithShadow_06004232
                  ((float)(iVar2 + iVar3 + -0x80) - fVar11,(float)(*(int *)(lVar9 + 0x3c) + 0x2c),
                   0x3f800000,0xbf800000,0x3f800000,param_2,uVar10,lVar7,*puRam00000001038d5c70,
                   0xffffffff,0xffffffff,3);
        return;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar5 = (code *)SoftwareBreakpoint(1,0x1020a7cc8);
  (*pcVar5)();
}

