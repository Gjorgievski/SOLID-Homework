using ExampleDIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDIP.Classes
{
    public class MobileLoggingChangeState:ILoggingState
    {
        public void ComputerLogChangeState(string stateChangeInfo)
        {
            Console.WriteLine("MOBILE ==============Car changed state:{0}", stateChangeInfo);
        }
    }
}
