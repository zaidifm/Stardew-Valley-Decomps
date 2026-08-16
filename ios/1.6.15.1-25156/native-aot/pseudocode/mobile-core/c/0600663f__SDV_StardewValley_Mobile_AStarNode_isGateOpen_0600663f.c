/* 0x0600663f StardewValley.Mobile.AStarNode.isGateOpen @ 0x101fa9294 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_AStarNode_isGateOpen_0600663f(long param_1)

{
  code *pcVar1;
  char cVar2;
  undefined8 *puVar3;
  undefined8 uVar4;
  long lVar5;
  
  cVar2 = cRam000000010391144e;
  if (lRam0000000103976fb8 == 0) {
    if (cRam000000010391144e != '\0') goto LAB_101fa92c0;
LAB_101fa9398:
    func_0x00010119b908(&UNK_103324b1e);
    cRam000000010391144e = '\x01';
    lVar5 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 == '\0') goto LAB_101fa9398;
LAB_101fa92c0:
    lVar5 = *(long *)(param_1 + 0x18);
  }
  uVar4 = _UNK_1036d2b00;
  if (*(long *)(*(long *)(lVar5 + 0x10) + 0xb8) != 0) {
    cVar2 = func_0x000101b55e1c((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38));
    if (cVar2 != '\0') {
      uVar4 = _UNK_1036d2b18;
      if (*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xb8) == 0) goto LAB_101fa9404;
      puVar3 = (undefined8 *)
               func_0x000101b547f0((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38));
      if (puVar3 == (undefined8 *)0x0) {
        return false;
      }
      if (((lRam00000001038c6a58 == *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x18)) &&
          (*(char *)(puVar3[0x45] + 0x68) != '\0')) &&
         (cVar2 = func_0x000101995778(puVar3), cVar2 == '\0')) {
        if (lRam00000001038c6a58 == *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x18)) {
          return *(int *)(puVar3[0x44] + 0x68) == 0x58;
        }
        func_0x0001003316f4(0xd3,_UNK_1036d2b28);
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa9430);
        (*pcVar1)();
      }
    }
    return false;
  }
LAB_101fa9404:
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa9410);
  (*pcVar1)();
}

