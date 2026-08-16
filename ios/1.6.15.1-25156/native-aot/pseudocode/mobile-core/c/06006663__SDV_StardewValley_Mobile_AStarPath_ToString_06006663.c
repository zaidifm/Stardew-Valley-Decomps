/* 0x06006663 StardewValley.Mobile.AStarPath.ToString @ 0x101fae714 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8 SDV_StardewValley_Mobile_AStarPath_ToString_06006663(long *param_1)

{
  char cVar1;
  code *pcVar2;
  long lVar3;
  long lVar4;
  undefined8 uVar5;
  long lVar6;
  undefined8 uVar7;
  undefined8 uVar8;
  uint uVar9;
  undefined4 auStack_6c [3];
  
  cVar1 = cRam0000000103911472;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar1 == '\0') {
    func_0x00010119b908(&UNK_103324e50);
    cRam0000000103911472 = '\x01';
  }
  auStack_6c[0] = 0;
  if (param_1 != (long *)0x0) {
    auStack_6c[0] = 0;
    lVar3 = (**(code **)(*param_1 + 0x88))(param_1);
    if (lVar3 == 0) {
      return uRam00000001039047c0;
    }
    lVar3 = (**(code **)(*param_1 + 0x88))(param_1);
    if (lVar3 != 0) {
      if (*(int *)(lVar3 + 0x18) == 0) {
        return uRam00000001039047c0;
      }
      uVar9 = 0;
      lVar3 = 0x20;
      lVar6 = lRam00000001038efee0;
      while (lVar4 = (**(code **)(*param_1 + 0x88))(param_1), lVar4 != 0) {
        if (*(int *)(lVar4 + 0x18) <= (int)uVar9) {
          if (lVar6 != 0) {
            uVar7 = func_0x00010035629c(lVar6,0,*(int *)(lVar6 + 0x10) + -2);
            uVar5 = uRam00000001039047d0;
            lVar3 = (**(code **)(*param_1 + 0x88))(param_1);
            if (lVar3 != 0) {
              auStack_6c[0] = *(undefined4 *)(lVar3 + 0x18);
              uVar8 = func_0x00010034eec0(auStack_6c);
              uVar5 = func_0x000100332388(uVar7,uVar5,uVar8);
              return uVar5;
            }
          }
          break;
        }
        uVar5 = func_0x000100331794(uRam00000001038c4f40,6);
        func_0x000100331f8c(uVar5,0,lVar6);
        func_0x000100331f8c(uVar5,1,uRam00000001038dfaa0);
        lVar6 = (**(code **)(*param_1 + 0x88))(param_1);
        if (lVar6 == 0) break;
        if (*(uint *)(lVar6 + 0x18) <= uVar9) {
LAB_101fae98c:
          func_0x000100331b90();
          goto LAB_101fae9d0;
        }
        lVar6 = *(long *)(lVar6 + 0x10);
        if (lVar6 == 0) break;
        if (*(uint *)(lVar6 + 0x18) <= uVar9) {
LAB_101fae9c0:
          uVar5 = 0xcc;
          goto LAB_101fae9c4;
        }
        if (*(long *)(lVar3 + lVar6) == 0) break;
        auStack_6c[0] = *(undefined4 *)(*(long *)(lVar3 + lVar6) + 0x34);
        uVar7 = func_0x00010034eec0(auStack_6c);
        func_0x000100331f8c(uVar5,2,uVar7);
        func_0x000100331f8c(uVar5,3,uRam00000001038d3dd0);
        lVar6 = (**(code **)(*param_1 + 0x88))(param_1);
        if (lVar6 == 0) break;
        if (*(uint *)(lVar6 + 0x18) <= uVar9) goto LAB_101fae98c;
        lVar6 = *(long *)(lVar6 + 0x10);
        if (lVar6 == 0) break;
        if (*(uint *)(lVar6 + 0x18) <= uVar9) goto LAB_101fae9c0;
        if (*(long *)(lVar3 + lVar6) == 0) break;
        auStack_6c[0] = *(undefined4 *)(*(long *)(lVar3 + lVar6) + 0x38);
        uVar7 = func_0x00010034eec0(auStack_6c);
        func_0x000100331f8c(uVar5,4,uVar7);
        func_0x000100331f8c(uVar5,5,uRam00000001039047c8);
        lVar6 = func_0x000100351da0(uVar5);
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
        lVar3 = lVar3 + 8;
        uVar9 = uVar9 + 1;
      }
    }
  }
  uVar5 = 0xee;
LAB_101fae9c4:
  func_0x0001003316f4(uVar5,_UNK_1036d36e8);
LAB_101fae9d0:
                    /* WARNING: Does not return */
  pcVar2 = (code *)SoftwareBreakpoint(1,0x101fae9d4);
  (*pcVar2)();
}

