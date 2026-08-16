/* 0x06005e86 StardewValley.Menus.TutorialManager.drawButtonHands @ 0x101e211ac */

void SDV_StardewValley_Menus_TutorialManager_drawButtonHands_06005e86
               (long param_1,undefined8 param_2)

{
  long lVar1;
  
  if (lRam0000000103976fb8 == 0) {
    lVar1 = *(long *)(param_1 + 0x80);
  }
  else {
    func_0x00010119b8f8();
    lVar1 = *(long *)(param_1 + 0x80);
  }
  if (((lVar1 != 0) && (*(char *)(lVar1 + 0xb0) == '\0')) ||
     ((*(char *)(param_1 + 0xac) != '\0' &&
      ((lVar1 = *(long *)(param_1 + 0x90), lVar1 != 0 && (*(char *)(lVar1 + 0xb0) == '\0')))))) {
    SDV_StardewValley_Menus_TutorialItem_drawButtonHands_06005e5d(lVar1,param_2);
  }
  return;
}

