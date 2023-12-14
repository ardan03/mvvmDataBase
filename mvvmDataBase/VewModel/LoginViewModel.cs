using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using mvvmDataBase.Models;
using mvvmDataBase.Repositories;
using mvvmDataBase.Commands;
using mvvmDataBase.View;
using System.Windows;

namespace mvvmDataBase.VewModel
{
    public class LoginViewModel : ViewModelBase
    {
        //Fields
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

        //-> Commands
        public ICommand LoginCommand { get; set; }
        public ICommand RecoverPasswordCommand { get; }
        public ICommand ShowPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }

        //Constructor
        public LoginViewModel()
        {
            _databaseLogic = new DataBaseLogic("Data Source=localhost;Initial Catalog=User;Integrated Security=True;Encrypt=False");
            LoginCommand = new RelsyCommand(LogIN);
        }
        private void LogIN(object parament)
        {
            if(Username==null || Password == null)
            {
                ErrorMessage = "Вы не заполнели Поля";
                return;
            }
            _currentUser.AccessLevel = 0;
            if (_databaseLogic.LogIn(_currentUser))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Application.Current.Windows[0].Close();
            }
            _currentUser.AccessLevel = 1;
            if (_databaseLogic.LogIn(_currentUser))
            {
                userWindow mainWindow = new userWindow();
                mainWindow.Show();
                Application.Current.Windows[0].Close();
            }
            else
            {
                ErrorMessage = "Такого пользователя нет";
            }
        }
    }
}
