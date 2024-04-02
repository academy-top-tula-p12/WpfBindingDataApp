using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBindingDataApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee tommy;

        ObservableCollection<Employee> employees;
        public MainWindow()
        {
            InitializeComponent();
            //tommy = new() { Name = "Tommy", Age = 31, Salary = 78000 };
            //grid.DataContext = tommy;

            employees = new()
            {
                new() { Name = "Tommy", Age = 31, Salary = 78000, Image = "D:/Images/EXCEL.png" },
                new() { Name = "Bobby", Age = 29, Salary = 56000, Image = "D:/Images/PDF.png" },
                new() { Name = "Sammy", Age = 22, Salary = 87000, Image = "D:/Images/PNG.png" },
            };

            empls.ItemsSource = employees;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(tommy.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tommy.Name = "Tomas";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Employee newEmployee = new()
            {
                Name = txtName.Text,
                Age = Int32.Parse(txtAge.Text),
                Salary = Decimal.Parse(txtSalary.Text)
            };
            employees.Add(newEmployee);
        }
    }
}