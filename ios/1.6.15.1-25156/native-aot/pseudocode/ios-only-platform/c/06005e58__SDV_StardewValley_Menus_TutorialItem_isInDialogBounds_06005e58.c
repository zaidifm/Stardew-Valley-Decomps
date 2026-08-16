/* 0x06005e58 StardewValley.Menus.TutorialItem.isInDialogBounds @ 0x101e1d204 */

undefined8
SDV_StardewValley_Menus_TutorialItem_isInDialogBounds_06005e58
          (long param_1,undefined4 param_2,undefined4 param_3)

{
  undefined8 uVar1;
  long lVar2;
  undefined8 uStack_50;
  undefined8 uStack_48;
  undefined8 uStack_40;
  undefined8 uStack_38;
  
  if (lRam0000000103976fb8 == 0) {
    lVar2 = *(long *)(param_1 + 0x90);
  }
  else {
    func_0x00010119b8f8();
    lVar2 = *(long *)(param_1 + 0x90);
  }
  if (lVar2 == 0) {
    uVar1 = 0;
  }
  else {
    uStack_40 = 0;
    uStack_38 = 0;
    func_0x00010034ede4(&uStack_40,*(undefined4 *)(lVar2 + 0xcc),*(undefined4 *)(lVar2 + 0xd0),
                        *(undefined4 *)(lVar2 + 0x58),*(undefined4 *)(lVar2 + 0x5c));
    uStack_50 = uStack_40;
    uStack_48 = uStack_38;
    uVar1 = func_0x000100356238(&uStack_50,param_2,param_3);
  }
  return uVar1;
}

