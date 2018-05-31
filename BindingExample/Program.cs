using BindingExample.Core.Services;
using BindingExample.Presentation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BindingExample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new MainView();
            var usersService = new UsersService();
            var presenter = new MainViewPresenter(view, usersService);
            presenter.Run();
        }
    }
}