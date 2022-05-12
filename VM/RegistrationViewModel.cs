using CourseProject.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CourseProject.VM
{
    public class RegistrationViewModel : ViewModel
    {
        private string username;
        private string password_1;
        private string password_2;

        public ICommand BackToLogin => new BackToLogin();

        public string Username
        {
            get => username;
            set => Set(ref username, value, nameof(Username));
        }

        public string Password_1
        {
            get => password_1;
            set => Set(ref password_1, value, nameof(Password_1));
        }

        public string Password_2
        {
            get => password_2;
            set => Set(ref password_2, value, nameof(Password_2));
        }
    }
}
