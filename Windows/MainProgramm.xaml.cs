using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CourseProject
{
    /// <summary>
    /// Логика взаимодействия для MainProgramm.xaml
    /// </summary>
    public partial class MainProgramm : Window
    {
        public class Employee
        {
            public Employee(string name, int passport, int phoneNumber, string adress)
            {
                Name = name;
                Passport = passport;
                PhoneNumber = phoneNumber;
                Adress = adress;
            }

            public string Name { get; set; }
            public int Passport { get; set; }
            public int PhoneNumber { get; set; }
            public string Adress { get; set; }
        }
        public MainProgramm()
        {
            InitializeComponent();
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Никита Койнов Микалевмч", 2281337, 898989898, "Город пушкина улица колотушкина"));
            employees.Add(new Employee("Никита Койнов Микалевмч1", 22813337, 838989898, "Город пушкина улица 1колотушкина"));
            employees.Add(new Employee("Никита Койнов Микалевмч2", 22281337, 828989898, "Город пушкина улица 2колотушкина"));
            employees.Add(new Employee("Никита Койнов Микалевмч3", 228331337, 858989898, "Город пушкина улица 3колотушкина"));
            kakugodno.ItemsSource = employees;
        }
    }
}
