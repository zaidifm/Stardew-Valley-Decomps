/* 0x06005e02 StardewValley.Menus.MobileCustomizer..ctor @ 0x101e06fdc */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_MobileCustomizer__ctor_06005e02
               (long *param_1,undefined4 param_2,undefined4 param_3,undefined4 param_4,
               undefined4 param_5,int param_6,long param_7)

{
  int iVar1;
  code *pcVar2;
  char cVar3;
  undefined4 uVar4;
  long lVar5;
  long *plVar6;
  undefined8 uVar7;
  long lVar8;
  long lVar9;
  ulong uVar10;
  long lVar11;
  
  cVar3 = cRam0000000103910c11;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103316c90);
    cRam0000000103910c11 = '\x01';
  }
  lVar5 = func_0x000100331820(uRam0000000103900358,0x20);
  lVar8 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar5 + 0x10) = *puRam0000000103900360;
  *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar8) = 1;
  uVar7 = _UNK_10369f000;
  if (param_1 == (long *)0x0) goto LAB_101e07e0c;
  DataMemoryBarrier(2,3);
  param_1[0x10] = lVar5;
  *(undefined1 *)(((ulong)(param_1 + 0x10) >> 9 & 0x7fffff) + lVar8) = 1;
  lVar5 = func_0x000100331820(uRam0000000103900358,0x20);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar5 + 0x10) = *puRam0000000103900360;
  *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar8) = 1;
  DataMemoryBarrier(2,3);
  param_1[0x15] = lVar5;
  *(undefined1 *)(((ulong)(param_1 + 0x15) >> 9 & 0x7fffff) + lVar8) = 1;
  lVar5 = func_0x000100331820(uRam0000000103900358,0x20);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar5 + 0x10) = *puRam0000000103900360;
  *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar8) = 1;
  DataMemoryBarrier(2,3);
  param_1[0x16] = lVar5;
  *(undefined1 *)(((ulong)(param_1 + 0x16) >> 9 & 0x7fffff) + lVar8) = 1;
  lVar5 = func_0x000100331820(uRam0000000103900358,0x20);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar5 + 0x10) = *puRam0000000103900360;
  *(undefined1 *)(((ulong)(lVar5 + 0x10) >> 9 & 0x7fffff) + lVar8) = 1;
  DataMemoryBarrier(2,3);
  param_1[0x17] = lVar5;
  *(undefined1 *)(((ulong)(param_1 + 0x17) >> 9 & 0x7fffff) + lVar8) = 1;
  *(undefined4 *)(param_1 + 0x3e) = 8;
  lVar5 = func_0x000100331794(uRam00000001038c4dc0,5);
  func_0x0001003321f8(lVar5 + 0x20,uRam00000001039003d8,0x14);
  DataMemoryBarrier(2,3);
  param_1[0x2f] = lVar5;
  *(undefined1 *)(((ulong)(param_1 + 0x2f) >> 9 & 0x7fffff) + lVar8) = 1;
  StardewValley_StardewValley_Menus_IClickableMenu__ctor_06006162
            (param_1,param_2,param_3,param_4,param_5,0);
  lVar9 = param_1[0x2f];
  *(int *)((long)param_1 + 0x1ec) = param_6;
  *(undefined2 *)(param_1 + 0x66) = 0;
  lVar5 = StardewValley_StardewValley_Farmer_GetAllHairstyleIndices_06003659();
  uVar7 = _UNK_10369f008;
  if (lVar5 == 0) goto LAB_101e07e0c;
  if (*(uint *)(lVar9 + 0x18) < 2) {
    func_0x0001003316f4(0xcc,_UNK_10369f208);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101e07b2c);
    (*pcVar2)();
  }
  *(undefined4 *)(lVar9 + 0x24) = *(undefined4 *)(lVar5 + 0x18);
  SDV_StardewValley_Menus_MobileCustomizer_setUpSkinColorData_06005dff(param_1);
  SDV_StardewValley_Menus_MobileCustomizer_setUpShirts_06005e01(param_1);
  lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  *(undefined4 *)((long)param_1 + 0x324) = *(undefined4 *)(*(long *)(lVar5 + 0x380) + 0x68);
  lVar5 = SDV_StardewValley_Menus_MobileCustomizer_GetValidShirtIds_06005e18(param_1);
  lVar9 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar7 = _UNK_10369f030;
  if ((*(long *)(lVar9 + 0x370) == 0) || (uVar7 = _UNK_10369f038, lVar5 == 0)) goto LAB_101e07e0c;
  uVar4 = func_0x00010035c55c(lVar5,*(undefined8 *)(*(long *)(lVar9 + 0x370) + 0x60));
  *(undefined4 *)(param_1 + 0x65) = uVar4;
  uVar4 = SDV_StardewValley_Menus_MobileCustomizer_getSkinColor_06005e00
                    (param_1,*(undefined4 *)((long)param_1 + 0x324));
  *(undefined4 *)((long)param_1 + 0x32c) = uVar4;
  if (param_6 - 5U < 2) {
    *(undefined4 *)((long)param_1 + 500) = 7;
    if ((param_6 != 5) || (param_7 == 0)) goto LAB_101e0731c;
    DataMemoryBarrier(2,3);
    param_1[0x36] = param_7;
    *(undefined1 *)(((ulong)(param_1 + 0x36) >> 9 & 0x7fffff) + lVar8) = 1;
    lVar5 = SDV_StardewValley_Menus_MobileCustomizer_GetOrCreateDisplayFarmer_06005dfe(param_1);
    DataMemoryBarrier(2,3);
    param_1[0x35] = lVar5;
    *(undefined1 *)(((ulong)(param_1 + 0x35) >> 9 & 0x7fffff) + lVar8) = 1;
    lVar9 = func_0x000100331820(uRam00000001038d3b88,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar9 + 0x20) = (long)param_1;
    *(undefined1 *)(((ulong)(lVar9 + 0x20) >> 9 & 0x7fffff) + lVar8) = 1;
    uVar7 = uRam00000001039004a0;
    lVar5 = lRam0000000103900498;
    *(long *)(lVar9 + 0x40) = lRam0000000103900498;
    *(undefined8 *)(lVar9 + 0x28) = uVar7;
    *(undefined8 *)(lVar9 + 0x18) = *(undefined8 *)(lVar5 + 0x30);
    *(undefined8 *)(lVar9 + 0x10) = *(undefined8 *)(lVar5 + 0x28);
    DataMemoryBarrier(2,3);
    param_1[0x28] = lVar9;
    *(undefined1 *)(((ulong)(param_1 + 0x28) >> 9 & 0x7fffff) + lVar8) = 1;
    iVar1 = *(int *)(*(long *)(param_1[0x36] + 0xb8) + 0x68);
    if (iVar1 == 1) {
      plVar6 = *(long **)(param_1[0x35] + 0x408);
      uVar7 = _UNK_10369f1f0;
joined_r0x000101e07388:
      if (plVar6 == (long *)0x0) goto LAB_101e07e0c;
      (**(code **)(*plVar6 + 0x1a8))();
    }
    else if (iVar1 == 0) {
      plVar6 = *(long **)(param_1[0x35] + 0x400);
      uVar7 = _UNK_10369f200;
      goto joined_r0x000101e07388;
    }
    uVar7 = _UNK_10369f1f8;
    if (param_1[0x35] == 0) goto LAB_101e07e0c;
    StardewValley_StardewValley_Farmer_UpdateClothing_0600367a();
  }
  else {
    *(undefined4 *)((long)param_1 + 500) = 0;
LAB_101e0731c:
    lVar9 = func_0x000100331820(uRam00000001038d3b88,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar9 + 0x20) = (long)param_1;
    *(undefined1 *)(((ulong)(lVar9 + 0x20) >> 9 & 0x7fffff) + lVar8) = 1;
    uVar7 = uRam00000001039003e8;
    lVar5 = lRam00000001039003e0;
    *(long *)(lVar9 + 0x40) = lRam00000001039003e0;
    *(undefined8 *)(lVar9 + 0x28) = uVar7;
    *(undefined8 *)(lVar9 + 0x18) = *(undefined8 *)(lVar5 + 0x30);
    *(undefined8 *)(lVar9 + 0x10) = *(undefined8 *)(lVar5 + 0x28);
    DataMemoryBarrier(2,3);
    param_1[0x28] = lVar9;
    *(undefined1 *)(((ulong)(param_1 + 0x28) >> 9 & 0x7fffff) + lVar8) = 1;
  }
  *(float *)(param_1 + 0x40) = (float)(int)param_1[0xb] / 1280.0;
  *(float *)((long)param_1 + 0x204) = (float)*(int *)((long)param_1 + 0x5c) / 720.0;
  if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
    func_0x0001003319b0();
  }
  plVar6 = (long *)*plRam00000001038d5338;
  uVar7 = _UNK_10369f040;
  if ((plVar6 == (long *)0x0) ||
     (lVar5 = (**(code **)(*plVar6 + 0x100))(plVar6,uRam00000001039003f0), uVar7 = _UNK_10369f048,
     lVar5 == 0)) goto LAB_101e07e0c;
  lVar5 = func_0x000100331fdc(lVar5,uRam00000001038d7278,uRam00000001038c4d00);
  DataMemoryBarrier(2,3);
  param_1[0x31] = lVar5;
  *(undefined1 *)(((ulong)(param_1 + 0x31) >> 9 & 0x7fffff) + lVar8) = 1;
  plVar6 = (long *)*plRam00000001038d5338;
  uVar7 = _UNK_10369f050;
  if ((plVar6 == (long *)0x0) ||
     (lVar5 = (**(code **)(*plVar6 + 0x100))(plVar6,uRam00000001039003f8), uVar7 = _UNK_10369f058,
     lVar5 == 0)) goto LAB_101e07e0c;
  lVar5 = func_0x000100331fdc(lVar5,uRam00000001038d7278,uRam00000001038c4d00);
  DataMemoryBarrier(2,3);
  param_1[0x32] = lVar5;
  *(undefined1 *)(((ulong)(param_1 + 0x32) >> 9 & 0x7fffff) + lVar8) = 1;
  plVar6 = (long *)*plRam00000001038d5338;
  uVar7 = _UNK_10369f060;
  if ((plVar6 == (long *)0x0) ||
     (lVar5 = (**(code **)(*plVar6 + 0x100))(plVar6,uRam0000000103900400), uVar7 = _UNK_10369f068,
     lVar5 == 0)) goto LAB_101e07e0c;
  lVar5 = func_0x000100331fdc(lVar5,uRam00000001038d7278,uRam00000001038c4d00);
  DataMemoryBarrier(2,3);
  param_1[0x33] = lVar5;
  *(undefined1 *)(((ulong)(param_1 + 0x33) >> 9 & 0x7fffff) + lVar8) = 1;
  lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar7 = _UNK_10369f078;
  if (*(long *)(lVar5 + 0x58) == 0) goto LAB_101e07e0c;
  cVar3 = func_0x000100345aa0(*(undefined8 *)(*(long *)(lVar5 + 0x58) + 0x60),uRam00000001038c4f58);
  if (cVar3 != '\0') {
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar7 = _UNK_10369f1c8;
    if (*(long *)(lVar5 + 0x58) == 0) goto LAB_101e07e0c;
    func_0x000100354118(*(long *)(lVar5 + 0x58),param_1[0x31]);
  }
  lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar7 = _UNK_10369f080;
  if (lVar5 == 0) goto LAB_101e07e0c;
  cVar3 = func_0x000100377974(*(undefined8 *)(lVar5 + 0x2a8),0);
  if (cVar3 == '\0') {
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    cVar3 = func_0x000100345aa0(*(undefined8 *)(*(long *)(lVar5 + 0x2a8) + 0x60),
                                uRam00000001038c4f58);
    if (cVar3 != '\0') goto LAB_101e0754c;
  }
  else {
LAB_101e0754c:
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar7 = _UNK_10369f090;
    if (*(long *)(lVar5 + 0x2a8) == 0) goto LAB_101e07e0c;
    func_0x000100354118(*(long *)(lVar5 + 0x2a8),param_1[0x32]);
  }
  SDV_StardewValley_Menus_MobileCustomizer_setUpPositions_06005e04(param_1);
  if (param_1[0x1d] != 0) {
    lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    cVar3 = func_0x000100345aa0(*(undefined8 *)(*(long *)(lVar5 + 0x2a0) + 0x60),
                                uRam00000001038c4f58);
    if (cVar3 != '\0') {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar7 = _UNK_10369f1a8;
      if (*(long *)(lVar5 + 0x2a0) == 0) goto LAB_101e07e0c;
      func_0x000100354118(*(long *)(lVar5 + 0x2a0),param_1[0x33]);
    }
  }
  plVar6 = (long *)StardewValley_StardewValley_Game1_get_player_06002f9a();
  (**(code **)(*plVar6 + 0x178))(plVar6,2);
  lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar7 = _UNK_10369f0a0;
  if (lVar5 != 0) {
    plVar6 = (long *)StardewValley_StardewValley_Farmer_get_FarmerSprite_060035b3();
    (**(code **)(*plVar6 + 0x108))();
    lVar9 = func_0x000100331820(uRam00000001038d3b88,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar9 + 0x20) = (long)param_1;
    *(undefined1 *)(((ulong)(lVar9 + 0x20) >> 9 & 0x7fffff) + lVar8) = 1;
    uVar7 = uRam0000000103900418;
    lVar5 = lRam0000000103900410;
    *(long *)(lVar9 + 0x40) = lRam0000000103900410;
    *(undefined8 *)(lVar9 + 0x28) = uVar7;
    *(undefined8 *)(lVar9 + 0x18) = *(undefined8 *)(lVar5 + 0x30);
    *(undefined8 *)(lVar9 + 0x10) = *(undefined8 *)(lVar5 + 0x28);
    DataMemoryBarrier(2,3);
    param_1[0x27] = lVar9;
    *(undefined1 *)(((ulong)(param_1 + 0x27) >> 9 & 0x7fffff) + lVar8) = 1;
    lVar9 = func_0x000100331820(uRam00000001038d3b88,0x80);
    DataMemoryBarrier(2,3);
    *(long *)(lVar9 + 0x20) = (long)param_1;
    *(undefined1 *)(((ulong)(lVar9 + 0x20) >> 9 & 0x7fffff) + lVar8) = 1;
    uVar7 = uRam0000000103900428;
    lVar5 = lRam0000000103900420;
    *(long *)(lVar9 + 0x40) = lRam0000000103900420;
    *(undefined8 *)(lVar9 + 0x28) = uVar7;
    *(undefined8 *)(lVar9 + 0x18) = *(undefined8 *)(lVar5 + 0x30);
    uVar10 = (ulong)(param_1 + 0x29) >> 9 & 0x7fffff;
    *(undefined8 *)(lVar9 + 0x10) = *(undefined8 *)(lVar5 + 0x28);
    DataMemoryBarrier(2,3);
    param_1[0x29] = lVar9;
    *(undefined1 *)(uVar10 + lVar8) = 1;
    if ((param_6 - 5U < 2) && (*(undefined1 *)(param_1 + 100) = 1, param_6 == 6)) {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      if (((*(long *)(*(long *)(lVar5 + 0x408) + 0x60) != 0) &&
          (lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a(), uVar7 = _UNK_10369f188,
          *(long *)(*(long *)(*(long *)(lVar5 + 0x408) + 0x60) + 0xc0) == 0)) ||
         ((lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a(),
          *(long *)(*(long *)(lVar5 + 0x400) + 0x60) != 0 &&
          (lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a(), uVar7 = _UNK_10369f168,
          *(long *)(*(long *)(*(long *)(lVar5 + 0x400) + 0x60) + 0xc0) == 0)))) goto LAB_101e07e0c;
      lVar5 = SDV_StardewValley_Menus_MobileCustomizer_GetOrCreateDisplayFarmer_06005dfe(param_1);
      DataMemoryBarrier(2,3);
      param_1[0x35] = lVar5;
      *(undefined1 *)(((ulong)(param_1 + 0x35) >> 9 & 0x7fffff) + lVar8) = 1;
      lVar9 = func_0x000100331820(uRam00000001038d3b88,0x80);
      DataMemoryBarrier(2,3);
      *(long *)(lVar9 + 0x20) = (long)param_1;
      *(undefined1 *)(((ulong)(lVar9 + 0x20) >> 9 & 0x7fffff) + lVar8) = 1;
      uVar7 = uRam0000000103900480;
      lVar5 = lRam0000000103900478;
      *(long *)(lVar9 + 0x40) = lRam0000000103900478;
      *(undefined8 *)(lVar9 + 0x28) = uVar7;
      *(undefined8 *)(lVar9 + 0x18) = *(undefined8 *)(lVar5 + 0x30);
      *(undefined8 *)(lVar9 + 0x10) = *(undefined8 *)(lVar5 + 0x28);
      DataMemoryBarrier(2,3);
      param_1[0x29] = lVar9;
      *(undefined1 *)(lVar8 + uVar10) = 1;
      lVar9 = func_0x000100331820(uRam00000001038d3b88,0x80);
      DataMemoryBarrier(2,3);
      *(long *)(lVar9 + 0x20) = (long)param_1;
      *(undefined1 *)(((ulong)(lVar9 + 0x20) >> 9 & 0x7fffff) + lVar8) = 1;
      uVar7 = uRam0000000103900490;
      lVar5 = lRam0000000103900488;
      *(long *)(lVar9 + 0x40) = lRam0000000103900488;
      *(undefined8 *)(lVar9 + 0x28) = uVar7;
      *(undefined8 *)(lVar9 + 0x18) = *(undefined8 *)(lVar5 + 0x30);
      *(undefined8 *)(lVar9 + 0x10) = *(undefined8 *)(lVar5 + 0x28);
      DataMemoryBarrier(2,3);
      param_1[0x28] = lVar9;
      *(undefined1 *)(((ulong)(param_1 + 0x28) >> 9 & 0x7fffff) + lVar8) = 1;
    }
    SDV_StardewValley_Menus_MobileCustomizer_setUpPositions_06005e04(param_1);
    lVar5 = param_1[0x18];
    if (*(int *)(lVar5 + 0x54) == -500) {
      *(undefined4 *)(lVar5 + 0x54) = 0xffffffff;
    }
    *(undefined8 *)(lVar5 + 100) = 0xfffe7962fffe7962;
    *(undefined8 *)(lVar5 + 0x5c) = 0xfffe7962fffe7962;
    lVar5 = param_1[0x1f];
    if (*(int *)(lVar5 + 0x54) == -500) {
      *(undefined4 *)(lVar5 + 0x54) = 0xffffffff;
    }
    *(undefined4 *)(lVar5 + 0x5c) = 0xfffe7962;
    *(undefined4 *)(lVar5 + 0x60) = 0xfffe7962;
    *(undefined4 *)(lVar5 + 100) = 0xfffe7962;
    *(undefined4 *)(lVar5 + 0x68) = 0xfffe7962;
    lVar5 = param_1[0x21];
    if (*(int *)(lVar5 + 0x54) == -500) {
      *(undefined4 *)(lVar5 + 0x54) = 0xffffffff;
    }
    *(undefined4 *)(lVar5 + 0x5c) = 0xfffe7962;
    *(undefined4 *)(lVar5 + 0x60) = 0xfffe7962;
    *(undefined4 *)(lVar5 + 100) = 0xfffe7962;
    *(undefined4 *)(lVar5 + 0x68) = 0xfffe7962;
    lVar5 = param_1[0x20];
    if (lVar5 != 0) {
      if (*(int *)(lVar5 + 0x54) == -500) {
        *(undefined4 *)(lVar5 + 0x54) = 0xffffffff;
      }
      *(undefined4 *)(lVar5 + 0x5c) = 0xfffe7962;
      *(undefined4 *)(lVar5 + 0x60) = 0xfffe7962;
      *(undefined4 *)(lVar5 + 100) = 0xfffe7962;
      *(undefined4 *)(lVar5 + 0x68) = 0xfffe7962;
      uVar7 = _UNK_10369f128;
      if (param_1[0x1f] == 0) goto LAB_101e07e0c;
      *(undefined4 *)(param_1[0x1f] + 0x68) = 0x219;
      *(undefined4 *)(param_1[0x21] + 100) = 0x219;
    }
    lVar9 = param_1[0x15];
    lVar5 = *plRam0000000103900430;
    if (lVar5 == 0) {
      lVar11 = *plRam0000000103900448;
      uVar7 = _UNK_10369f120;
      if (lVar11 == 0) goto LAB_101e07d2c;
      lVar5 = func_0x000100331820(uRam0000000103900450,0x80);
      DataMemoryBarrier(2,3);
      *(long *)(lVar5 + 0x20U) = lVar11;
      *(undefined1 *)((lVar5 + 0x20U >> 9 & 0x7fffff) + lVar8) = 1;
      uVar7 = uRam0000000103900470;
      lVar11 = lRam0000000103900468;
      *(long *)(lVar5 + 0x40) = lRam0000000103900468;
      *(undefined8 *)(lVar5 + 0x28) = uVar7;
      *(undefined8 *)(lVar5 + 0x18) = *(undefined8 *)(lVar11 + 0x30);
      plVar6 = plRam0000000103900430;
      *(undefined8 *)(lVar5 + 0x10) = *(undefined8 *)(lVar11 + 0x28);
      DataMemoryBarrier(2,3);
      *plVar6 = lVar5;
    }
    uVar7 = _UNK_10369f0d0;
    if (lVar9 != 0) {
      func_0x0001003779b0(lVar9,lVar5);
      lVar9 = param_1[0x16];
      lVar5 = *plRam0000000103900440;
      if (lVar5 == 0) {
        lVar11 = *plRam0000000103900448;
        uVar7 = _UNK_10369f118;
        if (lVar11 == 0) {
LAB_101e07d2c:
          func_0x0001003316f4(0x69,uVar7);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101e07d38);
          (*pcVar2)();
        }
        lVar5 = func_0x000100331820(uRam0000000103900450,0x80);
        DataMemoryBarrier(2,3);
        *(long *)(lVar5 + 0x20U) = lVar11;
        *(undefined1 *)((lVar5 + 0x20U >> 9 & 0x7fffff) + lVar8) = 1;
        uVar7 = uRam0000000103900460;
        lVar8 = lRam0000000103900458;
        *(long *)(lVar5 + 0x40) = lRam0000000103900458;
        *(undefined8 *)(lVar5 + 0x28) = uVar7;
        *(undefined8 *)(lVar5 + 0x18) = *(undefined8 *)(lVar8 + 0x30);
        plVar6 = plRam0000000103900440;
        *(undefined8 *)(lVar5 + 0x10) = *(undefined8 *)(lVar8 + 0x28);
        DataMemoryBarrier(2,3);
        *plVar6 = lVar5;
      }
      uVar7 = _UNK_10369f0d8;
      if (lVar9 != 0) {
        func_0x0001003779b0(lVar9,lVar5);
        if (param_1[0x19] != 0) {
          *(bool *)(param_1[0x19] + 0x4c) = param_6 == 0 || param_6 == 3;
          lVar8 = param_1[0x19];
          if (*(int *)(lVar8 + 0x54) == -500) {
            *(undefined4 *)(lVar8 + 0x54) = 0xffffffff;
          }
          *(undefined4 *)(lVar8 + 0x5c) = 0xfffe7962;
          *(undefined4 *)(lVar8 + 0x60) = 0xfffe7962;
          *(undefined4 *)(lVar8 + 100) = 0xfffe7962;
          *(undefined4 *)(lVar8 + 0x68) = 0xfffe7962;
        }
        lVar8 = param_1[0x1a];
        if (*(int *)(lVar8 + 0x54) == -500) {
          *(undefined4 *)(lVar8 + 0x54) = 0xffffffff;
        }
        *(undefined4 *)(lVar8 + 0x5c) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 0x60) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 100) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 0x68) = 0xfffe7962;
        lVar8 = param_1[0x1b];
        if (*(int *)(lVar8 + 0x54) == -500) {
          *(undefined4 *)(lVar8 + 0x54) = 0xffffffff;
        }
        *(undefined4 *)(lVar8 + 0x5c) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 0x60) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 100) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 0x68) = 0xfffe7962;
        lVar8 = param_1[0x11];
        if (*(int *)(lVar8 + 0x54) == -500) {
          *(undefined4 *)(lVar8 + 0x54) = 0xffffffff;
        }
        *(undefined4 *)(lVar8 + 0x5c) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 0x60) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 100) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 0x68) = 0xfffe7962;
        lVar8 = param_1[0x12];
        if (*(int *)(lVar8 + 0x54) == -500) {
          *(undefined4 *)(lVar8 + 0x54) = 0xffffffff;
        }
        *(undefined4 *)(lVar8 + 0x5c) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 0x60) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 100) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 0x68) = 0xfffe7962;
        lVar8 = param_1[0x13];
        if (*(int *)(lVar8 + 0x54) == -500) {
          *(undefined4 *)(lVar8 + 0x54) = 0xffffffff;
        }
        *(undefined4 *)(lVar8 + 0x5c) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 0x60) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 100) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 0x68) = 0xfffe7962;
        lVar8 = param_1[0x14];
        if (*(int *)(lVar8 + 0x54) == -500) {
          *(undefined4 *)(lVar8 + 0x54) = 0xffffffff;
        }
        *(undefined4 *)(lVar8 + 0x5c) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 0x60) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 100) = 0xfffe7962;
        *(undefined4 *)(lVar8 + 0x68) = 0xfffe7962;
        (**(code **)(*param_1 + 0x188))(param_1);
        (**(code **)(*param_1 + 0x178))(param_1);
        return;
      }
    }
  }
LAB_101e07e0c:
  func_0x0001003316f4(0xee,uVar7);
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e07e18);
  (*pcVar2)();
}

