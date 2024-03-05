using Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classes
{
    internal class NotificationObserver : IObserver
    {
        public void Update(float value)
        {
            Console.WriteLine("Sending Notifcation " + value);
        }
    }
}
