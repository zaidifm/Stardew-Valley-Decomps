/* 0x06005ded StardewValley.Menus.MobileColorPicker..ctor @ 0x101e04a0c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileColorPicker__ctor_06005ded
               (long param_1,undefined8 param_2,undefined4 param_3,undefined4 param_4)

{
  long lVar1;
  char cVar2;
  code *pcVar3;
  undefined8 uVar4;
  undefined8 uStack_60;
  undefined8 uStack_58;
  
  cVar2 = cRam0000000103910bfc;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  lVar1 = lRam00000001038c4be0;
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103316c10);
    cRam0000000103910bfc = '\x01';
    lVar1 = lRam00000001038c4be0;
  }
  lRam00000001038c4be0 = lVar1;
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_10369ec48);
                    /* WARNING: Does not return */
    pcVar3 = (code *)SoftwareBreakpoint(1,0x101e04ba8);
    (*pcVar3)();
  }
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x20) = uRam00000001038d6940;
  *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lVar1) = 1;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x88) = param_2;
  *(undefined1 *)(((ulong)(param_1 + 0x88) >> 9 & 0x7fffff) + lVar1) = 1;
  uVar4 = func_0x000100331820(uRam0000000103900280,0x3c);
  StardewValley_StardewValley_Menus_SliderBar__ctor_060064cb(uVar4,0,0,0x32);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x68) = uVar4;
  *(undefined1 *)(((ulong)(param_1 + 0x68) >> 9 & 0x7fffff) + lVar1) = 1;
  uVar4 = func_0x000100331820(uRam0000000103900280,0x3c);
  StardewValley_StardewValley_Menus_SliderBar__ctor_060064cb(uVar4,0,0x14,0x32);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x78) = uVar4;
  *(undefined1 *)(((ulong)(param_1 + 0x78) >> 9 & 0x7fffff) + lVar1) = 1;
  uVar4 = func_0x000100331820(uRam0000000103900280,0x3c);
  StardewValley_StardewValley_Menus_SliderBar__ctor_060064cb(uVar4,0,0x28,0x32);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x70) = uVar4;
  *(undefined1 *)(((ulong)(param_1 + 0x70) >> 9 & 0x7fffff) + lVar1) = 1;
  uStack_60 = 0;
  uStack_58 = 0;
  func_0x00010034ede4(&uStack_60,param_3,param_4,*puRam00000001039003d0,0x3c);
  *(undefined8 *)(param_1 + 0x9c) = uStack_58;
  *(undefined8 *)(param_1 + 0x94) = uStack_60;
  return;
}

