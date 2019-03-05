using CommandPattern.Commands;
using CommandPattern.Sender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommand privateRegistration = new PrivatePatientsRegistrationCommand();
            ICommand nfzRegistration = new PatientsRegistrationCommand();
            ICommand patientPrinter = new PatientsPrinterCommand();

            MedicalRecorder medRecorder = new MedicalRecorder(privateRegistration, nfzRegistration, patientPrinter);
            medRecorder.Register("Jan", "Kowalski");
            medRecorder.Register("Anna", "Nowak");
            medRecorder.Register("Jerzy", "Luty", new DateTime(2019, 1, 15, 8, 0, 0), true);
            medRecorder.Register("Jan", "Bogacki", new DateTime(2019, 1, 15, 8, 30, 0), true);
            medRecorder.Register("Krzysztof", "Niebogaty");

            Console.WriteLine();
            Console.WriteLine("The full list of patients:");
            Console.WriteLine();

            medRecorder.Print();

            Console.Read();
        }
    }
}
