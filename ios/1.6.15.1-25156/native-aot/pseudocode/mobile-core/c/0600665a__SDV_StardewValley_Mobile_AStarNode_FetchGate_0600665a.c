/* 0x0600665a StardewValley.Mobile.AStarNode.FetchGate @ 0x101fad934 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 * SDV_StardewValley_Mobile_AStarNode_FetchGate_0600665a(long param_1)

{
  code *pcVar1;
  char cVar2;
  undefined8 *puVar3;
  undefined8 uVar4;
  long lVar5;
  int iVar6;
  int iVar7;
  
  cVar2 = cRam0000000103911469;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103911469 != '\0') goto LAB_101fad964;
LAB_101fada08:
    func_0x00010119b908(&UNK_103324dae);
    cRam0000000103911469 = '\x01';
    lVar5 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    if (cVar2 == '\0') goto LAB_101fada08;
LAB_101fad964:
    lVar5 = *(long *)(param_1 + 0x18);
  }
  uVar4 = _UNK_1036d3568;
  if (*(long *)(*(long *)(lVar5 + 0x10) + 0xb8) != 0) {
    iVar6 = *(int *)(param_1 + 0x34);
    iVar7 = *(int *)(param_1 + 0x38);
    cVar2 = func_0x000101b55e1c((float)iVar6,(float)iVar7);
    if (cVar2 != '\0') {
      uVar4 = _UNK_1036d3580;
      if (*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xb8) == 0) goto LAB_101fada80;
      puVar3 = (undefined8 *)func_0x000101b547f0((float)iVar6,(float)iVar7);
      if (puVar3 == (undefined8 *)0x0) {
        return (undefined8 *)0x0;
      }
      if (lRam00000001038c6a58 == *(long *)(*(long *)(*(long *)*puVar3 + 0x10) + 0x18)) {
        if (*(char *)(puVar3[0x45] + 0x68) == '\0') {
          return (undefined8 *)0x0;
        }
        return puVar3;
      }
    }
    return (undefined8 *)0x0;
  }
LAB_101fada80:
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fada8c);
  (*pcVar1)();
}

