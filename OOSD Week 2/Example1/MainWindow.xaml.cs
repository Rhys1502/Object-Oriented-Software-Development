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
using static System.Net.Mime.MediaTypeNames;

namespace MyFirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();
        }

        private void btnMyOKButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the values from the TextBoxes
            string name = txtName.Text;
            int age;
            string matriculationNumber = txtMatriculationNumber.Text;


            try
            {
                // Validate Name
                if (name.Length < 2 || name.Length > 20)
                {
                    throw new ArgumentException("Name must be between 2 and 20 characters in length.");
                }

                // Validate Age
                age = Convert.ToInt32(txtAge.Text);

                if (age < 18 || age > 110)
                {
                    throw new ArgumentException("Age must be in the range 18 - 110.");
                }

                // Validate Matriculation Number
                if (matriculationNumber.Length != 8 || !matriculationNumber.StartsWith("4"))
                {
                    throw new ArgumentException("Matriculation number must be 8 digits long and begin with a 4.");
                }

                // Disable the TextBoxes
                txtName.IsEnabled = false;
                txtAge.IsEnabled = false;
                txtMatriculationNumber.IsEnabled = false;

                // Create and display the message
                string message = $"Name: {name}\nAge: {age}\nMatriculation Number: {matriculationNumber}";
                MessageBox.Show(message, "User Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                // Handle validation errors
                MessageBox.Show($"Validation Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            // Create new window
            SecondWindow newWin = new SecondWindow();
            newWin.Show();
        }

        private void btnAdvanced_Click(object sender, RoutedEventArgs e)
        {
            lblCourse.Visibility = Visibility.Visible;
            cboCourse.Visibility = Visibility.Visible;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
