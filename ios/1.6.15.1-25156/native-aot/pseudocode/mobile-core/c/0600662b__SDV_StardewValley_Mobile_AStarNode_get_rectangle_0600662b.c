/* 0x0600662b StardewValley.Mobile.AStarNode.get_rectangle @ 0x101fa7838 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1  [16] SDV_StardewValley_Mobile_AStarNode_get_rectangle_0600662b(long param_1)

{
  undefined1 auVar1 [16];
  code *pcVar2;
  undefined8 uStack_30;
  undefined8 uStack_28;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036d28b0);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa78ac);
    (*pcVar2)();
  }
  uStack_30 = 0;
  uStack_28 = 0;
  func_0x00010034ede4(&uStack_30,*(int *)(param_1 + 0x34) << 6,*(int *)(param_1 + 0x38) << 6,0x40,
                      0x40);
  auVar1._8_8_ = uStack_28;
  auVar1._0_8_ = uStack_30;
  return auVar1;
}

