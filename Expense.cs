using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
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
        public Dictionary<string , object> expenses = new Dictionary<string, object>();
        public readonly string Id;
        public readonly double Amount;
        public readonly string? Type;
        public bool IsPaid { get; set; }

        public Expense()
        {
            this.Id = Utils.GenerateId();
            Console.WriteLine("Enter the expense Type: ");
            var type = Console.ReadLine(); 
            Console.WriteLine("Enter Expense: ");
            var amount = Convert.ToInt32(Console.ReadLine()); 
            this.IsPaid = false;
            if(amount > 0 && type != null)
            {
                 this.Amount = amount;
                 this.Type = type;
            }
        }

        public void ExpenseHeader()
        {
                Console.WriteLine($"\t\tNew Expense Added\t");
                Console.WriteLine($"\t\tAmount\t\tType\t\tIsPaid");

        }
        public void WriteExpenseOut()
        {
                Console.WriteLine($"\t\t{this.Amount}\t\t{this.Type}\t\t{this.IsPaid}");
        }

        public void ValidExpense()
        {
            var expenseObject = this.MemberwiseClone();
                this.expenses.Add(this.Id, expenseObject);
        }

        public void ListExpenses()
        {
            foreach (var expense in expenses)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(expense.Value))
                {
                    Console.WriteLine(descriptor);
                }
                Console.WriteLine("Key = {0}, Value = {1}", expense.Key, expense.Value);
            }
        }

        /**
         * @param bool isPaid Mark an expense paid or unpaid 
         * @param Expense expense expense for which we intend to change the status
         * @return void
         */
        public void UpdateExpense(Expense expense, bool isPaid) {
            if (expense.IsPaid == isPaid) return;
            if (expense.GetType().Equals(this.GetType()))
            {
                expense.IsPaid = isPaid;
                var cloneExpense = this.MemberwiseClone();
                if(this.expenses.ContainsKey(this.Id))
                {
                    this.expenses[this.Id] = cloneExpense;
                }
                return;
            }
        }

        //remove an expense from the dictionary expenses
        public void RemoveExpense()
        {
            this.expenses.Remove(this.Id);
        }
    }
}
