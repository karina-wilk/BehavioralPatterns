using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Listeners
{
    public class WorkerListener : IListener
    {
        public void TemperatureAlarmUpdate(string msg)
        {
            Console.WriteLine($"Blue collar worker got message: {msg}");
        }
    }
}
