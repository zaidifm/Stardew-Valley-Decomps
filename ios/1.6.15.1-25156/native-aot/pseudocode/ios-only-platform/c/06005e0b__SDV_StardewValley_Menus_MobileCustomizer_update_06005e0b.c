/* 0x06005e0b StardewValley.Menus.MobileCustomizer.update @ 0x101e0eb90 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_update_06005e0b(long param_1)

{
  code *pcVar1;
  char cVar2;
  undefined4 uVar3;
  long lVar4;
  undefined8 uVar5;
  
  cVar2 = cRam0000000103910c1a;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910c1a == '\0') goto LAB_101e0ecf4;
LAB_101e0ebbc:
    lVar4 = *(long *)(param_1 + 0x120);
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 != '\0') goto LAB_101e0ebbc;
LAB_101e0ecf4:
    func_0x00010119b908(&UNK_103316fe0);
    cRam0000000103910c1a = '\x01';
    lVar4 = *(long *)(param_1 + 0x120);
  }
  if (lVar4 != 0) {
    uVar3 = SDV_StardewValley_Menus_MobileColorPicker_getSelectedColor_06005dee();
    lVar4 = *(long *)(param_1 + 0x120);
    uVar5 = _UNK_1036a04b8;
    if (lVar4 == 0) goto LAB_101e0ede4;
    if (*(char *)(lVar4 + 0xb8) != '\0') {
      cVar2 = func_0x000100350464(*(undefined4 *)(lVar4 + 0xb4),uVar3);
      if (cVar2 != '\0') {
        (**(code **)(*(long *)(param_1 + 0x130) + 0x18))();
        lVar4 = *(long *)(param_1 + 0x120);
        uVar5 = _UNK_1036a04d0;
        if (lVar4 == 0) goto LAB_101e0ede4;
        uVar3 = SDV_StardewValley_Menus_MobileColorPicker_getSelectedColor_06005dee(lVar4);
        *(undefined4 *)(lVar4 + 0xb4) = uVar3;
        *(undefined1 *)(*(long *)(param_1 + 0x120) + 0xb8) = 0;
        *(undefined8 *)(param_1 + 0x120) = 0;
        goto LAB_101e0ec2c;
      }
      lVar4 = *(long *)(param_1 + 0x120);
      uVar5 = _UNK_1036a04c0;
      if (lVar4 == 0) goto LAB_101e0ede4;
    }
    *(undefined4 *)(lVar4 + 0xb4) = uVar3;
  }
LAB_101e0ec2c:
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar5 = _UNK_1036a0460;
  if (*(long *)(lVar4 + 0x58) == 0) {
LAB_101e0ede4:
    func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101e0edf0);
    (*pcVar1)();
  }
  cVar2 = func_0x000100345aa0(*(undefined8 *)(*(long *)(lVar4 + 0x58) + 0x60),uRam00000001038c4f58);
  if (cVar2 != '\0') {
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar5 = _UNK_1036a04b0;
    if (*(long *)(lVar4 + 0x58) == 0) goto LAB_101e0ede4;
    func_0x000100354118(*(long *)(lVar4 + 0x58),*(undefined8 *)(param_1 + 0x188));
  }
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  cVar2 = func_0x000100345aa0(*(undefined8 *)(*(long *)(lVar4 + 0x2a8) + 0x60),uRam00000001038c4f58)
  ;
  if (cVar2 != '\0') {
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar5 = _UNK_1036a04a0;
    if (*(long *)(lVar4 + 0x2a8) == 0) goto LAB_101e0ede4;
    func_0x000100354118(*(long *)(lVar4 + 0x2a8),*(undefined8 *)(param_1 + 400));
  }
  if (*(long *)(param_1 + 0xe8) != 0) {
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    cVar2 = func_0x000100345aa0(*(undefined8 *)(*(long *)(lVar4 + 0x2a0) + 0x60),
                                uRam00000001038c4f58);
    if (cVar2 != '\0') {
      lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar5 = _UNK_1036a0490;
      if (*(long *)(lVar4 + 0x2a0) == 0) goto LAB_101e0ede4;
      func_0x000100354118(*(long *)(lVar4 + 0x2a0),*(undefined8 *)(param_1 + 0x198));
    }
  }
  return;
}

