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

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool running = false;
        private void btnStatus_Click(object sender, RoutedEventArgs e)
        {
            if(running)
            {
                tbStatus.Text = "Running...";
                btnStatus.Content = "Stop";
            }
            else
            {
                tbStatus.Text = "Stopped";
                btnStatus.Content = "Run";
            }
            running = !running;
        }
    }
}
