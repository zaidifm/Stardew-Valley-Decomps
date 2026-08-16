/* 0x060031cf StardewValley.TutorialMessage.receiveRightClick @ 0x101785298 */

void SDV_StardewValley_TutorialMessage_receiveRightClick_060031cf(void)

{
  code *pcVar1;
  
  if (lRam0000000103976fb8 != 0) {
    func_0x00010119b8f8();
  }
  func_0x00010033202c(0x20000eb);
  func_0x000100331a50();
                    /* WARNING: Does not return */
  pcVar1 = (code *)SoftwareBreakpoint(1,0x1017852c4);
  (*pcVar1)();
}

