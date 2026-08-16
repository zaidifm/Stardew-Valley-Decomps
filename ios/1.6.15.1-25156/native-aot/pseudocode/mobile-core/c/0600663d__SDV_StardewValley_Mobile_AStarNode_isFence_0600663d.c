/* 0x0600663d StardewValley.Mobile.AStarNode.isFence @ 0x101fa9008 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

bool SDV_StardewValley_Mobile_AStarNode_isFence_0600663d(long param_1)

{
  code *pcVar1;
  bool bVar2;
  char cVar3;
  undefined8 *puVar4;
  undefined8 uVar5;
  long lVar6;
  
  cVar3 = cRam000000010391144c;
  if (lRam0000000103976fb8 == 0) {
    if (cRam000000010391144c == '\0') goto LAB_101fa90c8;
LAB_101fa9034:
    lVar6 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 != '\0') goto LAB_101fa9034;
LAB_101fa90c8:
    func_0x00010119b908(&UNK_103324b0c);
    cRam000000010391144c = '\x01';
    lVar6 = *(long *)(param_1 + 0x18);
  }
  uVar5 = _UNK_1036d2a88;
  if (*(long *)(*(long *)(lVar6 + 0x10) + 0xb8) == 0) {
LAB_101fa9134:
    func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa9140);
    (*pcVar1)();
  }
  cVar3 = func_0x000101b55e1c((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38));
  if (cVar3 == '\0') {
    bVar2 = false;
  }
  else {
    uVar5 = _UNK_1036d2aa0;
    if (*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xb8) == 0) goto LAB_101fa9134;
    puVar4 = (undefined8 *)
             func_0x000101b547f0((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38));
    if ((puVar4 != (undefined8 *)0x0) &&
       (lRam00000001038c6a58 != *(long *)(*(long *)(*(long *)*puVar4 + 0x10) + 0x18))) {
      puVar4 = (undefined8 *)0x0;
    }
    bVar2 = puVar4 != (undefined8 *)0x0;
  }
  return bVar2;
}

