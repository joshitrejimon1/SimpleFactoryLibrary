using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLibrary.Model
{
    internal class Audi:IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("AUDI is starting");
        }

        public void Stop()
        {
            Console.WriteLine("AUDI is stopping ");
        }
    }
}
