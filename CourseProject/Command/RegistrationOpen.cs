using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CourseProject.Command
{
    public class RegistrationOpen : Cmd
    {
        public override void Execute(object parameter)
        {
            var command = new OpenCloseWindowCommand(new Registration(), Application.Current.MainWindow);
            command.Execute(parameter);
        }
    }
}
