using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindingExample.Core.Models;

namespace BindingExample.Core.Services
{
    public class UsersService : IUsersService
    {
        private List<IUserModel> _users;
        private List<IUserRoleModel> _roles;

        public UsersService()
        {
            var roleAdmin = new UserRoleModel { Id = 101, Name = "Admin" };
            var roleUser = new UserRoleModel { Id = 102, Name = "User" };

            _roles = new List<IUserRoleModel> { roleAdmin, roleUser };

            _users = new List<IUserModel>
            {   
                new UserModel { Id = 1, Name = "User 1", BirthDate = new DateTime(1950, 5, 10), RoleId = 101, Role = roleAdmin },
                new UserModel { Id = 2, Name = "User 2", BirthDate = new DateTime(2005, 2, 17), RoleId = 102, Role = roleUser },
            };
        }

        public IEnumerable<IUserModel> GetAll()
        {
            return _users;
        }

        public IUserModel GetById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public IUserDictionaries GetDictionaries()
        {
            return new UserDictionaries
            {
                Roles = _roles,
            };
        }
    }
}
