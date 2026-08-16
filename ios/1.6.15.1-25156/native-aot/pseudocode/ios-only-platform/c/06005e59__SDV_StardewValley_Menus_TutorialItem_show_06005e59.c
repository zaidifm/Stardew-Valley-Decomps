/* 0x06005e59 StardewValley.Menus.TutorialItem.show @ 0x101e1d2a0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialItem_show_06005e59
               (undefined1 param_1 [16],float param_2,long param_3)

{
  int iVar1;
  undefined4 uVar2;
  uint uVar3;
  code *pcVar4;
  char cVar5;
  long lVar6;
  undefined8 uVar7;
  ulong uVar8;
  int iVar9;
  undefined8 uVar10;
  int iVar11;
  int iVar12;
  uint uVar13;
  float fVar14;
  int iVar15;
  int iVar16;
  int iVar17;
  int iVar18;
  
  cVar5 = cRam0000000103910c68;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar5 == '\0') {
    func_0x00010119b908(&UNK_103317610);
    cRam0000000103910c68 = '\x01';
  }
  lVar6 = SDV_StardewValley_Menus_TutorialManager_get_Instance_06005e62();
  if (*(char *)(lVar6 + 0xac) == '\0') {
    if (*(int *)(param_3 + 0xcc) != 0x31) {
      return;
    }
  }
  else {
    uVar7 = _UNK_1036a2910;
    if (param_3 == 0) goto LAB_101e1d648;
  }
  *(undefined1 *)(param_3 + 0xb1) = 1;
  if (0.0 < *(float *)(param_3 + 0xd4)) {
    *(undefined1 *)(param_3 + 0xb5) = 1;
    return;
  }
  if (*(char *)(param_3 + 0xb2) != '\0') {
    return;
  }
  if (*(char *)(lRam0000000103900780 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  *puRam0000000103900788 = 1;
  *(undefined1 *)(param_3 + 0xb2) = 1;
  *(undefined4 *)(param_3 + 0xd8) = 0;
  if ((*(long *)(param_3 + 0x80) != 0) &&
     (cVar5 = func_0x00010035011c(*(long *)(param_3 + 0x80),uRam00000001038c4f58), cVar5 != '\0')) {
    uVar10 = *(undefined8 *)(param_3 + 0x80);
    uVar7 = func_0x000100331820(uRam00000001038d6f90,0x108);
    StardewValley_StardewValley_Menus_DialogueBox__ctor_06006076(uVar7,uVar10,0);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_3 + 0x90) = uVar7;
    *(undefined1 *)(((ulong)(param_3 + 0x90) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  }
  if (*(char *)(param_3 + 0xb4) == '\0') {
    return;
  }
  lVar6 = *(long *)(param_3 + 0xa0);
  if (lVar6 == 0) {
    cVar5 = func_0x00010035011c(*(undefined8 *)(param_3 + 0xa8),uRam00000001038c4f58);
    if (cVar5 != '\0') {
      uVar7 = _UNK_1036a2938;
      if (*(long *)(param_3 + 0xa8) == 0) goto LAB_101e1d648;
      cVar5 = func_0x000100353ad8(*(long *)(param_3 + 0xa8),uRam0000000103900798);
      if (cVar5 == '\0') {
        uVar7 = _UNK_1036a2940;
        if (*plRam00000001038e4ba8 == 0) goto LAB_101e1d648;
        fVar14 = (float)StardewValley_StardewValley_Menus_Toolbar_getIconPosition_060065be
                                  (*plRam00000001038e4ba8,*(undefined8 *)(param_3 + 0xa8));
        if (fVar14 != -999.0) {
          uVar3 = *(uint *)(param_3 + 200);
          iVar9 = (int)fVar14;
          iVar11 = (int)param_2;
          iVar12 = (int)(fVar14 + -32.0);
          uVar13 = (uint)(param_2 + -32.0);
          uVar7 = func_0x000100331820(uRam0000000103900790,0x40);
          goto LAB_101e1d57c;
        }
      }
      *(undefined8 *)(param_3 + 0x78) = 0;
      *(undefined1 *)(param_3 + 0xb4) = 0;
      goto LAB_101e1d5ac;
    }
    uVar3 = *(uint *)(param_3 + 200);
    if ((uVar3 | 2) == 3) {
      uVar7 = _UNK_1036a2918;
      if ((param_3 == -0xc0) || (uVar7 = _UNK_1036a2920, param_3 == -0xb8)) {
LAB_101e1d648:
        func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
        pcVar4 = (code *)SoftwareBreakpoint(1,0x101e1d654);
        (*pcVar4)();
      }
      uVar8 = 0x103900000;
      iVar9 = *(int *)(param_3 + 0xc0);
      iVar11 = *(int *)(param_3 + 0xc4);
      iVar12 = *(int *)(param_3 + 0xb8);
      uVar13 = *(uint *)(param_3 + 0xbc);
    }
    else {
      uVar7 = _UNK_1036a2928;
      if ((param_3 == -0xc0) || (uVar7 = _UNK_1036a2930, param_3 == -0xb8)) goto LAB_101e1d648;
      iVar12 = *(int *)(param_3 + 0xb8);
      iVar1 = *(int *)(param_3 + 0xbc);
      iVar9 = *(int *)(param_3 + 0xc0);
      iVar11 = *(int *)(param_3 + 0xc4);
      iVar15 = (uint)((char)iVar1 + (byte)(-(uint)(iVar1 < 0) >> 0x1e) & 3) -
               (-(uint)(iVar1 < 0) >> 0x1e);
      iVar16 = (uint)((char)iVar12 + (byte)(-(uint)(iVar12 < 0) >> 0x1e) & 3) -
               (-(uint)(iVar12 < 0) >> 0x1e);
      iVar17 = (uint)((char)iVar9 + (byte)(-(uint)(iVar9 < 0) >> 0x1e) & 3) -
               (-(uint)(iVar9 < 0) >> 0x1e);
      iVar18 = (uint)((char)iVar11 + (byte)(-(uint)(iVar11 < 0) >> 0x1e) & 3) -
               (-(uint)(iVar11 < 0) >> 0x1e);
      iVar9 = iVar9 - iVar17;
      iVar11 = iVar11 - iVar18;
      iVar12 = iVar12 - iVar16;
      if (2 < iVar18) {
        iVar11 = iVar11 + 4;
      }
      if (2 < iVar17) {
        iVar9 = iVar9 + 4;
      }
      if (2 < iVar16) {
        iVar12 = iVar12 + 4;
      }
      uVar13 = iVar1 - iVar15;
      uVar8 = (ulong)uVar13;
      if (2 < iVar15) {
        uVar13 = uVar13 + 4;
      }
    }
    uVar7 = func_0x000100331820(uVar8,uRam0000000103900790,0x40);
LAB_101e1d57c:
    SDV_StardewValley_Menus_HandPointer__ctor_06005dd6(uVar7,iVar9,iVar11,uVar3,iVar12,uVar13,0);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_3 + 0x78) = uVar7;
  }
  else {
    uVar2 = *(undefined4 *)(param_3 + 200);
    uVar7 = func_0x000100331820(uRam0000000103900790,0x40);
    SDV_StardewValley_Menus_HandPointer__ctor_06005dd6(uVar7,0,0,uVar2,0,0,lVar6);
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_3 + 0x78) = uVar7;
  }
  *(undefined1 *)((param_3 + 0x78U >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
LAB_101e1d5ac:
  lVar6 = *(long *)(param_3 + 0x78);
  if ((lVar6 != 0) && (*(undefined1 *)(lVar6 + 0x38) = 0, *(long *)(lVar6 + 0x18) != 0)) {
    SDV_StardewValley_Menus_tweeningSprite_start_06005e9c();
  }
  return;
}

