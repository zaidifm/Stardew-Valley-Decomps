/* 0x060032df StardewValley.CloudSync.ShowConflictBox @ 0x10179de14 */

/* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

undefined8
SDV_StardewValley_CloudSync_ShowConflictBox_060032df
          (undefined8 param_1,undefined8 param_2,long param_3)

{
  uint uVar1;
  long lVar2;
  char cVar3;
  code *pcVar4;
  long lVar5;
  undefined8 uVar6;
  long lVar7;
  long lVar8;
  uint uVar9;
  int iVar10;
  long *plVar11;
  undefined8 uVar12;
  undefined8 uStack_80;
  undefined8 uStack_78;
  undefined8 uStack_70;
  undefined8 uStack_68;
  long lStack_60;
  undefined8 uStack_58;
  ulong uStack_50;
  
  cVar3 = cRam000000010390e0ee;
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  if (cVar3 == '\0') {
    func_0x00010119b908(&UNK_1032d3ad0);
    cRam000000010390e0ee = '\x01';
  }
  uStack_80 = 0;
  uStack_78 = 0;
  uStack_50 = 0;
  uStack_68 = 0;
  uStack_70 = 0;
  uStack_58 = 0;
  lStack_60 = 0;
  lVar5 = func_0x000100331820(uRam00000001038df768,0x58);
  lVar2 = lRam00000001038c4be0;
  DataMemoryBarrier(2,3);
  *(undefined8 *)(lVar5 + 0x18) = param_2;
  *(undefined1 *)(((ulong)(lVar5 + 0x18) >> 9 & 0x7fffff) + lVar2) = 1;
  DataMemoryBarrier(2,3);
  plVar11 = (long *)(lVar5 + 0x28);
  *plVar11 = param_3;
  *(undefined1 *)(((ulong)plVar11 >> 9 & 0x7fffff) + lVar2) = 1;
  *(undefined8 *)(lVar5 + 0x10) = 0;
  uVar6 = _UNK_1035f54a8;
  if ((*plVar11 != 0) && (uVar6 = _UNK_1035f54b0, *(long *)(lVar5 + 0x18) != 0)) {
    uVar12 = *(undefined8 *)(*plVar11 + 0x10);
    uStack_80 = func_0x0001003577b4(*(long *)(lVar5 + 0x18) + 0x38);
    uVar6 = _UNK_1035f54b8;
    if (*(long *)(lVar5 + 0x28) != 0) {
      uStack_78 = func_0x0001003577b4(*(long *)(lVar5 + 0x28) + 0x38);
      DataMemoryBarrier(2,3);
      *(undefined8 *)(lVar5 + 0x30) = uRam00000001038df770;
      *(undefined1 *)(((ulong)(lVar5 + 0x30) >> 9 & 0x7fffff) + lVar2) = 1;
      func_0x0001003318fc(&uStack_70,0x4d,5);
      func_0x00010034ef38(&uStack_70,uVar12);
      lVar7 = lRam00000001038df778;
      uVar6 = _UNK_1035f54c0;
      if (&stack0x00000000 != (undefined1 *)0x60) {
        if ((uint)uStack_50 <= (uint)uStack_58) {
          uVar9 = *(uint *)(lRam00000001038df778 + 0x10);
          if ((uint)uStack_58 - (uint)uStack_50 < uVar9) {
            func_0x000100331910(&uStack_70,lRam00000001038df778);
            uVar9 = (uint)uStack_50;
          }
          else {
            iVar10 = 0;
            if (uVar9 != 0) {
              lVar8 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
              uVar6 = _UNK_1035f5530;
              if ((lVar8 == 0) || (uVar6 = _UNK_1035f5538, lRam00000001038df778 + 0x14 == 0))
              goto LAB_10179e51c;
              _memmove(lVar8,lRam00000001038df778 + 0x14,(ulong)uVar9 << 1);
              iVar10 = *(int *)(lVar7 + 0x10);
            }
            uVar9 = iVar10 + (uint)uStack_50;
            uStack_50 = CONCAT44(uStack_50._4_4_,uVar9);
          }
          lVar7 = lRam00000001038df780;
          if (uVar9 <= (uint)uStack_58) {
            uVar1 = *(uint *)(lRam00000001038df780 + 0x10);
            if ((uint)uStack_58 - uVar9 < uVar1) {
              func_0x000100331910(&uStack_70,lRam00000001038df780);
            }
            else {
              iVar10 = 0;
              if (uVar1 != 0) {
                lVar8 = lStack_60 + (ulong)uVar9 * 2;
                uVar6 = _UNK_1035f5520;
                if ((lVar8 == 0) || (uVar6 = _UNK_1035f5528, lRam00000001038df780 + 0x14 == 0))
                goto LAB_10179e51c;
                _memmove(lVar8,lRam00000001038df780 + 0x14,(ulong)uVar1 << 1);
                iVar10 = *(int *)(lVar7 + 0x10);
                uVar9 = (uint)uStack_50;
              }
              uStack_50 = CONCAT44(uStack_50._4_4_,iVar10 + uVar9);
            }
            uVar6 = func_0x0001003577c8(&uStack_80);
            func_0x00010034ef38(&uStack_70,uVar6);
            lVar7 = lRam00000001038c4d00;
            if ((uint)uStack_50 <= (uint)uStack_58) {
              uVar9 = *(uint *)(lRam00000001038c4d00 + 0x10);
              if ((uint)uStack_58 - (uint)uStack_50 < uVar9) {
                func_0x000100331910(&uStack_70,lRam00000001038c4d00);
              }
              else {
                iVar10 = 0;
                if (uVar9 != 0) {
                  lVar8 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
                  uVar6 = _UNK_1035f5510;
                  if ((lVar8 == 0) || (uVar6 = _UNK_1035f5518, lRam00000001038c4d00 + 0x14 == 0))
                  goto LAB_10179e51c;
                  _memmove(lVar8,lRam00000001038c4d00 + 0x14,(ulong)uVar9 << 1);
                  iVar10 = *(int *)(lVar7 + 0x10);
                }
                uStack_50 = CONCAT44(uStack_50._4_4_,iVar10 + (uint)uStack_50);
              }
              uVar6 = func_0x0001003577dc(&uStack_80);
              func_0x00010034ef38(&uStack_70,uVar6);
              lVar7 = lRam00000001038df788;
              if ((uint)uStack_50 <= (uint)uStack_58) {
                uVar9 = *(uint *)(lRam00000001038df788 + 0x10);
                if ((uint)uStack_58 - (uint)uStack_50 < uVar9) {
                  func_0x000100331910(&uStack_70,lRam00000001038df788);
                  uVar9 = (uint)uStack_50;
                }
                else {
                  iVar10 = 0;
                  if (uVar9 != 0) {
                    lVar8 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
                    uVar6 = _UNK_1035f5500;
                    if ((lVar8 == 0) || (uVar6 = _UNK_1035f5508, lRam00000001038df788 + 0x14 == 0))
                    goto LAB_10179e51c;
                    _memmove(lVar8,lRam00000001038df788 + 0x14,(ulong)uVar9 << 1);
                    iVar10 = *(int *)(lVar7 + 0x10);
                  }
                  uVar9 = iVar10 + (uint)uStack_50;
                  uStack_50 = CONCAT44(uStack_50._4_4_,uVar9);
                }
                lVar7 = lRam00000001038df790;
                if (uVar9 <= (uint)uStack_58) {
                  uVar1 = *(uint *)(lRam00000001038df790 + 0x10);
                  if ((uint)uStack_58 - uVar9 < uVar1) {
                    func_0x000100331910(&uStack_70,lRam00000001038df790);
                  }
                  else {
                    iVar10 = 0;
                    if (uVar1 != 0) {
                      lVar8 = lStack_60 + (ulong)uVar9 * 2;
                      uVar6 = _UNK_1035f54f0;
                      if ((lVar8 == 0) || (uVar6 = _UNK_1035f54f8, lRam00000001038df790 + 0x14 == 0)
                         ) goto LAB_10179e51c;
                      _memmove(lVar8,lRam00000001038df790 + 0x14,(ulong)uVar1 << 1);
                      iVar10 = *(int *)(lVar7 + 0x10);
                      uVar9 = (uint)uStack_50;
                    }
                    uStack_50 = CONCAT44(uStack_50._4_4_,iVar10 + uVar9);
                  }
                  uVar6 = func_0x0001003577c8(&uStack_78);
                  func_0x00010034ef38(&uStack_70,uVar6);
                  lVar7 = lRam00000001038c4d00;
                  if ((uint)uStack_50 <= (uint)uStack_58) {
                    uVar9 = *(uint *)(lRam00000001038c4d00 + 0x10);
                    if ((uint)uStack_58 - (uint)uStack_50 < uVar9) {
                      func_0x000100331910(&uStack_70,lRam00000001038c4d00);
                    }
                    else {
                      iVar10 = 0;
                      if (uVar9 != 0) {
                        lVar8 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
                        uVar6 = _UNK_1035f54e0;
                        if ((lVar8 == 0) ||
                           (uVar6 = _UNK_1035f54e8, lRam00000001038c4d00 + 0x14 == 0))
                        goto LAB_10179e51c;
                        _memmove(lVar8,lRam00000001038c4d00 + 0x14,(ulong)uVar9 << 1);
                        iVar10 = *(int *)(lVar7 + 0x10);
                      }
                      uStack_50 = CONCAT44(uStack_50._4_4_,iVar10 + (uint)uStack_50);
                    }
                    uVar6 = func_0x0001003577dc(&uStack_78);
                    func_0x00010034ef38(&uStack_70,uVar6);
                    lVar7 = lRam00000001038df788;
                    if ((uint)uStack_50 <= (uint)uStack_58) {
                      uVar9 = *(uint *)(lRam00000001038df788 + 0x10);
                      if ((uint)uStack_58 - (uint)uStack_50 < uVar9) {
                        func_0x000100331910(&uStack_70,lRam00000001038df788);
                      }
                      else {
                        iVar10 = 0;
                        if (uVar9 != 0) {
                          lVar8 = lStack_60 + (uStack_50 & 0xffffffff) * 2;
                          uVar6 = _UNK_1035f54d0;
                          if ((lVar8 == 0) ||
                             (uVar6 = _UNK_1035f54d8, lRam00000001038df788 + 0x14 == 0))
                          goto LAB_10179e51c;
                          _memmove(lVar8,lRam00000001038df788 + 0x14,(ulong)uVar9 << 1);
                          iVar10 = *(int *)(lVar7 + 0x10);
                        }
                        uStack_50 = CONCAT44(uStack_50._4_4_,iVar10 + (uint)uStack_50);
                      }
                      uVar6 = func_0x000100331938(&uStack_70);
                      uVar6 = func_0x0001003323d8(uVar6,uRam00000001038df798);
                      DataMemoryBarrier(2,3);
                      *(undefined8 *)(lVar5 + 0x38) = uVar6;
                      *(undefined1 *)(((ulong)(lVar5 + 0x38) >> 9 & 0x7fffff) + lVar2) = 1;
                      lVar7 = func_0x000100331820(uRam00000001038df7a0,0x18);
                      func_0x0001003577f0(lVar7,0);
                      DataMemoryBarrier(2,3);
                      plVar11 = (long *)(lVar5 + 0x20);
                      *plVar11 = lVar7;
                      *(undefined1 *)(((ulong)plVar11 >> 9 & 0x7fffff) + lVar2) = 1;
                      lVar8 = func_0x000100331820(uRam00000001038df7a8,0x80);
                      DataMemoryBarrier(2,3);
                      *(long *)(lVar8 + 0x20) = lVar5;
                      *(undefined1 *)(((ulong)(lVar8 + 0x20) >> 9 & 0x7fffff) + lVar2) = 1;
                      uVar6 = uRam00000001038df7b8;
                      lVar7 = lRam00000001038df7b0;
                      *(long *)(lVar8 + 0x40) = lRam00000001038df7b0;
                      *(undefined8 *)(lVar8 + 0x28) = uVar6;
                      *(undefined8 *)(lVar8 + 0x18) = *(undefined8 *)(lVar7 + 0x30);
                      *(undefined8 *)(lVar8 + 0x10) = *(undefined8 *)(lVar7 + 0x28);
                      DataMemoryBarrier(2,3);
                      *(long *)(lVar5 + 0x40) = lVar8;
                      *(undefined1 *)(((ulong)(lVar5 + 0x40) >> 9 & 0x7fffff) + lVar2) = 1;
                      lVar8 = func_0x000100331820(uRam00000001038df7a8,0x80);
                      DataMemoryBarrier(2,3);
                      *(long *)(lVar8 + 0x20) = lVar5;
                      *(undefined1 *)(((ulong)(lVar8 + 0x20) >> 9 & 0x7fffff) + lVar2) = 1;
                      uVar6 = uRam00000001038df7c8;
                      lVar7 = lRam00000001038df7c0;
                      *(long *)(lVar8 + 0x40) = lRam00000001038df7c0;
                      *(undefined8 *)(lVar8 + 0x28) = uVar6;
                      *(undefined8 *)(lVar8 + 0x18) = *(undefined8 *)(lVar7 + 0x30);
                      *(undefined8 *)(lVar8 + 0x10) = *(undefined8 *)(lVar7 + 0x28);
                      DataMemoryBarrier(2,3);
                      *(long *)(lVar5 + 0x48) = lVar8;
                      *(undefined1 *)(((ulong)(lVar5 + 0x48) >> 9 & 0x7fffff) + lVar2) = 1;
                      lVar8 = func_0x000100331820(uRam00000001038df7a8,0x80);
                      DataMemoryBarrier(2,3);
                      *(long *)(lVar8 + 0x20) = lVar5;
                      *(undefined1 *)(((ulong)(lVar8 + 0x20) >> 9 & 0x7fffff) + lVar2) = 1;
                      uVar6 = uRam00000001038df7d8;
                      lVar7 = lRam00000001038df7d0;
                      *(long *)(lVar8 + 0x40) = lRam00000001038df7d0;
                      *(undefined8 *)(lVar8 + 0x28) = uVar6;
                      *(undefined8 *)(lVar8 + 0x18) = *(undefined8 *)(lVar7 + 0x30);
                      *(undefined8 *)(lVar8 + 0x10) = *(undefined8 *)(lVar7 + 0x28);
                      DataMemoryBarrier(2,3);
                      *(long *)(lVar5 + 0x50) = lVar8;
                      *(undefined1 *)(((ulong)(lVar5 + 0x50) >> 9 & 0x7fffff) + lVar2) = 1;
                      lVar7 = func_0x000100331820(uRam00000001038d3b88,0x80);
                      DataMemoryBarrier(2,3);
                      *(long *)(lVar7 + 0x20) = lVar5;
                      *(undefined1 *)(((ulong)(lVar7 + 0x20) >> 9 & 0x7fffff) + lVar2) = 1;
                      uVar6 = uRam00000001038df7e8;
                      lVar2 = lRam00000001038df7e0;
                      *(long *)(lVar7 + 0x40) = lRam00000001038df7e0;
                      *(undefined8 *)(lVar7 + 0x28) = uVar6;
                      *(undefined8 *)(lVar7 + 0x18) = *(undefined8 *)(lVar2 + 0x30);
                      *(undefined8 *)(lVar7 + 0x10) = *(undefined8 *)(lVar2 + 0x28);
                      func_0x000100357804();
                      uVar6 = _UNK_1035f54c8;
                      if (*plVar11 != 0) {
                        func_0x000100357818();
                        return *(undefined8 *)(lVar5 + 0x10);
                      }
                      goto LAB_10179e51c;
                    }
                  }
                }
              }
            }
          }
        }
        func_0x0001003319d8();
                    /* WARNING: Does not return */
        pcVar4 = (code *)SoftwareBreakpoint(1,0x10179e43c);
        (*pcVar4)();
      }
    }
  }
LAB_10179e51c:
  func_0x0001003316f4(0xee,uVar6);
                    /* WARNING: Does not return */
  pcVar4 = (code *)SoftwareBreakpoint(1,0x10179e528);
  (*pcVar4)();
}

