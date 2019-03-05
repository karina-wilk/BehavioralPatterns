using CommandPattern.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Commands
{
    class PatientsPrinterCommand : ICommand
    {
        private CommandPattern.Receiver.PatientsQueue patientQueue;

        public PatientsPrinterCommand()
            => patientQueue = new PatientsQueue();

        public void Execute()
        {
            patientQueue.PrintPatientsList();
        }
    }
}
