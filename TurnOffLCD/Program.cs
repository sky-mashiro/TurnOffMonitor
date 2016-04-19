using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TurnOffLCD
{
    class Program
    {

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int Wparam, int lParam);
        private const int SC_MONITORPOWER = 0xF170;
        private const int WM_SYSCOMMAND = 0x0112;
        private const int HWND_BROADCAST = 0xFFFF;

        private const int MONITOR_ON = -1;
        private const int MONITOR_OFF = 2;
        private const int MONITOR_STANDBY = 1;
        static void Main(string[] args)
        {
            SendMessage(HWND_BROADCAST, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF);
        }
    }
}
