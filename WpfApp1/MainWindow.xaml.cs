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
using System.Net;
using System.Collections.Specialized;


namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WebRequest request = WebRequest.Create("http://tmgwebtest.azurewebsites.net/api/textstrings/1");
            request.Headers.Add("TMG-Api-Key", "0J/RgNC40LLQtdGC0LjQutC4IQ==");
            request.Method = "GET";
            WebResponse resp = request.GetResponse();
            Stream receiveStream = resp.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            Txt1.Text = readStream.ReadToEnd();
            resp.Close();
            readStream.Close();
        }
    }
}
