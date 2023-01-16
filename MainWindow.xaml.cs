using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Diagnostics;
using TubbyLauncher.Classes;


namespace TubbyLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        
        string gameverison = "Loading value";
        public MainWindow()
        {
            InitializeComponent();
            //var url = "http://falloutarcadia.epizy.com/TubbyLauncher/launcher.html";
            //NewsInfo.Navigate(url + "?refreshToken=" + Guid.NewGuid().ToString());
            try
            {
                using (TextReader reader = File.OpenText("LauncherData/gameversion.txt"))
                {
                    string z = reader.ReadLine();
                    gameverison = z;
                    GameVersionLabel.Content = "Game version " + z;
                }
            }
            catch (Exception)
            {
                Launcher.LaunchDiag("Couldn't find game version.", "Launcher error", "Error");
                GameVersionLabel.Content = "Game version invalid";
            }

        }
        private void LaunchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process[] pname = Process.GetProcessesByName("Slendertubbies");
                if (pname.Length == 0)
                {
                    Launcher.PlayGame();
                    if (Properties.Settings.Default.bCloseLauncher == true)
                    {
                        System.Windows.Application.Current.Shutdown();
                    }
                }
                else
                    Launcher.LaunchDiag("We have detected that game is currently running. To prevent running unnecessary processes Tubby launcher will not run game.", "Game is already running.", "Error");
                
            }
            catch (Exception)
            {
                Launcher.LaunchDiag("Launcher couldn't find game, please reinstall Slendertubbies.", "Game not found!", "Error");
            }
            
        }

        private void Website_Click(object sender, RoutedEventArgs e)
        {
            LauncherFunctions.ObtainIP();
        }

        private void WebsiteLaunchButton_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebstie("https://seba0456.itch.io/slendertubbies");
        }

        private void DiscordLaunch_Click(object sender, RoutedEventArgs e)
        {
            Launcher.LaunchWebstie("https://discord.gg/Tr5eWb6");
        }

        private void ShowIP_Click(object sender, RoutedEventArgs e)
        {
            LauncherFunctions.ObtainIP();
        }

        private void ShowNewsWindow(object sender, RoutedEventArgs e)
        {
            Window1 win2 = new Window1();
            win2.ShowDialog();
        }

        private void ShowSupportWindow(object sender, RoutedEventArgs e)
        {
            TubbyHelp win2 = new TubbyHelp();
            win2.ShowDialog();
        }

        private void SettingsLaunch_Click(object sender, RoutedEventArgs e)
        {
            Tabs.LaucherSettings win2 = new Tabs.LaucherSettings();
            win2.ShowDialog();
        }
    }
}
