using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Media;

namespace TubbyLauncher.Classes
{
    internal class Launcher
    {
        public static void PlayGame()
        {
            _ = Process.Start("Slendertubbies.exe");
        }
        public static void PlayAudio(bool checkstate)
        {
            if (checkstate == true)
            {
                SoundPlayer player = new SoundPlayer(Properties.Resource.Click1);
                player.Load();
                player.Play();
            }
            else
            {
                SoundPlayer player = new SoundPlayer(Properties.Resource.Click2);
                player.Load();
                player.Play();
            }
            
        }
        public static void LaunchWebstie(string url)
        {
            var ps = new ProcessStartInfo(url)
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(ps);
        }
        public static void LaunchDiag(string text, string title, string msboxicon)
        {
            if (msboxicon == "Error")
            {
                MessageBox.Show(text, title,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (msboxicon == "Info")
            {
                MessageBox.Show(text, title,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Program has invalid function ID.", "Wrong ID!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
