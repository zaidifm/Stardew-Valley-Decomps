/* 0x060066a2 StardewValley.Mobile.TapToMove.OnButtonAHeld @ 0x101fb2d84 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_OnButtonAHeld_060066a2(float param_1,long param_2)

{
  code *pcVar1;
  bool bVar2;
  bool bVar3;
  char cVar4;
  long lVar5;
  long *plVar6;
  int iVar7;
  undefined4 uVar8;
  
  if (lRam0000000103976fb8 == 0) {
    cVar4 = *(char *)(param_2 + 0x14d);
  }
  else {
    func_0x00010119b8f8();
    cVar4 = *(char *)(param_2 + 0x14d);
  }
  if (cVar4 == '\0') {
    *(undefined1 *)(param_2 + 0x14d) = 1;
    if (*(char *)(param_2 + 0xf7) != '\0') {
      return;
    }
    SDV_StardewValley_Mobile_TapToMove_Reset_06006698(param_2,1);
    *(undefined1 *)(param_2 + 0xf7) = 1;
    if ((param_1 < -22.5) || (22.5 <= param_1)) {
      if ((param_1 < 22.5) || (67.5 <= param_1)) {
        if ((param_1 < 67.5) || (112.5 <= param_1)) {
          if ((param_1 < 112.5) || (157.5 <= param_1)) {
            if ((-112.5 <= param_1) || (param_1 < -157.5)) {
              if ((-22.5 <= param_1) || (param_1 < -67.5)) {
                bVar2 = false;
                if ((-112.5 <= param_1) && (bVar2 = false, !NAN(param_1))) {
                  bVar2 = param_1 < -67.5;
                }
                uVar8 = 3;
                if (bVar2) {
                  uVar8 = 1;
                }
              }
              else {
                uVar8 = 6;
              }
            }
            else {
              uVar8 = 5;
            }
          }
          else {
            uVar8 = 7;
          }
        }
        else {
          uVar8 = 2;
        }
      }
      else {
        uVar8 = 8;
      }
    }
    else {
      uVar8 = 4;
    }
    *(undefined4 *)(param_2 + 0x154) = uVar8;
    if ((param_1 <= -135.0) || (-45.0 < param_1)) {
      if ((param_1 < 45.0) || (135.0 < param_1)) {
        bVar2 = true;
        bVar3 = false;
        if (param_1 <= 45.0) {
          bVar2 = false;
          bVar3 = true;
          if (!NAN(param_1)) {
            bVar2 = param_1 < -45.0;
            bVar3 = false;
          }
        }
        uVar8 = 3;
        if (bVar2 == bVar3) {
          uVar8 = 1;
        }
      }
      else {
        uVar8 = 2;
      }
    }
    else {
      uVar8 = 0;
    }
    *(undefined4 *)(param_2 + 0x150) = uVar8;
  }
  else {
    if ((param_1 <= -135.0) || (-45.0 < param_1)) {
      if ((param_1 < 45.0) || (135.0 < param_1)) {
        bVar2 = true;
        bVar3 = false;
        if (param_1 <= 45.0) {
          bVar2 = false;
          bVar3 = true;
          if (!NAN(param_1)) {
            bVar2 = param_1 < -45.0;
            bVar3 = false;
          }
        }
        iVar7 = 3;
        if (bVar2 == bVar3) {
          iVar7 = 1;
        }
      }
      else {
        iVar7 = 2;
      }
    }
    else {
      iVar7 = 0;
    }
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if (*(int *)(*(long *)(lVar5 + 0x38) + 0x68) == iVar7) {
      return;
    }
    if ((*(int *)(param_2 + 0x150) == iVar7) && (*(int *)(param_2 + 0x124) == 0xd)) {
      return;
    }
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    if ((*(char *)(lVar5 + 0x76c) == '\0') &&
       (lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
       *(char *)(*(long *)(lVar5 + 0x530) + 0x68) != '\0')) {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if (lVar5 == 0) {
        func_0x0001003316f4(0xee,_UNK_1036d3f60);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fb322c);
        (*pcVar1)();
      }
      plVar6 = (long *)StardewValley_StardewValley_Farmer_get_CurrentTool_0600359c();
      cVar4 = (**(code **)(*plVar6 + 0x400))();
      if (cVar4 != '\0') {
        plVar6 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
        (**(code **)(*plVar6 + 0x188))();
        lVar5 = *(long *)(param_2 + 0x18);
        *(undefined1 *)(param_2 + 0xf7) = 0;
        *(undefined1 *)(lVar5 + 0x15) = 0;
        *(undefined1 *)(lVar5 + 0x16) = *(undefined1 *)(lVar5 + 0x17);
        *(undefined1 *)(lVar5 + 0x17) = 0;
      }
    }
    if ((param_1 < -22.5) || (22.5 <= param_1)) {
      if ((param_1 < 22.5) || (67.5 <= param_1)) {
        if ((param_1 < 67.5) || (112.5 <= param_1)) {
          if ((param_1 < 112.5) || (157.5 <= param_1)) {
            if ((-112.5 <= param_1) || (param_1 < -157.5)) {
              if ((-22.5 <= param_1) || (param_1 < -67.5)) {
                bVar2 = false;
                if ((-112.5 <= param_1) && (bVar2 = false, !NAN(param_1))) {
                  bVar2 = param_1 < -67.5;
                }
                uVar8 = 3;
                if (bVar2) {
                  uVar8 = 1;
                }
              }
              else {
                uVar8 = 6;
              }
            }
            else {
              uVar8 = 5;
            }
          }
          else {
            uVar8 = 7;
          }
        }
        else {
          uVar8 = 2;
        }
      }
      else {
        uVar8 = 8;
      }
    }
    else {
      uVar8 = 4;
    }
    *(undefined4 *)(param_2 + 0x154) = uVar8;
    *(int *)(param_2 + 0x150) = iVar7;
  }
  *(undefined4 *)(param_2 + 0x124) = 0xd;
  return;
}

