using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Model
{
    public static class MessagesManager
    {
        public static void SendSMS(Patient p, DateTime newVisitDate)
        {
            //.. Logika
            Console.WriteLine($"---- Patient {p.FirstName} {p.LastName} was texted: Your appointment was posponed to {newVisitDate}");
        }
    }
}
