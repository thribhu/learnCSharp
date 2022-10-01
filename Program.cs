// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
              {

            /*
            var employee1 = new EmpDTO() {
                age = 28
            };
            var employee2 = new EmpDTO() {
                age = 48
            };
            var employee3 = new EmpDTO() {
                age = 29
            };
            var empObj1 = new Employee(employee1);
            var empObj2 = new Employee(employee2);
            var empObj3 = new Employee(employee3);

            //create team
            var alphaTeam = new Team(name:"Alpha");
            alphaTeam.AddEmployeeToTeam(empObj1);
            alphaTeam.AddEmployeeToTeam(empObj2);
            alphaTeam.AddEmployeeToTeam(empObj3);
            var teamSize = alphaTeam.CountTeamMembers();
            //string interpolation
            Console.WriteLine($"Current team size: {teamSize}");
            alphaTeam.UpdateHourRateAmongTeam(hours: 6, rate: 12.55);
            */

            StartMenu();

        }
        public static void StartMenu() {
            Option AddExpense = new Option(actionName: "Add Expense", selected: () =>
            {
                var ExpenseToAdd = new Expense();
                ExpenseToAdd.ValidExpense();
                ExpenseToAdd.ListExpenses();
            });
            Option ListExpenses = new Option(actionName: "List Expense", selected: () =>
            {
                Console.Write('H');
            });
            Option UpdateExpense = new Option(actionName: "Update Expense", selected: () => Console.Write("Hi"));
            Option Exit = new Option(actionName: "Exit", selected: () => Environment.Exit(0));

            var MenuOptions = new List<Option> { AddExpense, ListExpenses, UpdateExpense, Exit };
            //create menu with options
            var ConsoleMenu = new Menu(MenuOptions);

            ConsoleMenu.ShowOptionsOnConsole();
        }

        public static void CreateOption(string actionName, Action selected)
        {
        }

    }
}