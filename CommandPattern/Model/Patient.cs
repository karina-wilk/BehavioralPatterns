using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Model
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Patient(string f, string l)
        {
            FirstName = f;
            LastName = l;
        }
    }
}
