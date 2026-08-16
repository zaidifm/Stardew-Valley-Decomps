/* 0x060066be StardewValley.Mobile.TapToMove.CheckToOpenClosedGate @ 0x101fc5840 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_CheckToOpenClosedGate_060066be
               (undefined1 param_1 [16],float param_2,long param_3)

{
  code *pcVar1;
  undefined4 uVar2;
  long *plVar3;
  undefined8 uVar4;
  long lVar5;
  ulong uVar6;
  undefined8 uVar7;
  long *plVar8;
  float fVar9;
  double dVar10;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar4 = _UNK_1036d6ea8;
  if (param_3 != 0) {
    plVar8 = (long *)(param_3 + 0x60);
    if (*plVar8 == 0) {
      plVar8 = (long *)(param_3 + 0xd8);
      if (*plVar8 == 0) {
        return;
      }
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar4 = _UNK_1036d6eb0;
      if (lVar5 != 0) {
        uVar2 = func_0x000101793b94();
        lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        uVar4 = _UNK_1036d6eb8;
        if (lVar5 != 0) {
          uVar6 = func_0x000101793b94();
          plVar3 = (long *)*plVar8;
          uVar4 = _UNK_1036d6ec0;
          if (plVar3 != (long *)0x0) {
            fVar9 = (float)(**(code **)(*plVar3 + 0x5f8))(plVar3);
            (**(code **)(*(long *)*plVar8 + 0x5f8))();
            dVar10 = (double)StardewValley_StardewValley_Utility_Distance_060042a9
                                       (uVar2,uVar6 >> 0x20,(int)fVar9,(int)param_2);
            if (dVar10 <= 1.5) {
              return;
            }
            plVar3 = (long *)*plVar8;
            uVar7 = StardewValley_StardewValley_Game1_get_player_06002f9a();
            uVar4 = _UNK_1036d6ed0;
            if (plVar3 != (long *)0x0) {
              (**(code **)(*plVar3 + 0x4f0))(plVar3,uVar7,0);
              goto LAB_101fc59c8;
            }
          }
        }
      }
    }
    else {
      SDV_StardewValley_Mobile_TapToMoveUtils_get_PlayerOffsetPosition_060066d5();
      uVar4 = _UNK_1036d6ed8;
      if (*plVar8 != 0) {
        fVar9 = (float)func_0x000100354758();
        if (83.2 <= fVar9) {
          return;
        }
        plVar3 = (long *)SDV_StardewValley_Mobile_TapToMoveUtils_FetchGate_06006719
                                   (*(undefined8 *)(*(long *)(param_3 + 0x28) + 0x10),*plVar8);
        if (plVar3 == (long *)0x0) {
          return;
        }
        if (*(int *)(plVar3[0x44] + 0x68) == 0x58) {
          return;
        }
        uVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
        (**(code **)(*plVar3 + 0x4f0))(plVar3,uVar4,0);
        if (*(long *)(param_3 + 0x68) == 0) {
          DataMemoryBarrier(2,3);
          *(long *)(param_3 + 0xd8) = (long)plVar3;
          *(undefined1 *)(((ulong)(param_3 + 0xd8) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
        }
LAB_101fc59c8:
        *plVar8 = 0;
        return;
      }
    }
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fc5a58);
  (*pcVar1)();
}

