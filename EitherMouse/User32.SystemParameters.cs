namespace EitherMouse
{
    static partial class User32
    {
        internal enum SystemParameters
        {
            SPI_GETMOUSESPEED = 0x0070,
            SPI_SETMOUSESPEED = 0x0071,
            SPI_SETDOUBLECLICKTIME = 0x0020,
            SPI_SETWHEELSCROLLLINES = 0x0069,
        }
    }
}
