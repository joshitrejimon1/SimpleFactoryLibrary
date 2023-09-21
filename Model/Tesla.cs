using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLibrary.Model
{
    internal class Tesla : IAutomobile
    {
        public void Start()
        {
            Console.WriteLine("tesla is starting");
        }

        public void Stop()
        {
            Console.WriteLine("tesla is stopping ");
        }
    }
}
