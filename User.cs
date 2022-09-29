using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class UserDTO
    {
        public string? Id { get;  set; }
        public string? Name { get;  set; }

    }

    public class User
    {
        public readonly UserDTO _user;
        public User()
        {
            this._user.Id = Utils.GenerateId();
            Console.WriteLine("Please mention the username to add: \n");
            var  InputName = Convert.ToString(Console.ReadLine());
            if (InputName != null)
            {
                this._user.Name = InputName;
            }
        }

    }
    public class ExpenseType
    {
        public string Id { get;  set; }
        public string? Type { get;  set; }
        public string? Name { get;  set; }

        public ExpenseType (string type, string name) {
            this.Id = Utils.GenerateId();
            this.Type = type;
            this.Name = name;
            } 
    }

    public class Expense
    {
        public List<Expense> _expenses;
        public readonly string Id;
        public readonly double Amount;
        public readonly ExpenseType Type;
        public bool IsPaid { get; set; }

        public Expense(double amount, ExpenseType type)
        {
            this.Id = Utils.GenerateId();
            this.Amount = amount;
            this.IsPaid = false;
            this.Type = type;

        }

        /*
        public List<Expense> ListExpense()
        {
               
        }
        */
    }
}
