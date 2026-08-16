/* 0x060031cd StardewValley.TutorialMessage..ctor @ 0x101784f10 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_TutorialMessage__ctor_060031cd
               (long param_1,undefined8 param_2,int param_3,int param_4,int param_5,
               undefined4 param_6)

{
  int iVar1;
  long lVar2;
  char cVar3;
  code *pcVar4;
  undefined4 uVar5;
  undefined8 uVar6;
  long lVar7;
  undefined8 *puVar8;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  
  cVar3 = cRam000000010390dfdc;
  puVar8 = &uStack_80;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1032d2f10);
    cRam000000010390dfdc = '\x01';
  }
  uVar6 = _UNK_1035f2f60;
  if (param_1 != 0) {
    *(undefined8 *)(param_1 + 0x88) = 0xffffffff3f800000;
    lVar2 = lRam00000001038c4be0;
    DataMemoryBarrier(2,3);
    *(undefined8 *)(param_1 + 0x20) = uRam00000001038d6940;
    *(undefined1 *)(((ulong)(param_1 + 0x20) >> 9 & 0x7fffff) + lVar2) = 1;
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    lVar7 = lRam00000001038d5380;
    uVar6 = _UNK_1035f2f70;
    if ((lRam00000001038d5380 != -8) && (uVar6 = _UNK_1035f2f68, lRam00000001038d5380 != 0)) {
      *(float *)(param_1 + 0xa8) = (float)*(int *)(lRam00000001038d5380 + 8) / 1280.0;
      *(float *)(param_1 + 0xac) = (float)*(int *)(lVar7 + 0xc) / 720.0;
      if (param_3 == -1) {
        iVar1 = *piRam00000001038dee10;
        if (((*(char *)(lRam00000001038c4c88 + 0x35) == '\0') &&
            (func_0x0001003319b0(), uVar6 = _UNK_1035f2f78, lVar7 = lRam00000001038d5380,
            lRam00000001038d5380 == 0)) || (uVar6 = _UNK_1035f2f80, lVar7 == -8))
        goto LAB_101785164;
        param_6 = 0x80;
        puVar8 = &uStack_70;
        param_4 = *(int *)(lVar7 + 0xc) + -0x100;
        uStack_70 = 0;
        uStack_68 = 0;
        param_3 = iVar1 + 0x28 + *piRam00000001038d57b8;
        param_5 = (*(int *)(lVar7 + 8) - (*piRam00000001038d57b8 + *piRam00000001038dee10)) + -0x28;
      }
      else {
        uStack_80 = 0;
        uStack_78 = 0;
      }
      func_0x00010034ede4(puVar8,param_3,param_4,param_5,param_6);
      uVar6 = *puVar8;
      *(undefined8 *)(param_1 + 0xa0) = puVar8[1];
      *(undefined8 *)(param_1 + 0x98) = uVar6;
      DataMemoryBarrier(2,3);
      *(undefined8 *)(param_1 + 0x68) = param_2;
      *(undefined1 *)(((ulong)(param_1 + 0x68) >> 9 & 0x7fffff) + lVar2) = 1;
      uVar5 = func_0x000100356c24();
      *(undefined4 *)(param_1 + 0x80) = uVar5;
      *(undefined4 *)(param_1 + 0x84) = 0x459c4000;
      uVar6 = func_0x000100331820(uRam00000001038d6f90,0x108);
      StardewValley_StardewValley_Menus_DialogueBox__ctor_06006076(uVar6,param_2,1);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(param_1 + 0x78) = uVar6;
      *(undefined1 *)(((ulong)(param_1 + 0x78) >> 9 & 0x7fffff) + lVar2) = 1;
      return;
    }
  }
LAB_101785164:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x101785170);
  (*pcVar4)();
}

