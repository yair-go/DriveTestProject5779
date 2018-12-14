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
            CreateDemoEntites();
            bl.addTester(new Tester("Nadav", 40));
            lbTesters.DataContext = bl.getTestersList();
           // bl.addTester(new Tester("Nadav", 40));


        }

        private void CreateDemoEntites()
        {
            int[] idArray = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in idArray)
            {
                bl.addTester(new Tester(i.ToString(), 20));
                //  bl.addChild(new Child(i.ToString(), 20));
            }

        }
    }
}
