using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenuClasses
{
    class Timer : MenuItem
    {
        public override Boolean Start()
        {
            Console.WriteLine("Current time is:");
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            return true;
        }

        public Timer(string label) : base(label) { }

    }
}
