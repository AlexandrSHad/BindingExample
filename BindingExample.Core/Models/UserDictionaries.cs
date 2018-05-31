using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExample.Core.Models
{
    public class UserDictionaries : IUserDictionaries
    {
        public List<IUserRoleModel> Roles { get; set; } = new List<IUserRoleModel>();
    }
}
