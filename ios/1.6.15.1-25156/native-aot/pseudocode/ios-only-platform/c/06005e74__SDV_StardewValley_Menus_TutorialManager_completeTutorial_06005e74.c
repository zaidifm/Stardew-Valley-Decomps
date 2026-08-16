/* 0x06005e74 StardewValley.Menus.TutorialManager.completeTutorial @ 0x101e1f1bc */

undefined8
SDV_StardewValley_Menus_TutorialManager_completeTutorial_06005e74(long param_1,int param_2)

{
  int iVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  long lVar5;
  long *plVar6;
  undefined8 uVar7;
  
  cVar2 = cRam0000000103910c83;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910c83 == '\0') goto LAB_101e1f330;
LAB_101e1f1ec:
    iVar1 = *(int *)(param_1 + 0xa8);
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 != '\0') goto LAB_101e1f1ec;
LAB_101e1f330:
    func_0x00010119b908(&UNK_103317798);
    cRam0000000103910c83 = '\x01';
    iVar1 = *(int *)(param_1 + 0xa8);
  }
  if ((iVar1 == 1) && (param_2 == 7)) {
    if (*(long *)(param_1 + 0x80) != 0) {
      SDV_StardewValley_Menus_TutorialItem_setComplete_06005e56();
    }
    *(undefined8 *)(param_1 + 0x80) = 0;
    *(undefined4 *)(param_1 + 0xa8) = 2;
  }
  if (*(char *)(param_1 + 0xac) == '\0') {
LAB_101e1f314:
    uVar4 = 0;
  }
  else {
    lVar3 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b(param_1,param_2);
    if (lVar3 == 0) {
      return 0;
    }
    cVar2 = func_0x000100345aa0(*(undefined8 *)(lVar3 + 0x88),uRam00000001038c4f58);
    if (cVar2 == '\0') {
      lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      if (lVar5 != 0) {
        uVar4 = *(undefined8 *)(lVar3 + 0x88);
        lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
        cVar2 = func_0x000100345aa0(uVar4,*(undefined8 *)(*(long *)(lVar5 + 0x178) + 0x60));
        if ((cVar2 != '\0') &&
           (lVar5 = SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1(), lVar5 == 0))
        goto LAB_101e1f24c;
      }
      cVar2 = func_0x000100350ff4(*(undefined8 *)(lVar3 + 0x98),0);
      if ((cVar2 != '\0') &&
         (lVar5 = SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1(), lVar5 != 0)) {
        uVar7 = *(undefined8 *)(lVar3 + 0x98);
        plVar6 = (long *)SDV_StardewValley_Game1_get_activeClickableMenu_06002fe1();
        uVar4 = (**(code **)(*plVar6 + 0x1a0))();
        cVar2 = func_0x000100331be0(uVar7,uVar4);
        if (cVar2 != '\0') goto LAB_101e1f24c;
      }
      if ((*(int *)(lVar3 + 0xcc) != 6) && (*(int *)(lVar3 + 0xcc) != 0x30)) goto LAB_101e1f314;
    }
LAB_101e1f24c:
    if ((*(long *)(param_1 + 0x90) != 0) &&
       (*(int *)(lVar3 + 0xcc) == *(int *)(*(long *)(param_1 + 0x90) + 0xcc))) {
      *(undefined8 *)(param_1 + 0x90) = 0;
    }
    SDV_StardewValley_Menus_TutorialItem_setComplete_06005e56(lVar3);
    if (*(int *)(lVar3 + 0xcc) == 0x2c) {
      SDV_StardewValley_Menus_TutorialManager_initializeTutorials_06005e89(param_1);
    }
    uVar4 = 1;
  }
  return uVar4;
}

