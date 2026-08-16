/* 0x0600670d StardewValley.Mobile.TapToMoveUtils.ClickedCrabPot @ 0x101fce5a8 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 *
SDV_StardewValley_Mobile_TapToMoveUtils_ClickedCrabPot_0600670d(long param_1,long param_2)

{
  char cVar1;
  code *pcVar2;
  undefined8 *puVar3;
  long lVar4;
  undefined8 *puVar5;
  undefined8 uVar6;
  
  cVar1 = cRam000000010391151c;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103325ad5);
    cRam000000010391151c = '\x01';
  }
  uVar6 = _UNK_1036d7e70;
  if (param_2 == 0) {
LAB_101fce77c:
    func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101fce788);
    (*pcVar2)();
  }
  puVar3 = (undefined8 *)SDV_StardewValley_Mobile_AStarNode_FetchObject_06006640(param_2);
  if ((puVar3 == (undefined8 *)0x0) || (*(int *)(puVar3[0xb] + 0x68) != 0x2c6)) {
    uVar6 = _UNK_1036d7e78;
    if (param_1 == 0) goto LAB_101fce77c;
    lVar4 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,*(undefined4 *)(param_2 + 0x34),*(int *)(param_2 + 0x38) + 1);
    if (((lVar4 != 0) &&
        (puVar3 = (undefined8 *)SDV_StardewValley_Mobile_AStarNode_FetchObject_06006640(),
        puVar3 != (undefined8 *)0x0)) && (*(int *)(puVar3[0xb] + 0x68) == 0x2c6)) {
      uVar6 = _UNK_1036d7ea8;
      if (lRam00000001038c73e8 != *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x18))
      goto LAB_101fce768;
      if (*(char *)(puVar3[0x22] + 0x68) != '\0') {
        return puVar3;
      }
    }
    lVar4 = SDV_StardewValley_Mobile_AStarGraph_FetchAStarNode_060065fc
                      (param_1,*(undefined4 *)(param_2 + 0x34),*(int *)(param_2 + 0x38) + 2);
    puVar3 = (undefined8 *)0x0;
    if ((lVar4 != 0) &&
       (puVar5 = (undefined8 *)SDV_StardewValley_Mobile_AStarNode_FetchObject_06006640(),
       puVar3 = puVar5, puVar5 != (undefined8 *)0x0)) {
      if (*(int *)(puVar5[0xb] + 0x68) == 0x2c6) {
        uVar6 = _UNK_1036d7e90;
        if (lRam00000001038c73e8 != *(long *)(*(long *)(*(long *)*puVar5 + 0x10) + 0x18)) {
LAB_101fce768:
          func_0x0001003316f4(0xd3,uVar6);
                    /* WARNING: Does not return */
          pcVar2 = (code *)SoftwareBreakpoint(1,0x101fce774);
          (*pcVar2)();
        }
        puVar3 = (undefined8 *)0x0;
        if (*(char *)(puVar5[0x22] + 0x68) != '\0') {
          puVar3 = puVar5;
        }
      }
      else {
        puVar3 = (undefined8 *)0x0;
      }
    }
  }
  else if (lRam00000001038c73e8 != *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x18)) {
    puVar3 = (undefined8 *)0x0;
  }
  return puVar3;
}

