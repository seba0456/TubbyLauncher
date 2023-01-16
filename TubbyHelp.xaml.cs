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
using System.Windows.Shapes;

namespace TubbyLauncher
{
    /// <summary>
    /// Interaction logic for TubbyHelp.xaml
    /// </summary>
    public partial class TubbyHelp : Window
    {
        public TubbyHelp()
        {
            InitializeComponent();
            var location = Environment.CurrentDirectory;
            var url = location + "/LauncherData/Support/Index.html";
            Console.WriteLine(url);
            webView.Source = new Uri(url);
        }
    }
}
