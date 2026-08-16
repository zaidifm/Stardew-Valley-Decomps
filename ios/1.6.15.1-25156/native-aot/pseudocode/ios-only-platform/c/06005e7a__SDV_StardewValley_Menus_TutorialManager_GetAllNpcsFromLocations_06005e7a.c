/* 0x06005e7a StardewValley.Menus.TutorialManager.GetAllNpcsFromLocations @ 0x101e1fb58 */

/* WARNING: Removing unreachable block (ram,0x000101e1feac) */
/* WARNING: Removing unreachable block (ram,0x000101e1fe1c) */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */
/* WARNING: Restarted to delay deadcode elimination for space: stack */

long SDV_StardewValley_Menus_TutorialManager_GetAllNpcsFromLocations_06005e7a(long param_1)

{
  long lVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  undefined8 uVar5;
  long lVar6;
  undefined8 uVar7;
  uint uStack_f4;
  undefined8 uStack_e0;
  undefined8 uStack_d8;
  long *plStack_d0;
  long *plStack_c8;
  undefined8 uStack_c0;
  long lStack_b8;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  long *plStack_a0;
  long *plStack_98;
  undefined8 *puStack_90;
  long *plStack_88;
  uint uStack_7c;
  long lStack_78;
  long *plStack_70;
  undefined8 *puStack_68;
  
  cVar3 = cRam0000000103910c89;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_103317800);
    cRam0000000103910c89 = '\x01';
  }
  uStack_d8 = 0;
  plStack_d0 = (long *)0x0;
  uStack_e0 = 0;
  plStack_c8 = (long *)0x0;
  lVar4 = func_0x000100331820(uRam0000000103900810,0x50);
  func_0x000100378090();
  lVar1 = lRam00000001038c4be0;
  uStack_f4 = 0;
  uVar7 = _UNK_1036a2c78;
  if (param_1 != 0) {
LAB_101e1fbf8:
    do {
      if (*(int *)(param_1 + 0x18) <= (int)uStack_f4) {
        return lVar4;
      }
      if (*(uint *)(param_1 + 0x18) <= uStack_f4) {
        func_0x0001003316f4(0xcc,_UNK_1036a2cb0);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1fee0);
        (*pcVar2)();
      }
      uVar5 = SDV_StardewValley_Menus_TutorialManager_FilterLocationName_06005e79
                        (*(undefined8 *)(param_1 + (long)(int)uStack_f4 * 8 + 0x20));
      lStack_b8 = func_0x000100331820(uRam00000001038e2058,0x20);
      uVar7 = _UNK_1036a2c80;
      if (lStack_b8 == 0) break;
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lStack_b8 + 0x10U) = *puRam00000001038e2060;
      *(undefined1 *)((lStack_b8 + 0x10U >> 9 & 0x7fffff) + lVar1) = 1;
      uVar7 = _UNK_1036a2c88;
      if (lVar4 == 0) break;
      func_0x0001003780b8(lVar4,uVar5,lStack_b8);
      lVar6 = StardewValley_StardewValley_Game1_getLocationFromName_060030db(uVar5);
      if (lVar6 != 0) {
        uVar7 = _UNK_1036a2c98;
        if (*(long *)(lVar6 + 0xa0) == 0) break;
        func_0x0001003432b4(&uStack_b0);
        uStack_d8 = uStack_a8;
        uStack_e0 = uStack_b0;
        plStack_d0 = plStack_a0;
        while (cVar3 = func_0x000100353470(&uStack_e0), cVar3 != '\0') {
          puStack_90 = &uStack_e0;
          if ((&uStack_e0 == (undefined8 *)0x0) ||
             (plStack_c8 = plStack_d0, plStack_98 = plStack_c8, plStack_d0 == (long *)0x0))
          goto LAB_101e1fdec;
          cVar3 = (**(code **)(*plStack_d0 + 0x3a0))();
          if (cVar3 == '\0') goto LAB_101e1fcd0;
          if (lVar4 == 0) {
LAB_101e1fdec:
            func_0x0001003316f4(0xee,_UNK_1036a2ca8);
            goto LAB_101e1ff14;
          }
          lStack_78 = func_0x0001003780cc(lVar4,uVar5);
          plStack_70 = plStack_c8;
          plStack_88 = (long *)0x0;
          uStack_7c = 0;
          if ((((lStack_78 == 0) || (lStack_78 == 0)) || (lStack_78 == 0)) ||
             (((*(int *)(lStack_78 + 0x1c) = *(int *)(lStack_78 + 0x1c) + 1, lStack_78 == 0 ||
               (plStack_88 = *(long **)(lStack_78 + 0x10), lStack_78 == 0)) ||
              (uStack_7c = *(uint *)(lStack_78 + 0x18), plStack_88 == (long *)0x0))))
          goto LAB_101e1fdec;
          if (uStack_7c < *(uint *)(plStack_88 + 3)) {
            if (lStack_78 != 0) {
              *(uint *)(lStack_78 + 0x18) = uStack_7c + 1;
              if (plStack_88 != (long *)0x0) {
                (**(code **)(*plStack_88 + 0x110))(plStack_88,(long)(int)uStack_7c,plStack_c8);
                goto LAB_101e1fcd0;
              }
            }
            goto LAB_101e1fdec;
          }
          func_0x000100359960(lStack_78,plStack_c8);
LAB_101e1fcd0:
          if (lRam0000000103976fb8 != 0) {
            func_0x00010119b8f8();
          }
        }
        uStack_c0 = 0;
        uVar7 = _UNK_1036a2ca0;
        puStack_68 = &uStack_e0;
        if (&uStack_e0 == (undefined8 *)0x0) break;
      }
      uStack_f4 = uStack_f4 + 1;
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
        uVar7 = _UNK_1036a2c78;
        if (param_1 == 0) break;
        goto LAB_101e1fbf8;
      }
      uVar7 = _UNK_1036a2c78;
    } while (param_1 != 0);
  }
  func_0x0001003316f4(0xee,uVar7);
LAB_101e1ff14:
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101e1ff18);
  (*pcVar2)();
}

