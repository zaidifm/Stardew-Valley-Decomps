/* 0x06005db0 StardewValley.Menus.CoopGameMenu.drawExtra @ 0x101df7c8c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_CoopGameMenu_drawExtra_06005db0(long param_1,undefined8 param_2)

{
  undefined4 uVar1;
  undefined4 uVar2;
  undefined4 uVar3;
  undefined4 uVar4;
  char cVar5;
  undefined8 uVar6;
  code *pcVar7;
  undefined4 uVar8;
  int iVar9;
  int extraout_var;
  undefined8 uVar10;
  long lVar11;
  undefined8 uVar12;
  undefined8 uVar13;
  long lVar14;
  float fVar15;
  float fVar16;
  undefined8 uStack_80;
  undefined8 uStack_78;
  
  cVar5 = cRam0000000103910bbf;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910bbf == '\0') goto LAB_101df7e88;
LAB_101df7cd0:
    cVar5 = *(char *)(param_1 + 0x1b0);
  }
  else {
    func_0x00010119b8f8();
    if (cVar5 != '\0') goto LAB_101df7cd0;
LAB_101df7e88:
    func_0x00010119b908(&UNK_1033165c5);
    cRam0000000103910bbf = '\x01';
    cVar5 = *(char *)(param_1 + 0x1b0);
  }
  if ((cVar5 == '\0') || (*(char *)(*(long *)(param_1 + 0x180) + 0x4c) == '\0')) {
    return;
  }
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  uVar12 = *puRam00000001038d53d0;
  uStack_80 = 0;
  uStack_78 = 0;
  func_0x00010034ede4(&uStack_80,0x1b0,0x1b7,9,9);
  uVar6 = uStack_78;
  uVar13 = uStack_80;
  lVar11 = *(long *)(param_1 + 0x180);
  uVar10 = _UNK_10369cfb0;
  if ((lVar11 != 0) && (uVar10 = _UNK_10369cfb8, lVar11 != -0x38)) {
    uVar1 = *(undefined4 *)(lVar11 + 0x38);
    uVar3 = *(undefined4 *)(lVar11 + 0x3c);
    uVar2 = *(undefined4 *)(lVar11 + 0x40);
    uVar4 = *(undefined4 *)(lVar11 + 0x44);
    if (*(float *)(lVar11 + 0x48) <= 0.0) {
      uVar8 = func_0x000100331988();
    }
    else {
      uVar8 = func_0x0001003773ac();
    }
    fVar16 = -1.0;
    StardewValley_StardewValley_Menus_IClickableMenu_drawTextureBox_060061a8
              (0x40800000,0xbf800000,param_2,uVar12,uVar13,uVar6,uVar1,uVar3,uVar2,uVar4,uVar8,1);
    lVar11 = *(long *)(param_1 + 0x180);
    uVar10 = _UNK_10369cfc0;
    if (lVar11 != 0) {
      uVar13 = *(undefined8 *)(lVar11 + 0x18);
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
        lVar11 = *(long *)(param_1 + 0x180);
        uVar10 = _UNK_10369cfc8;
        if (lVar11 == 0) goto LAB_101df7f20;
      }
      lVar14 = *plRam00000001038c4c90;
      iVar9 = func_0x00010035034c(lVar11 + 0x38);
      uVar10 = _UNK_10369cfd0;
      if (*(long *)(param_1 + 0x180) != 0) {
        func_0x00010035034c(*(long *)(param_1 + 0x180) + 0x38);
        uVar10 = _UNK_10369cfd8;
        if ((*(long *)(param_1 + 0x180) != 0) &&
           (uVar10 = _UNK_10369cfe0, *plRam00000001038c4c90 != 0)) {
          fVar15 = (float)func_0x0001003560e4(*plRam00000001038c4c90,
                                              *(undefined8 *)(*(long *)(param_1 + 0x180) + 0x18));
          func_0x0001003501e4((float)iVar9,(float)(extraout_var + 4),fVar15 * 0.5,fVar16 * 0.5);
          StardewValley_StardewValley_Utility_drawTextWithShadow_06004232
                    (param_2,uVar13,lVar14,*puRam00000001038d5c70,0xffffffff,0xffffffff,3);
          return;
        }
      }
    }
  }
LAB_101df7f20:
  func_0x0001003316f4(0xee,uVar10);
                    /* WARNING: Does not return */
  pcVar7 = (code *)SoftwareBreakpoint(1,0x101df7f2c);
  (*pcVar7)();
}

