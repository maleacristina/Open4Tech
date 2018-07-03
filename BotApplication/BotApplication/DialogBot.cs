using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotApplication
{
    class DialogBot:IDialogBot
    {
        public void ReceiveMessage(string message)
        {
            Console.WriteLine("Message receive: " + message);
        }
    }
}
