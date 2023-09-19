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
using System.Windows.Threading;

namespace RandomNumberWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        private TextBox currentTextBox = null;
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            // Start with a randomly selected TextBox having a different background color.
            ChangeRandomTextBoxColor();
        }

        private void ChangeRandomTextBoxColor()
        {
            // Choose a random TextBox.
            TextBox[] textBoxes = { txtTextBox1, txtTextBox2, txtTextBox3 };
            int randomIndex = random.Next(textBoxes.Length);
            currentTextBox = textBoxes[randomIndex];

            // Generate a random color.
            Color randomColor = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));

            // Set the background color of the selected TextBox.
            currentTextBox.Background = new SolidColorBrush(randomColor);
        }

        private void TextBox_MouseEnter(object sender, RoutedEventArgs e)
        {
            // When the mouse enters a TextBox, change its color back to white and reset the timer.
            if (currentTextBox != null)
            {
                currentTextBox.Background = Brushes.White;
                timer.Stop();
                timer.Start();
            }
        }

        private void TextBox_MouseLeave(object sender, RoutedEventArgs e)
        {
            // When the mouse leaves a TextBox, change it back to a random color.
            if (currentTextBox != null)
            {
                ChangeRandomTextBoxColor();
            }
        }

    }
}


