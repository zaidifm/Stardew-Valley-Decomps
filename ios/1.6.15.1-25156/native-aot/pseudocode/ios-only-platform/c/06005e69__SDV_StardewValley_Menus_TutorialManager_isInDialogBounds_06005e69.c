/* 0x06005e69 StardewValley.Menus.TutorialManager.isInDialogBounds @ 0x101e1e564 */

undefined8
SDV_StardewValley_Menus_TutorialManager_isInDialogBounds_06005e69
          (long param_1,undefined4 param_2,undefined4 param_3)

{
  char cVar1;
  undefined8 uVar2;
  long lVar3;
  undefined8 uStack_50;
  undefined8 uStack_48;
  
  cVar1 = cRam0000000103910c78;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103317722);
    cRam0000000103910c78 = '\x01';
    lVar3 = *(long *)(param_1 + 0x90);
  }
  else {
    lVar3 = *(long *)(param_1 + 0x90);
  }
  if (((lVar3 == 0) || (*pcRam0000000103900788 == '\0')) ||
     (lVar3 = *(long *)(lVar3 + 0x90), lVar3 == 0)) {
    uVar2 = 0;
  }
  else {
    uStack_50 = 0;
    uStack_48 = 0;
    func_0x00010034ede4(&uStack_50,*(undefined4 *)(lVar3 + 0xcc),*(undefined4 *)(lVar3 + 0xd0),
                        *(undefined4 *)(lVar3 + 0x58),*(undefined4 *)(lVar3 + 0x5c));
    uVar2 = func_0x000100356238(&uStack_50,param_2,param_3);
  }
  return uVar2;
}

