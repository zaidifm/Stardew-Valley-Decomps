/* 0x06005e84 StardewValley.Menus.TutorialManager.draw @ 0x101e20fb8 */

void SDV_StardewValley_Menus_TutorialManager_draw_06005e84(long param_1,undefined8 param_2)

{
  long *plVar1;
  
  if (lRam0000000103976fb8 == 0) {
    plVar1 = *(long **)(param_1 + 0x80);
  }
  else {
    func_0x00010119b8f8();
    plVar1 = *(long **)(param_1 + 0x80);
  }
  if (((plVar1 != (long *)0x0) && ((char)plVar1[0x16] == '\0')) ||
     ((*(char *)(param_1 + 0xac) != '\0' &&
      ((plVar1 = *(long **)(param_1 + 0x90), plVar1 != (long *)0x0 && ((char)plVar1[0x16] == '\0')))
      ))) {
    (**(code **)(*plVar1 + 0xa0))(plVar1,param_2);
  }
  return;
}

