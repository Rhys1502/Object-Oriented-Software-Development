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

namespace _1toManyDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person me = new Person();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, RoutedEventArgs e)
        {
            Car newCar = new Car(txtColour.Text, txtMake.Text);
            me.ownsCar(newCar);
        }

        private void btnShowCars_Click(object sender, RoutedEventArgs e)
        {
            me.showCars();
        }

   
    }
}
