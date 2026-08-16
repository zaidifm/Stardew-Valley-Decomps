/* 0x060066ba StardewValley.Mobile.TapToMove.CheckToRetargetFarmAnimal @ 0x101fc40ac */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_CheckToRetargetFarmAnimal_060066ba(long param_1)

{
  uint uVar1;
  int iVar2;
  char cVar3;
  code *pcVar4;
  int iVar5;
  uint uVar6;
  long lVar7;
  uint extraout_var;
  int extraout_var_00;
  undefined8 uVar8;
  float fVar9;
  
  cVar3 = cRam00000001039114c9;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039114c9 == '\0') goto LAB_101fc41f4;
LAB_101fc40dc:
    lVar7 = *(long *)(param_1 + 0x80);
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 != '\0') goto LAB_101fc40dc;
LAB_101fc41f4:
    func_0x00010119b908(&UNK_103325690);
    cRam00000001039114c9 = '\x01';
    lVar7 = *(long *)(param_1 + 0x80);
  }
  if (lVar7 == 0) {
    return;
  }
  uVar8 = _UNK_1036d6a98;
  if (param_1 != -0x110) {
    fVar9 = *(float *)(param_1 + 0x110);
    if (fVar9 == -1.0) {
      return;
    }
    iVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
    iVar2 = iVar5 + 0x3f;
    if (-1 < iVar5) {
      iVar2 = iVar5;
    }
    if (fVar9 == (float)(iVar2 >> 6)) {
      uVar8 = _UNK_1036d6ac0;
      if (*(long *)(param_1 + 0x80) == 0) goto LAB_101fc4268;
      fVar9 = *(float *)(param_1 + 0x114);
      StardewValley_StardewValley_Character_get_StandingPixel_06003255();
      iVar2 = extraout_var_00 + 0x3f;
      if (-1 < extraout_var_00) {
        iVar2 = extraout_var_00;
      }
      if (fVar9 == (float)(iVar2 >> 6)) {
        return;
      }
    }
    uVar8 = _UNK_1036d6aa0;
    if (*(long *)(param_1 + 0x80) != 0) {
      uVar6 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
      uVar1 = uVar6 + 0x3f;
      if (-1 < (int)uVar6) {
        uVar1 = uVar6;
      }
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar8 = _UNK_1036d6aa8;
      if ((piRam00000001038d5380 != (int *)0x0) &&
         (uVar8 = _UNK_1036d6ab0, *(long *)(param_1 + 0x80) != 0)) {
        iVar2 = *piRam00000001038d5380;
        StardewValley_StardewValley_Character_get_StandingPixel_06003255();
        uVar8 = _UNK_1036d6ab8;
        if (piRam00000001038d5380 != (int *)0x0) {
          uVar6 = extraout_var + 0x3f;
          if (-1 < (int)extraout_var) {
            uVar6 = extraout_var;
          }
          SDV_StardewValley_Mobile_TapToMove_OnTap_060066a5
                    (param_1,(uVar1 & 0xffffffc0 | 0x20) - iVar2,
                     (uVar6 & 0xffffffc0 | 0x20) - piRam00000001038d5380[1],*piRam00000001038d5380,
                     piRam00000001038d5380[1],0);
          return;
        }
      }
    }
  }
LAB_101fc4268:
  func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101fc4274);
  (*pcVar4)();
}

