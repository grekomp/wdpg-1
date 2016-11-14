using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenuClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuController controller = new MenuController();

            MenuItem item1 = new Timer("Get current time");
            MenuItem item2 = new Dater("Get current date");
            MenuItem item3 = new Arter("Show christmass tree");


            controller.AddItem(item1);
            controller.AddItem(item2);
            controller.AddItem(item3);

            Console.WriteLine(controller.Start());
        }
    }
}
