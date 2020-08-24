using System;
using System.Diagnostics;
using System.Timers;
using Util;

namespace MiniBot.Core
{
    public class TibiaClient
    {
        public static Process TibiaProcess;

        public static void FindTibiaClientProcess()
        {
            TibiaProcess = Process.GetProcessesByName("client")[0];
        }

        public static bool IsFocused()
        {
            var activatedHandle = User32.GetForegroundWindow();

            // No window is currently activated
            if (activatedHandle == IntPtr.Zero)
                return false;

            int activeProcId;

            User32.GetWindowThreadProcessId(activatedHandle, out activeProcId);

            return activeProcId == TibiaProcess.Id;
        }

        public static void SetForeground()
        {
            User32.SetForegroundWindow(TibiaProcess.MainWindowHandle);
            User32.SetActiveWindow(TibiaProcess.MainWindowHandle);
        }
    }
}
