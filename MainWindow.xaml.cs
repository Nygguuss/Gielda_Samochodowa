using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gielda_Samochodowa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string tymczasowehaslo = "admin";
        string tymczasowyuzytkownik = "admin";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;
            // Sprawdzanie danych logowania
            
            if (tymczasowyuzytkownik == "admin" && tymczasowehaslo == "admin")
            {
                MessageBox.Show("Zalogowano pomyślnie jako: " + username);

                // Tworzenie i otwieranie nowego okna
                GlownaStrona glownastrona = new GlownaStrona();
                glownastrona.Show();

                // Zamykanie bieżącego okna logowania
                this.Close();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane logowania. Spróbuj ponownie.");
            }   
        }
    }
}