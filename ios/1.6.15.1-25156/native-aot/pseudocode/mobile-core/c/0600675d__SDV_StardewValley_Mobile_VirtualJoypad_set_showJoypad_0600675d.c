/* 0x0600675d StardewValley.Mobile.VirtualJoypad.set_showJoypad @ 0x101fd62a4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_set_showJoypad_0600675d(long param_1,char param_2)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 uVar5;
  undefined4 uVar6;
  
  if (lRam0000000103976fb8 == 0) {
    iVar1 = *(int *)(param_1 + 0x100);
  }
  else {
    func_0x00010119b8f8();
    iVar1 = *(int *)(param_1 + 0x100);
  }
  *(char *)(param_1 + 0x104) = param_2;
  if (iVar1 == -1) {
    lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
    param_2 = *(char *)(param_1 + 0x104);
    *(undefined4 *)(param_1 + 0x100) = *(undefined4 *)(lVar4 + 0x178);
    lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
    uVar5 = _UNK_1036d8ee8;
  }
  else {
    lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
    uVar5 = _UNK_1036d8ee8;
  }
  _UNK_1036d8ee8 = uVar5;
  if (param_2 == '\0') {
    *(undefined4 *)(param_1 + 0x100) = *(undefined4 *)(lVar4 + 0x178);
    lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
    uVar5 = _UNK_1036d8ef8;
    if (lVar4 == 0) goto LAB_101fd6380;
    uVar6 = 0;
  }
  else {
    if (lVar4 == 0) {
LAB_101fd6380:
      func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
      pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd638c);
      (*pcVar3)();
    }
    uVar6 = *(undefined4 *)(param_1 + 0x100);
  }
  *(undefined4 *)(lVar4 + 0x178) = uVar6;
  cVar2 = *(char *)(param_1 + 0x106);
  *(undefined1 *)(param_1 + 0x106) = 0;
  *(bool *)(param_1 + 0x105) = cVar2 != '\0';
  return;
}

