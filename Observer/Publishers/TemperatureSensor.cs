using Observer.Listeners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer.Publishers
{
    public class TemperatureSensor
    {
        List<IListener> listeners = new List<IListener>();

        public void Subscribe(IListener x)
            => listeners.Add(x);

        public void UnSubscribe(IListener x)
            => listeners.Remove(x);

        private void NotiFy(string msg)
        {
            foreach(var x in listeners)
            {
                x.TemperatureAlarmUpdate(msg);
            }
        }

        public void CheckTemperature()
        {
            Console.WriteLine();
            
            var temp = new Random().Next(150); //Symulujemy odczyt temperatury z zewnętrznego urzadzenia:
            Thread.Sleep(300);

            Console.WriteLine($"Current temperature is {temp}");

            if (temp > 130)
            {
                NotiFy("Attention! Evacuation! Temp exceeded 130C");
            }
            else if (temp > 110)
            {
                NotiFy("Attention! Temp exceeded 110C");
            }
            else if(temp > 99)
            {
                NotiFy("Attention! Temp exceeded 99C");
            }
        }
    }
}
