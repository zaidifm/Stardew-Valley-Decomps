/* 0x06005e8c StardewValley.Menus.TutorialManager.SeenShop @ 0x101e22c04 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

void SDV_StardewValley_Menus_TutorialManager_SeenShop_06005e8c(long param_1,undefined4 param_2)

{
  uint uVar1;
  code *pcVar2;
  char cVar3;
  long lVar4;
  undefined8 uVar5;
  long lVar6;
  
  cVar3 = cRam0000000103910c9b;
  if (lRam0000000103976fb8 == 0) {
    if (cRam0000000103910c9b == '\0') goto LAB_101e22cc4;
LAB_101e22c34:
    lVar4 = *(long *)(param_1 + 0x88);
  }
  else {
    func_0x00010119b8f8();
    if (cVar3 != '\0') goto LAB_101e22c34;
LAB_101e22cc4:
    func_0x00010119b908(&UNK_103317ab6);
    cRam0000000103910c9b = '\x01';
    lVar4 = *(long *)(param_1 + 0x88);
  }
  uVar5 = _UNK_1036a2fd0;
  if (lVar4 == 0) {
LAB_101e22d0c:
    func_0x0001003316f4(0xee,uVar5);
                    /* WARNING: Does not return */
    pcVar2 = (code *)SoftwareBreakpoint(1,0x101e22d18);
    (*pcVar2)();
  }
  cVar3 = func_0x000100362588(lVar4,param_2);
  if (cVar3 == '\0') {
    lVar4 = *(long *)(param_1 + 0x88);
    lVar6 = *(long *)(lVar4 + 0x10);
    *(int *)(lVar4 + 0x1c) = *(int *)(lVar4 + 0x1c) + 1;
    uVar5 = _UNK_1036a2fe0;
    if (lVar6 == 0) goto LAB_101e22d0c;
    uVar1 = *(uint *)(lVar4 + 0x18);
    if (uVar1 < *(uint *)(lVar6 + 0x18)) {
      *(uint *)(lVar4 + 0x18) = uVar1 + 1;
      if (*(uint *)(lVar6 + 0x18) <= uVar1) {
        func_0x0001003316f4(0xcc,_UNK_1036a2fe8);
                    /* WARNING: Does not return */
        pcVar2 = (code *)SoftwareBreakpoint(1,0x101e22d2c);
        (*pcVar2)();
      }
      *(undefined4 *)(lVar6 + (long)(int)uVar1 * 4 + 0x20) = param_2;
    }
    else {
      func_0x000100346d88(lVar4,param_2);
    }
  }
  return;
}

