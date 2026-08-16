/* 0x060066ae StardewValley.Mobile.TapToMove.SetMouseCursor @ 0x101fba14c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Mobile_TapToMove_SetMouseCursor_060066ae(long param_1,long param_2)

{
  undefined4 uVar1;
  code *pcVar2;
  char cVar3;
  undefined8 uVar4;
  long lVar5;
  undefined8 *puVar6;
  long *plVar7;
  undefined8 uVar8;
  undefined4 uVar9;
  int iVar10;
  long *plVar11;
  int iVar12;
  float fVar13;
  float fVar14;
  int iVar15;
  undefined8 uStack_68;
  
  cVar3 = cRam00000001039114bd;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103325440);
    cRam00000001039114bd = '\x01';
  }
  uStack_68 = 0;
  *(undefined4 *)(param_1 + 0xe0) = 0;
  if (param_2 == 0) {
    return;
  }
  uVar9 = *(undefined4 *)(param_2 + 0x34);
  uVar1 = *(undefined4 *)(param_2 + 0x38);
  plVar11 = *(long **)(param_1 + 0x90);
  uVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar8 = _UNK_1036d4810;
  if (plVar11 == (long *)0x0) goto LAB_101fba99c;
  cVar3 = (**(code **)(*plVar11 + 0x1f8))(plVar11,uVar9,uVar1,uVar4);
  if (cVar3 == '\0') {
    uVar9 = *(undefined4 *)(param_2 + 0x34);
    iVar12 = *(int *)(param_2 + 0x38);
    plVar11 = *(long **)(param_1 + 0x90);
    uVar4 = StardewValley_StardewValley_Game1_get_player_06002f9a();
    uVar8 = _UNK_1036d49c0;
    if (plVar11 == (long *)0x0) goto LAB_101fba99c;
    cVar3 = (**(code **)(*plVar11 + 0x1f8))(plVar11,uVar9,iVar12 + 1,uVar4);
    if (cVar3 != '\0') goto LAB_101fba200;
  }
  else {
LAB_101fba200:
    *(undefined4 *)(param_1 + 0xe0) = 2;
  }
  plVar11 = *(long **)(param_1 + 0x90);
  uVar8 = _UNK_1036d4818;
  if (plVar11 == (long *)0x0) goto LAB_101fba99c;
  lVar5 = (**(code **)(*plVar11 + 0x260))
                    (plVar11,*(undefined4 *)(param_2 + 0x34),*(undefined4 *)(param_2 + 0x38),
                     uRam00000001038e3670,uRam00000001038cc720,0);
  if (lVar5 != 0) {
    plVar11 = *(long **)(param_1 + 0x90);
    uVar8 = _UNK_1036d49b0;
    if ((plVar11 == (long *)0x0) ||
       (lVar5 = (**(code **)(*plVar11 + 0x260))
                          (plVar11,*(undefined4 *)(param_2 + 0x34),*(undefined4 *)(param_2 + 0x38),
                           uRam00000001038e3670,uRam00000001038cc720,0), uVar8 = _UNK_1036d49b8,
       lVar5 == 0)) goto LAB_101fba99c;
    cVar3 = func_0x000100350144(lVar5,uRam00000001038e3848);
    if (cVar3 != '\0') {
      *(undefined4 *)(param_1 + 0xe0) = 5;
    }
  }
  iVar12 = *(int *)(param_2 + 0x34);
  iVar15 = *(int *)(param_2 + 0x38);
  lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  uVar8 = _UNK_1036d4820;
  if (lVar5 == 0) goto LAB_101fba99c;
  fVar14 = (float)iVar12;
  fVar13 = (float)iVar15;
  plVar11 = (long *)func_0x0001018e7738(fVar14,fVar13);
  if ((plVar11 != (long *)0x0) && (cVar3 = (**(code **)(*plVar11 + 0x1d0))(), cVar3 == '\0')) {
    if (*(char *)(lRam00000001038c4c88 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (*pcRam00000001038d53e0 == '\0') {
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar8 = _UNK_1036d4958;
      if (lVar5 == 0) goto LAB_101fba99c;
      lVar5 = StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
      if (lVar5 == 0) goto LAB_101fba3ec;
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar8 = _UNK_1036d4960;
      if (lVar5 == 0) goto LAB_101fba99c;
      plVar7 = (long *)StardewValley_StardewValley_Farmer_get_ActiveObject_06003592();
      cVar3 = (**(code **)(*plVar7 + 0x230))();
      if (cVar3 == '\0') goto LAB_101fba3ec;
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar8 = _UNK_1036d4970;
      if (((lVar5 == 0) || (uVar8 = _UNK_1036d4978, plVar11[0xb] == 0)) ||
         (uVar8 = _UNK_1036d4980, *(long *)(lVar5 + 0x5a0) == 0)) goto LAB_101fba99c;
      cVar3 = func_0x00010035421c(*(long *)(lVar5 + 0x5a0),*(undefined8 *)(plVar11[0xb] + 0x60));
      if (cVar3 == '\0') goto LAB_101fba3ec;
      lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
      uVar8 = _UNK_1036d4988;
      if (((lVar5 == 0) || (uVar8 = _UNK_1036d4990, plVar11[0xb] == 0)) ||
         (uVar8 = _UNK_1036d4998, *(long *)(lVar5 + 0x5a0) == 0)) goto LAB_101fba99c;
      lVar5 = func_0x000100354640(*(long *)(lVar5 + 0x5a0),*(undefined8 *)(plVar11[0xb] + 0x60));
      if (*(int *)(*(long *)(lVar5 + 0x20) + 0x68) == 1) goto LAB_101fba3ec;
      uVar9 = 3;
    }
    else {
LAB_101fba3ec:
      cVar3 = (**(code **)(*plVar11 + 0x388))(plVar11);
      if (((cVar3 == '\0') || (lVar5 = (**(code **)(*plVar11 + 0x3b0))(plVar11), lVar5 == 0)) ||
         (((lVar5 = (**(code **)(*plVar11 + 0x3b0))(plVar11), *(int *)(lVar5 + 0x18) < 1 &&
           (cVar3 = func_0x00010197bf1c(plVar11), cVar3 == '\0')) ||
          (cVar3 = func_0x00010197be40(plVar11), cVar3 != '\0')))) goto LAB_101fba2b8;
      uVar9 = 4;
    }
    *(undefined4 *)(param_1 + 0xe0) = uVar9;
  }
LAB_101fba2b8:
  lVar5 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
  if (((lVar5 != 0) &&
      (lVar5 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd(),
      *(char *)(lVar5 + 0x118) != '\0')) &&
     (lVar5 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd(),
     *(long *)(lVar5 + 0xb0) != 0)) {
    lVar5 = StardewValley_StardewValley_Game1_get_CurrentEvent_06002ffd();
    uVar8 = _UNK_1036d4948;
    if (*(long *)(lVar5 + 0xb0) == 0) goto LAB_101fba99c;
    lVar5 = StardewValley_StardewValley_Character_get_StandingPixel_06003255();
    iVar15 = (int)lVar5;
    iVar12 = iVar15 + 0x3f;
    if (-1 < iVar15) {
      iVar12 = iVar15;
    }
    iVar10 = (int)((ulong)lVar5 >> 0x20);
    iVar15 = iVar10 + 0x3f;
    if (-1 < lVar5) {
      iVar15 = iVar10;
    }
    uStack_68 = CONCAT44((float)(iVar15 >> 6),(float)(iVar12 >> 6));
    cVar3 = func_0x000100353f10(fVar14,fVar13,&uStack_68);
    if (cVar3 != '\0') {
      *(undefined4 *)(param_1 + 0xe0) = 4;
    }
  }
  lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  uVar8 = _UNK_1036d4828;
  if (lVar5 == 0) goto LAB_101fba99c;
  cVar3 = func_0x000101839cac();
  if (cVar3 == '\0') goto LAB_101fba398;
  lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  uVar8 = _UNK_1036d4840;
  if (*(long *)(lVar5 + 0xb8) == 0) goto LAB_101fba99c;
  cVar3 = func_0x000101b55e1c(fVar14,fVar13);
  lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
  if (cVar3 == '\0') {
    uVar8 = _UNK_1036d4850;
    if (*(long *)(lVar5 + 0x120) == 0) goto LAB_101fba99c;
    cVar3 = func_0x00010035afb8(fVar14,fVar13);
    if (cVar3 == '\0') goto LAB_101fba398;
    lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar8 = _UNK_1036d4860;
    if (*(long *)(lVar5 + 0x120) == 0) goto LAB_101fba99c;
    puVar6 = (undefined8 *)func_0x000100358178(fVar14,fVar13);
    if ((puVar6 == (undefined8 *)0x0) ||
       (lRam00000001038c7940 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10)))
    goto LAB_101fba398;
    lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
    uVar8 = _UNK_1036d4870;
    if ((*(long *)(lVar5 + 0x120) == 0) ||
       (puVar6 = (undefined8 *)func_0x000100358178(fVar14,fVar13), uVar8 = _UNK_1036d49c8,
       puVar6 == (undefined8 *)0x0)) goto LAB_101fba99c;
    if (lRam00000001038c7940 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10)) {
      func_0x0001003316f4(0xd3,_UNK_1036d49d0);
                    /* WARNING: Does not return */
      pcVar2 = (code *)SoftwareBreakpoint(1,0x101fba8f8);
      (*pcVar2)();
    }
LAB_101fba500:
    cVar3 = func_0x000101a8fe28();
    if (cVar3 == '\0') goto LAB_101fba398;
  }
  else {
    uVar8 = _UNK_1036d4880;
    if (*(long *)(lVar5 + 0xb8) == 0) goto LAB_101fba99c;
    lVar5 = func_0x000101b547f0(fVar14,fVar13);
    if (*(char *)(*(long *)(lVar5 + 0x110) + 0x68) == '\0') {
      lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      uVar8 = _UNK_1036d48a0;
      if (*(long *)(lVar5 + 0xb8) == 0) goto LAB_101fba99c;
      plVar11 = (long *)func_0x000101b547f0(fVar14,fVar13);
      lVar5 = (**(code **)(*plVar11 + 0x1e8))();
      uVar8 = _UNK_1036d48b0;
      if (lVar5 == 0) goto LAB_101fba99c;
      cVar3 = func_0x000100350144(lVar5,uRam00000001038ed9c0);
      if (cVar3 != '\0') {
        lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
        uVar8 = _UNK_1036d4918;
        if (*(long *)(lVar5 + 0xb8) == 0) goto LAB_101fba99c;
        lVar5 = func_0x000101b547f0(fVar14,fVar13);
        if (*(long *)(*(long *)(lVar5 + 0x130) + 0x60) != 0) goto LAB_101fba390;
      }
      lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
      uVar8 = _UNK_1036d48c0;
      if (*(long *)(lVar5 + 0xb8) == 0) {
LAB_101fba99c:
        func_0x0001003316f4(0xee,uVar8);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101fba9a8);
        (*pcVar2)();
      }
      lVar5 = func_0x000101b547f0(fVar14,fVar13);
      if (*(char *)(*(long *)(lVar5 + 0xc0) + 0x68) == '\0') {
        lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
        uVar8 = _UNK_1036d48e0;
        if (*(long *)(lVar5 + 0xb8) == 0) goto LAB_101fba99c;
        puVar6 = (undefined8 *)func_0x000101b547f0(fVar14,fVar13);
        if ((puVar6 == (undefined8 *)0x0) ||
           (lRam00000001038c7448 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18)))
        goto LAB_101fba398;
        lVar5 = StardewValley_StardewValley_Game1_get_currentLocation_06002fa8();
        uVar8 = _UNK_1036d48f0;
        if ((*(long *)(lVar5 + 0xb8) == 0) ||
           (((puVar6 = (undefined8 *)func_0x000101b547f0(fVar14,fVar13), uVar8 = _UNK_1036d48f8,
             puVar6 == (undefined8 *)0x0 ||
             (lRam00000001038c7448 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18))) ||
            (uVar8 = _UNK_1036d4908, *(long *)(puVar6[0x41] + 0x60) == 0)))) goto LAB_101fba99c;
        goto LAB_101fba500;
      }
    }
  }
LAB_101fba390:
  *(undefined4 *)(param_1 + 0xe0) = 6;
LAB_101fba398:
  lVar5 = StardewValley_StardewValley_Game1_get_player_06002f9a();
  if (*(char *)(lVar5 + 0x772) != '\0') {
    *(undefined4 *)(param_1 + 0xe0) = 0xffffffff;
  }
  return;
}

