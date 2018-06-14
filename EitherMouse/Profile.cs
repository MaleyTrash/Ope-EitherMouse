namespace EitherMouse
{
    class Profile
    {
        private string _name;
        private int _mouseSpeed;
        private int _doubleClickSpeed;
        private int _scrollSpeed;

        public string Name { get => _name; set => _name = value; }
        public int MouseSpeed { get => _mouseSpeed; set => _mouseSpeed = value; }
        public int DoubleClickSpeed { get => _doubleClickSpeed; set => _doubleClickSpeed = value; }
        public int ScrollSpeed { get => _scrollSpeed; set => _scrollSpeed = value; }

        public Profile(string name, int mouseSpeed, int doubleClickSpeed, int scrollSpeed)
        {
            this._name = name;
            this._mouseSpeed = mouseSpeed;
            this._doubleClickSpeed = doubleClickSpeed;
            this._scrollSpeed = scrollSpeed;
        }

        public void ApplySettings()
        {
            User32.SetMouseSpeed((uint)_mouseSpeed);
            User32.SetDoubleClickSpeed((uint)_doubleClickSpeed);
            User32.SetScrollSpeed((uint)_scrollSpeed);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
