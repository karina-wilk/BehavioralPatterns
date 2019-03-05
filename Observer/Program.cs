using Observer.Listeners;
using Observer.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new TemperatureSensor();

            IListener janWorker = new WorkerListener();
            IListener adamWorker = new WorkerListener();
            IListener kamilaWorker = new WorkerListener();

            IListener piotrManager = new ManagerListener();

            IListener jerzyBoss = new BossListener();

            publisher.Subscribe(janWorker);
            publisher.Subscribe(adamWorker);
            publisher.Subscribe(kamilaWorker);
            publisher.Subscribe(piotrManager);
            publisher.Subscribe(jerzyBoss);

            int i = 10;
            while (--i > 0)
            {
                publisher.CheckTemperature();
            }

            Console.Read();
        }
    }
}
