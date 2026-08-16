/* 0x06005db4 StardewValley.Menus.CoopGameMenu.<enterIPPressed>b__38_0 @ 0x101df8474 */

void SDV_StardewValley_Menus_CoopGameMenu__enterIPPressed_b__38_0_06005db4
               (long *param_1,undefined8 param_2)

{
  char cVar1;
  long lVar2;
  undefined8 uVar3;
  undefined8 uVar4;
  long *plVar5;
  
  cVar1 = cRam0000000103910bc3;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103316620);
    cRam0000000103910bc3 = '\x01';
  }
  cVar1 = func_0x000100345aa0(param_2,uRam00000001038c4f58);
  if (cVar1 != '\0') {
    param_2 = uRam00000001039001f8;
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  plVar5 = (long *)*puRam00000001038d5710;
  lVar2 = func_0x000100331820(uRam00000001039001e8,0x90);
  *(undefined4 *)(lVar2 + 0x78) = 10000;
  StardewValley_StardewValley_Network_HookableClient__ctor_06004b31();
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar2 + 0x60) = param_2;
  *(undefined1 *)(((ulong)(lVar2 + 0x60) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  uVar3 = (**(code **)(*plVar5 + 0x78))(plVar5,lVar2);
  uVar4 = func_0x000100331870(uRam00000001039001f0);
  StardewValley_StardewValley_Menus_FarmhandMenu__ctor_060060f2(uVar4,uVar3);
  (**(code **)(*param_1 + 0x220))(param_1,uVar4);
  return;
}

