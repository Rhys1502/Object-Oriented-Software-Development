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

namespace RelationDemo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person me = new Person();
        //Create a Person object that we will manipulate 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, RoutedEventArgs e)
        {
            me.addCar();
        }

        private void btnShowCar_Click(object sender, RoutedEventArgs e)
        {
            me.showCar();
        }
    }
}
