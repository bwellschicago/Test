using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipBoardSetter
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Writing contents to the Clipboard now...");
            // For this example, the data to be placed on the clipboard is a simple
            // string.
            string textData = "pasword!HAHAH";

            // After this call, the data (string) is placed on the clipboard and tagged
            // with a data format of "Text".
            Clipboard.SetData(DataFormats.Text, (Object)textData);

        }
    }
}
