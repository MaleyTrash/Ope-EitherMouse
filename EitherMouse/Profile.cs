namespace EitherMouse
{
    class Profile
    {
        public string name;
        public int mouseSpeed;
        public int doubleClickSpeed;
        public int scrollSpeed;

        public Profile(string name, int mouseSpeed, int doubleClickSpeed, int scrollSpeed)
        {
            this.name = name;
            this.mouseSpeed = mouseSpeed;
            this.doubleClickSpeed = doubleClickSpeed;
            this.scrollSpeed = scrollSpeed;
        }
    }
}
