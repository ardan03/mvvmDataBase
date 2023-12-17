using mvvmDataBase.Commands;
using mvvmDataBase.Models;
using mvvmDataBase.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace mvvmDataBase.VewModel
{
    public class AddUserViewModel : ViewModelBase
    {
        private ObservableCollection<Users> _users;
        private Users _selectedUser;
        private Users _currentUser = new Users();
        private string _errorMessage;
        public ObservableCollection<Users> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged("Users");
            }
        }
        public Users SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged(nameof(SelectedUser));
            }
        }
        public string Name
        {
            get
            {
                return _currentUser.Name;
            }

            set
            {
                if (_currentUser.Name != value)
                {
                    _currentUser.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string Password
        {
            get
            {
                return _currentUser.Password;
            }

            set
            {
                if (_currentUser.Password != value)
                {
                    _currentUser.Password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }
        public string Username
        {
            get
            {
                return _currentUser.Username;
            }

            set
            {
                if (_currentUser.Username != value)
                {
                    _currentUser.Username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }
        public int AccessLevel
        {
            get
            {
                return _currentUser.AccessLevel;
            }

            set
            {
                if (_currentUser.AccessLevel != Convert.ToInt32(value))
                {
                    _currentUser.AccessLevel = Convert.ToInt32(value);
                    OnPropertyChanged(nameof(AccessLevel));

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
        public ICommand AddUserCommand { get; private set; }
        private DataBaseLogic _databaseLogic;
        public AddUserViewModel()
        {
            _databaseLogic = new DataBaseLogic("Data Source=localhost;Initial Catalog=User;Integrated Security=True;Encrypt=False");
            AddUserCommand = new RelsyCommand(AddUser);
        }
        private ObservableCollection<Users> ConvertDataTableToObservableCollection(System.Data.DataTable dt)
        {
            var users = new ObservableCollection<Users>();

            foreach (System.Data.DataRow row in dt.Rows)
            {
                var user = new Users
                {
                    id = Convert.ToInt32(row["ID"]),
                    Username = row["UserName"].ToString(),
                    Password = row["Password"].ToString(),
                    Name = row["Name"].ToString(),
                    AccessLevel = Convert.ToInt32(row["AccessLevel"])
                };
                users.Add(user);
            }

            return users;
        }
        public void AddUser(object parameter)
        {
            MainWindow mainWindow = new MainWindow();
            
            // Проверка наличия заполненных данных о пользователе
            if (!string.IsNullOrWhiteSpace(_currentUser.Name) && !string.IsNullOrWhiteSpace(_currentUser.Password) && !string.IsNullOrWhiteSpace(_currentUser.Username))
            {
                // Создание нового пользователя на основе введенных данных
                Users newUser = new Users
                {
                    Name = _currentUser.Name,
                    Password = _currentUser.Password,
                    Username = _currentUser.Username,
                    AccessLevel = _currentUser.AccessLevel,
                };
                if (_databaseLogic.inDataBase(newUser))
                {
                    ErrorMessage = "*Такой пользователь уже есть";
                    return;
                }
                // Добавление нового пользователя в базу данных
                _databaseLogic.AddUser(newUser);

                MessageBox.Show("Пользователь успешно зарегистрирован!");

                // Очистка полей после регистрации
                _currentUser.Name = null;
                _currentUser.Password=null;
                _currentUser.Username = null;
            }
            else
            {
                MessageBox.Show("Введите данные для регистрации!");
                return;
            }
            
        }

    }
}
