/* 0x060066ef StardewValley.Mobile.TapToMoveUtils.IsWateringCanFillingSource @ 0x101fcc490 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_TapToMoveUtils_IsWateringCanFillingSource_060066ef
               (undefined8 param_1,undefined8 param_2)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  long *plVar4;
  long lVar5;
  undefined8 *puVar6;
  ushort uVar7;
  float fVar8;
  float fVar9;
  
  cVar2 = cRam00000001039114fe;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(param_1,param_2,&UNK_1033259f0);
    cRam00000001039114fe = '\x01';
  }
  cVar2 = SDV_StardewValley_Mobile_TapToMoveUtils_IsWater_060066ec(param_1,param_2);
  fVar8 = (float)param_1;
  fVar9 = (float)param_2;
  if (cVar2 != '\0') {
    uVar3 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    cVar2 = SDV_StardewValley_Mobile_TapToMoveUtils_IsTilePassable_060066ee
                      (uVar3,(int)fVar8,(int)fVar9);
    if (cVar2 == '\0') {
      return true;
    }
  }
  plVar4 = (long *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  cVar2 = (**(code **)(*plVar4 + 0x510))();
  if (cVar2 != '\0') {
    lVar5 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    uVar3 = _UNK_1036d7b20;
    if (lVar5 == 0) goto LAB_101fcc798;
    puVar6 = (undefined8 *)func_0x000101938908(param_1,param_2);
    if (puVar6 != (undefined8 *)0x0) {
      if (lRam00000001038c6590 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10)) {
        plVar4 = (long *)puVar6[0x11];
        uVar3 = _UNK_1036d7b30;
        if (plVar4 == (long *)0x0) goto LAB_101fcc798;
        cVar2 = (**(code **)(*plVar4 + 0x58))(plVar4,uRam00000001038ff008);
        if (cVar2 == '\0') goto LAB_101fcc56c;
      }
      if (*(int *)(puVar6[0xe] + 0x68) < 1) {
        return true;
      }
    }
  }
LAB_101fcc56c:
  puVar6 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
  if ((puVar6 != (undefined8 *)0x0) &&
     (lRam00000001038c6e68 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10))) {
    puVar6 = (undefined8 *)0x0;
  }
  uVar7 = NEON_umaxv(CONCAT26(CONCAT11(~(byte)(-(uint)(7.0 <= fVar9) >> 8),
                                       ~(byte)-(uint)(7.0 <= fVar9)),
                              CONCAT24(CONCAT11(~(byte)(-(uint)(9.0 <= fVar8) >> 8),
                                                ~(byte)-(uint)(9.0 <= fVar8)),
                                       CONCAT22(CONCAT11(~(byte)(-(uint)(fVar9 <= 11.0) >> 8),
                                                         ~(byte)-(uint)(fVar9 <= 11.0)),
                                                CONCAT11(~(byte)(-(uint)(fVar8 <= 20.0) >> 8),
                                                         ~(byte)-(uint)(fVar8 <= 20.0))))),2);
  if ((((uVar7 & 1) != 0) || (puVar6 == (undefined8 *)0x0)) &&
     ((lVar5 = SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb(),
      *(char *)(*(long *)(lVar5 + 0x1a8) + 0x68) == '\0' ||
      (((fVar8 != 9.0 || (fVar9 != 7.0)) && ((fVar8 != 10.0 || (fVar9 != 7.0)))))))) {
    puVar6 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
    if ((puVar6 != (undefined8 *)0x0) &&
       (lRam00000001038c6e28 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10))) {
      puVar6 = (undefined8 *)0x0;
    }
    uVar7 = NEON_umaxv(CONCAT26(CONCAT11(~(byte)(-(uint)(55.0 <= fVar9) >> 8),
                                         ~(byte)-(uint)(55.0 <= fVar9)),
                                CONCAT24(CONCAT11(~(byte)(-(uint)(14.0 <= fVar8) >> 8),
                                                  ~(byte)-(uint)(14.0 <= fVar8)),
                                         CONCAT22(CONCAT11(~(byte)(-(uint)(fVar9 <= 56.0) >> 8),
                                                           ~(byte)-(uint)(fVar9 <= 56.0)),
                                                  CONCAT11(~(byte)(-(uint)(fVar8 <= 16.0) >> 8),
                                                           ~(byte)-(uint)(fVar8 <= 16.0))))),2);
    if (((uVar7 & 1) != 0) || (puVar6 == (undefined8 *)0x0)) {
      puVar6 = (undefined8 *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
      if (puVar6 == (undefined8 *)0x0) {
        return false;
      }
      if (lRam00000001038d7950 != *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x18)) {
        return false;
      }
      plVar4 = (long *)SDV_StardewValley_Mobile_TapToMoveUtils_get_gameLocation_060066cb();
      uVar3 = _UNK_1036d7b18;
      if ((plVar4 != (long *)0x0) &&
         (lRam00000001038d7950 == *(long *)(*(long *)(*(long *)*plVar4 + 0x10) + 0x18))) {
        cVar2 = (*(code *)((long *)*plVar4)[0xa7])(plVar4,(int)fVar8,(int)fVar9);
        return cVar2 != '\0';
      }
LAB_101fcc798:
      func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
      pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcc7a4);
      (*pcVar1)();
    }
  }
  return true;
}

