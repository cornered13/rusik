using CourseProject.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Command
{
    public class Login : Cmd
    {
        private LoginViewModel _viewModel;
        public Login(LoginViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
        }
    }
}
