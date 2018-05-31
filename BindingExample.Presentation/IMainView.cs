using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BindingExample.Core.Models;

namespace BindingExample.Presentation
{
    public interface IMainView
    {
        IMainViewPresenter Presenter { get; set; }
        IEnumerable<IUserModel> UsersList { get; set; }
        int SelectedUserId { get; }
        IUserModel User { get; set; }
        IUserDictionaries Dictionaries { get; set; }

        void Run();
        void ShowUserList();
        void ShowUserEdit();
    }
}
