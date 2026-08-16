/* 0x060032e0 StardewValley.CloudSync.SyncTask @ 0x1000a8e00 */

/* WARNING: Restarted to delay deadcode elimination for space: stack */

void SDV_StardewValley_CloudSync_SyncTask_060032e0(long param_1)

{
  uint uVar1;
  char cVar2;
  int iVar3;
  long lVar4;
  undefined8 uVar5;
  long *plVar6;
  long lVar7;
  undefined8 uStack_268;
  undefined8 uStack_260;
  long lStack_258;
  undefined8 uStack_250;
  undefined8 uStack_248;
  long lStack_240;
  undefined8 uStack_238;
  undefined8 uStack_230;
  long lStack_228;
  undefined8 uStack_220;
  undefined8 uStack_218;
  long lStack_210;
  undefined8 uStack_208;
  undefined8 uStack_200;
  undefined8 uStack_1f8;
  long lStack_1f0;
  long lStack_1e8;
  long lStack_1e0;
  long lStack_1d8;
  float fStack_1d0;
  undefined8 uStack_1c8;
  int aiStack_1c0 [2];
  long lStack_1b8;
  long lStack_1b0;
  long lStack_1a8;
  long lStack_1a0;
  undefined8 uStack_198;
  undefined1 auStack_190 [8];
  undefined8 uStack_188;
  undefined1 *puStack_180;
  long lStack_178;
  undefined8 *puStack_170;
  long lStack_168;
  long lStack_160;
  undefined8 *puStack_150;
  long lStack_148;
  long lStack_140;
  undefined8 *puStack_130;
  long lStack_128;
  long lStack_120;
  long lStack_110;
  long lStack_100;
  undefined8 uStack_10;
  
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  lStack_1f0 = 0;
  lStack_1e8 = 0;
  lStack_1e0 = 0;
  lStack_1d8 = 0;
  fStack_1d0 = 0.0;
  uStack_208 = 0;
  uStack_200 = 0;
  uStack_1f8 = 0;
  uStack_1c8 = 0;
  aiStack_1c0[0] = 0;
  uStack_220 = 0;
  uStack_218 = 0;
  lStack_210 = 0;
  uStack_238 = 0;
  uStack_230 = 0;
  lStack_228 = 0;
  lStack_1b8 = 0;
  lStack_1b0 = 0;
  lStack_1a8 = 0;
  lStack_1a0 = 0;
  uStack_198 = 0;
  auStack_190[0] = 0;
  *(undefined4 *)(param_1 + 0x38) = 0;
  if (*(int *)(*(long *)(param_1 + 0x28) + 0x18) < 1) {
    if (0 < *(int *)(*(long *)(param_1 + 0x30) + 0x18)) {
      func_0x00010035458c(&uStack_208);
      while (cVar2 = func_0x0001003545a0(&uStack_208), cVar2 != '\0') {
        if (*plRam00000001037fff88 != 0) {
          func_0x0001003316e0();
        }
        uStack_10 = uStack_1f8;
        func_0x000100357a20(uStack_1f8,&uStack_1c8,aiStack_1c0);
        aiStack_1c0[0] = aiStack_1c0[0] + 1;
        func_0x000100383328(uStack_10,uStack_1c8,(long)aiStack_1c0[0]);
      }
      lStack_100 = 0;
      func_0x0001000a8fa0();
      if (lStack_100 != 0) {
        func_0x000100331ba4();
      }
      lVar7 = *(long *)(param_1 + 0x30);
      *(int *)(lVar7 + 0x1c) = *(int *)(lVar7 + 0x1c) + 1;
      iVar3 = *(int *)(lVar7 + 0x18);
      *(undefined4 *)(lVar7 + 0x18) = 0;
      if (0 < iVar3) {
        func_0x000100331c80(*(undefined8 *)(lVar7 + 0x10),0,(long)iVar3);
      }
    }
    cVar2 = func_0x00010038333c(param_1,&lStack_1f0,&lStack_1e8,&lStack_1e0,&lStack_1d8);
    if (cVar2 != '\0') {
      if (*(char *)(param_1 + 0x3e) == '\0') {
        *(int *)(lStack_1d8 + 0x1c) = *(int *)(lStack_1d8 + 0x1c) + 1;
        iVar3 = *(int *)(lStack_1d8 + 0x18);
        *(undefined4 *)(lStack_1d8 + 0x18) = 0;
        if (0 < iVar3) {
          func_0x000100331c80(*(undefined8 *)(lStack_1d8 + 0x10),0,(long)iVar3);
        }
      }
      if (0 < *(int *)(lStack_1d8 + 0x18)) {
        while( true ) {
          if (*plRam00000001037fff88 != 0) {
            func_0x0001003316e0();
          }
          if (*(long *)(param_1 + 0x20) != 0) break;
          func_0x000100363398(500);
        }
        func_0x000100383350(&uStack_220);
        while (cVar2 = func_0x000100383378(&uStack_220), cVar2 != '\0') {
          if (*plRam00000001037fff88 != 0) {
            func_0x0001003316e0();
          }
          lVar7 = lStack_210;
          lVar4 = func_0x000100383364(param_1,*(undefined8 *)(lStack_210 + 0x10),
                                      *(undefined8 *)(lStack_210 + 0x18));
          if (lVar4 == 0) {
            *(undefined1 *)(param_1 + 0x3d) = 1;
            lStack_110 = 0;
            func_0x0001000a9270();
            if (lStack_110 != 0) {
              func_0x000100331ba4();
            }
            goto LAB_1000a9800;
          }
          if (*(long *)(lVar7 + 0x10) == lVar4) {
            uVar5 = *(undefined8 *)(lVar7 + 0x10);
            *(int *)(lStack_1e8 + 0x1c) = *(int *)(lStack_1e8 + 0x1c) + 1;
            plVar6 = *(long **)(lStack_1e8 + 0x10);
            uVar1 = *(uint *)(lStack_1e8 + 0x18);
            if (uVar1 < *(uint *)(plVar6 + 3)) {
              *(uint *)(lStack_1e8 + 0x18) = uVar1 + 1;
              (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,uVar5);
            }
            else {
              func_0x00010035787c(lStack_1e8,uVar5);
            }
          }
          else if (*(long *)(lVar7 + 0x18) == lVar4) {
            uVar5 = *(undefined8 *)(lVar7 + 0x18);
            *(int *)(lStack_1f0 + 0x1c) = *(int *)(lStack_1f0 + 0x1c) + 1;
            plVar6 = *(long **)(lStack_1f0 + 0x10);
            uVar1 = *(uint *)(lStack_1f0 + 0x18);
            if (uVar1 < *(uint *)(plVar6 + 3)) {
              *(uint *)(lStack_1f0 + 0x18) = uVar1 + 1;
              (**(code **)(*plVar6 + 0x110))(plVar6,(long)(int)uVar1,uVar5);
            }
            else {
              func_0x00010035787c(lStack_1f0,uVar5);
            }
          }
        }
        lStack_110 = 0;
        func_0x0001000a9270();
        if (lStack_110 != 0) {
          func_0x000100331ba4();
        }
      }
      fStack_1d0 = 100.0;
      iVar3 = *(int *)(lStack_1f0 + 0x18) + *(int *)(lStack_1e8 + 0x18) +
              *(int *)(lStack_1e0 + 0x18);
      if (0 < iVar3) {
        fStack_1d0 = 100.0 / (float)iVar3;
      }
      *(float *)(param_1 + 0x38) = *(float *)(param_1 + 0x38) + fStack_1d0 * 0.5;
      func_0x000100357854(&uStack_238);
      while (cVar2 = func_0x000100357868(&uStack_238), cVar2 != '\0') {
        if (*plRam00000001037fff88 != 0) {
          func_0x0001003316e0();
        }
        puStack_170 = &uStack_238;
        lStack_1b8 = lStack_228;
        lStack_168 = lStack_1b8;
        if (*(char *)(param_1 + 0x3c) != '\0') {
          lStack_160 = 0;
          func_0x0001000a9444();
          if (lStack_160 != 0) {
            func_0x000100331ba4();
          }
          goto LAB_1000a9478;
        }
        func_0x00010038338c(*(undefined8 *)(lStack_228 + 0x28));
        *(float *)(param_1 + 0x38) = *(float *)(param_1 + 0x38) + fStack_1d0;
      }
      lStack_160 = 0;
      func_0x0001000a9444();
      if (lStack_160 != 0) {
        func_0x000100331ba4();
      }
LAB_1000a9478:
      func_0x000100357854(&uStack_250);
      uStack_238 = uStack_250;
      uStack_230 = uStack_248;
      lStack_228 = lStack_240;
      while (cVar2 = func_0x000100357868(&uStack_238), cVar2 != '\0') {
        if (*plRam00000001037fff88 != 0) {
          func_0x0001003316e0();
        }
        puStack_150 = &uStack_238;
        lStack_1b0 = lStack_228;
        lStack_148 = lStack_1b0;
        if (*(char *)(param_1 + 0x3c) != '\0') {
          lStack_140 = 0;
          func_0x0001000a963c();
          if (lStack_140 != 0) {
            func_0x000100331ba4();
          }
          goto LAB_1000a9670;
        }
        lStack_1a8 = 0;
        lStack_1a8 = func_0x0001003833a0(param_1,lStack_228);
        if ((lStack_1a8 != 0) && (cVar2 = func_0x0001003833b4(param_1,lStack_1a8), cVar2 == '\0')) {
          lStack_140 = 0;
          func_0x0001000a963c();
          if (lStack_140 != 0) {
            func_0x000100331ba4();
          }
          goto LAB_1000a9800;
        }
        *(float *)(param_1 + 0x38) = *(float *)(param_1 + 0x38) + fStack_1d0;
      }
      lStack_140 = 0;
      func_0x0001000a963c();
      if (lStack_140 != 0) {
        func_0x000100331ba4();
      }
LAB_1000a9670:
      func_0x000100357854(&uStack_268);
      uStack_238 = uStack_268;
      uStack_230 = uStack_260;
      lStack_228 = lStack_258;
      while (cVar2 = func_0x000100357868(&uStack_238), cVar2 != '\0') {
        if (*plRam00000001037fff88 != 0) {
          func_0x0001003316e0();
        }
        puStack_130 = &uStack_238;
        lStack_1a0 = lStack_228;
        lStack_128 = lStack_1a0;
        if (*(char *)(param_1 + 0x3c) != '\0') {
          lStack_120 = 0;
          func_0x0001000a97cc();
          if (lStack_120 != 0) {
            func_0x000100331ba4();
          }
          goto LAB_1000a9800;
        }
        cVar2 = func_0x0001003833c8(param_1,lStack_228);
        if (cVar2 == '\0') {
          lStack_120 = 0;
          func_0x0001000a97cc();
          if (lStack_120 != 0) {
            func_0x000100331ba4();
          }
          goto LAB_1000a9800;
        }
        *(float *)(param_1 + 0x38) = *(float *)(param_1 + 0x38) + fStack_1d0;
      }
      lStack_120 = 0;
      func_0x0001000a97cc();
      if (lStack_120 != 0) {
        func_0x000100331ba4();
      }
    }
  }
  else {
    func_0x000100383314(param_1);
  }
LAB_1000a9800:
  *(undefined4 *)(param_1 + 0x38) = 0x42c80000;
  uStack_198 = *(undefined8 *)(param_1 + 0x10);
  auStack_190[0] = 0;
  puStack_180 = auStack_190;
  uStack_188 = uStack_198;
  iVar3 = func_0x000103141e78(uStack_198,auStack_190);
  if (iVar3 == 0) {
    func_0x000100331bb8(uStack_188,puStack_180);
  }
  *(undefined1 *)(param_1 + 0x3c) = 0;
  *(undefined8 *)(param_1 + 0x18) = 0;
  lStack_178 = 0;
  func_0x0001000a987c();
  if (lStack_178 != 0) {
    func_0x000100331ba4();
  }
  return;
}

