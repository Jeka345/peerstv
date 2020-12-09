using MahApps.Metro.Controls;
using System.Diagnostics;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для settings.xaml
    /// </summary>
    public partial class settings : MetroWindow
    {
        public settings()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
        }
        private void LaunchTelegram(object sender, RoutedEventArgs e) => Process.Start("tg://resolve/?domain=SmallVeins");
        private void DevChannel(object sender, RoutedEventArgs e) => Process.Start("tg://resolve/?domain=devcm_jeka345");

        /*private void changetoogle(object sender, RoutedEventArgs e)
        {
            if (tooglebutton1.IsOn == false)
            {
                label1.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                textbox1.Visibility = Visibility.Visible;
                textbox2.Visibility = Visibility.Visible;
                button1.Visibility = Visibility.Visible;
            }
            else
            {
                label1.Visibility = Visibility.Collapsed;
                label2.Visibility = Visibility.Collapsed;
                textbox1.Visibility = Visibility.Collapsed;
                textbox2.Visibility = Visibility.Collapsed;
                button1.Visibility = Visibility.Collapsed;
            }
        }*/

        private void savesettings(object sender, RoutedEventArgs e)
        {

        }
    }
}
