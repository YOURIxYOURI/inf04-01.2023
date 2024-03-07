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

namespace WpfApp1
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
        string pass;
        static Random random = new Random();

        private void Password_Gen_Button_Click(object sender, RoutedEventArgs e)
        {
            pass = "";
            int.TryParse(PassLength.Text, out int passLength);
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string signs = "!@#$%^&*()_+-=";
            string allChars = "";
            if ((bool)LettersCheck.IsChecked && pass.Length < passLength) 
            {
                int num = random.Next(0, letters.Length);
                pass += letters[num];
                allChars += letters;
            }
            if ((bool)NumbersCheck.IsChecked && pass.Length < passLength)
            {
                int num = random.Next(0, numbers.Length);
                pass += numbers[num];
                allChars += numbers;
            }
            if ((bool)SignsCheck.IsChecked && pass.Length < passLength)
            {
                int num = random.Next(0, signs.Length);
                pass += signs[num];
                allChars += signs;
            }
            while (pass.Length < passLength)
            {
                int num = random.Next(0, allChars.Length);
                pass += allChars[num];
            }
            MessageBox.Show(pass);
        }
        private void Accept_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Dane pracownika: {FirstName.Text} {LastName.Text} {PositionBox.Text} {pass}");
        }
    }
}
