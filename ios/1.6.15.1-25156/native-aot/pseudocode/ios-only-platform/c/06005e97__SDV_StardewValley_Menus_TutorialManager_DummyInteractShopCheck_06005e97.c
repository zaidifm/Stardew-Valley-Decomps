/* 0x06005e97 StardewValley.Menus.TutorialManager.DummyInteractShopCheck @ 0x101e23ba8 */

void SDV_StardewValley_Menus_TutorialManager_DummyInteractShopCheck_06005e97(long param_1)

{
  char cVar1;
  long lVar2;
  undefined8 uVar3;
  
  cVar1 = cRam0000000103910ca6;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317b80);
    cRam0000000103910ca6 = '\x01';
    cVar1 = *(char *)(param_1 + 0xca);
  }
  else {
    cVar1 = *(char *)(param_1 + 0xca);
  }
  if (cVar1 == '\0') {
    lVar2 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    if (lVar2 == 0) {
      uVar3 = 0;
    }
    else {
      uVar3 = *(undefined8 *)(*(long *)(lVar2 + 0x178) + 0x60);
    }
    cVar1 = func_0x000100345aa0(uVar3,uRam00000001038c6e30);
    if ((((cVar1 != '\0') ||
         (cVar1 = func_0x000100345aa0(uVar3,uRam00000001038c6d78), cVar1 != '\0')) ||
        (cVar1 = func_0x000100345aa0(uVar3,uRam00000001038cb208), cVar1 != '\0')) ||
       (((cVar1 = func_0x000100345aa0(uVar3,uRam00000001038cb1f0), cVar1 != '\0' ||
         (cVar1 = func_0x000100345aa0(uVar3,uRam00000001038cb1e0), cVar1 != '\0')) ||
        (cVar1 = func_0x000100345aa0(uVar3,uRam00000001038c6c58), cVar1 != '\0')))) {
      *(undefined1 *)(param_1 + 0xca) = 1;
      SDV_StardewValley_Menus_TutorialManager_completeTutorial_06005e74(param_1,0x28);
    }
  }
  return;
}

