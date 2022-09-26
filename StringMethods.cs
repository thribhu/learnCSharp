using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class EmpDTO
    {
       public int age { get; set; }
        public string? name { get; set; } //!Note: Format of the name firstName middleName lastName
        public string[]? realName { get; set; }

        public double? weekRate { get; set; }

    }
    /* string methods*/
    public class Employee
    {
        private readonly EmpDTO _employee;
        public Employee(EmpDTO employee)
        {
            this._employee = employee;
            Console.WriteLine("Enter the employee fullname with spaces: ");
            var userInput = Console.ReadLine();
            if (userInput != null)
            {
                this.setName(userInput);
                this._employee.realName = userInput.Split(' ');
            }
        }

        public void setName(string args)
        {
            this._employee.name = args;
        }
        public string ShareEmployeeGreeting(string? customerName)
        {
            string defaultGreeting = $"My name is {this._employee?.realName?[0]}";
            if (customerName?.Length > 0)
            {
             defaultGreeting =  $"Hello {customerName}. " + defaultGreeting;
                return defaultGreeting;
            }
            return "Hello, " + defaultGreeting;
            
        }

        //default hours=5, days=4
        public bool setHourRate(double rate, [Optional]int hours, [Optional]int days)
        {
            if(hours > 0 && days > 0)
            {
                this._employee.weekRate = rate * hours * days;   
            }
            else
            {
                this._employee.weekRate = rate * 5 * 4;
            }
            if (this._employee.weekRate > 0) { return true; }
            else return false;
        }

        public void returnEmployeeNameWithId()
        {
            string[] employerIdPrefix = new string[] {"EMP", "#", "101"};
            Array.Sort(employerIdPrefix);
            foreach (var i in employerIdPrefix)
            {
                Console.WriteLine(i);
            }

        }
    }
}
