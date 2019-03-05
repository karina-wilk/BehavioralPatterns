using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    class LowerCaseWriting : ITextEditorState
    {
        public void Write(string text)
            => Console.Write(text.ToLower());
    }
}
