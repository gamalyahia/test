using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    public partial class ModifyPage : Page
    {
        NewExpenseItEntities DB = new NewExpenseItEntities();
        public ModifyPage()
        {
            InitializeComponent();
            ModifyGrid.ItemsSource = DB.NewExpenseItTables.ToList();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("ID must be epmty");
                return;
            }
            NewExpenseItTable rec = new NewExpenseItTable
            {
                PersonAmount = int.Parse(txtAmount.Text),
                PersonDepartment = txtDepartment.Text,
                PersonExpenseType = txtExpenseType.Text,
                PersonName = txtName.Text,
            };

            DB.NewExpenseItTables.Add(rec);
            DB.SaveChanges();

            MessageBox.Show("added successfully");
            Refresh_Click(sender, e);
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Must enter ID");
                return;
            }
            try
            {
                int personId = int.Parse(txtID.Text);

                NewExpenseItTable rec = DB.NewExpenseItTables.FirstOrDefault(x => x.PersonID == personId);

                if (rec == null)
                {
                    MessageBox.Show("ID not found");
                    return;
                }

                rec.PersonName = txtName.Text;
                rec.PersonAmount = int.Parse(txtAmount.Text);
                rec.PersonDepartment = txtDepartment.Text;
                rec.PersonExpenseType = txtExpenseType.Text;

                DB.SaveChanges();

                MessageBox.Show("Data Updated");

                Refresh_Click(sender, e);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID format. Please enter a numeric ID.");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("ID not found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Must enter ID");
                return;
            }
            try
            {
                int personId = int.Parse(txtID.Text);
                NewExpenseItTable rec = DB.NewExpenseItTables.Remove(DB.NewExpenseItTables.FirstOrDefault(x => x.PersonID == personId));
                //DB.NewExpenseItTables.Remove(rec);
                MessageBox.Show("Record deleted");

                DB.SaveChanges();

                Refresh_Click(sender, e);

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID format. Please enter a numeric ID.");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Error occurred while trying to delete the record.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            ModifyGrid.ItemsSource = DB.NewExpenseItTables.Where(x => x.PersonName.Contains(txtName.Text)).ToList();
        }
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            ModifyGrid.ItemsSource = DB.NewExpenseItTables.ToList();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            ModifyGrid.ItemsSource = DB.NewExpenseItTables.ToList();
        }

    }
}
