/* 0x06005e98 StardewValley.Menus.tweeningSprite..ctor @ 0x101e23cec */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_tweeningSprite__ctor_06005e98
               (undefined4 param_1,undefined4 param_2,undefined4 param_3,undefined4 param_4,
               undefined4 param_5,undefined4 param_6,long param_7,long param_8,long param_9,
               undefined1 param_10,long param_11)

{
  undefined8 uVar1;
  undefined8 uVar2;
  undefined8 uVar3;
  undefined8 uVar4;
  long lVar5;
  char cVar6;
  code *pcVar7;
  undefined8 uVar8;
  undefined8 uVar9;
  
  cVar6 = cRam0000000103910ca7;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar6 == '\0') {
    func_0x00010119b908(&UNK_103317b94);
    cRam0000000103910ca7 = '\x01';
  }
  if (param_7 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036a3158);
                    /* WARNING: Does not return */
    pcVar7 = (code *)SoftwareBreakpoint(1,0x101e23e94);
    (*pcVar7)();
  }
  *(undefined1 *)(param_7 + 0x54) = 0;
  lVar5 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(long *)(param_7 + 0x28) = param_11;
  *(undefined1 *)(((ulong)(param_7 + 0x28) >> 9 & 0x7fffff) + lVar5) = 1;
  *(undefined4 *)(param_7 + 0x48) = param_6;
  *(undefined1 *)(param_7 + 0x31) = param_10;
  *(undefined1 *)(param_7 + 0x30) = 0;
  if (param_9 != 0) {
    uVar9 = *(undefined8 *)(param_9 + 0x78);
    uVar1 = *(undefined8 *)(param_9 + 0x38);
    uVar3 = *(undefined8 *)(param_9 + 0x40);
    uVar2 = *(undefined8 *)(param_9 + 0x88);
    uVar4 = *(undefined8 *)(param_9 + 0x90);
    uVar8 = func_0x000100331820(uRam00000001038f6ca0,0xb0);
    StardewValley_StardewValley_Menus_ClickableTextureComponent__ctor_0600601b
              (param_6,uVar8,uVar1,uVar3,uVar9,uVar2,uVar4,0);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_7 + 0x18) = uVar8;
    *(undefined1 *)(((ulong)(param_7 + 0x18) >> 9 & 0x7fffff) + lVar5) = 1;
  }
  if (param_8 != 0) {
    DataMemoryBarrier(2,3);
    *(long *)(param_7 + 0x20) = param_8;
    *(undefined1 *)(((ulong)(param_7 + 0x20) >> 9 & 0x7fffff) + lVar5) = 1;
  }
  if (param_11 == 0) {
    SDV_StardewValley_Menus_tweeningSprite_setUp_06005e9a
              (param_1,param_2,param_3,param_4,param_5,param_7);
  }
  else {
    SDV_StardewValley_Menus_tweeningSprite_setUp_06005e99(param_5,param_7,param_11,0);
  }
  return;
}

