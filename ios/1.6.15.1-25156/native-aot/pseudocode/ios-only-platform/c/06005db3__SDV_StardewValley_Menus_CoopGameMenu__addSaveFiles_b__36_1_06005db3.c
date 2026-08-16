/* 0x06005db3 StardewValley.Menus.CoopGameMenu.<addSaveFiles>b__36_1 @ 0x101df83cc */

long SDV_StardewValley_Menus_CoopGameMenu__addSaveFiles_b__36_1_06005db3
               (undefined8 param_1,undefined8 param_2)

{
  char cVar1;
  long lVar2;
  
  cVar1 = cRam0000000103910bc2;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103316611);
    cRam0000000103910bc2 = '\x01';
  }
  lVar2 = func_0x000100331820(uRam00000001039001e0,0x58);
  StardewValley_StardewValley_Menus_LoadGameMenu_SaveFileSlot__ctor_060073b6
            (lVar2,param_1,param_2,0);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar2 + 0x50) = param_1;
  *(undefined1 *)(((ulong)(lVar2 + 0x50) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  return lVar2;
}

