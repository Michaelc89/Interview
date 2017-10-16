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
using System.Data.SqlClient;

namespace BankApp1
{
    /// <summary>
    /// Interaction logic for Window1Loading.xaml
    /// </summary>
    public partial class Window1Loading : Window
    {
        MainWindow mw = new MainWindow();
        System.Windows.Threading.DispatcherTimer DT = new System.Windows.Threading.DispatcherTimer();//new timer

        public Window1Loading()
        {
            InitializeComponent();

            System.Threading.Thread.Sleep(1000);
        }

        

        private void button(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Michael C\Dropbox\Bank App\DB\BankDB.mdf;Integrated Security=True;Connect Timeout=30");
            string loginQuery = "select * from loginTable where username = *" + textUser.Text.Trim()+ "and password = *"+textPass.Text.Trim();
            SqlDataAdapter sda = new SqlDataAdapter(loginQuery, sqlCon);
             


            if (textUser.Text == "user")
            {
                if (textPass.Text == "password")
                {
                    this.Hide();
                    mw.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect Password!!");
                }
            }
            else
            {
                MessageBox.Show("Error: Please enter the correct Information!!");
            }
            
             
            
           // MainWindow mw = new MainWindow();
            //this.Hide();
            //mw.Show();
        }

        
    }
}
