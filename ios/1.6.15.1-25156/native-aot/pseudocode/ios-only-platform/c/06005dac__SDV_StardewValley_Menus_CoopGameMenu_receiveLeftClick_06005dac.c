/* 0x06005dac StardewValley.Menus.CoopGameMenu.receiveLeftClick @ 0x101df7a7c */

void SDV_StardewValley_Menus_CoopGameMenu_receiveLeftClick_06005dac
               (long *param_1,undefined4 param_2,undefined4 param_3)

{
  long lVar1;
  char cVar2;
  long *plVar3;
  undefined8 uVar4;
  
  cVar2 = cRam0000000103910bbb;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1033165ba);
    cRam0000000103910bbb = '\x01';
    cVar2 = (char)param_1[0x36];
  }
  else {
    cVar2 = (char)param_1[0x36];
  }
  if (cVar2 != '\0') {
    plVar3 = (long *)param_1[0x30];
    if ((*(char *)((long)plVar3 + 0x4c) == '\0') ||
       (cVar2 = (**(code **)(*plVar3 + 0x90))(plVar3,param_2,param_3), cVar2 == '\0')) {
      StardewValley_StardewValley_Menus_LoadGameMenu_receiveLeftClick_060062d7
                (param_1,param_2,param_3);
    }
    else {
      StardewValley_StardewValley_Game1_playSound_0600301b(uRam00000001038d6940,0);
      lVar1 = param_1[0x38];
      uVar4 = func_0x000100331870(uRam00000001039001c0);
      SDV_StardewValley_Menus_CoopGameMenu__ctor_06005d9b(uVar4,(char)lVar1,0);
      (**(code **)(*param_1 + 0x220))(param_1,uVar4);
    }
  }
  return;
}

