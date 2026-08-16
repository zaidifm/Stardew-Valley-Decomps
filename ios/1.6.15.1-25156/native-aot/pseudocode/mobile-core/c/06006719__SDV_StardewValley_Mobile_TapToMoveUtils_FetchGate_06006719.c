/* 0x06006719 StardewValley.Mobile.TapToMoveUtils.FetchGate @ 0x101fcfa80 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 * SDV_StardewValley_Mobile_TapToMoveUtils_FetchGate_06006719(long param_1,long param_2)

{
  code *pcVar1;
  char cVar2;
  undefined8 *puVar3;
  undefined8 uVar4;
  int iVar5;
  int iVar6;
  
  cVar2 = cRam0000000103911528;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103325b4a);
    cRam0000000103911528 = '\x01';
  }
  uVar4 = _UNK_1036d8010;
  if ((param_2 != 0) && (uVar4 = _UNK_1036d8020, *(long *)(param_1 + 0xb8) != 0)) {
    iVar5 = *(int *)(param_2 + 0x34);
    iVar6 = *(int *)(param_2 + 0x38);
    cVar2 = func_0x000101b55e1c((float)iVar5,(float)iVar6);
    if (cVar2 != '\0') {
      uVar4 = _UNK_1036d8028;
      if (*(long *)(param_1 + 0xb8) == 0) goto LAB_101fcfb9c;
      puVar3 = (undefined8 *)func_0x000101b547f0((float)iVar5,(float)iVar6);
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
LAB_101fcfb9c:
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fcfba8);
  (*pcVar1)();
}

