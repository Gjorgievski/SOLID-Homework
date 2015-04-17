using ExampleDIP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDIP.Classes
{
    public class CloundLoggingChangeState:ILoggingState
    {
        public void ComputerLogChangeState(string stateChangeInfo)
        {
            Console.WriteLine("CLOUD ==============Car changed state:{0}", stateChangeInfo);
        }
    }
}
