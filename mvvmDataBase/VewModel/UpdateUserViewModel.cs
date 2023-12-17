using mvvmDataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmDataBase.VewModel
{
    public class UpdateUserViewModel:ViewModelBase
    {
        private Users _selectuser;
        public UpdateUserViewModel( Users selectuser)
        {
            _selectuser = selectuser;

        }
    }
}
