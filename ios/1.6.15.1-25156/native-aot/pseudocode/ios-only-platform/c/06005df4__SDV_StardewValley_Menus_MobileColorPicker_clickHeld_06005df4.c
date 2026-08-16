/* 0x06005df4 StardewValley.Menus.MobileColorPicker.clickHeld @ 0x101e0503c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileColorPicker_clickHeld_06005df4(long param_1,int param_2)

{
  int iVar1;
  int iVar2;
  code *pcVar3;
  char cVar4;
  ulong uVar5;
  undefined8 uVar6;
  long lVar7;
  long *plVar8;
  
  if (lRam0000000103976fb8 == 0) {
    lVar7 = *(long *)(param_1 + 0x80);
  }
  else {
    func_0x00010119b8f8();
    lVar7 = *(long *)(param_1 + 0x80);
  }
  if (lVar7 == 0) goto LAB_101e05154;
  uVar6 = _UNK_10369ece0;
  if (param_1 != -0x94) {
    iVar1 = *(int *)(param_1 + 0x94);
    iVar2 = iVar1;
    if (iVar1 <= param_2) {
      iVar2 = param_2;
    }
    iVar1 = iVar1 + *(int *)(param_1 + 0x9c) + -1;
    if (iVar1 <= iVar2) {
      iVar2 = iVar1;
    }
    uVar5 = func_0x00010035034c(lVar7 + 0x1c);
    plVar8 = *(long **)(param_1 + 0x80);
    uVar6 = _UNK_10369ece8;
    if (plVar8 != (long *)0x0) {
      uVar5 = uVar5 >> 0x20;
      iVar2 = iVar2 - *(int *)(param_1 + 0x94);
      cVar4 = (**(code **)(*plVar8 + 0x58))(plVar8,*(undefined8 *)(param_1 + 0x68));
      if (cVar4 != '\0') {
        uVar6 = _UNK_10369ed10;
        if (*(long *)(param_1 + 0x68) == 0) goto LAB_101e051d4;
        StardewValley_StardewValley_Menus_SliderBar_click_060064cd
                  (*(long *)(param_1 + 0x68),iVar2,uVar5,0,0);
      }
      cVar4 = (**(code **)(**(long **)(param_1 + 0x80) + 0x58))
                        (*(long **)(param_1 + 0x80),*(undefined8 *)(param_1 + 0x78));
      if (cVar4 != '\0') {
        uVar6 = _UNK_10369ed08;
        if (*(long *)(param_1 + 0x78) == 0) goto LAB_101e051d4;
        StardewValley_StardewValley_Menus_SliderBar_click_060064cd
                  (*(long *)(param_1 + 0x78),iVar2,uVar5,0,0);
      }
      cVar4 = (**(code **)(**(long **)(param_1 + 0x80) + 0x58))
                        (*(long **)(param_1 + 0x80),*(undefined8 *)(param_1 + 0x70));
      if (cVar4 != '\0') {
        uVar6 = _UNK_10369ed00;
        if (*(long *)(param_1 + 0x70) == 0) goto LAB_101e051d4;
        StardewValley_StardewValley_Menus_SliderBar_click_060064cd
                  (*(long *)(param_1 + 0x70),iVar2,uVar5,0,0);
      }
LAB_101e05154:
      SDV_StardewValley_Menus_MobileColorPicker_getSelectedColor_06005dee(param_1);
      return;
    }
  }
LAB_101e051d4:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101e051e0);
  (*pcVar3)();
}

