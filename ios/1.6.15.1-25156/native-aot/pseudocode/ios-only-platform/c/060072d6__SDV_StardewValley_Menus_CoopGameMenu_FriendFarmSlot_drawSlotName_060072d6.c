/* 0x060072d6 StardewValley.Menus.CoopGameMenu+FriendFarmSlot.drawSlotName @ 0x1020a751c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_FriendFarmSlot_drawSlotName_060072d6
               (long *param_1,undefined8 param_2,uint param_3)

{
  char cVar1;
  code *pcVar2;
  undefined8 uVar3;
  undefined8 uVar4;
  undefined8 in_x6;
  long lVar5;
  
  cVar1 = cRam00000001039120e5;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332fcc1);
    cRam00000001039120e5 = '\x01';
    lVar5 = *param_1;
  }
  else {
    lVar5 = *param_1;
  }
  uVar3 = (**(code **)(lVar5 + 0xb8))(param_1);
  if (*(uint *)(*(long *)(param_1[5] + 0x90) + 0x18) <= param_3) {
    func_0x000100331b90();
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a7658);
    (*pcVar2)();
  }
  lVar5 = *(long *)(*(long *)(param_1[5] + 0x90) + 0x10);
  if (*(uint *)(lVar5 + 0x18) <= param_3) {
    func_0x0001003316f4(0xcc,_UNK_1036edc18);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a7678);
    (*pcVar2)();
  }
  lVar5 = *(long *)(lVar5 + (long)(int)param_3 * 8 + 0x20);
  uVar4 = _UNK_1036edc08;
  if ((lVar5 != 0) && (uVar4 = _UNK_1036edc10, (int *)(lVar5 + 0x38) != (int *)0x0)) {
    StardewValley_StardewValley_BellsAndWhistles_SpriteText_drawString_06005d44
              (0x3f800000,0x3f6147ae,param_2,uVar3,*(int *)(lVar5 + 0x38) + 0xa4,
               *(int *)(lVar5 + 0x3c) + 0x24,999999,0xffffffff,in_x6,0,0xffffffff,
               uRam00000001038c4f58,0,0);
    return;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a7698);
  (*pcVar2)();
}

