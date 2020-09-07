using MiniBot.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Util;
using WindowsInput;
using WindowsInput.Native;

namespace MiniBot.Domain
{
    public class KeyBoardSimulator
    {
        private const UInt32 WM_KEYDOWN = 0x0100;
        private const ushort VK_F3 = 0x72;

        public void MoveCharWithControlArrow()
        {
            var tibiaWindowFocused = TibiaClient.IsFocused();

            if(tibiaWindowFocused)
            {
                var inputSimulator = new InputSimulator();

                inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.UP);
                Thread.Sleep(150);
                inputSimulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.DOWN);
            }
            else
            {
                User32.PostMessage(TibiaClient.Process.MainWindowHandle, WM_KEYDOWN, VK_F3, 0);
            }
            
        }
    }
}
