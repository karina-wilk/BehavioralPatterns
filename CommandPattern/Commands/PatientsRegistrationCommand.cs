using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class PatientsRegistrationCommand : ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private CommandPattern.Receiver.PatientsQueue patientQueue;

        public PatientsRegistrationCommand()
            => patientQueue = new PatientsQueue();

        public void Execute()
        {
            patientQueue.AddPatient(new Model.Patient(FirstName, LastName));
        }
    }
}
