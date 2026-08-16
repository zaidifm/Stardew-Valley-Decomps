/* 0x0600675e StardewValley.Mobile.VirtualJoypad.UpdateButtonToogleBounds @ 0x101fd638c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_VirtualJoypad_UpdateButtonToogleBounds_0600675e(long param_1)

{
  undefined8 uVar1;
  char cVar2;
  code *pcVar3;
  long lVar4;
  undefined8 *puVar5;
  undefined8 uVar6;
  int iVar7;
  int *piVar8;
  
  cVar2 = cRam000000010391156d;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325df0);
    cRam000000010391156d = '\x01';
  }
  lVar4 = StardewValley_StardewValley_Game1_get_options_06002fec();
  if (*(char *)(lVar4 + 0x168) == '\0') {
    uVar6 = _UNK_1036d8f10;
    if (*(long *)(param_1 + 0x68) == 0) goto LAB_101fd66f8;
    piVar8 = (int *)(*(long *)(param_1 + 0x68) + 0x38);
    puVar5 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    if ((puVar5 == (undefined8 *)0x0) ||
       (lRam00000001038c6de0 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x10))) {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      iVar7 = *piRam00000001038d57b8;
      if (iVar7 < 9) {
        iVar7 = 8;
      }
    }
    else {
      iVar7 = 0;
    }
    uVar6 = _UNK_1036d8f18;
    if (piVar8 == (int *)0x0) goto LAB_101fd66f8;
    *piVar8 = iVar7;
    lVar4 = *(long *)(param_1 + 0x68);
    uVar6 = _UNK_1036d8f28;
    uVar1 = _UNK_1036d8fb0;
    if (*(char *)(*plRam00000001038e4ba8 + 0xc5) == '\0') goto joined_r0x000101fd65a4;
    uVar6 = _UNK_1036d8f70;
    if ((lVar4 == 0) || (lVar4 = lVar4 + 0x38, uVar6 = _UNK_1036d8f78, lVar4 == 0))
    goto LAB_101fd66f8;
    iVar7 = *(int *)(*plRam00000001038e4ba8 + 0xa8);
    if (iVar7 < 2) {
      iVar7 = 1;
    }
    iVar7 = iVar7 + 0x28;
  }
  else {
    lVar4 = *(long *)(param_1 + 0x68);
    uVar6 = _UNK_1036d8f88;
    if (lVar4 == 0) goto LAB_101fd66f8;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar6 = _UNK_1036d8f90;
    if ((*plRam00000001038e4ba8 == 0) ||
       (piVar8 = (int *)(lVar4 + 0x38), uVar6 = _UNK_1036d8f98, piVar8 == (int *)0x0))
    goto LAB_101fd66f8;
    iVar7 = *(int *)(*plRam00000001038e4ba8 + 0xa8);
    if (iVar7 < 2) {
      iVar7 = 1;
    }
    *piVar8 = *piRam00000001038d57b8 + iVar7 + 0x30;
    lVar4 = *(long *)(param_1 + 0x68);
    uVar6 = _UNK_1036d8fa0;
    uVar1 = _UNK_1036d8fa8;
joined_r0x000101fd65a4:
    if ((lVar4 == 0) || (lVar4 = lVar4 + 0x38, uVar6 = uVar1, lVar4 == 0)) goto LAB_101fd66f8;
    iVar7 = 10;
  }
  *(int *)(lVar4 + 4) = iVar7;
  puVar5 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  if ((puVar5 == (undefined8 *)0x0) ||
     (lRam00000001038c6de0 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x10))) {
    puVar5 = (undefined8 *)StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    if ((puVar5 != (undefined8 *)0x0) &&
       (lRam00000001038c6be8 == *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x10))) {
      uVar6 = _UNK_1036d8f30;
      if ((*(long *)(param_1 + 0x68) == 0) ||
         (piVar8 = (int *)(*(long *)(param_1 + 0x68) + 0x3c), uVar6 = _UNK_1036d8f58,
         piVar8 == (int *)0x0)) goto LAB_101fd66f8;
      iVar7 = 0x50;
      goto LAB_101fd6548;
    }
  }
  else {
    uVar6 = _UNK_1036d8f60;
    if ((*(long *)(param_1 + 0x68) == 0) ||
       (piVar8 = (int *)(*(long *)(param_1 + 0x68) + 0x3c), uVar6 = _UNK_1036d8f68,
       piVar8 == (int *)0x0)) goto LAB_101fd66f8;
    iVar7 = 0x46;
LAB_101fd6548:
    *piVar8 = *piVar8 + iVar7;
  }
  uVar6 = _UNK_1036d8f38;
  if ((*(long *)(param_1 + 0x68) != 0) &&
     (piVar8 = (int *)(*(long *)(param_1 + 0x68) + 0x38), uVar6 = _UNK_1036d8f40,
     piVar8 != (int *)0x0)) {
    *piVar8 = (int)(float)*piVar8;
    lVar4 = *(long *)(param_1 + 0x68);
    uVar6 = _UNK_1036d8f48;
    if ((lVar4 != 0) && (uVar6 = _UNK_1036d8f50, lVar4 != -0x38)) {
      *(int *)(lVar4 + 0x3c) = (int)(float)*(int *)(lVar4 + 0x3c);
      return;
    }
  }
LAB_101fd66f8:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar3 = (code *)SoftwareBreakpoint(1,0x101fd6704);
  (*pcVar3)();
}

