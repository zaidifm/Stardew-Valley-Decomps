/* 0x06005e71 StardewValley.Menus.TutorialManager.isTutorialComplete @ 0x101e1ef64 */

undefined1
SDV_StardewValley_Menus_TutorialManager_isTutorialComplete_06005e71(long param_1,undefined4 param_2)

{
  char cVar1;
  undefined1 uVar2;
  long lVar3;
  
  if (lRam0000000103976fb8 == 0) {
    cVar1 = *(char *)(param_1 + 0xac);
  }
  else {
    func_0x00010119b8f8();
    cVar1 = *(char *)(param_1 + 0xac);
  }
  if (cVar1 == '\0') {
    uVar2 = 0;
  }
  else {
    lVar3 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b(param_1,param_2);
    uVar2 = 0;
    if (lVar3 != 0) {
      uVar2 = *(undefined1 *)(lVar3 + 0xb0);
    }
  }
  return uVar2;
}

