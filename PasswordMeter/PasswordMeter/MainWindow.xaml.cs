using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace PasswordMeter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Input velden: userNameTextBox en passwordTextBox
        /// Output veld: resultTextBlock
        /// </summary>

        public MainWindow()
        {
            InitializeComponent();
        }

        private void passwordMeterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = userNameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                resultTextBlock.Text = "Geef eerste een gebruikersnaam en wachtwoord in.";
                return;
            }
            int passwordStrenght = 0;
            if (!password.Contains(username))
            {
                passwordStrenght++;
            }
            if (password.Length >= 10)
            {
                passwordStrenght++;
            }

            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;

            foreach (char character in password.ToCharArray())
            {

                if (char.IsDigit(character))
                {
                    hasDigit = true;
                }
                if (!char.IsLower(character))
                {
                    hasUpper = true;
                }
                if (!char.IsLower(character))
                {
                    hasLower = true;
                }
            }

            if (hasDigit)
            {
                passwordStrenght++;
            }
            if (hasUpper)
            {
                passwordStrenght++;
            }
            if (hasLower)
            {
                passwordStrenght++;
            }

            switch (passwordStrenght)
            {
                case 5:
                    resultTextBlock.Text = "Sterk Wachtwoord";
                    break;
                case 4:
                    resultTextBlock.Text = "Ok Wachtwoord";
                    break;
                default:
                    resultTextBlock.Text = "Zwak Wachtwoord";
                    break;
            }




        }
    }
}
