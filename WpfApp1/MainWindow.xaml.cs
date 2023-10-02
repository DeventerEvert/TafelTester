using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using classLibraryForSums;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            randomSumGenerator generator = new randomSumGenerator();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window easyWindow = new easyWindow();
            easyWindow.ShowDialog();
        }

        private void mediumBtn_Click(object sender, RoutedEventArgs e)
        {
            Window mediumWindow = new mediumWindow();
            mediumWindow.ShowDialog();
        }

        private void hardBtn_Click(object sender, RoutedEventArgs e)
        {
            Window hardWindow = new hardWindow();
            hardWindow.ShowDialog();
        }
    }
}
