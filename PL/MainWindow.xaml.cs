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
using BL;
using BE;

namespace PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyBL bl;
        public MainWindow()
        {
            InitializeComponent();
            bl = MyBL.Instance;
      //      CreateDemoEntites();
            bl.addTester(new Tester("Nadav", new DateTime(1978,11,1)));
            lbTesters.DataContext = bl.getTestersList();
            testerDataGrid.DataContext = bl.getTestersList();
        }

        private void CreateDemoEntites()
        {
            int[] idArray = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in idArray)
            {
                bl.addTester(new Tester(i.ToString(), 20));
            }

        }

        private void pbTester_Click(object sender, RoutedEventArgs e)
        {
            AddTesterWindow addTesterWindow = new AddTesterWindow();
            addTesterWindow.Show();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            lbTesters.DataContext = bl.getTestersList();
            testerDataGrid.DataContext = bl.getTestersList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource testerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("testerViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // testerViewSource.Source = [generic data source]
        }
    }
}
