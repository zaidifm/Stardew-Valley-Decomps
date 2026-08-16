/* 0x06005e8a StardewValley.Menus.TutorialManager.TestForHoeSelected @ 0x101e22a7c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_TestForHoeSelected_06005e8a(long param_1)

{
  char cVar1;
  code *pcVar2;
  undefined1 uVar3;
  long lVar4;
  undefined8 *puVar5;
  
  cVar1 = cRam0000000103910c99;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910c99 != '\0') goto LAB_101e22aa8;
LAB_101e22b38:
    func_0x00010119b908(&UNK_103317aac);
    cRam0000000103910c99 = '\x01';
    cVar1 = *(char *)(param_1 + 0xc9);
  }
  else {
    func_0x00010119b8f8();
    if (cVar1 == '\0') goto LAB_101e22b38;
LAB_101e22aa8:
    cVar1 = *(char *)(param_1 + 0xc9);
  }
  if (cVar1 == '\0') {
    lVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (lVar4 == 0) {
      func_0x0001003316f4(0xee,_UNK_1036a2fb8);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101e22b74);
      (*pcVar2)();
    }
    puVar5 = (undefined8 *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
    uVar3 = 0;
    if (puVar5 != (undefined8 *)0x0) {
      if ((lRam00000001038c7a20 == *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18)) &&
         (*(char *)(param_1 + 0xac) != '\0')) {
        lVar4 = SDV_StardewValley_Menus_TutorialManager_GetTutorial_06005e6b(param_1,0xf);
        uVar3 = 0;
        if (lVar4 == 0) goto LAB_101e22aec;
        if (*(char *)(lVar4 + 0xb0) != '\0') {
          uVar3 = SDV_StardewValley_Menus_TutorialManager_completeTutorial_06005e74(param_1,0x10);
          goto LAB_101e22aec;
        }
      }
      uVar3 = 0;
    }
  }
  else {
    uVar3 = 1;
  }
LAB_101e22aec:
  *(undefined1 *)(param_1 + 0xc9) = uVar3;
  return;
}

