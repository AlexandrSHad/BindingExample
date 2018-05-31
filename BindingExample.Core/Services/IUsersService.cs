using BindingExample.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExample.Core.Services
{
    public interface IUsersService
    {
        IEnumerable<IUserModel> GetAll();
        IUserModel GetById(int id);
        IUserDictionaries GetDictionaries();
    }
}
