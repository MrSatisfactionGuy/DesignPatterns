using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Interface;

namespace Observer.Classes
{
    internal class DisplayObserver : IObserver
    {
        public void Update(float value)
        {
            Console.WriteLine("Update Display. Value " + value);
        }
    }
}
