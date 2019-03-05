using StatePattern.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StatePattern.Context
{
    class TextEditor
    {
        private ITextEditorState state;

        public TextEditor()
        {
            state = new NormalCaseWriting();
        }

        public void SetState(ITextEditorState state)
        {
            this.state = state;
        }

        public void WriteOnConole(string text)
        {
            Console.WriteLine();
            foreach(var letter in text)
            {
                Thread.Sleep(100);
                state.Write(letter.ToString());
            }
        }

    }
}
