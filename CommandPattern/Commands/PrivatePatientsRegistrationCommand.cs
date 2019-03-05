using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class PrivatePatientsRegistrationCommand : ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DesiredDate { get; set; }

        private CommandPattern.Receiver.PatientsQueue patientQueue;

        public PrivatePatientsRegistrationCommand()
            => patientQueue = new PatientsQueue();

        public void Execute()
        {
            patientQueue.AddPatientPrivateVisit(new Model.Patient(FirstName, LastName), DesiredDate);
        }
    }
}
