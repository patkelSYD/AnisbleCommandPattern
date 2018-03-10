using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver_TextEditor
{
    public interface ICommand
    {
        void Execute();
        void UnExecute(); 

    }
}
