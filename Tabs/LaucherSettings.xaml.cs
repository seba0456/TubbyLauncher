using System;
using System.Media;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using TubbyLauncher.Classes;

namespace TubbyLauncher.Tabs
{
    /// <summary>
    /// Interaction logic for LaucherSettings.xaml
    /// </summary>
    public partial class LaucherSettings : Window
    {
        public LaucherSettings()
        {
            InitializeComponent();
            LaucherCloseCheckBox.IsChecked = !(Properties.Settings.Default.bCloseLauncher);
        }
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (!(bool)(LaucherCloseCheckBox.IsChecked)) 
            {
                Properties.Settings.Default.bCloseLauncher = true;
                
            }
            else 
            {
                Properties.Settings.Default.bCloseLauncher = false;
            }
            Properties.Settings.Default.Save();
            Launcher.PlayAudio((bool)(LaucherCloseCheckBox.IsChecked));
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
