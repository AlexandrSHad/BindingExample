using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExample.Core.Models
{
    public class UserModel : IUserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int RoleId { get; set; }
        public UserRoleModel Role { get; set; }
    }
}
