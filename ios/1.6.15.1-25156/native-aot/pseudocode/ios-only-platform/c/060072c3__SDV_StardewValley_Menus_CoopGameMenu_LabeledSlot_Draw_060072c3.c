/* 0x060072c3 StardewValley.Menus.CoopGameMenu+LabeledSlot.Draw @ 0x1020a69fc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_LabeledSlot_Draw_060072c3
               (long param_1,undefined8 param_2,uint param_3)

{
  char cVar1;
  code *pcVar2;
  int iVar3;
  int iVar4;
  undefined8 uVar5;
  undefined8 in_x6;
  long lVar6;
  
  cVar1 = cRam00000001039120d2;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332fc4f);
    cRam00000001039120d2 = '\x01';
    uVar5 = *(undefined8 *)(param_1 + 0x30);
  }
  else {
    uVar5 = *(undefined8 *)(param_1 + 0x30);
  }
  iVar3 = StardewValley_StardewValley_BellsAndWhistles_SpriteText_getWidthOfString_06005d29
                    (uVar5,999999);
  iVar4 = StardewValley_StardewValley_BellsAndWhistles_SpriteText_getHeightOfString_06005d2b
                    (*(undefined8 *)(param_1 + 0x30),999999);
  lVar6 = *(long *)(*(long *)(param_1 + 0x28) + 0x90);
  if (*(uint *)(lVar6 + 0x18) <= param_3) {
    func_0x000100331b90();
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a6b60);
    (*pcVar2)();
  }
  lVar6 = *(long *)(lVar6 + 0x10);
  if (*(uint *)(lVar6 + 0x18) <= param_3) {
    func_0x0001003316f4(0xcc,_UNK_1036edae8);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a6b80);
    (*pcVar2)();
  }
  lVar6 = *(long *)(lVar6 + (long)(int)param_3 * 8 + 0x20);
  if (lVar6 != 0) {
    iVar3 = *(int *)(lVar6 + 0x40) - iVar3;
    iVar4 = *(int *)(lVar6 + 0x44) - iVar4;
    if (iVar3 < 0) {
      iVar3 = iVar3 + 1;
    }
    if (iVar4 < 0) {
      iVar4 = iVar4 + 1;
    }
    StardewValley_StardewValley_BellsAndWhistles_SpriteText_drawString_06005d44
              (0x3f800000,0x3f6147ae,param_2,*(undefined8 *)(param_1 + 0x30),
               *(int *)(lVar6 + 0x38) + (iVar3 >> 1),*(int *)(lVar6 + 0x3c) + (iVar4 >> 1),999999,
               0xffffffff,in_x6,0,0xffffffff,uRam00000001038c4f58,0,0);
    return;
  }
  func_0x0001003316f4(0xee,_UNK_1036edae0);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x1020a6b94);
  (*pcVar2)();
}

