using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfDays;
            //Employee employee = new SoftwareEngineer(
            //    new Mentor(
            //        new ProjectManger(
            //            new HRManger(
            //                new CEO(null)))));

            IKernel kernel = new StandardKernel(new CORModule());
            var employee = kernel.Get<Employee>();

            while (true)
            {
                Console.WriteLine("Enter Number Of Day's Of Leave");
                NumberOfDays = int.Parse(Console.ReadLine());
                employee.ProcessLeave(NumberOfDays);
            }
        }
    }
    public class CORModule:NinjectModule
    {

        public override void Load()
        {
            Bind<ICommand>().To<Command>();
            Bind<Employee>().To<SoftwareEngineer>();
            Bind<Employee>().To<Mentor>().WhenInjectedInto<SoftwareEngineer>();
            Bind<Employee>().To<ProjectManger>().WhenInjectedInto<Mentor>();
            Bind<Employee>().To<HRManger>().WhenInjectedInto<ProjectManger>();
            Bind<Employee>().To<CEO>().WhenInjectedInto<HRManger>();
            //Bind<Employee>().To<>().WhenInjectedInto<CEO>();

        }
    }
    public interface Employee
    {
        // protected Employee NextLevelEmployee;
        void ProcessLeave(int numberOfDays);
        //public void SetNextLevelEmployee(Employee emp)
        //{
        //    NextLevelEmployee = emp;
        //}
    }
    interface ICommand
    {
        void Start(int numberOfDays);
    }
    public class Command:ICommand
    {
        private readonly Employee _employee;
        public Command(Employee employee)
        {
            _employee = employee;
        }
        public void Start(int numberOfDays)
        {
            _employee.ProcessLeave(numberOfDays);
        }
    }
    public class SoftwareEngineer : Employee
    {
        private readonly Employee _nextLevelEmployee;
        public SoftwareEngineer(Employee nextLevelEmployee)
        {
            _nextLevelEmployee = nextLevelEmployee;
        }
        public void ProcessLeave(int numberOfDays)
        {
            if (_nextLevelEmployee != null)
            {
                _nextLevelEmployee.ProcessLeave(numberOfDays);
            }
        }
    }
    public class Mentor : Employee
    {
        private readonly Employee _nextLevelEmployee;
        public Mentor(Employee nextLevelEmployee)
        {
            _nextLevelEmployee = nextLevelEmployee;
        }
        public  void ProcessLeave(int numberOfDays)
        {
            if (numberOfDays < 2)
            {
                Console.WriteLine("Leave approved by Mentor");
            }
            else if (_nextLevelEmployee != null)
            {
                _nextLevelEmployee.ProcessLeave(numberOfDays);
            }
        }
    }
    public class ProjectManger : Employee
    {
        private readonly Employee _nextLevelEmployee;
        public ProjectManger(Employee nextLevelEmployee)
        {
            _nextLevelEmployee = nextLevelEmployee;
        }
        public  void ProcessLeave(int numberOfDays)
        {
            if (numberOfDays <= 3)
            {
                Console.WriteLine("Leave approved by Project Manger");
            }
            else if (_nextLevelEmployee != null)
            {
                _nextLevelEmployee.ProcessLeave(numberOfDays);
            }
        }
    }
    public class HRManger : Employee
    {
        private readonly Employee _nextLevelEmployee;
        public HRManger(Employee nextLevelEmployee)
        {
            _nextLevelEmployee = nextLevelEmployee;
        }

        public  void ProcessLeave(int numberOfDays)
        {
            if (numberOfDays <= 4)
            {
                Console.WriteLine("Leave approved by HRMnager");
            }
            else if (_nextLevelEmployee != null)
            {
                _nextLevelEmployee.ProcessLeave(numberOfDays);
            }
        }
    }
    public class CEO : Employee
    {
        private readonly Employee _nextLevelEmployee;
        //public CEO(Employee nextLevelEmployee)
        //{
        //    _nextLevelEmployee = nextLevelEmployee;
        //}
        public  void ProcessLeave(int numberOfDays)
        {
            if (numberOfDays <= 5)
            {
                Console.WriteLine("Leave approved by CEO");
            }
            else
            {
                Console.WriteLine("Let us have a meeting with CEO");
            }
        }
    }
}
