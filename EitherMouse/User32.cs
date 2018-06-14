using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace EitherMouse
{
    static partial class User32
    {

        [DllImport("User32.dll")]
        extern static bool SystemParametersInfo(SystemParameters action, uint param, IntPtr output, uint fWinIni);

        public static unsafe int SetMouseSpeed(uint speed)
        {
            if (speed < 1 || speed > 20) return -1;
            SystemParametersInfo(SystemParameters.SPI_SETMOUSESPEED, 0, new IntPtr(speed), 0);
            return (int)speed;
        }

        public static unsafe int SetDoubleClickSpeed(uint speed)
        {
            SystemParametersInfo(SystemParameters.SPI_SETDOUBLECLICKTIME, 0, new IntPtr(speed), 0);
            return (int)speed;
        }

        public static unsafe int SetScrollSpeed(uint speed)
        {
            SystemParametersInfo(SystemParameters.SPI_SETWHEELSCROLLLINES, 0, new IntPtr(speed), 0);
            return (int)speed;
        }
    }
}
