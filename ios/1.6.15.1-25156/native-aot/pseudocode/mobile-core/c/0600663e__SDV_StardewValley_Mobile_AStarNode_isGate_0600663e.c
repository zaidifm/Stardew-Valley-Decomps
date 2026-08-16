/* 0x0600663e StardewValley.Mobile.AStarNode.isGate @ 0x101fa9140 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_AStarNode_isGate_0600663e(long param_1)

{
  code *pcVar1;
  char cVar2;
  undefined8 *puVar3;
  undefined8 uVar4;
  long lVar5;
  
  cVar2 = cRam000000010391144d;
  if (lRam0000000103976fb8 == 0) {
    if (cRam000000010391144d != '\0') goto LAB_101fa916c;
LAB_101fa9210:
    func_0x00010119b908(&UNK_103324b13);
    cRam000000010391144d = '\x01';
    lVar5 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 == '\0') goto LAB_101fa9210;
LAB_101fa916c:
    lVar5 = *(long *)(param_1 + 0x18);
  }
  uVar4 = _UNK_1036d2ac0;
  if (*(long *)(*(long *)(lVar5 + 0x10) + 0xb8) != 0) {
    cVar2 = func_0x000101b55e1c((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38));
    if (cVar2 != '\0') {
      uVar4 = _UNK_1036d2ad8;
      if (*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xb8) == 0) goto LAB_101fa9288;
      puVar3 = (undefined8 *)
               func_0x000101b547f0((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38));
      if (puVar3 == (undefined8 *)0x0) {
        return false;
      }
      if ((lRam00000001038c6a58 == *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x18)) &&
         (*(char *)(puVar3[0x45] + 0x68) != '\0')) {
        cVar2 = func_0x000101995778();
        return cVar2 == '\0';
      }
    }
    return false;
  }
LAB_101fa9288:
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa9294);
  (*pcVar1)();
}

