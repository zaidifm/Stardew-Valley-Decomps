/* 0x06005e11 StardewValley.Menus.MobileCustomizer.selectionClick @ 0x101e0f53c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_selectionClick_06005e11(long param_1,int param_2)

{
  int iVar1;
  code *pcVar2;
  int iVar3;
  undefined4 uVar4;
  long lVar5;
  undefined8 uVar6;
  long lVar7;
  undefined8 uVar8;
  uint uVar9;
  
  if (lRam0000000103976fb8 == 0) {
    uVar4 = *(undefined4 *)(param_1 + 500);
  }
  else {
    func_0x00010119b8f8();
    uVar4 = *(undefined4 *)(param_1 + 500);
  }
  switch(uVar4) {
  case 0:
    uVar9 = *(int *)(param_1 + 0x324) + param_2;
    *(uint *)(param_1 + 0x324) = uVar9;
    if ((int)uVar9 < 0) {
      uVar4 = 0x17;
code_r0x000101e0f800:
      *(undefined4 *)(param_1 + 0x324) = uVar4;
    }
    else if (0x17 < uVar9) {
      uVar4 = 0;
      goto code_r0x000101e0f800;
    }
    uVar4 = SDV_StardewValley_Menus_MobileCustomizer_getSkinColor_06005e00(param_1);
    *(undefined4 *)(param_1 + 0x32c) = uVar4;
    if (*(char *)(param_1 + 0x2fc) != '\0') {
      return;
    }
    uVar8 = _UNK_1036a0668;
    if (*(int *)(*(long *)(param_1 + 0x178) + 0x18) == 0) {
code_r0x000101e0fa24:
      func_0x0001003316f4(0xcc,uVar8);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0fa30);
      (*pcVar2)();
    }
    uVar8 = _UNK_1036a0670;
    if (*(long *)(param_1 + 0x160) == 0) {
code_r0x000101e0f89c:
      func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0f8a8);
      (*pcVar2)();
    }
    *(int *)(*(long *)(param_1 + 0x160) + 0x10) =
         (int)(((float)*(int *)(param_1 + 0x324) * 100.0) /
              (float)*(int *)(*(long *)(param_1 + 0x178) + 0x20));
    lVar5 = *(long *)(param_1 + 0x180);
    uVar8 = _UNK_1036a0678;
    if (lVar5 == 0) goto code_r0x000101e0f89c;
    uVar9 = *(uint *)(param_1 + 500);
    uVar8 = _UNK_1036a0680;
    if (*(uint *)(lVar5 + 0x18) <= uVar9) goto code_r0x000101e0fa24;
    iVar3 = *(int *)(param_1 + 0x324);
    break;
  case 1:
    uVar8 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentHairIndex_06005e0f();
    SDV_StardewValley_Menus_MobileCustomizer_SetCurrentHairIndex_06005e10
              (uVar8,(int)uVar8 + param_2);
    if (*(char *)(param_1 + 0x2fc) != '\0') {
      return;
    }
    lVar5 = *(long *)(param_1 + 0x160);
    iVar3 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentHairIndex_06005e0f();
    uVar8 = _UNK_1036a0690;
    if (*(uint *)(*(long *)(param_1 + 0x178) + 0x18) < 2) goto code_r0x000101e0fa24;
    uVar8 = _UNK_1036a0698;
    if (lVar5 == 0) goto code_r0x000101e0f89c;
    *(int *)(lVar5 + 0x10) =
         (int)(((float)iVar3 * 100.0) / (float)*(int *)(*(long *)(param_1 + 0x178) + 0x24));
    lVar5 = *(long *)(param_1 + 0x180);
    uVar9 = *(uint *)(param_1 + 500);
    iVar3 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentHairIndex_06005e0f();
    uVar8 = _UNK_1036a06a8;
    if (*(uint *)(lVar5 + 0x18) <= uVar9) goto code_r0x000101e0fa24;
    break;
  case 2:
    *(int *)(param_1 + 0x328) = *(int *)(param_1 + 0x328) + param_2;
    lVar5 = SDV_StardewValley_Menus_MobileCustomizer_GetValidShirtIds_06005e18(param_1);
    iVar3 = *(int *)(param_1 + 0x328);
    iVar1 = *(int *)(lVar5 + 0x18) + -1;
    if (iVar3 < 0) {
code_r0x000101e0f794:
      iVar3 = iVar1;
      *(int *)(param_1 + 0x328) = iVar3;
    }
    else if (iVar1 < iVar3) {
      iVar1 = 0;
      goto code_r0x000101e0f794;
    }
    if (*(char *)(param_1 + 0x2fc) != '\0') {
      return;
    }
    uVar8 = _UNK_1036a06c0;
    if (*(uint *)(*(long *)(param_1 + 0x178) + 0x18) < 3) goto code_r0x000101e0fa24;
    uVar8 = _UNK_1036a06c8;
    if (*(long *)(param_1 + 0x160) == 0) goto code_r0x000101e0f89c;
    *(int *)(*(long *)(param_1 + 0x160) + 0x10) =
         (int)(((float)iVar3 * 100.0) / (float)*(int *)(*(long *)(param_1 + 0x178) + 0x28));
    lVar5 = *(long *)(param_1 + 0x180);
    uVar8 = _UNK_1036a06d0;
    if (lVar5 == 0) goto code_r0x000101e0f89c;
    uVar9 = *(uint *)(param_1 + 500);
    uVar8 = _UNK_1036a06d8;
    if (*(uint *)(lVar5 + 0x18) <= uVar9) goto code_r0x000101e0fa24;
    iVar3 = *(int *)(param_1 + 0x328);
    break;
  case 3:
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036a06e8;
    if ((*(long *)(lVar7 + 0x390) == 0) || (uVar8 = _UNK_1036a06f0, lVar5 == 0))
    goto code_r0x000101e0f89c;
    StardewValley_StardewValley_Farmer_changeAccessory_06003662
              (lVar5,*(int *)(*(long *)(lVar7 + 0x390) + 0x68) + param_2);
    if (*(char *)(param_1 + 0x2fc) != '\0') {
      return;
    }
    lVar7 = *(long *)(param_1 + 0x160);
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036a0700;
    if (*(long *)(lVar5 + 0x390) == 0) goto code_r0x000101e0f89c;
    uVar8 = _UNK_1036a0710;
    if (*(uint *)(*(long *)(param_1 + 0x178) + 0x18) < 4) goto code_r0x000101e0fa24;
    uVar8 = _UNK_1036a0718;
    if (lVar7 == 0) goto code_r0x000101e0f89c;
    *(int *)(lVar7 + 0x10) =
         (int)(((float)(*(int *)(*(long *)(lVar5 + 0x390) + 0x68) + 1) * 100.0) /
              (float)*(int *)(*(long *)(param_1 + 0x178) + 0x2c));
    lVar5 = *(long *)(param_1 + 0x180);
    uVar9 = *(uint *)(param_1 + 500);
    lVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036a0728;
    if (*(long *)(lVar7 + 0x390) == 0) goto code_r0x000101e0f89c;
    uVar8 = _UNK_1036a0738;
    if (*(uint *)(lVar5 + 0x18) <= uVar9) goto code_r0x000101e0fa24;
    iVar3 = *(int *)(*(long *)(lVar7 + 0x390) + 0x68) + 1;
    break;
  case 4:
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar6 = SDV_StardewValley_Menus_MobileCustomizer_GetValidPantsIds_06005e17(param_1);
    uVar8 = _UNK_1036a0740;
    if (lVar5 == 0) goto code_r0x000101e0f89c;
    iVar3 = StardewValley_StardewValley_Farmer_rotatePantStyle_06003654(lVar5,param_2,uVar6);
    if (*(char *)(param_1 + 0x2fc) != '\0') {
      return;
    }
    uVar8 = _UNK_1036a0750;
    if (*(uint *)(*(long *)(param_1 + 0x178) + 0x18) < 5) goto code_r0x000101e0fa24;
    uVar8 = _UNK_1036a0758;
    if (*(long *)(param_1 + 0x160) == 0) goto code_r0x000101e0f89c;
    *(int *)(*(long *)(param_1 + 0x160) + 0x10) =
         (int)(((float)iVar3 * 100.0) / ((float)*(int *)(*(long *)(param_1 + 0x178) + 0x30) + -1.0))
    ;
    lVar5 = *(long *)(param_1 + 0x180);
    uVar8 = _UNK_1036a0760;
    if (lVar5 == 0) goto code_r0x000101e0f89c;
    uVar9 = *(uint *)(param_1 + 500);
    uVar8 = _UNK_1036a0768;
    if (*(uint *)(lVar5 + 0x18) <= uVar9) goto code_r0x000101e0fa24;
    break;
  default:
    goto LAB_101e0f878;
  }
  *(int *)(lVar5 + (long)(int)uVar9 * 4 + 0x20) = iVar3;
LAB_101e0f878:
  return;
}

