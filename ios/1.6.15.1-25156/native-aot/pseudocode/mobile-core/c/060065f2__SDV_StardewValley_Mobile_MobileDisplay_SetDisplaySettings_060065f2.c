/* 0x060065f2 StardewValley.Mobile.MobileDisplay.SetDisplaySettings @ 0x101fa0054 */

/* WARNING: Removing unreachable block (ram,0x000101fa03f8) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_MobileDisplay_SetDisplaySettings_060065f2(int param_1)

{
  undefined4 uVar1;
  code *pcVar2;
  char cVar3;
  int iVar4;
  undefined8 uVar5;
  long lVar6;
  long *plVar7;
  undefined8 uStack_140;
  undefined8 uStack_138;
  undefined8 uStack_130;
  undefined8 uStack_128;
  undefined8 uStack_118;
  undefined8 uStack_110;
  undefined8 uStack_108;
  undefined8 uStack_100;
  undefined8 uStack_f8;
  undefined8 uStack_f0;
  ulong uStack_e8;
  ulong uStack_e0;
  undefined8 uStack_d8;
  undefined8 uStack_d0;
  undefined8 uStack_c8;
  undefined8 uStack_c0;
  ulong uStack_b8;
  ulong uStack_b0;
  undefined8 uStack_a0;
  undefined8 *puStack_98;
  undefined8 uStack_90;
  undefined8 *puStack_88;
  undefined4 uStack_7c;
  undefined8 uStack_78;
  undefined8 *puStack_70;
  int iStack_64;
  long lStack_60;
  undefined8 uStack_58;
  
  cVar3 = cRam0000000103911401;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1033247b0);
    cRam0000000103911401 = '\x01';
  }
  uStack_118 = 0;
  uStack_b0 = 0;
  uStack_c8 = 0;
  uStack_d0 = 0;
  uStack_b8 = 0;
  uStack_c0 = 0;
  uStack_138 = 0;
  uStack_140 = 0;
  uStack_128 = 0;
  uStack_130 = 0;
  uStack_108 = 0;
  uStack_110 = 0;
  uStack_f8 = 0;
  uStack_100 = 0;
  uStack_e8 = 0;
  uStack_f0 = 0;
  uStack_d8 = 0;
  uStack_e0 = 0;
  if (param_1 == 0x4b) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    plVar7 = (long *)*puRam00000001038d5b58;
    if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    lVar6 = *plRam00000001039044e0;
    uVar5 = _UNK_1036d1538;
    if ((lVar6 == 0) || (uVar5 = _UNK_1036d1540, plVar7 == (long *)0x0)) goto LAB_101fa0288;
    iVar4 = (**(code **)(*plVar7 + 0x90))(plVar7,*(int *)(lVar6 + 0x40) + ~*(uint *)(lVar6 + 0x48));
    uStack_118 = uRam00000001038c4f58;
    uVar5 = _UNK_1036d1548;
    if (*plRam00000001039044e0 == 0) goto LAB_101fa0288;
    func_0x00010037cfc8(&uStack_110,*plRam00000001039044e0);
    iVar4 = iVar4 + 2;
    do {
      while( true ) {
        cVar3 = func_0x00010037cfdc(&uStack_110);
        if (cVar3 == '\0') {
          iVar4 = 2;
          goto LAB_101fa03d0;
        }
        uStack_c8 = uStack_f8;
        uStack_d0 = uStack_100;
        uStack_b8 = uStack_e8;
        uStack_c0 = uStack_f0;
        uStack_b0 = uStack_e0;
        if (lRam0000000103976fb8 != 0) break;
        iVar4 = iVar4 + -1;
        if (iVar4 == 0) goto LAB_101fa01a4;
      }
      func_0x00010119b8f8();
      iVar4 = iVar4 + -1;
    } while (iVar4 != 0);
LAB_101fa01a4:
    uVar1 = (undefined4)uStack_d0;
    uStack_138 = uStack_c0;
    uStack_140 = uStack_c8;
    uStack_128 = uStack_b0;
    uStack_130 = uStack_b8;
    lVar6 = func_0x000100331820(uRam0000000103904510,0x14);
    *(undefined4 *)(lVar6 + 0x10) = uVar1;
    uStack_118 = func_0x000100356abc();
    iVar4 = 1;
LAB_101fa03d0:
    uStack_a0 = 0;
    puStack_98 = &uStack_110;
    uVar5 = _UNK_1036d1550;
    if (puStack_98 == (undefined8 *)0x0) goto LAB_101fa0288;
    if ((iVar4 != 1) && (iVar4 != 2)) {
      func_0x000100331c30();
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa0408);
      (*pcVar2)();
    }
    uStack_a0 = 0;
    func_0x000100332388(uRam00000001039044f8,uStack_138,uRam0000000103904500);
    func_0x00010033180c();
    uVar5 = uStack_118;
    lStack_60 = lRam00000001038d7890;
    uStack_58 = uStack_118;
    if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
      func_0x0001003319b0(lRam00000001038d7890);
    }
    DataMemoryBarrier(2,3);
    *puRam00000001038d7898 = uVar5;
  }
  else {
    if (*(char *)(lRam00000001038d7890 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    uVar5 = _UNK_1036d1510;
    if (*plRam00000001039044e0 == 0) goto LAB_101fa0288;
    func_0x00010037cfa0(&uStack_140,*plRam00000001039044e0,param_1);
  }
  if ((int)uStack_140 == 1) {
    SDV_StardewValley_Mobile_MobileDisplay_Android_SetDisplaySettings_060065f6
              (uStack_130 & 0xffffffff,uStack_130._4_4_,uStack_128 & 0xffffffff,uStack_128._4_4_);
  }
  else {
    puStack_88 = &uStack_90;
    uStack_90 = 0;
    uStack_7c = (undefined4)uStack_128;
                    /* WARNING: Ignoring partial resolution of indirect */
    uStack_90._4_4_ = (undefined4)uStack_128;
    uVar5 = _UNK_1036d1520;
    if (puStack_88 == (undefined8 *)0x0) goto LAB_101fa0288;
                    /* WARNING: Ignoring partial resolution of indirect */
    uStack_90._0_1_ = 1;
    SDV_StardewValley_Mobile_MobileDisplay_iOS_SetDisplaySettings_060065f9
              (uStack_138,uStack_130 & 0xffffffff,uStack_130._4_4_,uStack_90);
  }
  puStack_70 = &uStack_78;
  uStack_78 = 0;
                    /* WARNING: Ignoring partial resolution of indirect */
  uStack_78._4_4_ = param_1;
  iStack_64 = param_1;
  if (puStack_70 != (undefined8 *)0x0) {
                    /* WARNING: Ignoring partial resolution of indirect */
    uStack_78._0_1_ = 1;
    SDV_StardewValley_Mobile_MobileDisplay_PrintInfo_060065f3
              (uStack_78,uStack_130 & 0xffffffff,uStack_130._4_4_,uStack_128 & 0xffffffff);
    return;
  }
  puStack_70 = (undefined8 *)0x0;
  uVar5 = _UNK_1036d1530;
LAB_101fa0288:
  func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fa0294);
  (*pcVar2)();
}

