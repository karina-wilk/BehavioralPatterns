using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Listeners
{
    public interface IListener
    {
        void TemperatureAlarmUpdate(string msg);
    }
}
