using StatePattern.Context;
using StatePattern.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new TextEditor();

            editor.WriteOnConole("This sentENce is written In MiXEd Style!");

            editor.SetState(new UpperCaseWriting());

            editor.WriteOnConole("This sentence will appear as uppercase, although I wrote it lowercase");
            editor.WriteOnConole("just like this sentence...");

            editor.SetState(new LowerCaseWriting());

            editor.WriteOnConole("AND HERE EVERYTHING WILL APPEAR AS LOWERCASE");
            editor.WriteOnConole("BUT I WROTE IT WITH CAPSLOCK!");

            Console.Read();
        }
    }
}
