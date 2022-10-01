using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class Option
    {
        public readonly string ActionName;

        public readonly Action? Selected;

      
        public Option(string actionName, Action? selected)
        {
            ActionName = actionName;
            Selected = selected;
        }
    }
    public class Menu
    {
        public List<Option> MenuOptions { get; set;}
        
        public Menu (List<Option> options)
        {
            //NOTE!Using foreach, console write all the options actionName
            //appending the options to MenuOptions
            Console.WriteLine("Adding a new option");
            MenuOptions = new List<Option>(options);
        }

        public void AddMenuOption(Option option) { MenuOptions?.Add(option); }
        public void RemoveMenuOption(Option option) { MenuOptions?.Remove(option); }

     
        public void ShowOptionsOnConsole()
        {
            //test check 
            if(MenuOptions == null) return;
            // Set the default index of the selected item to be the first
            int index = 0;

            // Write the menu out
            WriteMenu(MenuOptions, MenuOptions[index]);

            // Store key info in here
            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();

                // Handle each key input (down arrow will write the menu again with a different selected item)
                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    if (index + 1 < MenuOptions.Count)
                    {
                        index++;
                        WriteMenu(MenuOptions, MenuOptions[index]);
                    }
                }
                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteMenu(MenuOptions, MenuOptions[index]);
                    }
                }
                // Handle different action for the option
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                    MenuOptions[index].Selected.Invoke();
                    index = 0;
                }
            }
            while (keyinfo.Key != ConsoleKey.X);

            Console.ReadKey();

        }
        public void WriteMenu(List<Option> options, Option selectedOption)
        {
            Console.Clear();

            foreach (Option option in options)
            {
                if (option == selectedOption)
                {
                    Console.Write("\t>");
                }
                else
                {
                    Console.Write("\t");
                }

                Console.WriteLine("\t"+option.ActionName);
            }
        }
    }
        

    }

