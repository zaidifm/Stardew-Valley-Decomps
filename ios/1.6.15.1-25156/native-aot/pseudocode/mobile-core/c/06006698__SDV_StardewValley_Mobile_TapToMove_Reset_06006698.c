/* 0x06006698 StardewValley.Mobile.TapToMove.Reset @ 0x101fb15b4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_Reset_06006698(long param_1,char param_2)

{
  undefined4 uVar1;
  code *pcVar2;
  undefined8 uVar3;
  long lVar4;
  
  uVar3 = _UNK_1036d3bb0;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
    uVar3 = _UNK_1036d3bb0;
  }
  _UNK_1036d3bb0 = uVar3;
  if (param_1 == 0) {
LAB_101fb16f8:
    func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101fb1704);
    (*pcVar2)();
  }
  lVar4 = *(long *)(param_1 + 0x40);
  *(undefined4 *)(param_1 + 0x124) = 0;
  *(undefined1 *)(param_1 + 0xf9) = 0;
  *(undefined8 *)(param_1 + 0x128) = 0xffffffffffffffff;
  *(undefined8 *)(param_1 + 0x130) = 0xffffffffffffffff;
  if (lVar4 != 0) {
    *(undefined1 *)(lVar4 + 0x45) = 0;
  }
  *(long *)(param_1 + 0x40) = 0;
  *(undefined8 *)(param_1 + 0x48) = 0;
  *(undefined8 *)(param_1 + 0x60) = 0;
  *(undefined8 *)(param_1 + 0x68) = 0;
  *(undefined4 *)(param_1 + 0x120) = 0;
  *(undefined8 *)(param_1 + 0xe4) = 0xbf800000bf800000;
  *(undefined8 *)(param_1 + 0x108) = 0xbf800000bf800000;
  *(undefined8 *)(param_1 + 0x110) = 0xbf800000bf800000;
  *(undefined8 *)(param_1 + 0x118) = 0;
  if (param_2 != '\0') {
    lVar4 = *(long *)(param_1 + 0x18);
    *(undefined1 *)(lVar4 + 0x18) = 0;
    uVar1 = *(undefined4 *)(lVar4 + 0x21);
    *(undefined4 *)(lVar4 + 0x19) = 0;
    *(undefined4 *)(lVar4 + 0x21) = 0;
    *(undefined4 *)(lVar4 + 0x1d) = uVar1;
    *(undefined4 *)(lVar4 + 0x14) = 0x10000;
  }
  *(undefined2 *)(param_1 + 0xf5) = 0;
  *(undefined1 *)(param_1 + 0xf8) = 0;
  *(undefined2 *)(param_1 + 0x102) = 0;
  *(undefined4 *)(param_1 + 0x13c) = 0;
  *(undefined8 *)(param_1 + 0x20) = 0;
  *(undefined1 *)(param_1 + 0xfc) = 0;
  *(undefined1 *)(param_1 + 0x100) = 0;
  *(undefined8 *)(param_1 + 0x80) = 0;
  *(undefined8 *)(param_1 + 0x88) = 0;
  *(undefined8 *)(param_1 + 0x78) = 0;
  *(undefined8 *)(param_1 + 0xb0) = 0;
  *(undefined8 *)(param_1 + 0xb8) = 0;
  *(undefined8 *)(param_1 + 0xa8) = 0;
  lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (*(long *)(*(long *)(lVar4 + 0x5c0) + 0x60) != 0) {
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    lVar4 = *(long *)(*(long *)(lVar4 + 0x5c0) + 0x60);
    uVar3 = _UNK_1036d3bd8;
    if (lVar4 == 0) goto LAB_101fb16f8;
    *(undefined1 *)(lVar4 + 0x476) = 1;
  }
  return;
}

