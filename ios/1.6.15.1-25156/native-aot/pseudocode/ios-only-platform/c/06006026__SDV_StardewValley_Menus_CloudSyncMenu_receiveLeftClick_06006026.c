/* 0x06006026 StardewValley.Menus.CloudSyncMenu.receiveLeftClick @ 0x101e606a0 */

/* WARNING: Removing unreachable block (ram,0x000101e60878) */
/* WARNING: Removing unreachable block (ram,0x000101e60848) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CloudSyncMenu_receiveLeftClick_06006026
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  long *plVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  undefined8 uStack_88;
  undefined8 uStack_80;
  long *plStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  
  cVar3 = cRam0000000103910e35;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_10331a060);
    cRam0000000103910e35 = '\x01';
  }
  uStack_88 = 0;
  uStack_80 = 0;
  plStack_78 = (long *)0x0;
  StardewValley_StardewValley_Menus_IClickableMenu_receiveLeftClick_0600618b
            (param_1,param_2,param_3);
  uVar4 = _UNK_1036aa980;
  if (*(long *)(param_1 + 0x68) != 0) {
    func_0x00010037744c(&uStack_88);
    while (cVar3 = func_0x000100377460(&uStack_88), plVar1 = plStack_78, cVar3 != '\0') {
      if (plStack_78 == (long *)0x0) {
LAB_101e607c0:
        func_0x0001003316f4(0xee,_UNK_1036aa990);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101e607d4);
        (*pcVar2)();
      }
      cVar3 = (**(code **)(*plStack_78 + 0x90))(plStack_78,param_2,param_3);
      if ((cVar3 != '\0') &&
         (cVar3 = func_0x000100345aa0(plVar1[2],uRam00000001038d6530), cVar3 != '\0')) {
        StardewValley_StardewValley_Game1_playSound_0600301b(uRam00000001038d7418,0);
        if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
          func_0x0001003319b0();
        }
        if (*plRam00000001038d57f8 == 0) goto LAB_101e607c0;
        SDV_StardewValley_CloudSync_RequestStop_060032da();
      }
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
    }
    uStack_70 = 0;
    if (&stack0x00000000 != (undefined1 *)0x88) {
      return;
    }
    uStack_68 = 0;
    uVar4 = _UNK_1036aa988;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e60828);
  (*pcVar2)();
}

