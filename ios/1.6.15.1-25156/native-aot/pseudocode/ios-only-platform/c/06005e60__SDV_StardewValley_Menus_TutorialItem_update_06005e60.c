/* 0x06005e60 StardewValley.Menus.TutorialItem.update @ 0x101e1deb4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_update_06005e60(long param_1,long param_2)

{
  char cVar1;
  code *pcVar2;
  long *plVar3;
  long lVar4;
  undefined8 uVar5;
  float fVar6;
  
  cVar1 = cRam0000000103910c6f;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar5 = _UNK_1036a2a40;
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317696);
    cRam0000000103910c6f = '\x01';
    uVar5 = _UNK_1036a2a40;
  }
  _UNK_1036a2a40 = uVar5;
  if (param_1 != 0) {
    *(float *)(param_1 + 0xd8) =
         *(float *)(param_1 + 0xd8) + (float)((*(long *)(param_2 + 0x18) / 10000) % 1000);
    if (*(char *)(param_1 + 0xb5) == '\0') {
      if (*(char *)(param_1 + 0xb2) != '\0') {
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        if ((*(char *)(*plRam00000001038d53a0 + 0xdc) == '\0') &&
           (plVar3 = *(long **)(param_1 + 0x90), plVar3 != (long *)0x0)) {
          (**(code **)(*plVar3 + 0x90))(plVar3,param_2);
        }
        if (*(long *)(param_1 + 0x78) != 0) {
          SDV_StardewValley_Menus_HandPointer_update_06005dd8(*(long *)(param_1 + 0x78),param_2);
        }
      }
      if ((*(char *)(param_1 + 0xb3) != '\0') &&
         (fVar6 = *(float *)(param_1 + 0xd0) - (float)((*(long *)(param_2 + 0x18) / 10000) % 1000),
         *(float *)(param_1 + 0xd0) = fVar6, fVar6 < 0.0)) {
        lVar4 = SDV_StardewValley_Menus_TutorialManager_get_Instance_06005e62();
        uVar5 = _UNK_1036a2a50;
        if (lVar4 == 0) goto LAB_101e1e0cc;
        SDV_StardewValley_Menus_TutorialManager_completeTutorial_06005e74
                  (lVar4,*(undefined4 *)(param_1 + 0xcc));
        *(undefined8 *)(param_1 + 0x90) = 0;
        if (*(char *)(lRam0000000103900780 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        *puRam0000000103900788 = 0;
      }
    }
    else {
      fVar6 = *(float *)(param_1 + 0xd4) - (float)((*(long *)(param_2 + 0x18) / 10000) % 1000);
      *(float *)(param_1 + 0xd4) = fVar6;
      if (fVar6 <= 0.0) {
        *(undefined1 *)(param_1 + 0xb5) = 0;
        SDV_StardewValley_Menus_TutorialItem_show_06005e59(param_1);
      }
    }
    return;
  }
LAB_101e1e0cc:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1e0d8);
  (*pcVar2)();
}

