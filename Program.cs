// See https://aka.ms/new-console-template for more information
using System;


namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)

        {
            var employee = new EmpDTO() {
                age = 28,
            };
            var empObj = new Employee(employee);
            empObj.setHourRate(rate: 13.89);
            empObj.returnEmployeeNameWithId();
            foreach (var name in employee.realName)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine($"Name:\t{employee.name}\nWeekRate:\t{employee.weekRate}");
        }
    }
}