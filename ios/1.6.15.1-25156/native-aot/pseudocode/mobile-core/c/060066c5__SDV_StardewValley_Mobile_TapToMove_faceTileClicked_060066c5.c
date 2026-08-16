/* 0x060066c5 StardewValley.Mobile.TapToMove.faceTileClicked @ 0x101fc7410 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_faceTileClicked_060066c5
               (undefined1 param_1 [16],float param_2,long param_3,char param_4,int param_5,
               int param_6)

{
  int iVar1;
  char cVar2;
  code *pcVar3;
  bool bVar4;
  bool bVar5;
  int iVar6;
  long lVar7;
  int extraout_var;
  long *plVar8;
  undefined8 uVar9;
  int iVar10;
  int iVar11;
  float fVar12;
  double dVar13;
  float fVar14;
  float fVar15;
  
  cVar2 = cRam00000001039114d4;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_10332575b);
    cRam00000001039114d4 = '\x01';
  }
  lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  iVar1 = *(int *)(*(long *)(lVar7 + 0x38) + 0x68);
  if (param_4 == '\0') {
    if (param_5 == -1000) {
      uVar9 = _UNK_1036d71d8;
      if ((param_3 == -0x110) || (uVar9 = _UNK_1036d71d0, param_3 == 0)) goto LAB_101fc76e8;
      fVar14 = *(float *)(param_3 + 0x110);
      if (param_6 == -1000) goto LAB_101fc74f4;
LAB_101fc74e0:
      fVar15 = (float)param_6;
    }
    else {
      fVar14 = (float)param_5;
      if (param_6 != -1000) goto LAB_101fc74e0;
LAB_101fc74f4:
      uVar9 = _UNK_1036d71e0;
      if ((param_3 == 0) || (uVar9 = _UNK_1036d71e8, param_3 == -0x110)) goto LAB_101fc76e8;
      fVar15 = *(float *)(param_3 + 0x114);
    }
    lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar9 = _UNK_1036d71f0;
    if (lVar7 == 0) {
LAB_101fc76e8:
      func_0x0001003316f4(0xee,uVar9);
                    /* WARNING: Does not return */
      pcVar3 = (code *)SoftwareBreakpoint(1,0x101fc76f4);
      (*pcVar3)();
    }
    iVar6 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
    lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar9 = _UNK_1036d71f8;
    if (lVar7 == 0) goto LAB_101fc76e8;
    iVar10 = (int)(float)iVar6;
    iVar6 = iVar10 + 0x3f;
    if (-1 < iVar10) {
      iVar6 = iVar10;
    }
    StardewValley_StardewValley_Character_get_StandingPixel_06003255();
    iVar11 = (int)(float)extraout_var;
    iVar10 = iVar11 + 0x3f;
    if (-1 < iVar11) {
      iVar10 = iVar11;
    }
    dVar13 = (double)func_0x00010035d358((double)(fVar15 - (float)(iVar10 >> 6)),
                                         (double)(fVar14 - (float)(iVar6 >> 6)));
    if ((_UNK_103333c70 <= dVar13) && (dVar13 <= _UNK_103333c78)) goto LAB_101fc7590;
  }
  else {
    fVar14 = *(float *)(param_3 + 0x108);
    fVar15 = *(float *)(param_3 + 0x10c);
    lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar9 = _UNK_1036d7220;
    if (*(long *)(lVar7 + 0x20) == 0) goto LAB_101fc76e8;
    fVar12 = (float)func_0x0001003436c4();
    dVar13 = (double)func_0x00010035d358((double)(fVar15 - param_2),(double)(fVar14 - fVar12));
    if ((_UNK_103333c70 <= dVar13) && (dVar13 <= _UNK_103333c78)) {
LAB_101fc7590:
      iVar6 = 1;
      if (iVar1 == 1) {
        return;
      }
      goto LAB_101fc75f0;
    }
  }
  if ((dVar13 < _UNK_103333c78) || (_UNK_103333c80 < dVar13)) {
    bVar4 = false;
    bVar5 = true;
    if (_UNK_103333c88 <= dVar13) {
      bVar4 = false;
      bVar5 = true;
      if (!NAN(dVar13) && !NAN(_UNK_103333c70)) {
        bVar4 = dVar13 == _UNK_103333c70;
        bVar5 = _UNK_103333c70 <= dVar13;
      }
    }
    iVar6 = 3;
    if (!bVar5 || bVar4) {
      iVar6 = 0;
    }
    if (iVar6 == iVar1) {
      return;
    }
  }
  else {
    iVar6 = 2;
    if (iVar1 == 2) {
      return;
    }
  }
LAB_101fc75f0:
  plVar8 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
  (**(code **)(*plVar8 + 0x188))();
  plVar8 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
  (**(code **)(*plVar8 + 0x178))(plVar8,iVar6);
  return;
}

