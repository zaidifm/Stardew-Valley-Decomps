/* 0x06005e8d StardewValley.Menus.TutorialManager.shouldShowAttackDialog @ 0x101e22d2c */

bool SDV_StardewValley_Menus_TutorialManager_shouldShowAttackDialog_06005e8d(long param_1)

{
  char cVar1;
  bool bVar2;
  undefined8 *puVar3;
  
  cVar1 = cRam0000000103910c9c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317ac4);
    cRam0000000103910c9c = '\x01';
    cVar1 = *(char *)(param_1 + 0xcd);
  }
  else {
    cVar1 = *(char *)(param_1 + 0xcd);
  }
  if ((cVar1 == '\0') ||
     ((puVar3 = (undefined8 *)SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1(),
      puVar3 != (undefined8 *)0x0 &&
      (lRam00000001038d5298 == *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x18))))) {
    bVar2 = false;
  }
  else {
    bVar2 = *(int *)(param_1 + 0xa8) < 1;
  }
  return bVar2;
}

