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

namespace BINARY
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
      

   

        private void btnRun_Click_1(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            if (input == "1") { lblOutput.Content = "1"; }
            else if (input == "2") { lblOutput.Content = "10"; }
            else if (input == "3") { lblOutput.Content = "11"; }
            else if (input == "4") { lblOutput.Content = "100"; }
            else if (input == "5") { lblOutput.Content = "101"; }
            else if (input == "6") { lblOutput.Content = "1000"; }
            else if (input == "7") { lblOutput.Content = "1001"; }
            else if (input == "8") { lblOutput.Content = "1010"; }
            else if (input == "9") { lblOutput.Content = "1011"; }
            else if (input == "10") { lblOutput.Content = "1100"; }
            else if (input == "11") { lblOutput.Content = "1101"; }
            else if (input == "12") { lblOutput.Content = "1110"; }
            else if (input == "13") { lblOutput.Content = "1111"; }
            else if (input == "14") { lblOutput.Content = "10000"; }
            else if (input == "15") { lblOutput.Content = "10001"; }
            else if (input == "16") { lblOutput.Content = "10010"; }
            else if (input == "17") { lblOutput.Content = "10011"; }
            else if (input == "18") { lblOutput.Content = "10100"; }
            else if (input == "19") { lblOutput.Content = "10101"; }
            else if (input == "20") { lblOutput.Content = "10110"; }

            string output = input;
           
            
        }
    }
}
