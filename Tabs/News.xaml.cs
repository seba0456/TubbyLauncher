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
using Microsoft.Web.WebView2.Core;
using System.Runtime;
namespace TubbyLauncher
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        public Window1()
        {
            
            InitializeComponent();
            var url = "http://falloutarcadia.epizy.com/TubbyLauncher/launcher.html"; 
            NewsWeb.Source = new Uri(url + "?refreshToken=" + Guid.NewGuid().ToString());
            //NewsWeb.Source = new Uri("http://falloutarcadia.epizy.com/TubbyLauncher/launcher.html");
        }
        


    }
}
