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

namespace WpfApp40.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            btnSend.IsEnabled = false;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in User.Users)
            {
                if (item.Name == tbName.Text & item.Password == tbPass.Text)
                {
                    new Client(item.Name, item.Password).ShowDialog();
                }
            }
        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbName.Text != "" & tbPass.Text != "")
            {
                btnSend.IsEnabled = true;
            }
            else
            {
                btnSend.IsEnabled = false;
            }
        }
    }
}
