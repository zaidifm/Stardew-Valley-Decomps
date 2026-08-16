/* 0x06006655 StardewValley.Mobile.AStarNode.ContainsAnimals @ 0x101facfe8 */

/* WARNING: Removing unreachable block (ram,0x000101fad2f8) */
/* WARNING: Removing unreachable block (ram,0x000101fad310) */
/* WARNING: Removing unreachable block (ram,0x000101fad36c) */
/* WARNING: Removing unreachable block (ram,0x000101fad354) */
/* WARNING: Type propagation algorithm not settling */
/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined1 SDV_StardewValley_Mobile_AStarNode_ContainsAnimals_06006655(long param_1)

{
  code *pcVar1;
  char cVar2;
  int iVar3;
  undefined8 uVar4;
  int iVar5;
  undefined8 *puVar6;
  long lVar7;
  undefined8 uStack_b0;
  undefined8 uStack_a8;
  undefined8 uStack_a0;
  undefined8 uStack_98;
  undefined8 uStack_90;
  undefined8 uStack_88;
  long lStack_80;
  undefined8 uStack_78;
  long lStack_70;
  undefined1 uStack_61;
  undefined8 uStack_60;
  undefined8 uStack_58;
  long lStack_50;
  undefined8 *puStack_48;
  long lStack_40;
  undefined8 *puStack_38;
  
  cVar2 = cRam0000000103911464;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar2 == '\0') {
    func_0x00010119b908(&UNK_103324d90);
    cRam0000000103911464 = '\x01';
  }
  lStack_70 = 0;
  uStack_61 = 0;
  uStack_a8 = 0;
  uStack_b0 = 0;
  uStack_98 = 0;
  uStack_a0 = 0;
  uStack_88 = 0;
  uStack_90 = 0;
  uStack_78 = 0;
  lStack_80 = 0;
  puVar6 = *(undefined8 **)(*(long *)(param_1 + 0x18) + 0x10);
  if (puVar6 == (undefined8 *)0x0) {
    return 0;
  }
  lVar7 = *(long *)(*(long *)(*(long *)*puVar6 + 0x10) + 0x10);
  if (lRam00000001038c64d0 == lVar7) {
    lVar7 = puVar6[5];
    uVar4 = _UNK_1036d3440;
    if (lVar7 != 0) {
      DataMemoryBarrier(2,3);
      *(undefined1 *)(((ulong)&lStack_50 >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
      lStack_70 = lVar7;
      lStack_50 = lVar7;
      func_0x00010035aff4(&uStack_b0,&lStack_70);
      while (cVar2 = func_0x00010035b008(&uStack_b0), lVar7 = lStack_80, cVar2 != '\0') {
        if (lStack_80 == 0) {
          func_0x0001003316f4(0xee,_UNK_1036d3430);
          goto LAB_101fad22c;
        }
        iVar3 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(lStack_80);
        iVar5 = iVar3 + 0x3f;
        if (-1 < iVar3) {
          iVar5 = iVar3;
        }
        if (*(int *)(param_1 + 0x34) == iVar5 >> 6) {
          lVar7 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(lVar7);
          iVar3 = (int)((ulong)lVar7 >> 0x20);
          iVar5 = iVar3 + 0x3f;
          if (-1 < lVar7) {
            iVar5 = iVar3;
          }
          if (*(int *)(param_1 + 0x38) == iVar5 >> 6) {
            iVar5 = 1;
            uStack_61 = 1;
            goto LAB_101fad334;
          }
        }
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
      }
      iVar5 = 2;
LAB_101fad334:
      uStack_60 = 0;
      puStack_48 = &uStack_b0;
      if (puStack_48 != (undefined8 *)0x0) {
        if (iVar5 == 1) {
          return uStack_61;
        }
        if (iVar5 == 2) {
          return 0;
        }
        goto LAB_101fad374;
      }
      puStack_48 = (undefined8 *)0x0;
      uVar4 = _UNK_1036d3438;
    }
  }
  else {
    if (lRam00000001038c69d0 != lVar7) {
      return 0;
    }
    lVar7 = puVar6[5];
    uVar4 = _UNK_1036d3428;
    if (lVar7 != 0) {
      DataMemoryBarrier(2,3);
      *(undefined1 *)(((ulong)&lStack_40 >> 9 & 0x7fffff) + lRam00000001038c4be0) = 1;
      lStack_70 = lVar7;
      lStack_40 = lVar7;
      func_0x00010035aff4(&uStack_b0,&lStack_70);
      while (cVar2 = func_0x00010035b008(&uStack_b0), lVar7 = lStack_80, cVar2 != '\0') {
        if (lStack_80 == 0) {
          func_0x0001003316f4(0xee,_UNK_1036d3418);
LAB_101fad22c:
                    /* WARNING: Does not return */
          pcVar1 = (code *)SoftwareBreakpoint(1,0x101fad230);
          (*pcVar1)();
        }
        iVar3 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(lStack_80);
        iVar5 = iVar3 + 0x3f;
        if (-1 < iVar3) {
          iVar5 = iVar3;
        }
        if (*(int *)(param_1 + 0x34) == iVar5 >> 6) {
          lVar7 = StardewValley_StardewValley_Character_get_StandingPixel_06003255(lVar7);
          iVar3 = (int)((ulong)lVar7 >> 0x20);
          iVar5 = iVar3 + 0x3f;
          if (-1 < lVar7) {
            iVar5 = iVar3;
          }
          if (*(int *)(param_1 + 0x38) == iVar5 >> 6) {
            iVar5 = 1;
            uStack_61 = 1;
            goto LAB_101fad2d8;
          }
        }
        if (lRam0000000103976fb8 != 0) {
          func_0x00010119b8f8();
        }
      }
      iVar5 = 2;
LAB_101fad2d8:
      uStack_58 = 0;
      puStack_38 = &uStack_b0;
      if (puStack_38 != (undefined8 *)0x0) {
        if (iVar5 == 1) {
          return uStack_61;
        }
        if (iVar5 == 2) {
          return 0;
        }
LAB_101fad374:
        func_0x000100331c30();
                    /* WARNING: Does not return */
        pcVar1 = (code *)SoftwareBreakpoint(1,0x101fad37c);
        (*pcVar1)();
      }
      puStack_38 = (undefined8 *)0x0;
      uVar4 = _UNK_1036d3420;
    }
  }
  func_0x0001003316f4(0xee,uVar4);
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x101fad2b4);
  (*pcVar1)();
}

