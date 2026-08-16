/* 0x06005e7b StardewValley.Menus.TutorialManager.DefaultPositionString @ 0x100123100 */

undefined8
SDV_StardewValley_Menus_TutorialManager_DefaultPositionString_06005e7b(undefined8 param_1)

{
  char cVar1;
  undefined8 uVar2;
  undefined8 uStack_70;
  undefined8 uStack_68;
  long lStack_60;
  undefined8 uStack_58;
  undefined8 uStack_50;
  undefined8 uStack_48;
  long lStack_40;
  long lStack_30;
  
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  uVar2 = uRam0000000103805380;
  uStack_58 = 0;
  uStack_50 = 0;
  uStack_48 = 0;
  uStack_70 = 0;
  uStack_68 = 0;
  lStack_60 = 0;
  func_0x000100384d40(param_1);
  func_0x000100384d54(&uStack_58);
  while (cVar1 = func_0x000100384d68(&uStack_58), cVar1 != '\0') {
    if (*plRam00000001037fff88 != 0) {
      func_0x0001003316e0();
    }
    func_0x00010035340c(&uStack_70);
    while (cVar1 = func_0x000100353470(&uStack_70), cVar1 != '\0') {
      if (*plRam00000001037fff88 != 0) {
        func_0x0001003316e0();
      }
      uVar2 = func_0x00010035048c(uVar2,uRam0000000103800c08,
                                  *(undefined8 *)(*(long *)(lStack_60 + 0x58) + 0x60),
                                  uRam0000000103805398);
    }
    lStack_40 = 0;
    func_0x000100123248();
    if (lStack_40 != 0) {
      func_0x000100331ba4();
    }
  }
  lStack_30 = 0;
  func_0x0001001232a8();
  if (lStack_30 != 0) {
    func_0x000100331ba4();
  }
  return uVar2;
}

