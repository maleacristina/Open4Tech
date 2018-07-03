using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotApplication
{
    public interface IDialogBot
    {
        void ReceiveMessage(string message);
    }
}
