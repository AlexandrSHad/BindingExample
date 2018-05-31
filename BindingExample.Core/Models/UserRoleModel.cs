using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExample.Core.Models
{
    public class UserRoleModel : IUserRoleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
