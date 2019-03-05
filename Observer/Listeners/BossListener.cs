using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Listeners
{
    public class BossListener : IListener
    {
        public void TemperatureAlarmUpdate(string msg)
        {
            Console.WriteLine($"Boss got the message: {msg}");
            Console.WriteLine($"Boss arranges meeting with insurance company");
        }
    }
}
