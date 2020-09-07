using System;
using System.Diagnostics;
using System.Timers;
using Util;

namespace MiniBot.Core
{
    public class TibiaClient
    {
        public static Process Process;

        public static void FindTibiaClientProcess()
        {
            Process = Process.GetProcessesByName("client")[0];
        }

        public static bool IsFocused()
        {
            var activatedHandle = User32.GetForegroundWindow();

            // No window is currently activated
            if (activatedHandle == IntPtr.Zero)
                return false;

            int activeProcId;

            User32.GetWindowThreadProcessId(activatedHandle, out activeProcId);

            return activeProcId == Process.Id;
        }

        public static void SetForeground()
        {
            User32.SetForegroundWindow(Process.MainWindowHandle);
            User32.SetActiveWindow(Process.MainWindowHandle);
        }
    }
}
