using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Listeners
{
    public class ManagerListener : IListener
    {
        public void TemperatureAlarmUpdate(string msg)
        {
            Console.WriteLine($"Manager got message: {msg}");
            Console.WriteLine($"Manager calls the ambulance!");
        }
    }
}
