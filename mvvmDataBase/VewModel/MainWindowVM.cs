using Microsoft.Win32;
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
using System.Windows.Markup;

namespace mvvmDataBase.VewModel
{
    internal class MainWindowVM : ViewModelBase
    {
        private ObservableCollection<Users> _users;
        private Users _selectedUser;
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
        private DataBaseLogic _databaseLogic;
        public ICommand ResCommand { get; set; }
        public ICommand OpenAddWindow {  get; set; }
        public MainWindowVM()
        {
            _databaseLogic = new DataBaseLogic("Data Source=localhost;Initial Catalog=User;Integrated Security=True;Encrypt=False");
            LoadUserData();
            OpenAddWindow = new RelsyCommand(openAddWindow);
        }
        private void LoadUserData()
        {
            var dataTable = _databaseLogic.GetUserData();
            Users = ConvertDataTableToObservableCollection(dataTable);
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
        private void openAddWindow(object parameter)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            Application.Current.Windows[0].Close();

        }
    }
}
