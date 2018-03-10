using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver_TextEditor
{
    public class CommandTwoExe : ICommand 
    {
        private Receiver _textContent;
        public CommandTwoExe(Receiver txt)
        {
            _textContent = txt;
        }
        public void Execute()
        {
            _textContent.AppendCMD2();
        }

        public void UnExecute()
        {
            _textContent.UnDoAppendCMD2();
        }
    }
}
