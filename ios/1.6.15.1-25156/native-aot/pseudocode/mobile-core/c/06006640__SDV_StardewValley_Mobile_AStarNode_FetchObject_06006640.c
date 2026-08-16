/* 0x06006640 StardewValley.Mobile.AStarNode.FetchObject @ 0x101fa943c */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_AStarNode_FetchObject_06006640(long param_1)

{
  code *pcVar1;
  char cVar2;
  undefined8 uVar3;
  long lVar4;
  
  if (lRam0000000103976fb8 == 0) {
    lVar4 = *(long *)(param_1 + 0x18);
  }
  else {
    func_0x00010119b8f8();
    lVar4 = *(long *)(param_1 + 0x18);
  }
  uVar3 = _UNK_1036d2b50;
  if (*(long *)(*(long *)(lVar4 + 0x10) + 0xb8) == 0) {
LAB_101fa9510:
    func_0x0001003316f4(0xee,uVar3);
                    /* WARNING: Does not return */
    pcVar1 = (code *)SoftwareBreakpoint(1,0x101fa951c);
    (*pcVar1)();
  }
  cVar2 = func_0x000101b55e1c((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38));
  if (cVar2 == '\0') {
    uVar3 = 0;
  }
  else {
    uVar3 = _UNK_1036d2b68;
    if (*(long *)(*(long *)(*(long *)(param_1 + 0x18) + 0x10) + 0xb8) == 0) goto LAB_101fa9510;
    uVar3 = func_0x000101b547f0((float)*(int *)(param_1 + 0x34),(float)*(int *)(param_1 + 0x38));
  }
  return uVar3;
}

