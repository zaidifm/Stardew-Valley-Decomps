/* 0x06005e94 StardewValley.Menus.TutorialManager.SaleTutorialCheck @ 0x101e2398c */

void SDV_StardewValley_Menus_TutorialManager_SaleTutorialCheck_06005e94(long param_1)

{
  char cVar1;
  long lVar2;
  
  if (lRam0000000103976fb8 == 0) {
    cVar1 = *(char *)(param_1 + 0xb6);
  }
  else {
    func_0x00010119b8f8();
    cVar1 = *(char *)(param_1 + 0xb6);
  }
  if ((((cVar1 == '\0') && (*(char *)(param_1 + 0xac) != '\0')) &&
      (lVar2 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b(param_1,0x29),
      lVar2 != 0)) && (*(char *)(lVar2 + 0xb0) != '\0')) {
    *(undefined1 *)(param_1 + 0xb6) = 1;
    SDV_StardewValley_Menus_TutorialManager_completeTutorial_06005e74(param_1,0x15);
  }
  return;
}

