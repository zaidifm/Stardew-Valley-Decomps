/* 0x06005e22 StardewValley.Menus.MobileFarmChooser.selectionClick @ 0x101e16e64 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileFarmChooser_selectionClick_06005e22
               (undefined8 param_1,undefined8 param_2,int param_3)

{
  int iVar1;
  int *piVar2;
  code *pcVar3;
  char cVar4;
  long lVar5;
  undefined8 uVar6;
  long lVar7;
  float fVar8;
  float fVar9;
  
  cVar4 = cRam0000000103910c31;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar4 == '\0') {
    func_0x00010119b908(&UNK_1033173a0);
    cRam0000000103910c31 = '\x01';
  }
  cVar4 = func_0x000100345aa0(param_2,uRam0000000103900708);
  if (cVar4 == '\0') {
    cVar4 = func_0x000100345aa0(param_2,uRam0000000103900740);
    if (cVar4 == '\0') {
      cVar4 = func_0x000100345aa0(param_2,uRam0000000103900750);
      if (cVar4 != '\0') {
        StardewValley_StardewValley_Game1_playSound_0600301b(uRam00000001038dfd20,0);
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar6 = _UNK_1036a1af8;
        if (lVar5 != 0) {
          lVar5 = StardewValley_StardewValley_Farmer_get_team_06003559();
          lVar7 = *(long *)(lVar5 + 0x28);
          lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
          uVar6 = _UNK_1036a1b08;
          if (lVar5 != 0) {
            lVar5 = StardewValley_StardewValley_Farmer_get_team_06003559();
            uVar6 = _UNK_1036a1b18;
            if ((*(long *)(lVar5 + 0x28) != 0) && (uVar6 = _UNK_1036a1b20, lVar7 != 0)) {
              func_0x00010035197c(lVar7,*(char *)(*(long *)(lVar5 + 0x28) + 0x68) == '\0');
              return;
            }
          }
        }
        goto LAB_101e17134;
      }
    }
    else {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if ((1.0 <= *(float *)(lVar5 + 0x748)) || (-1 < param_3)) {
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        if (*(float *)(lVar5 + 0x748) <= 0.25) {
          return;
        }
        if (param_3 < 1) {
          return;
        }
        StardewValley_StardewValley_Game1_playSound_0600301b(uRam00000001038e68b8,0);
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        fVar8 = *(float *)(lVar5 + 0x748);
        fVar9 = -0.25;
      }
      else {
        StardewValley_StardewValley_Game1_playSound_0600301b(uRam00000001038f7ad8,0);
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        fVar8 = *(float *)(lVar5 + 0x748);
        fVar9 = 0.25;
      }
      *(float *)(lVar5 + 0x748) = fVar8 + fVar9;
    }
  }
  else {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if ((*piRam00000001038d7c40 != 0) || (-1 < param_3)) {
      if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      uVar6 = _UNK_1036a1ac8;
      if (*plRam00000001038d5710 == 0) {
LAB_101e17134:
        func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
        pcVar3 = (code *)SoftwareBreakpoint(1,0x101e17140);
        (*pcVar3)();
      }
      if ((*piRam00000001038d7c40 != *(int *)(*plRam00000001038d5710 + 0x40) + -1) || (param_3 < 1))
      {
        StardewValley_StardewValley_Game1_playSound_0600301b(uRam00000001038ecae8,0);
      }
    }
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    piVar2 = piRam00000001038d7c40;
    param_3 = *piRam00000001038d7c40 + param_3;
    *piRam00000001038d7c40 = param_3;
    iVar1 = *(int *)(*plRam00000001038d5710 + 0x40) + -1;
    if (param_3 <= iVar1) {
      iVar1 = param_3;
    }
    if (iVar1 < 1) {
      iVar1 = 0;
    }
    *piVar2 = iVar1;
  }
  return;
}

