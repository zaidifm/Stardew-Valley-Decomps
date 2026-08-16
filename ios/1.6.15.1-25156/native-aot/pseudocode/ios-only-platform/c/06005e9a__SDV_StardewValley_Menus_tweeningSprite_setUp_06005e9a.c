/* 0x06005e9a StardewValley.Menus.tweeningSprite.setUp @ 0x101e240d8 */

void SDV_StardewValley_Menus_tweeningSprite_setUp_06005e9a
               (undefined4 param_1,undefined4 param_2,undefined4 param_3,undefined4 param_4,
               undefined4 param_5,long param_6)

{
  long lVar1;
  undefined8 uVar2;
  long *plVar3;
  char cVar4;
  long lVar5;
  long lVar6;
  
  cVar4 = cRam0000000103910ca9;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_103317bc0);
    cRam0000000103910ca9 = '\x01';
    *(undefined4 *)(param_6 + 0x34) = param_1;
    *(undefined4 *)(param_6 + 0x38) = param_2;
  }
  else {
    *(undefined4 *)(param_6 + 0x34) = param_1;
    *(undefined4 *)(param_6 + 0x38) = param_2;
  }
  *(undefined4 *)(param_6 + 0x3c) = param_3;
  *(undefined4 *)(param_6 + 0x40) = param_4;
  *(undefined4 *)(param_6 + 0x44) = param_5;
  *(undefined1 *)(param_6 + 0x30) = 0;
  lVar6 = *plRam0000000103900a60;
  if (lVar6 == 0) {
    lVar6 = func_0x000100331820(uRam00000001038d4fc8,0x80);
    uVar2 = uRam00000001038d4fd8;
    lVar1 = lRam00000001038d4fd0;
    *(long *)(lVar6 + 0x40) = lRam00000001038d4fd0;
    *(undefined8 *)(lVar6 + 0x28) = uVar2;
    *(undefined8 *)(lVar6 + 0x18) = *(undefined8 *)(lVar1 + 0x30);
    plVar3 = plRam0000000103900a60;
    *(undefined8 *)(lVar6 + 0x10) = *(undefined8 *)(lVar1 + 0x28);
    DataMemoryBarrier(2,3);
    *plVar3 = lVar6;
  }
  lVar5 = func_0x000100331820(uRam0000000103900a68,0x48);
  lVar1 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(long *)(lVar5 + 0x10) = lVar6;
  *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  *(undefined4 *)(lVar5 + 0x28) = 2;
  DataMemoryBarrier(2,3);
  *(long *)(param_6 + 0x10) = lVar5;
  *(undefined1 *)(((ulong)(param_6 + 0x10) >> 9 & 0x7fffff) + lVar1) = 1;
  *(undefined8 *)(param_6 + 0x28) = 0;
  return;
}

