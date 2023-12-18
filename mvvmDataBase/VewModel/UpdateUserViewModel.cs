using mvvmDataBase.Commands;
using mvvmDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using mvvmDataBase.VewModel;
using System.Windows;
using System.Collections.ObjectModel;

namespace mvvmDataBase.VewModel
{
    public class UpdateUserViewModel:ViewModelBase
    {
        private ObservableCollection<Users> _users;
        private Users _selectuser;
        public ICommand UpdateUser;
        private Users _currentUser = new Users();
        private DataBaseLogic _databaseLogic;
        MainWindowVM vM = new MainWindowVM();
        public Users SelectUser
        {
            get { return _selectuser; }
            set
            {
                if (_selectuser != value)
                {
                    _selectuser = vM.SelectedUser;
                    OnPropertyChanged(nameof(SelectUser));
                }
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
        public ObservableCollection<Users> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged("Users");
            }
        }
        public UpdateUserViewModel()
        {
            _databaseLogic = new DataBaseLogic("Data Source=localhost;Initial Catalog=User;Integrated Security=True;Encrypt=False");
            UpdateUser = new RelsyCommand(Update);
        }
        


        private void Update(object parameter)
        {
            MessageBox.Show("fdsg", $"{SelectUser.id}");
        }
    }
}
