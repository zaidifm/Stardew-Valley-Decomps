/* 0x060072d7 StardewValley.Menus.CoopGameMenu+FriendFarmSlot.drawSlotDate @ 0x1020a7698 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_FriendFarmSlot_drawSlotDate_060072d7
               (long param_1,undefined8 param_2,uint param_3)

{
  char cVar1;
  code *pcVar2;
  undefined8 uVar3;
  undefined8 uVar4;
  long lVar5;
  
  cVar1 = cRam00000001039120e6;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332fcc8);
    cRam00000001039120e6 = '\x01';
    lVar5 = *(long *)(param_1 + 0x30);
  }
  else {
    lVar5 = *(long *)(param_1 + 0x30);
  }
  uVar4 = _UNK_1036edc30;
  if (*(long *)(lVar5 + 0x28) != 0) {
    uVar3 = StardewValley_StardewValley_WorldDate_Localize_060042d3();
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0(lRam00000001038c4c88);
    }
    lVar5 = *(long *)(*(long *)(param_1 + 0x28) + 0x90);
    if (*(uint *)(lVar5 + 0x18) <= param_3) {
      func_0x000100331b90();
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a7804);
      (*pcVar2)();
    }
    lVar5 = *(long *)(lVar5 + 0x10);
    if (*(uint *)(lVar5 + 0x18) <= param_3) {
      func_0x0001003316f4(0xcc,_UNK_1036edc60);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a7824);
      (*pcVar2)();
    }
    lVar5 = *(long *)(lVar5 + (long)(int)param_3 * 8 + 0x20);
    uVar4 = _UNK_1036edc50;
    if ((lVar5 != 0) && (uVar4 = _UNK_1036edc58, (int *)(lVar5 + 0x38) != (int *)0x0)) {
      StardewValley_StardewValley_Utility_drawTextWithShadow_06004232
                ((float)(*(int *)(lVar5 + 0x38) + 0xa0),(float)(*(int *)(lVar5 + 0x3c) + 0x68),
                 0x3f800000,0xbf800000,0x3f800000,param_2,uVar3,*puRam00000001038c4c90,
                 *puRam00000001038d5c70,0xffffffff,0xffffffff,3);
      return;
    }
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a7844);
  (*pcVar2)();
}

