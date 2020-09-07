using System;
using System.Windows;
using Util;

namespace MiniBot.Infra.CrossCutting.Pinvoke.Wrappers
{
    public class User32Wrapper : IUser32Wrapper
    {
        public IntPtr GetForegroundWindow()
        {
            return User32.GetForegroundWindow();
        }

        public bool SetForegroundWindow(IntPtr hWnd)
        {
            return User32.SetForegroundWindow(hWnd);
        }

        public int GetWindowThreadProcessId(IntPtr handle, out int processId)
        {
            return User32.GetWindowThreadProcessId(handle, out processId);
        }

        public IntPtr SetActiveWindow(IntPtr hWnd)
        {
            return User32.SetActiveWindow(hWnd);
        }

        public IntPtr GetDC(IntPtr hwnd)
        {
            return User32.GetDC(hwnd);
        }

        public Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc)
        {
            return User32.ReleaseDC(hwnd, hdc);
        }

        public bool GetWindowRect(IntPtr hWnd, out Rect lpRect)
        {
            return User32.GetWindowRect(hWnd, out lpRect);
        }

        public bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags)
        {
            return User32.PrintWindow(hWnd, hdcBlt, nFlags);
        }

        public IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow)
        {
            return User32.FindWindowEx(hwndParent, hwndChildAfter, lpszClass, lpszWindow);
        }

        public int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam)
        {
            return User32.SendMessage(hWnd, uMsg, wParam, lParam);
        }

        public bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam)
        {
            return User32.PostMessage(hWnd, Msg, wParam, lParam);
        }
    }
}
