using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CourseProject.Command
{
    public class OpenCloseWindowCommand : Cmd
    {
        private Window _window1;
        private Window _window2;

        public OpenCloseWindowCommand(Window newWindow, Window oldWindow)
        {
            _window1 = newWindow;
            _window2 = oldWindow;
        }

        public override void Execute(object parameter)
        {
            _window1.Show();
            _window2.Close();
        }
    }
}
