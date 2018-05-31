using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExample.Core.Models
{
    public interface IUserModel
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime BirthDate { get; set; }
        int RoleId { get; set; }
        UserRoleModel Role { get; set; }
    }
}
