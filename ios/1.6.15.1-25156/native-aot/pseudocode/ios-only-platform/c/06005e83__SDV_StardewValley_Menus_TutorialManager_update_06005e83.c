/* 0x06005e83 StardewValley.Menus.TutorialManager.update @ 0x100123960 */

void SDV_StardewValley_Menus_TutorialManager_update_06005e83(long param_1,undefined8 param_2)

{
  long lVar1;
  char cVar2;
  long *plVar3;
  long lVar4;
  long lVar5;
  undefined8 uVar6;
  undefined8 uStack_70;
  undefined8 uStack_68;
  long lStack_60;
  long lStack_58;
  long *plStack_10;
  
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  uStack_70 = 0;
  uStack_68 = 0;
  lStack_60 = 0;
  func_0x000100384dcc(param_1);
  if (*(int *)(param_1 + 0xa8) == 1) {
    plVar3 = *(long **)(param_1 + 0x80);
    if (plVar3 != (long *)0x0) {
      (**(code **)(*plVar3 + 0x90))(plVar3,param_2);
    }
  }
  else {
    if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
      func_0x0001003319b0();
    }
    if (*pcRam0000000103801940 == '\0') {
      if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      if (*pcRam0000000103805420 == '\0') {
        cVar2 = func_0x00010037811c(param_1);
        if ((cVar2 == '\0') || (*(long *)(param_1 + 0xa0) == 0)) {
          cVar2 = func_0x000100378130(param_1);
          if ((cVar2 != '\0') && (plVar3 = *(long **)(param_1 + 0x98), plVar3 != (long *)0x0)) {
            (**(code **)(*plVar3 + 0x90))(plVar3,param_2);
          }
        }
        else {
          (**(code **)(**(long **)(param_1 + 0xa0) + 0x90))(*(long **)(param_1 + 0xa0),param_2);
        }
      }
    }
    if ((*(int *)(param_1 + 0xa8) < 1) && (*(char *)(param_1 + 0xac) != '\0')) {
      cVar2 = func_0x000100377fc8();
      if (cVar2 == '\0') {
        lVar4 = func_0x0001003517c4();
        if ((lVar4 != 0) || (lVar4 = func_0x0001003516e8(), lVar4 != 0)) {
          lVar4 = func_0x0001003517c4();
          if (lVar4 == 0) {
            lVar4 = 0;
          }
          else {
            lVar4 = *(long *)(*(long *)(lVar4 + 0x178) + 0x60);
          }
          if (lVar4 == 0) {
            lVar4 = lRam0000000103800060;
          }
          cVar2 = func_0x000100384de0(*(undefined8 *)(param_1 + 0x90));
          if (cVar2 != '\0') {
            func_0x000100384df4(*(undefined8 *)(param_1 + 0x90));
            func_0x0001003595c8(param_1,(long)*(int *)(*(long *)(param_1 + 0x90) + 0xcc));
            *(undefined8 *)(param_1 + 0x90) = 0;
          }
          func_0x000100378040(&uStack_70);
LAB_100123da8:
          cVar2 = func_0x000100378054(&uStack_70);
          if (cVar2 != '\0') {
            if (*plRam00000001037fff88 != 0) {
              func_0x0001003316e0();
            }
            lVar1 = lStack_60;
            if (*(char *)(lRam0000000103800448 + 0x35) == '\0') {
              func_0x0001003319b0();
            }
            cVar2 = func_0x000100352e80(*puRam0000000103802240);
            if ((cVar2 != '\0') ||
               ((cVar2 = func_0x000100345aa0(*(undefined8 *)(lVar1 + 0x88),lRam0000000103800060),
                cVar2 == '\0' &&
                (cVar2 = func_0x000100345aa0(*(undefined8 *)(lVar1 + 0x88),lVar4), cVar2 == '\0'))))
            goto LAB_100123c2c;
            lVar5 = func_0x0001003516e8();
            if (lVar5 != 0) {
              plVar3 = (long *)func_0x0001003516e8();
              uVar6 = (**(code **)(*plVar3 + 0x1a0))(plVar3);
              cVar2 = func_0x000100331be0(uVar6,uRam0000000103805430);
              if (cVar2 == '\0') goto LAB_100123c2c;
            }
            goto LAB_100123cf0;
          }
          lStack_58 = 0;
          func_0x000100123ddc();
          if (lStack_58 != 0) {
            func_0x000100331ba4();
          }
          plVar3 = *(long **)(param_1 + 0x90);
          if (plVar3 != (long *)0x0) {
            (**(code **)(*plVar3 + 0x90))(plVar3,param_2);
          }
        }
      }
      else {
        func_0x000100377f50(param_1);
        *(undefined1 *)(param_1 + 0xac) = 0;
      }
    }
  }
  return;
LAB_100123c2c:
  cVar2 = func_0x000100350ff4(*(undefined8 *)(lVar1 + 0x98),0);
  if ((cVar2 != '\0') && (lVar5 = func_0x0001003516e8(), lVar5 != 0)) {
    plStack_10 = *(long **)(lVar1 + 0x98);
    plVar3 = (long *)func_0x0001003516e8();
    uVar6 = (**(code **)(*plVar3 + 0x1a0))(plVar3);
    cVar2 = func_0x000100331be0(plStack_10,uVar6);
    if (cVar2 == '\0') {
      if (*(char *)(lRam0000000103805438 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      if (*plRam0000000103805440 == 0) goto LAB_100123da8;
      plStack_10 = *(long **)(lVar1 + 0x98);
      if (*(char *)(lRam0000000103805438 + 0x35) == '\0') {
        func_0x0001003319b0();
      }
      cVar2 = func_0x000100331be0(plStack_10,*(undefined8 *)(*(long *)*plRam0000000103805440 + 0x18)
                                 );
      if (cVar2 == '\0') goto LAB_100123da8;
    }
LAB_100123cf0:
    if ((((*(char *)(lVar1 + 0xb2) == '\0') && (*(char *)(lVar1 + 0xb0) == '\0')) &&
        ((*(char *)(lVar1 + 0xb4) != '\0' ||
         (cVar2 = func_0x00010035011c(*(undefined8 *)(lVar1 + 0x80),lRam0000000103800060),
         cVar2 != '\0')))) &&
       ((cVar2 = func_0x000100384e08(param_1,lVar1), cVar2 != '\0' &&
        (cVar2 = func_0x000100384e1c(param_1,lVar1), cVar2 != '\0')))) {
      plStack_10 = (long *)(param_1 + 0x90);
      DataMemoryBarrier(2,3);
      *plStack_10 = lVar1;
      *(undefined1 *)(((ulong)plStack_10 >> 9 & 0x7fffff) + lRam00000001037fff60) = 1;
      func_0x000100377ec4(*(undefined8 *)(param_1 + 0x90));
    }
  }
  goto LAB_100123da8;
}

