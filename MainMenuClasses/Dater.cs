using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenuClasses
{
    class Dater : MenuItem
    {
        public override Boolean Start()
        {
            Console.WriteLine("Current date is:");
            Console.WriteLine(DateTime.Now.ToString("dd.MM.yyyy"));
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            return true;
        }

        public Dater(string label) : base(label) { }
    }
}
