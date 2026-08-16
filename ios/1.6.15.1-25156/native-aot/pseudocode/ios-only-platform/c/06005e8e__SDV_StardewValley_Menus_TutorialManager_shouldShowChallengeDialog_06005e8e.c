/* 0x06005e8e StardewValley.Menus.TutorialManager.shouldShowChallengeDialog @ 0x101e22de4 */

bool SDV_StardewValley_Menus_TutorialManager_shouldShowChallengeDialog_06005e8e(long param_1)

{
  int iVar1;
  char cVar2;
  bool bVar3;
  undefined8 *puVar4;
  
  cVar2 = cRam0000000103910c9d;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103317ace);
    cRam0000000103910c9d = '\x01';
    iVar1 = *(int *)(param_1 + 0xa8);
  }
  else {
    iVar1 = *(int *)(param_1 + 0xa8);
  }
  if (iVar1 == 3) {
    puVar4 = (undefined8 *)SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
    if ((puVar4 != (undefined8 *)0x0) &&
       (lRam00000001038d5298 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x18))) {
      puVar4 = (undefined8 *)0x0;
    }
    bVar3 = puVar4 == (undefined8 *)0x0;
  }
  else {
    bVar3 = false;
  }
  return bVar3;
}

