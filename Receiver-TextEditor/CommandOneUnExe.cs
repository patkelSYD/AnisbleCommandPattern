using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver_TextEditor
{
    public class CommandOneUnExe : ICommand 
    {
        private Receiver _textContent;
        /// <summary>
        /// Dependent on the 
        /// </summary>
        /// <param name="txt"></param>
        public CommandOneUnExe(Receiver txt) 
        {
            _textContent = txt;
        }
        public void Execute()
        {
            this._textContent.UnDoAppendCMD1();
        }

        public void UnExecute()
        {
            this._textContent.AppendCMD1();
        }
    }
}
