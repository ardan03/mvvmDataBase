using mvvmDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmDataBase.VewModel
{
    public class UserVM : ViewModelBase
    {
        private Users _curentUser;
        public Users CurentUser
        {
            get { return _curentUser; }
            set
            {
                if (_curentUser != value)
                {
                    _curentUser = value;
                    OnPropertyChanged(nameof(CurentUser));
                }
            }
        }
        public UserVM(Users CurentLogin)
        {
            CurentUser = CurentLogin;
        }
    }
}
