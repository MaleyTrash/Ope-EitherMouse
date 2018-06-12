using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EitherMouse
{
    public partial class MainWindow : Window
    {
        private bool canExitFlag;

        public MainWindow()
        {
            InitializeComponent();
            //Tray icon
            IconGenerator icon = new IconGenerator(this, "EitherMouse", "EitherMouse", @"./icon.ico");
            icon.AddNotifyMenuItem(0, "Exit", exitItem_Click);
            icon.notifyIcon.DoubleClick += notifyIcon_MouseDoubleClick;
            InitializeComponent();
            Visibility = Visibility.Hidden;
            ShowInTaskbar = false;
            //MVVM
        }

        private void notifyIcon_MouseDoubleClick(object sender, EventArgs e)
        {
            if (Visibility == Visibility.Hidden || WindowState == WindowState.Minimized)
            {
                WindowState = WindowState.Normal;
                Visibility = Visibility.Visible;
                ShowInTaskbar = true;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!canExitFlag)
            {
                e.Cancel = true;
                Visibility = Visibility.Hidden;
                ShowInTaskbar = false;
            }
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            canExitFlag = true;
            System.Windows.Application.Current.Shutdown();
        }
    }
}
