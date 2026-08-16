/* 0x06005e99 StardewValley.Menus.tweeningSprite.setUp @ 0x101e23e94 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_tweeningSprite_setUp_06005e99
               (undefined4 param_1,long param_2,long param_3,char param_4)

{
  int iVar1;
  int iVar2;
  int iVar3;
  long lVar4;
  long *plVar5;
  char cVar6;
  code *pcVar7;
  long lVar8;
  long lVar9;
  undefined8 uVar10;
  undefined8 uVar11;
  float fVar12;
  
  cVar6 = cRam0000000103910ca8;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910ca8 == '\0') goto LAB_101e24078;
LAB_101e23ed4:
    *(char *)(param_2 + 0x54) = param_4;
  }
  else {
    func_0x00010119b8f8();
    if (cVar6 != '\0') goto LAB_101e23ed4;
LAB_101e24078:
    func_0x00010119b908(&UNK_103317ba0);
    cRam0000000103910ca8 = '\x01';
    *(char *)(param_2 + 0x54) = param_4;
  }
  uVar10 = _UNK_1036a3168;
  if ((param_3 != 0) && (uVar10 = _UNK_1036a3170, param_3 != -0x38)) {
    iVar1 = *(int *)(param_3 + 0x40);
    iVar2 = *(int *)(param_3 + 0x44);
    iVar3 = *(int *)(param_3 + 0x3c);
    if (iVar1 < 0) {
      iVar1 = iVar1 + 1;
    }
    if (iVar2 < 0) {
      iVar2 = iVar2 + 1;
    }
    *(float *)(param_2 + 0x3c) = (float)(*(int *)(param_3 + 0x38) + (iVar1 >> 1));
    *(float *)(param_2 + 0x40) = (float)(iVar3 + (iVar2 >> 1));
    uVar11 = *(undefined8 *)(param_2 + 0x3c);
    lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
    uVar10 = _UNK_1036a3178;
    if (lVar8 != 0) {
      fVar12 = *(float *)(lVar8 + 400);
      *(float *)(param_2 + 0x3c) = fVar12 * (float)uVar11;
      *(float *)(param_2 + 0x40) = fVar12 * (float)((ulong)uVar11 >> 0x20);
      if (param_4 == '\0') {
        iVar1 = *(int *)(param_3 + 0x40);
        iVar2 = *(int *)(param_3 + 0x44);
        iVar3 = *(int *)(param_3 + 0x3c);
        if (iVar1 < 0) {
          iVar1 = iVar1 + 1;
        }
        if (iVar2 < 0) {
          iVar2 = iVar2 + 1;
        }
        *(float *)(param_2 + 0x34) = (float)(*(int *)(param_3 + 0x38) + (iVar1 >> 1) + -0x40);
        *(float *)(param_2 + 0x38) = (float)(iVar3 + (iVar2 >> 1) + 0x40);
        uVar11 = *(undefined8 *)(param_2 + 0x34);
        lVar8 = StardewValley_StardewValley_Game1_get_options_06002fec();
        uVar10 = _UNK_1036a3180;
        if (lVar8 == 0) goto LAB_101e240cc;
        fVar12 = *(float *)(lVar8 + 400);
        *(float *)(param_2 + 0x34) = fVar12 * (float)uVar11;
        *(float *)(param_2 + 0x38) = fVar12 * (float)((ulong)uVar11 >> 0x20);
      }
      else {
        *(undefined8 *)(param_2 + 0x34) = *(undefined8 *)(param_2 + 0x3c);
      }
      *(undefined4 *)(param_2 + 0x44) = param_1;
      *(undefined1 *)(param_2 + 0x30) = 0;
      lVar8 = *plRam0000000103900a60;
      if (lVar8 == 0) {
        lVar8 = func_0x000100331820(uRam00000001038d4fc8,0x80);
        uVar10 = uRam00000001038d4fd8;
        lVar4 = lRam00000001038d4fd0;
        *(long *)(lVar8 + 0x40) = lRam00000001038d4fd0;
        *(undefined8 *)(lVar8 + 0x28) = uVar10;
        *(undefined8 *)(lVar8 + 0x18) = *(undefined8 *)(lVar4 + 0x30);
        plVar5 = plRam0000000103900a60;
        *(undefined8 *)(lVar8 + 0x10) = *(undefined8 *)(lVar4 + 0x28);
        DataMemoryBarrier(2,3);
        *plVar5 = lVar8;
      }
      lVar9 = func_0x000100331820(uRam0000000103900a68,0x48);
      lVar4 = lRam00000001038c4be0;
      DataMemoryBarrier(2,3);
      *(long *)(lVar9 + 0x10) = lVar8;
      *(undefined1 *)(((ulong)(lVar9 + 0x10) >> 9 & 0x7fffff) + lVar4) = 1;
      *(undefined4 *)(lVar9 + 0x28) = 2;
      DataMemoryBarrier(2,3);
      *(long *)(param_2 + 0x10) = lVar9;
      *(undefined1 *)(((ulong)(param_2 + 0x10) >> 9 & 0x7fffff) + lVar4) = 1;
      return;
    }
  }
LAB_101e240cc:
  func_0x0001003316f4(0xee,uVar10);
                    /* WARNING: Does not return */
  pcVar7 = (code *)SoftwareBreakpoint(1,0x101e240d8);
  (*pcVar7)();
}

