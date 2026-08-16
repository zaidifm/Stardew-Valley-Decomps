/* 0x06005e25 StardewValley.Menus.MobileFarmChooser.leftClickHeld @ 0x101e176a4 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileFarmChooser_leftClickHeld_06005e25
               (long param_1,undefined4 param_2,undefined4 param_3)

{
  undefined4 *puVar1;
  int *piVar2;
  undefined8 uVar3;
  code *pcVar4;
  char cVar5;
  undefined8 uVar6;
  long lVar7;
  long lVar8;
  
  if (lRam0000000103976fb8 == 0) {
    cVar5 = *(char *)(param_1 + 0x1c0);
  }
  else {
    func_0x00010119b8f8();
    cVar5 = *(char *)(param_1 + 0x1c0);
  }
  if (cVar5 == '\0') {
    uVar6 = _UNK_1036a1c20;
    if (*(long *)(param_1 + 0xf8) == 0) goto LAB_101e17be8;
    *(undefined1 *)(*(long *)(param_1 + 0xf8) + 0xad) = 1;
    uVar6 = _UNK_1036a1c28;
    if (((*(long *)(param_1 + 0xf8) == 0) || (uVar6 = _UNK_1036a1c30, param_1 == -0x1dc)) ||
       (puVar1 = (undefined4 *)(*(long *)(param_1 + 0xf8) + 0x38), uVar6 = _UNK_1036a1c38,
       puVar1 == (undefined4 *)0x0)) goto LAB_101e17be8;
    *puVar1 = *(undefined4 *)(param_1 + 0x1dc);
    lVar8 = *(long *)(param_1 + 0xf8);
    uVar6 = _UNK_1036a1c40;
    if ((lVar8 == 0) || (uVar6 = _UNK_1036a1c48, lVar8 == -0x38)) goto LAB_101e17be8;
    *(undefined4 *)(lVar8 + 0x3c) = *(undefined4 *)(param_1 + 0x1e0);
    uVar6 = _UNK_1036a1c50;
    if (*(long *)(param_1 + 0x100) == 0) goto LAB_101e17be8;
    *(undefined1 *)(*(long *)(param_1 + 0x100) + 0xad) = 1;
    uVar6 = _UNK_1036a1c58;
    if (((*(long *)(param_1 + 0x100) == 0) ||
        (lVar8 = param_1 + 0x1ec, uVar6 = _UNK_1036a1c60, lVar8 == 0)) ||
       (puVar1 = (undefined4 *)(*(long *)(param_1 + 0x100) + 0x38), uVar6 = _UNK_1036a1c68,
       puVar1 == (undefined4 *)0x0)) goto LAB_101e17be8;
    *puVar1 = *(undefined4 *)(param_1 + 0x1ec);
    lVar7 = *(long *)(param_1 + 0x100);
    uVar6 = _UNK_1036a1c70;
    if ((lVar7 == 0) || (uVar6 = _UNK_1036a1c78, lVar7 == -0x38)) goto LAB_101e17be8;
    *(undefined4 *)(lVar7 + 0x3c) = *(undefined4 *)(param_1 + 0x1f0);
    cVar5 = (**(code **)(**(long **)(param_1 + 0xf8) + 0x90))
                      (*(long **)(param_1 + 0xf8),param_2,param_3);
    if (cVar5 != '\0') {
      *(undefined1 *)(*(long *)(param_1 + 0xf8) + 0xad) = 0;
      uVar6 = _UNK_1036a1cc0;
      if ((*(long *)(param_1 + 0xf8) == 0) ||
         (piVar2 = (int *)(*(long *)(param_1 + 0xf8) + 0x38), uVar6 = _UNK_1036a1cc8,
         piVar2 == (int *)0x0)) goto LAB_101e17be8;
      *piVar2 = *(int *)(param_1 + 0x1dc) + -4;
      lVar7 = *(long *)(param_1 + 0xf8);
      uVar6 = _UNK_1036a1cd0;
      if ((lVar7 == 0) || (uVar6 = _UNK_1036a1cd8, lVar7 == -0x38)) goto LAB_101e17be8;
      *(int *)(lVar7 + 0x3c) = *(int *)(param_1 + 0x1e0) + 4;
    }
    cVar5 = (**(code **)(**(long **)(param_1 + 0x100) + 0x90))
                      (*(long **)(param_1 + 0x100),param_2,param_3);
    if (cVar5 == '\0') {
      return;
    }
    *(undefined1 *)(*(long *)(param_1 + 0x100) + 0xad) = 0;
    uVar6 = _UNK_1036a1c98;
    if ((*(long *)(param_1 + 0x100) == 0) ||
       (piVar2 = (int *)(*(long *)(param_1 + 0x100) + 0x38), uVar6 = _UNK_1036a1ca0,
       piVar2 == (int *)0x0)) goto LAB_101e17be8;
    *piVar2 = *(int *)(param_1 + 0x1ec) + -4;
    lVar7 = *(long *)(param_1 + 0x100);
    uVar6 = _UNK_1036a1ca8;
    uVar3 = _UNK_1036a1cb0;
  }
  else {
    uVar6 = _UNK_1036a1ce0;
    if (*(long *)(param_1 + 0x88) == 0) goto LAB_101e17be8;
    *(undefined1 *)(*(long *)(param_1 + 0x88) + 0xad) = 1;
    uVar6 = _UNK_1036a1ce8;
    if (((*(long *)(param_1 + 0x88) == 0) ||
        (lVar8 = param_1 + 400, uVar6 = _UNK_1036a1cf0, lVar8 == 0)) ||
       (puVar1 = (undefined4 *)(*(long *)(param_1 + 0x88) + 0x38), uVar6 = _UNK_1036a1cf8,
       puVar1 == (undefined4 *)0x0)) goto LAB_101e17be8;
    *puVar1 = *(undefined4 *)(param_1 + 400);
    lVar7 = *(long *)(param_1 + 0x88);
    uVar6 = _UNK_1036a1d00;
    if ((lVar7 == 0) || (uVar6 = _UNK_1036a1d08, lVar7 == -0x38)) goto LAB_101e17be8;
    *(undefined4 *)(lVar7 + 0x3c) = *(undefined4 *)(param_1 + 0x194);
    uVar6 = _UNK_1036a1d10;
    if (*(long *)(param_1 + 0x90) == 0) goto LAB_101e17be8;
    *(undefined1 *)(*(long *)(param_1 + 0x90) + 0xad) = 1;
    uVar6 = _UNK_1036a1d18;
    if (((*(long *)(param_1 + 0x90) == 0) || (uVar6 = _UNK_1036a1d20, param_1 == -0x1a0)) ||
       (puVar1 = (undefined4 *)(*(long *)(param_1 + 0x90) + 0x38), uVar6 = _UNK_1036a1d28,
       puVar1 == (undefined4 *)0x0)) goto LAB_101e17be8;
    *puVar1 = *(undefined4 *)(param_1 + 0x1a0);
    lVar7 = *(long *)(param_1 + 0x90);
    uVar6 = _UNK_1036a1d30;
    if ((lVar7 == 0) || (uVar6 = _UNK_1036a1d38, lVar7 == -0x38)) goto LAB_101e17be8;
    *(undefined4 *)(lVar7 + 0x3c) = *(undefined4 *)(param_1 + 0x1a4);
    uVar6 = _UNK_1036a1d40;
    if (*(long *)(param_1 + 0x90) == 0) goto LAB_101e17be8;
    cVar5 = func_0x000100356238(*(long *)(param_1 + 0x90) + 0x38,param_2,param_3);
    if (cVar5 != '\0') {
      *(undefined1 *)(*(long *)(param_1 + 0x90) + 0xad) = 0;
      uVar6 = _UNK_1036a1d80;
      if ((*(long *)(param_1 + 0x90) == 0) ||
         (piVar2 = (int *)(*(long *)(param_1 + 0x90) + 0x38), uVar6 = _UNK_1036a1d88,
         piVar2 == (int *)0x0)) goto LAB_101e17be8;
      *piVar2 = *(int *)(param_1 + 0x1a0) + -4;
      lVar7 = *(long *)(param_1 + 0x90);
      uVar6 = _UNK_1036a1d90;
      if ((lVar7 == 0) || (uVar6 = _UNK_1036a1d98, lVar7 == -0x38)) goto LAB_101e17be8;
      *(int *)(lVar7 + 0x3c) = *(int *)(param_1 + 0x1a4) + 4;
    }
    uVar6 = _UNK_1036a1d48;
    if (*(long *)(param_1 + 0x88) == 0) goto LAB_101e17be8;
    cVar5 = func_0x000100356238(*(long *)(param_1 + 0x88) + 0x38,param_2,param_3);
    if (cVar5 == '\0') {
      return;
    }
    cVar5 = SDV_StardewValley_Menus_MobileFarmChooser_canLeaveMenu_06005e29(param_1);
    if (cVar5 == '\0') {
      return;
    }
    *(undefined1 *)(*(long *)(param_1 + 0x88) + 0xad) = 0;
    uVar6 = _UNK_1036a1d58;
    if ((*(long *)(param_1 + 0x88) == 0) ||
       (piVar2 = (int *)(*(long *)(param_1 + 0x88) + 0x38), uVar6 = _UNK_1036a1d60,
       piVar2 == (int *)0x0)) goto LAB_101e17be8;
    *piVar2 = *(int *)(param_1 + 400) + -4;
    lVar7 = *(long *)(param_1 + 0x88);
    uVar6 = _UNK_1036a1d68;
    uVar3 = _UNK_1036a1d70;
  }
  if ((lVar7 != 0) && (uVar6 = uVar3, lVar7 != -0x38)) {
    *(int *)(lVar7 + 0x3c) = *(int *)(lVar8 + 4) + 4;
    return;
  }
LAB_101e17be8:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101e17bf4);
  (*pcVar4)();
}

