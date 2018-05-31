using BindingExample.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingExample.Presentation
{
    public class MainViewPresenter : IMainViewPresenter
    {
        private readonly IMainView _view;
        private readonly IUsersService _service;

        public MainViewPresenter(IMainView view, IUsersService service)
        {
            _view = view;
            _view.Presenter = this;
            _service = service;
        }

        public void Run()
        {
            // get data and dictionaries from web API
            var users = _service.GetAll();               
            var dictionaries = _service.GetDictionaries();
            // set data and dictionaries to view
            _view.UsersList = users;
            _view.Dictionaries = dictionaries;
            // run view
            _view.Run();
        }

        public void RunUserEdit()
        {
            if (_view.SelectedUserId == 0)
                return;

            var user = _service.GetById(_view.SelectedUserId);

            _view.User = user;
            _view.ShowUserEdit();
        }
    }
}
