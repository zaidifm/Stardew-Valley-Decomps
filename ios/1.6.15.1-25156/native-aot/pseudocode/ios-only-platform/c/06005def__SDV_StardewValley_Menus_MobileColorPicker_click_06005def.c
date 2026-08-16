/* 0x06005def StardewValley.Menus.MobileColorPicker.click @ 0x101e04c6c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileColorPicker_click_06005def
               (long param_1,undefined4 param_2,undefined4 param_3,char param_4)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar4 = _UNK_10369ec70;
  if (param_1 == 0) goto LAB_101e04e10;
  cVar2 = func_0x000100356238(param_1 + 0x94,param_2,param_3);
  if (cVar2 != '\0' || param_4 != '\0') {
    if (param_4 == '\0') {
      uVar4 = _UNK_10369ec78;
      if (*(long *)(param_1 + 0x68) == 0) {
LAB_101e04e10:
        func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101e04e1c);
        (*pcVar1)();
      }
      cVar2 = func_0x000100356238(*(long *)(param_1 + 0x68) + 0x2c,param_2,param_3);
      if (cVar2 != '\0') {
        uVar4 = _UNK_10369eca0;
        if (*(long *)(param_1 + 0x68) == 0) goto LAB_101e04e10;
        StardewValley_StardewValley_Menus_SliderBar_click_060064cd
                  (*(long *)(param_1 + 0x68),param_2,param_3,0,0);
        lVar3 = lRam00000001038c4be0;
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0x80) = *(undefined8 *)(param_1 + 0x68);
        *(undefined1 *)(((ulong)(param_1 + 0x80) >> 9 & 0x7fffff) + lVar3) = 1;
      }
      uVar4 = _UNK_10369ec80;
      if (*(long *)(param_1 + 0x78) == 0) goto LAB_101e04e10;
      cVar2 = func_0x000100356238(*(long *)(param_1 + 0x78) + 0x2c,param_2,param_3);
      lVar3 = lRam00000001038c4be0;
      if (cVar2 != '\0') {
        DataMemoryBarrier(2,3);
        *(undefined8 *)(param_1 + 0x80) = *(undefined8 *)(param_1 + 0x78);
        *(undefined1 *)(((ulong)(param_1 + 0x80) >> 9 & 0x7fffff) + lVar3) = 1;
        uVar4 = _UNK_10369ec98;
        if (*(long *)(param_1 + 0x78) == 0) goto LAB_101e04e10;
        StardewValley_StardewValley_Menus_SliderBar_click_060064cd
                  (*(long *)(param_1 + 0x78),param_2,param_3,0,0);
      }
      uVar4 = _UNK_10369ec88;
      if (*(long *)(param_1 + 0x70) == 0) goto LAB_101e04e10;
      cVar2 = func_0x000100356238(*(long *)(param_1 + 0x70) + 0x2c,param_2,param_3);
      lVar3 = lRam00000001038c4be0;
      if (cVar2 == '\0') goto LAB_101e04de8;
      DataMemoryBarrier(2,3);
      *(undefined8 *)(param_1 + 0x80) = *(undefined8 *)(param_1 + 0x70);
      *(undefined1 *)(((ulong)(param_1 + 0x80) >> 9 & 0x7fffff) + lVar3) = 1;
      lVar3 = *(long *)(param_1 + 0x70);
      uVar4 = _UNK_10369ec90;
      if (lVar3 == 0) goto LAB_101e04e10;
      uVar4 = 0;
    }
    else {
      lVar3 = *(long *)(param_1 + 0x80);
      if (lVar3 == 0) goto LAB_101e04de8;
      uVar4 = 1;
    }
    StardewValley_StardewValley_Menus_SliderBar_click_060064cd(lVar3,param_2,param_3,0,uVar4);
  }
LAB_101e04de8:
  SDV_StardewValley_Menus_MobileColorPicker_getSelectedColor_06005dee(param_1);
  return;
}

