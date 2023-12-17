using mvvmDataBase.Commands;
using mvvmDataBase.Models;
using mvvmDataBase.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace mvvmDataBase.VewModel
{
    public class SignInVM:ViewModelBase
    {
        private string _errorMessage;
        private Users _currentUser = new Users();
        private DataBaseLogic _databaseLogic;
        //Properties
        public string Username
        {
            get { return _currentUser.Username; }
            set
            {
                if (_currentUser.Username != value)
                {
                    _currentUser.Username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        public string Password
        {
            get { return _currentUser.Password; }
            set
            {
                if (_currentUser.Password != value)
                {
                    _currentUser.Password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }
        public string Name
        {
            get { return _currentUser.Name; }
            set
            {
                if (_currentUser.Name != value)
                {
                    _currentUser.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }

            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public ICommand SignIn {  get; set; }
        public SignInVM()
        {
            _databaseLogic = new DataBaseLogic("Data Source=localhost;Initial Catalog=User;Integrated Security=True;Encrypt=False");
            SignIn = new RelsyCommand(SignInLogin);
        }

        private void SignInLogin(object obj)
        {
            _currentUser.AccessLevel = 1;
            if (_databaseLogic.inDataBase(_currentUser))
            {
                ErrorMessage = "Уже существует такое пользователь";
                return;
            }
            _databaseLogic.AddUser(_currentUser);
            LoginView loginView = new LoginView();
            loginView.Show();
            Application.Current.Windows[0].Close();
        }
    }
}
