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

namespace _2WayRelationDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person me = new Person();
        private Car myCar;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, RoutedEventArgs e)
        {
            myCar = new Car();
            myCar.setOwner(me);
            myCar.colour = "Red";
            myCar.make = "Ford";
        }

        private void btnShowCar_Click(object sender, RoutedEventArgs e)
        {
            myCar.printDetails();
        }
    }
}
