using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PomodoroTaskBar.Service
{
    public static class ModifyProgressBarColor
    {
        public enum State : int
        {
            Normal = 1,
            Error = 2,
            Warning = 3
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, State state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)(int)state, IntPtr.Zero);
        }
    }
}
