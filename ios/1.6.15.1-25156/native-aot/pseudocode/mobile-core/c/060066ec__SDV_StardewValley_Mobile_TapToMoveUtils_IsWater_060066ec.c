/* 0x060066ec StardewValley.Mobile.TapToMoveUtils.IsWater @ 0x101fcbb7c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMoveUtils_IsWater_060066ec(float param_1,float param_2)

{
  code *pcVar1;
  char cVar2;
  undefined8 *puVar3;
  long *plVar4;
  long lVar5;
  undefined8 uVar6;
  ushort uVar7;
  
  cVar2 = cRam00000001039114fb;
  if (lRam0000000103976fb8 == 0) {
    if (cRam00000001039114fb != '\0') goto LAB_101fcbbb0;
LAB_101fcbd80:
    func_0x00010119b908(&UNK_103325940);
    cRam00000001039114fb = '\x01';
    puVar3 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 == '\0') goto LAB_101fcbd80;
LAB_101fcbbb0:
    puVar3 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  }
  if ((puVar3 != (undefined8 *)0x0) &&
     (lRam00000001038c6e68 != *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x10))) {
    puVar3 = (undefined8 *)0x0;
  }
  uVar7 = NEON_umaxv(CONCAT26(CONCAT11(~(byte)(-(uint)(7.0 <= param_2) >> 8),
                                       ~(byte)-(uint)(7.0 <= param_2)),
                              CONCAT24(CONCAT11(~(byte)(-(uint)(9.0 <= param_1) >> 8),
                                                ~(byte)-(uint)(9.0 <= param_1)),
                                       CONCAT22(CONCAT11(~(byte)(-(uint)(param_2 <= 11.0) >> 8),
                                                         ~(byte)-(uint)(param_2 <= 11.0)),
                                                CONCAT11(~(byte)(-(uint)(param_1 <= 20.0) >> 8),
                                                         ~(byte)-(uint)(param_1 <= 20.0))))),2);
  if (((uVar7 & 1) == 0) && (puVar3 != (undefined8 *)0x0)) {
    return true;
  }
  puVar3 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  if ((puVar3 != (undefined8 *)0x0) &&
     (lRam00000001038d7950 == *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x18))) {
    plVar4 = (long *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    uVar6 = _UNK_1036d7a00;
    if ((plVar4 == (long *)0x0) ||
       (lRam00000001038d7950 != *(long *)(*(long *)(*(long *)*plVar4 + 0x10) + 0x18)))
    goto LAB_101fcbdcc;
    cVar2 = (**(code **)(*plVar4 + 0x700))(plVar4,(int)param_1,(int)param_2);
    if (cVar2 != '\0') {
      return false;
    }
    plVar4 = (long *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    uVar6 = _UNK_1036d7a08;
    if ((plVar4 == (long *)0x0) ||
       (lRam00000001038d7950 != *(long *)(*(long *)(*(long *)*plVar4 + 0x10) + 0x18)))
    goto LAB_101fcbdcc;
    cVar2 = (*(code *)((long *)*plVar4)[0xa7])(plVar4,(int)param_1,(int)param_2);
    if (cVar2 != '\0') {
      return true;
    }
  }
  plVar4 = (long *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  uVar6 = _UNK_1036d79f0;
  if (plVar4 != (long *)0x0) {
    lVar5 = (**(code **)(*plVar4 + 0x260))
                      (plVar4,(int)param_1,(int)param_2,uRam00000001038e7d30,uRam00000001038c90d0,0)
    ;
    if (lVar5 != 0) {
      return true;
    }
    plVar4 = (long *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    uVar6 = _UNK_1036d79f8;
    if (plVar4 != (long *)0x0) {
      lVar5 = (**(code **)(*plVar4 + 0x260))
                        (plVar4,(int)param_1,(int)param_2,uRam00000001038e7e60,uRam00000001038c90d0,
                         0);
      return lVar5 != 0;
    }
  }
LAB_101fcbdcc:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcbdd8);
  (*pcVar1)();
}

