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
    public partial class ReportPage : Page
    {
        class Person{ public string Name { get; set; }}
        public ReportPage(string name)
        {
            InitializeComponent();
            Person _Person = new Person();
            _Person.Name = name;

            this.DataContext = _Person;

            ShowByEntity(name);
        }

        private void ShowByEntity(string name)
        {
            NewExpenseItEntities DB = new NewExpenseItEntities();

            DataGridName.ItemsSource = DB.NewExpenseItTables.Where(x => x.PersonName == name).ToList();

            //DepartmentData.Content = DB.NewExpenseItTables.Where(x => x.PersonName == name)
            //                                              .Select(x => x.PersonDepartment)
            //                                              .ToList()
            //                                              .FirstOrDefault();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
        private void Modify_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ModifyPage());
        }
    }
}
