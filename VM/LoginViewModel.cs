using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CourseProject.Command;

namespace CourseProject.VM
{
    public class LoginViewModel : ViewModel
    {
        private string username;
        private string password;

        public ICommand LoginCommand => new Login(this);
        public ICommand RegistrationCommand => new RegistrationOpen();

        public string Username
        {
            get => username;
            set => Set(ref username, value, nameof(Username));
        }

        public string Password
        {
            get => password;
            set => Set(ref password, value, nameof(Password));
        }
    }
}
