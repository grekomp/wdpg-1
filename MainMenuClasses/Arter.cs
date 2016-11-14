using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenuClasses
{
    class Arter : MenuItem
    {
        public override Boolean Start()
        {
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < (10 - i); j++) Console.Write(" ");
                for (int j = 0; j < 1 + 2 * i; j++) Console.Write("*");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            return true;
        }

        public Arter(string label) : base(label) { }
    }
}
