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

namespace BankApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            decimal TotalCredit = 0.0M;
            SavingsAccount sa = new SavingsAccount(1000.25M, 0.1M)
                //https://www.youtube.com/watch?v=KBOtWrPXhE8 25.29
        }

        private void Deposit_Click(object sender, RoutedEventArgs e)
        {
            DepositWindow dw = new DepositWindow();
            this.Hide();
            dw.Show();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
