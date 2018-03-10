using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver_TextEditor
{
    public class Invoker
    {
        ICommand Cmd1Exe; 
        ICommand Cmd1UnExe;

        ICommand Cmd2Exe;
        ICommand Cmd2UnExe;

        /// <summary>
        /// Invoker has 4 commands everytime the invoker is initialied it will instantiate 4 commands
        /// </summary>
        /// <param name="cmd1Exe"></param>
        /// <param name="cmd1UnExe"></param>
        /// <param name="cmd2Exe"></param>
        /// <param name="cmd2UnExe"></param>
        public Invoker (ICommand cmd1Exe, ICommand cmd1UnExe, ICommand cmd2Exe, ICommand cmd2UnExe)
        {
            this.Cmd1Exe = cmd1Exe;
            this.Cmd1UnExe = cmd1UnExe;
            this.Cmd2Exe = cmd2Exe;
            this.Cmd2UnExe = cmd2UnExe;
        }
       
        public void ClickCMD1Execute()
        {
            Cmd1Exe.Execute();
        }

        public void ClickCMD1UnExecute()
        {
            Cmd1UnExe.Execute();
        }

        public void ClickCMD2Execute()
        {
            Cmd2Exe.Execute();
        }

        public void ClickCMD2UnExecute()
        {
            Cmd2UnExe.Execute();
        }

    }
}
