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

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*System.Net.Sockets.UdpClient udpclient = new System.Net.Sockets.UdpClient();
            System.Net.IPEndPoint localEp = new System.Net.IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 24000);
            udpclient.Client.Bind(localEp);
            udpclient.Client.ReceiveTimeout = 10000;
            udpclient.Receive();*/
        }
    }
}
