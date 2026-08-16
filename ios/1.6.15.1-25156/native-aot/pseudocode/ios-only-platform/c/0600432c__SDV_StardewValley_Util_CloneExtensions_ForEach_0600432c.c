/* 0x0600432c StardewValley.Util.CloneExtensions.ForEach @ 0x101a3d768 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Util_CloneExtensions_ForEach_0600432c(long param_1,long param_2)

{
  code *pcVar1;
  char cVar2;
  long lVar3;
  undefined8 uVar4;
  
  cVar2 = cRam000000010390f13b;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  uVar4 = _UNK_10363a998;
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_1032eece7);
    cRam000000010390f13b = '\x01';
    uVar4 = _UNK_10363a998;
  }
  _UNK_10363a998 = uVar4;
  if (param_1 != 0) {
    lVar3 = func_0x000100367d58(param_1);
    if (lVar3 != 0) {
      lVar3 = func_0x000100331820(uRam00000001038f0338,0x20);
      SDV_StardewValley_Util_CloneExtensions_ArrayTraverse__ctor_06006e57(lVar3,param_1);
      uVar4 = _UNK_10363a9a0;
      if (param_2 == 0) goto LAB_101a3d854;
      do {
        while( true ) {
          (**(code **)(param_2 + 0x18))(param_2,param_1,*(undefined8 *)(lVar3 + 0x10));
          cVar2 = SDV_StardewValley_Util_CloneExtensions_ArrayTraverse_Step_06006e58(lVar3);
          if (lRam0000000103976fb8 != 0) break;
          if (cVar2 == '\0') {
            return;
          }
        }
        func_0x00010119b8f8();
      } while (cVar2 != '\0');
    }
    return;
  }
LAB_101a3d854:
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101a3d860);
  (*pcVar1)();
}

