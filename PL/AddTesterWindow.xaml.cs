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
using BE;
using BL;

namespace PL
{
    /// <summary>
    /// Interaction logic for AddTesterWindow.xaml
    /// </summary>
    public partial class AddTesterWindow : Window
    {
        public AddTesterWindow()
        {
            

            InitializeComponent();
            birthdayDatePicker.DisplayDateEnd = DateTime.Now.AddYears(BL.MyBL.Instance.getMinimumAge());
            birthdayDatePicker.DisplayDateStart = DateTime.Now.AddYears(BL.MyBL.Instance.getMaximumAge());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource testerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("testerViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // testerViewSource.Source = [generic data source]
        }

        private void pbAddTester_Click(object sender, RoutedEventArgs e)
        {
            MyBL.Instance.addTester(new Tester(nameTextBox.Text, birthdayDatePicker.DisplayDate,1));
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int a;
        }
    }
}
