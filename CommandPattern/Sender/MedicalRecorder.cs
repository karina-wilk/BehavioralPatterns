using CommandPattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Sender
{
    public class MedicalRecorder
    {
        ICommand registerPrivate;
        ICommand registerNFZ;
        ICommand patientPrinter;

        public MedicalRecorder(ICommand registerPrivate, ICommand registerNFZ, ICommand patientPrinter)
        {
            this.registerPrivate = registerPrivate;
            this.registerNFZ = registerNFZ;
            this.patientPrinter = patientPrinter;
        }

        public void Register(string fName, string lName, DateTime? d = null, bool isPrivate = false)
        {
            if(isPrivate)
            {
                if(registerPrivate is PrivatePatientsRegistrationCommand)
                {
                    var command = registerPrivate as PrivatePatientsRegistrationCommand;
                    command.DesiredDate = d.HasValue ? d.Value : DateTime.Now;
                    command.FirstName = fName;
                    command.LastName = lName;

                    command.Execute();
                }
            }
            else
            {
                if (registerNFZ is PatientsRegistrationCommand)
                {
                    var command = registerNFZ as PatientsRegistrationCommand;
                    command.FirstName = fName;
                    command.LastName = lName;

                    command.Execute();
                }
            }
        }

        public void Print()
        {
            patientPrinter.Execute();
        }
    }
}
