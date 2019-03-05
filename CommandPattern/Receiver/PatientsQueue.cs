using CommandPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Receiver
{
    public class PatientsQueue
    {
        private static List<KeyValuePair<DateTime, Patient>> patients = new List<KeyValuePair<DateTime, Patient>>();
        DateTime dateStart = new DateTime(2019, 1, 15, 8, 0, 0);
        public bool AddPatient(Patient p)
        {
            //Public health care - patient registered on the first free date.
            var date = dateStart;
            if(patients.Count > 0)
            {
                date = patients.Last().Key.AddMinutes(30);
            }
            if(date.Hour > 20)
            {
                throw new Exception("Patients' list is full!");
            }
           
            patients.Add(new KeyValuePair<DateTime, Patient>(date, p));
            Console.WriteLine($"NFZ: Zarejestrowano na {date} pacjenta: {p.FirstName} {p.LastName}");
            return true;
        }

        public bool AddPatientPrivateVisit(Patient p, DateTime d)
        {
            //Private health care - patient chooses appointment date. We pospone appointments of all the the rest patients (and then - we text them).
            var patientsToMove = patients.Where(c => c.Key >= d).ToList();

            patients.Add(new KeyValuePair<DateTime, Patient>(d, p));
            patients.Sort((x, y) => x.Key.CompareTo(y.Key));

            List<KeyValuePair<DateTime, Patient>> temp = new List<KeyValuePair<DateTime, Patient>>();
            foreach(var pa in patientsToMove)
            {
                var newDate = pa.Key.AddMinutes(30);
                var pToMove = pa.Value;
                patients.Remove(pa);
                temp.Add(new KeyValuePair<DateTime, Patient>(newDate, pToMove));
                MessagesManager.SendSMS(pa.Value, newDate);
            }
            patients.AddRange(temp);
            patients.Sort((x, y) => x.Key.CompareTo(y.Key));

            Console.WriteLine($"Registered on {d} patient: {p.FirstName} {p.LastName}");

            return true;
        }

        public void PrintPatientsList()
        {
            foreach (var p in patients)
            {
                Console.WriteLine($"{p.Key}:\t{p.Value.FirstName} {p.Value.LastName}");
            }
        }
    }
}
