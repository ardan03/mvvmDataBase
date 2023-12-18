using mvvmDataBase.VewModel;
using System.Windows;


namespace mvvmDataBase.View
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
            DataContext = new SignInVM();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            Close();
        }
    }
}
