using AutoUpdaterDotNET;
using System.Windows;

namespace wpf_calc_beta.UI
{
    /// <summary>
    /// Interaction logic for updater.xaml
    /// </summary>
    public partial class Updater
    {
        Updater()
        {
            InitializeComponent();
        }

        private static Updater msgbox;
        private static bool result = false;
   
        public static bool Show (string msg)
        {
            msgbox = new Updater();
            msgbox.nfoText.Text = msg;
            msgbox.ShowDialog();
            return result;
        }

        private void InstallUpdateClick(object sender, RoutedEventArgs e)
        {
            result = true;
            msgbox.Close();
        }
        private void LaterUpdateClick(object sender, RoutedEventArgs e)
        {
            result = false;
            msgbox.Close();
        }
    }
}
