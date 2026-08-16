/* 0x06005e91 StardewValley.Menus.TutorialManager.ChallengeChoiceCheck @ 0x101e2327c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_ChallengeChoiceCheck_06005e91(long param_1)

{
  undefined8 uVar1;
  code *pcVar2;
  char cVar3;
  int iVar4;
  long lVar5;
  long lVar6;
  undefined8 uVar7;
  undefined8 uVar8;
  undefined4 uVar9;
  long lStack_108;
  undefined8 uStack_100;
  char cStack_e9;
  long lStack_e8;
  long lStack_e0;
  undefined1 uStack_d1;
  long lStack_d0;
  long lStack_c8;
  long lStack_c0;
  undefined8 uStack_b8;
  undefined8 uStack_b0;
  long *plStack_a8;
  uint uStack_9c;
  long lStack_98;
  long lStack_90;
  long lStack_88;
  undefined8 uStack_80;
  undefined8 uStack_78;
  long *plStack_70;
  uint uStack_64;
  long lStack_60;
  long lStack_58;
  
  cVar3 = cRam0000000103910ca0;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103317b20);
    cRam0000000103910ca0 = '\x01';
  }
  cStack_e9 = '\0';
  lStack_e8 = 0;
  if (*(int *)(param_1 + 0xa8) == 2) {
    lStack_108 = 0;
    uStack_100 = 0;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    cStack_e9 = '\0';
    uVar8 = *puRam00000001038d5478;
    iVar4 = func_0x000100331adc(uVar8,&cStack_e9);
    if (iVar4 == 0) {
      func_0x000100331bb8(uVar8,&cStack_e9);
    }
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (*pcRam00000001038d5480 == '\0') {
      lVar5 = StardewValley_StardewValley_Game1_get_MasterPlayer_06002ffa();
      if ((lVar5 == 0) || (*(long *)(lVar5 + 0x228) == 0)) {
        func_0x0001003316f4(0xee,_UNK_1036a3110);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101e23720);
        (*pcVar2)();
      }
      cVar3 = func_0x000100354410(*(long *)(lVar5 + 0x228),uRam00000001038d76e0);
      if (cVar3 == '\0') {
        uVar9 = 1;
        uStack_100 = uRam0000000103900a38;
      }
      else {
        uVar9 = 2;
        lStack_108 = lRam0000000103900a40;
      }
    }
    else if (*pcRam00000001038d5480 == '\x01') {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if ((lVar5 == 0) ||
         (cVar3 = StardewValley_StardewValley_Farmer_get_hasSkullKey_0600356a(), cVar3 == '\0')) {
        uVar9 = 3;
        uStack_100 = uRam0000000103900a48;
      }
      else {
        uVar9 = 4;
        lStack_108 = lRam0000000103900a50;
      }
    }
    else {
      uVar9 = 5;
    }
    lStack_e0 = 0;
    if (cStack_e9 != '\0') {
      func_0x000100331c1c(uVar8);
    }
    switch(uVar9) {
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
      if (lStack_e0 != 0) {
        func_0x000100331ba4();
      }
      lStack_d0 = lStack_108;
      if (lStack_108 == 0) {
        uStack_d1 = true;
      }
      else {
        uStack_d1 = *(int *)(lStack_108 + 0x10) == 0;
      }
      break;
    default:
      func_0x000100331c30();
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101e2378c);
      (*pcVar2)();
    }
    if ((bool)uStack_d1 == false) {
      lVar6 = func_0x000100331820(uRam00000001038d5af8,0x20);
      lVar5 = lRam00000001038c4be0;
      uVar8 = _UNK_1036a3048;
      lStack_c8 = lVar6;
      if (lVar6 != 0) {
        DataMemoryBarrier(2,3);
        *(undefined8 *)(lVar6 + 0x10U) = *puRam00000001038d5b00;
        *(undefined1 *)((lVar6 + 0x10U >> 9 & 0x7fffff) + lVar5) = 1;
        uVar1 = uRam0000000103900a20;
        uVar7 = uRam0000000103900a18;
        lStack_e8 = lVar6;
        lStack_c0 = func_0x000100331820(uRam00000001038e38c8,0x28);
        uStack_b8 = uVar7;
        uStack_b0 = uVar1;
        uVar8 = _UNK_1036a3050;
        if (lStack_c0 != 0) {
          DataMemoryBarrier(2,3);
          *(undefined8 *)(lStack_c0 + 0x10) = uVar7;
          *(undefined1 *)(((ulong)(lStack_c0 + 0x10) >> 9 & 0x7fffff) + lVar5) = 1;
          uVar8 = _UNK_1036a3058;
          if (lStack_c0 != 0) {
            DataMemoryBarrier(2,3);
            *(undefined8 *)(lStack_c0 + 0x18) = uVar1;
            *(undefined1 *)(((ulong)(lStack_c0 + 0x18) >> 9 & 0x7fffff) + lVar5) = 1;
            plStack_a8 = (long *)0x0;
            uStack_9c = 0;
            uVar8 = _UNK_1036a3060;
            lStack_98 = lVar6;
            lStack_90 = lStack_c0;
            if (((lVar6 != 0) && (uVar8 = _UNK_1036a3068, lVar6 != 0)) &&
               (uVar8 = _UNK_1036a3070, lVar6 != 0)) {
              *(int *)(lVar6 + 0x1c) = *(int *)(lVar6 + 0x1c) + 1;
              plStack_a8 = *(long **)(lVar6 + 0x10);
              uStack_9c = *(uint *)(lVar6 + 0x18);
              if (uStack_9c < *(uint *)(plStack_a8 + 3)) {
                uVar8 = _UNK_1036a30f8;
                if (lVar6 == 0) goto code_r0x000101e238b4;
                *(uint *)(lVar6 + 0x18) = uStack_9c + 1;
                (**(code **)(*plStack_a8 + 0x110))(plStack_a8,(long)(int)uStack_9c,lStack_c0);
              }
              else {
                func_0x0001003548d4(lVar6,lStack_c0);
              }
              lVar6 = lStack_e8;
              uVar1 = uRam0000000103900a30;
              uVar7 = uRam0000000103900a28;
              lStack_88 = func_0x000100331820(uRam00000001038e38c8,0x28);
              uStack_80 = uVar7;
              uStack_78 = uVar1;
              uVar8 = _UNK_1036a3090;
              if (lStack_88 != 0) {
                DataMemoryBarrier(2,3);
                *(undefined8 *)(lStack_88 + 0x10) = uVar7;
                *(undefined1 *)(((ulong)(lStack_88 + 0x10) >> 9 & 0x7fffff) + lVar5) = 1;
                uVar8 = _UNK_1036a3098;
                if (lStack_88 != 0) {
                  DataMemoryBarrier(2,3);
                  *(undefined8 *)(lStack_88 + 0x18) = uVar1;
                  *(undefined1 *)(((ulong)(lStack_88 + 0x18) >> 9 & 0x7fffff) + lVar5) = 1;
                  lStack_60 = lVar6;
                  uVar8 = _UNK_1036a30a0;
                  lStack_58 = lStack_88;
                  if (((lVar6 != 0) && (uVar8 = _UNK_1036a30a8, lVar6 != 0)) &&
                     (uVar8 = _UNK_1036a30b0, lVar6 != 0)) {
                    *(int *)(lVar6 + 0x1c) = *(int *)(lVar6 + 0x1c) + 1;
                    plStack_70 = *(long **)(lVar6 + 0x10);
                    uStack_64 = *(uint *)(lVar6 + 0x18);
                    if (uStack_64 < *(uint *)(plStack_70 + 3)) {
                      uVar8 = _UNK_1036a30e8;
                      if (lVar6 == 0) goto code_r0x000101e238b4;
                      *(uint *)(lVar6 + 0x18) = uStack_64 + 1;
                      (**(code **)(*plStack_70 + 0x110))(plStack_70,(long)(int)uStack_64,lStack_88);
                    }
                    else {
                      func_0x0001003548d4(lVar6,lStack_88);
                    }
                    uVar8 = _UNK_1036a30d0;
                    if (lStack_e8 != 0) {
                      uVar8 = func_0x00010036164c();
                      StardewValley_StardewValley_Menus_DialogueBox_GetWidth_0600609a();
                      uVar7 = func_0x000100331820(uRam00000001038d6f90,0x108);
                      StardewValley_StardewValley_Menus_DialogueBox__ctor_06006077
                                (uVar7,lStack_108,uVar8);
                      uVar8 = _UNK_1036a30d8;
                      if (param_1 != 0) {
                        DataMemoryBarrier(2,3);
                        *(undefined8 *)(param_1 + 0xa0) = uVar7;
                        *(undefined1 *)(((ulong)(param_1 + 0xa0) >> 9 & 0x7fffff) + lVar5) = 1;
                        uVar8 = _UNK_1036a30e0;
                        if (param_1 != 0) {
                          *(undefined4 *)(param_1 + 0xa8) = 3;
                          return;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
code_r0x000101e238b4:
      func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101e238c0);
      (*pcVar2)();
    }
    StardewValley_StardewValley_Game1_ResetLinkedChallenge_06002f8d();
    func_0x0001003323d8(uRam0000000103900a10,uStack_100);
    StardewValley_StardewValley_Game1_drawObjectDialogue_060030be();
  }
  return;
}

