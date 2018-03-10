using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receiver_TextEditor
{
    public class Receiver
    {

        public string content; // content in the text  

        public void AppendCMD1()
        {
            content = content + "CMD1";
        }

        public void UnDoAppendCMD1()
        {
            if (content.Length >= 4)
            {
                content = content.Substring(0, content.Length - 4);
            }
        }


        public void AppendCMD2()
        {
            content = content + "CMD2";
        }

        public void UnDoAppendCMD2()
        {
            if (content.Length >= 4)
            {
                content = content.Substring(0, content.Length - 4);
            }
        }

    }
}
