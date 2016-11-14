using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenuClasses
{
    class MenuController : Controller
    {
        protected List<MenuItem> items;

        public bool Start()
        {
            string line;
            int n = 1;
            while (true) {
                do
                {
                    Console.Clear();
                    DrawMenu();
                    if (n == 0)
                    {
                        Console.WriteLine("(!) Please insert correct menu item number (!)");
                    }
                    line = Console.ReadLine();
                    n = Select(line);
                    
                }
                while (n == 0);

                if (n == -1)
                {
                    Exit();
                    return true;
                }
                else
                {
                    Console.Clear();
                    items.ElementAt(n - 1).Start();

                }
            }
        }

        public void DrawMenu()
        {
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("---------");

            int i = 1;
            foreach (MenuItem item in items)
            {
                item.GenerateLabel();
                item.GenerateDescription();
                Console.WriteLine(i + ". " + item.Label);

                i++;
            }
            Console.WriteLine("---------");
            Console.WriteLine("exit - Exits the program");

            Console.WriteLine();
            Console.WriteLine("(i) Write a number or exit and press enter (i)");
        }

        public void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("(i) Program Ended (i)");

        }

        public int Select(string selection)
        {
            if(selection == "exit" || selection == "Exit" || selection == "EXIT")
            {
                return -1;
            }

            int n = 0;
            int.TryParse(selection, out n);

            if( n > 0 && n <= items.Count)
            {
                return n;
            }

            return 0;
        }

        public void AddItem(MenuItem item)
        {
            items.Add(item);
        }

        public MenuController()
        {
            items = new List<MenuItem>();
        }
    }
}
