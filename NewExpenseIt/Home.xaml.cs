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

namespace NewExpenseIt
{
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ListBoxName.SelectedItem == null)
            {
                MessageBox.Show("select one please !");
                return;
            }
            string name = ListBoxName.SelectedItem.ToString().Split().Last();
            this.NavigationService.Navigate(new ReportPage(name));
        }

        private void Modify_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ModifyPage());
        }
    }
}
