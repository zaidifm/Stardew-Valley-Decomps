/* 0x06005e81 StardewValley.Menus.TutorialManager.ShouldExitTutorial @ 0x101e20ac8 */

bool SDV_StardewValley_Menus_TutorialManager_ShouldExitTutorial_06005e81(long param_1)

{
  char cVar1;
  long lVar2;
  long *plVar3;
  undefined8 uVar4;
  undefined8 uVar5;
  long lVar6;
  
  cVar1 = cRam0000000103910c90;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_1033178cf);
    cRam0000000103910c90 = '\x01';
  }
  if ((param_1 != 0) && (*(char *)(param_1 + 0xb3) == '\0')) {
    lVar6 = *(long *)(param_1 + 0x88);
    if ((lVar6 != 0) && (*(int *)(lVar6 + 0x10) != 0)) {
      lVar2 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      if (lVar2 == 0) {
        uVar5 = 0;
      }
      else {
        uVar5 = *(undefined8 *)(*(long *)(lVar2 + 0x178) + 0x60);
      }
      cVar1 = func_0x00010035011c(lVar6,uVar5);
      if (cVar1 != '\0') {
        return true;
      }
      lVar6 = SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
      if (lVar6 != 0) {
        plVar3 = (long *)SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
        uVar5 = (**(code **)(*plVar3 + 0x1a0))();
        cVar1 = func_0x000100350ff4(uVar5,uRam00000001038e5bf8);
        if (cVar1 != '\0') {
          return true;
        }
      }
    }
    cVar1 = func_0x000100350ff4(*(undefined8 *)(param_1 + 0x98),0);
    if (cVar1 != '\0') {
      uVar5 = *(undefined8 *)(param_1 + 0x98);
      plVar3 = (long *)SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
      if (plVar3 == (long *)0x0) {
        uVar4 = 0;
      }
      else {
        uVar4 = (**(code **)(*plVar3 + 0x1a0))();
      }
      cVar1 = func_0x000100331be0(uVar5,uVar4);
      if (cVar1 == '\0') {
        uVar5 = *(undefined8 *)(param_1 + 0x98);
        if (*(char *)(lRam00000001038d60b8 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        if ((long *)*plRam00000001038d67d0 == (long *)0x0) {
          uVar4 = 0;
        }
        else {
          uVar4 = *(undefined8 *)(*(long *)*plRam00000001038d67d0 + 0x18);
        }
        cVar1 = func_0x000100331be0(uVar5,uVar4);
        return cVar1 == '\0';
      }
    }
  }
  return false;
}

