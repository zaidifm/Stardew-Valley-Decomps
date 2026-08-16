/* 0x06006778 StardewValley.iOS.AppDelegate.CopySaveGame @ 0x10013a7c0 */

/* WARNING: Removing unreachable block (ram,0x00010013aa24) */
/* WARNING: Removing unreachable block (ram,0x00010013aac0) */

void SDV_StardewValley_iOS_AppDelegate_CopySaveGame_06006778(undefined8 param_1,undefined8 param_2)

{
  int iVar1;
  int iVar2;
  long *plVar3;
  long *plVar4;
  undefined8 uVar5;
  undefined8 uVar6;
  undefined8 uVar7;
  
  if (*plRam00000001037fff88 != 0) {
    func_0x0001003316e0();
  }
  plVar3 = (long *)func_0x000100331820(uRam0000000103800028,0x40);
  func_0x00010036cda8(plVar3,0x20000);
  func_0x000100332388(uRam0000000103805d70,param_2,uRam0000000103805d78);
  plVar4 = (long *)func_0x000100385330();
  func_0x0001003844d0(plVar4);
  (**(code **)(*plVar3 + 0xb8))(plVar3,0,0);
  uVar5 = func_0x000100385344(plVar3);
  iVar1 = (**(code **)(*plVar3 + 0x158))(plVar3);
  (**(code **)(*plVar4 + 0x120))(plVar4);
  plVar3 = (long *)func_0x000100331820(uRam0000000103800028,0x40);
  func_0x00010036cda8(plVar3,0x200000);
  func_0x00010035048c(uRam0000000103805d70,param_2,uRam0000000103800c00,param_2);
  plVar4 = (long *)func_0x000100385330();
  func_0x0001003844d0(plVar4);
  (**(code **)(*plVar3 + 0xb8))(plVar3,0,0);
  uVar6 = func_0x000100385344(plVar3);
  iVar2 = (**(code **)(*plVar3 + 0x158))(plVar3);
  (**(code **)(*plVar4 + 0x120))(plVar4);
  uVar7 = func_0x00010035174c(5);
  func_0x000100351788();
  uVar7 = func_0x000100351760(uVar7,param_2);
  func_0x000100351788(uVar7);
  func_0x000100351760(uVar7,uRam0000000103805d80);
  plVar3 = (long *)func_0x000100385358();
  (**(code **)(*plVar3 + 0x90))(plVar3,uVar5,0,(long)iVar1);
  func_0x00010013aa2c();
  func_0x000100351760(uVar7,param_2);
  plVar3 = (long *)func_0x000100385358();
  (**(code **)(*plVar3 + 0x90))(plVar3,uVar6,0,(long)iVar2);
  func_0x00010013aac8();
  return;
}

