using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Windows.Forms;

namespace TubbyLauncher.Classes
{
    internal class LauncherFunctions
    {
        public static void ObtainIP()
        {
            string localIP = string.Empty;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();
            }
            string msg = "This info will be usefull only for people that hosts Slendertubbies game using LAN network method." + Environment.NewLine + "Send this adress to your friend:" + Environment.NewLine + localIP + Environment.NewLine + "Please remember it work only inside Local Area Network! Make sure that you are using the same network! You can also use this IP if you are using Hamachi. Remember to double check IP!" + Environment.NewLine + "Do you wisch to copy it?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msg, "Your IP address", buttons);
            if (result == DialogResult.Yes)
            {
                Clipboard.SetText(localIP);

            }
            else
            {

            }

        }
    }
}
