using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExample.Core.Models
{
    public interface IUserRoleModel
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
