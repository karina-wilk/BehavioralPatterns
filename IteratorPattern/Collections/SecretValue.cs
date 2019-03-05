using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Collections
{
    public class SecretValue
    {
        public string Word { get; set; }
        public bool CannotBeShown { get; set; }

        public override string ToString() => Word;
    }
}
