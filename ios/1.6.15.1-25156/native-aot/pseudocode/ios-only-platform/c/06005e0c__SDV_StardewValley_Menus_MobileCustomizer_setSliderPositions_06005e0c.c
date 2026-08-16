/* 0x06005e0c StardewValley.Menus.MobileCustomizer.setSliderPositions @ 0x101e0edf0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer_setSliderPositions_06005e0c(long param_1)

{
  uint uVar1;
  code *pcVar2;
  undefined4 uVar3;
  undefined8 uVar4;
  long lVar5;
  long lVar6;
  int iVar7;
  
  if (lRam0000000103976fb8 == 0) {
    uVar3 = *(undefined4 *)(param_1 + 500);
  }
  else {
    func_0x00010119b8f8();
    uVar3 = *(undefined4 *)(param_1 + 500);
  }
  switch(uVar3) {
  case 0:
    uVar4 = _UNK_1036a04f0;
    if (*(int *)(*(long *)(param_1 + 0x178) + 0x18) == 0) {
code_r0x000101e0f1fc:
      func_0x0001003316f4(0xcc,uVar4);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0f208);
      (*pcVar2)();
    }
    uVar4 = _UNK_1036a04f8;
    if (*(long *)(param_1 + 0x160) != 0) {
      *(int *)(*(long *)(param_1 + 0x160) + 0x10) =
           (int)(((float)*(int *)(param_1 + 0x324) * 100.0) /
                (float)*(int *)(*(long *)(param_1 + 0x178) + 0x20));
      lVar6 = *(long *)(param_1 + 0x180);
      uVar4 = _UNK_1036a0500;
      if (lVar6 != 0) {
        uVar4 = _UNK_1036a0508;
        if (*(uint *)(param_1 + 500) < *(uint *)(lVar6 + 0x18)) {
          *(undefined4 *)(lVar6 + (long)(int)*(uint *)(param_1 + 500) * 4 + 0x20) =
               *(undefined4 *)(param_1 + 0x324);
          uVar3 = SDV_StardewValley_Menus_MobileCustomizer_getSkinColor_06005e00
                            (param_1,*(undefined4 *)(param_1 + 0x324));
          *(undefined4 *)(param_1 + 0x32c) = uVar3;
          return;
        }
        goto code_r0x000101e0f1fc;
      }
    }
    break;
  case 1:
    lVar6 = *(long *)(param_1 + 0x180);
    uVar3 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentHairIndex_06005e0f();
    uVar4 = _UNK_1036a0518;
    if (*(uint *)(lVar6 + 0x18) < 2) goto code_r0x000101e0f1fc;
    *(undefined4 *)(lVar6 + 0x24) = uVar3;
    lVar6 = *(long *)(param_1 + 0x180);
    uVar4 = _UNK_1036a0520;
    if (lVar6 == 0) break;
    uVar4 = _UNK_1036a0528;
    if ((*(uint *)(lVar6 + 0x18) <= *(uint *)(param_1 + 500)) ||
       (uVar4 = _UNK_1036a0538, *(uint *)(*(long *)(param_1 + 0x178) + 0x18) < 2))
    goto code_r0x000101e0f1fc;
    lVar5 = *(long *)(param_1 + 0x160);
    uVar4 = _UNK_1036a0540;
    if (lVar5 == 0) break;
    lVar6 = lVar6 + (long)(int)*(uint *)(param_1 + 500) * 4;
    iVar7 = *(int *)(*(long *)(param_1 + 0x178) + 0x24);
    goto code_r0x000101e0f030;
  case 2:
    uVar4 = _UNK_1036a0550;
    if (*(uint *)(*(long *)(param_1 + 0x178) + 0x18) < 3) goto code_r0x000101e0f1fc;
    uVar4 = _UNK_1036a0558;
    if (*(long *)(param_1 + 0x160) != 0) {
      *(int *)(*(long *)(param_1 + 0x160) + 0x10) =
           (int)(((float)*(int *)(param_1 + 0x328) * 100.0) /
                (float)*(int *)(*(long *)(param_1 + 0x178) + 0x28));
      lVar6 = *(long *)(param_1 + 0x180);
      uVar4 = _UNK_1036a0560;
      if (lVar6 != 0) {
        uVar4 = _UNK_1036a0568;
        if (*(uint *)(param_1 + 500) < *(uint *)(lVar6 + 0x18)) {
          *(undefined4 *)(lVar6 + (long)(int)*(uint *)(param_1 + 500) * 4 + 0x20) =
               *(undefined4 *)(param_1 + 0x328);
          return;
        }
        goto code_r0x000101e0f1fc;
      }
    }
    break;
  case 3:
    lVar5 = *(long *)(param_1 + 0x160);
    lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar4 = _UNK_1036a0578;
    if (*(long *)(lVar6 + 0x390) != 0) {
      uVar4 = _UNK_1036a0588;
      if (*(uint *)(*(long *)(param_1 + 0x178) + 0x18) < 4) goto code_r0x000101e0f1fc;
      uVar4 = _UNK_1036a0590;
      if (lVar5 != 0) {
        *(int *)(lVar5 + 0x10) =
             (int)(((float)*(int *)(*(long *)(lVar6 + 0x390) + 0x68) * 100.0) /
                  (float)*(int *)(*(long *)(param_1 + 0x178) + 0x2c));
        lVar5 = *(long *)(param_1 + 0x180);
        uVar1 = *(uint *)(param_1 + 500);
        lVar6 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar4 = _UNK_1036a05a0;
        if (*(long *)(lVar6 + 0x390) != 0) {
          uVar4 = _UNK_1036a05b0;
          if (uVar1 < *(uint *)(lVar5 + 0x18)) {
            *(undefined4 *)(lVar5 + (long)(int)uVar1 * 4 + 0x20) =
                 *(undefined4 *)(*(long *)(lVar6 + 0x390) + 0x68);
            return;
          }
          goto code_r0x000101e0f1fc;
        }
      }
    }
    break;
  case 4:
    lVar6 = *(long *)(param_1 + 0x180);
    uVar3 = SDV_StardewValley_Menus_MobileCustomizer_GetCurrentPantIndex_06005e0e(param_1);
    uVar4 = _UNK_1036a05c0;
    if (*(uint *)(lVar6 + 0x18) < 5) goto code_r0x000101e0f1fc;
    *(undefined4 *)(lVar6 + 0x30) = uVar3;
    lVar6 = *(long *)(param_1 + 0x180);
    uVar4 = _UNK_1036a05c8;
    if (lVar6 == 0) break;
    uVar4 = _UNK_1036a05d0;
    if ((*(uint *)(lVar6 + 0x18) <= *(uint *)(param_1 + 500)) ||
       (uVar4 = _UNK_1036a05e0, *(uint *)(*(long *)(param_1 + 0x178) + 0x18) < 5))
    goto code_r0x000101e0f1fc;
    lVar5 = *(long *)(param_1 + 0x160);
    uVar4 = _UNK_1036a05e8;
    if (lVar5 == 0) break;
    lVar6 = lVar6 + (long)(int)*(uint *)(param_1 + 500) * 4;
    iVar7 = *(int *)(*(long *)(param_1 + 0x178) + 0x30);
code_r0x000101e0f030:
    *(int *)(lVar5 + 0x10) = (int)(((float)*(int *)(lVar6 + 0x20) * 100.0) / (float)iVar7);
LAB_101e0f054:
    return;
  default:
    goto LAB_101e0f054;
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e0f080);
  (*pcVar2)();
}

