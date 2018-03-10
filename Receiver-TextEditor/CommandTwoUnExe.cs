using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver_TextEditor
{
    public class CommandTwoUnExe : ICommand 
    {
        private Receiver _textContent;
        public CommandTwoUnExe(Receiver txt)
        {
            _textContent = txt;
        }
        public void Execute()
        {
            _textContent.UnDoAppendCMD2();
        }

        public void UnExecute()
        {
            _textContent.AppendCMD2();
        }
    }
}
