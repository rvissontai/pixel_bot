using System;
using System.Windows;

namespace MiniBot.Infra.CrossCutting.Pinvoke.Wrappers
{
    public interface IUser32Wrapper
    {
        IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
        IntPtr GetDC(IntPtr hwnd);
        IntPtr GetForegroundWindow();
        bool GetWindowRect(IntPtr hWnd, out Rect lpRect);
        int GetWindowThreadProcessId(IntPtr handle, out int processId);
        bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
        bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);
        int ReleaseDC(IntPtr hwnd, IntPtr hdc);
        int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
        IntPtr SetActiveWindow(IntPtr hWnd);
        bool SetForegroundWindow(IntPtr hWnd);
    }
}