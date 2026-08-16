/* 0x06006e57 StardewValley.Util.CloneExtensions+ArrayTraverse..ctor @ 0x1020563b0 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Util_CloneExtensions_ArrayTraverse__ctor_06006e57(long param_1,long *param_2)

{
  char cVar1;
  code *pcVar2;
  int iVar3;
  undefined8 uVar4;
  long lVar5;
  ulong uVar6;
  long lVar7;
  ulong uVar8;
  long lVar9;
  
  cVar1 = cRam0000000103911c66;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_10332c890);
    cRam0000000103911c66 = '\x01';
    lVar5 = *param_2;
  }
  else {
    lVar5 = *param_2;
  }
  uVar4 = func_0x000100331794(uRam00000001038c4dc0,*(undefined1 *)(lVar5 + 0x34));
  if (param_1 == 0) {
    func_0x0001003316f4(0xee,_UNK_1036e4dc0);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x102056508);
    (*pcVar2)();
  }
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x18) = uVar4;
  lVar5 = lRam00000001038c4be0;
  *(undefined1 *)(((ulong)(param_1 + 0x18) >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
  if (*(char *)(*param_2 + 0x34) == '\0') {
    uVar8 = 0;
  }
  else {
    uVar6 = 0;
    lVar9 = 0x20;
    do {
      lVar7 = *(long *)(param_1 + 0x18);
      iVar3 = func_0x0001003324b4(param_2,uVar6 & 0xffffffff);
      if (*(uint *)(lVar7 + 0x18) <= uVar6) {
        func_0x0001003316f4(0xcc,_UNK_1036e4dd0);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x10205651c);
        (*pcVar2)();
      }
      *(int *)(lVar9 + lVar7) = iVar3 + -1;
      uVar8 = (ulong)*(byte *)(*param_2 + 0x34);
      if (lRam0000000103976fb8 != 0) {
        func_0x00010119b8f8();
      }
      uVar6 = uVar6 + 1;
      lVar9 = lVar9 + 4;
    } while (uVar6 < uVar8);
  }
  uVar4 = func_0x000100331794(uRam00000001038c4dc0,uVar8);
  DataMemoryBarrier(2,3);
  *(undefined8 *)(param_1 + 0x10) = uVar4;
  *(undefined1 *)(((ulong)(param_1 + 0x10) >> 9 & 0x7fffff) + lVar5) = 1;
  return;
}

